using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBookRecoder.Models;
using WinformBookRecoder.Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
///
/// <summary>
/// FrmIncomeManage的功能
/// 1，加载名目列表；加载已有收入记录
/// 2. 收入记录信息录入、修改记录信息
/// 3. 选择记录信息并加载到信息栏
/// 4. 清空-- 清空信息栏并切换至录入状态
/// 5. 删除-- 将选择的记账信息从列表删除，保存重新写入剩余记录信息
/// 6. 保存-- 将修改或删除后的其余信息重新写入文件
/// 7. 查询-- 按记录描述模糊查询、按名目、金额范围查询
/// 
/// 
/// 待优化
/// 编号应该无法修改
/// 删除后，编号应该重新有序
/// </summary>
/// 
///
namespace WinformBookRecoder
{

    public partial class FrmIncomeManage : Form
    {

        public FrmIncomeManage()
        {
            InitializeComponent();
        }
        //private Dictionary<int,IncomeInfo> Curitem = new Dictionary<int, IncomeInfo>();
        private List<IncomeInfo> Curitem = new List<IncomeInfo>();

        private int actype = 1; //1 新增 2修改
        private int selindex = -1;
        private List<string> IncomeItem = new List<string>(); // items
        private string incomefilepath = CommonHelper.IncomePath;
        private int lastid = 0;

        // <summary>
        // 收入页面初始化
        // </summary>
        private void FrmIncomeManage_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CommonHelper.ItemPath)||string.IsNullOrEmpty(incomefilepath))
            {
                MessageHelper.Fail("提示", "未找到收入配置文件，请检查文件路径是否正确");
                // 禁用控件
                foreach (Control c in this.Controls)
                {
                    c.Enabled = false;
                }
                return;
            }
            // 加载名目数据
            Load_itemData();
            // 加载收入记录
            Load_IncomeData();

            // 补充
            label10.Text = label10.Text + incomefilepath;

        }

        // 加载 收入信息
        private void Load_IncomeData()
        {
            incomefilepath = CommonHelper.IncomePath;
            if (!File.Exists(incomefilepath))
            {   // 标题：编号\t名目\描述\t金额\t时间
                TextHelper.WriteMsg("编号\t名目\t描述\t金额\t时间", incomefilepath, false);
            }
            else
            {
                List<string> incomeinfo = new List<string>();
                incomeinfo = TextHelper.ReadTextAllLines(incomefilepath);

                for (int i = 1; i < incomeinfo.Count; i++)
                {
                    string[] arr = incomeinfo[i].Split('\t');
                    int s_id = int.Parse(arr[0]);

                    ListViewItem im = new ListViewItem(arr[0]);
                    im.SubItems.AddRange(arr.Skip(1).ToArray());
                    LV.Items.Add(im);

                    Curitem.Add(new IncomeInfo().ParseString(incomeinfo[i]));
                    lastid = s_id;
                }

            }
        }

        // 加载 名目信息
        private void Load_itemData()
        {
            // 加载名目类型
            IncomeItem= CommonHelper.Load_ItemData(0);
            //ItemList = TextHelper.ReadTextAllLines(itemconfigpath);

            //foreach (string item in ItemList)
            //{
            //    string itemtype = item.Split('\t')[1];
            //    string itemname = item.Split('\t')[2];
            //    if (itemtype == "收入")
            //    {
            //        IncomeItem.Add(itemname);
            //    }
            //}

            cbx_income_name.DataSource = IncomeItem;
            cbx_income_name2.DataSource = IncomeItem;


        }

        /// <summary>
        /// 4. 清空-- 清空信息栏并切换至录入状态
        /// </summary>
        private void btn_income_clear_Click(object sender, EventArgs e)
        {
            cbx_income_name.SelectedIndex = 0;
            txt_income_code.Text = "";
            txt_income_code.Enabled = true;
            txt_income_desc.Text = "";
            txt_income_price.Text = "";

            btn_income_new.Text = "新增";
            actype = 1;
        }

        ///
        /// <summary>
        /// 2. 收入记录信息录入、修改提交
        /// </summary>
        /// 
        ///
        private void btn_income_new_Click(object sender, EventArgs e)
        {
            //string info1 = cbx_income_name.SelectedItem.ToString();
            //int info2 = int.Parse(string.IsNullOrEmpty(txt_income_code.Text) ? "1" : txt_income_code.Text);
            //string info3 = string.IsNullOrEmpty(txt_income_desc.Text)? "-": txt_income_desc.Text;
            //decimal info4 = Decimal.Parse(string.IsNullOrEmpty(txt_income_price.Text) ? "0" : txt_income_price.Text);

            IncomeInfo ino = new IncomeInfo();
            ino.incomeid = int.Parse(string.IsNullOrEmpty(txt_income_code.Text) ? "0" : txt_income_code.Text);
            ino.incomeitem = cbx_income_name.SelectedItem.ToString(); 
            ino.incomedesc = string.IsNullOrEmpty(txt_income_desc.Text) ? "-" : txt_income_desc.Text;
            ino.money = Decimal.Parse(string.IsNullOrEmpty(txt_income_price.Text) ? "0" : txt_income_price.Text);
            ino.incometime = DateTime.Now.ToString();

            //string save_info = $"{info2}\t{info1}\t{info3}\t{info4}\t{DateTime.Now.ToString()}";
            string save_info = ino.ToString();

            if (actype == 1)
            {
                if(ExistID(ino.incomeid))
                {
                    int num = 0;
                    do
                    {
                        num = NextId(ino.incomeid);
                    }
                    while (num <= ino.incomeid);
                    ino.incomeid = num;
                    save_info = ino.ToString();
                }
                LV.Items.Add(ino.ParseView());
                Curitem.Add(new IncomeInfo().ParseString(save_info));

                var sortLV = LV.Items.Cast<ListViewItem>().OrderBy(x => int.TryParse(x.SubItems[0].Text, out int sval) ? sval : int.MaxValue).Select(item => (ListViewItem)item.Clone()).ToArray();
                LV.Items.Clear();
                LV.Items.AddRange(sortLV);


                //var sorted_li = LvIncome.Items.Cast<string>().OrderBy(s =>
                //{
                //    return int.TryParse(s.Split('\t')[0], out int id) ? id : 9999;
                //}).ToList();

                //LvIncome.Items.Clear();
                //LvIncome.Items.AddRange(sorted_li.ToArray());
            }
            else
            {
                // 修改列表
                int idx = Curitem.FindIndex(x => x.incomeid == ino.incomeid);
                Curitem[idx] = new IncomeInfo().ParseString(save_info);
                LV.Items.Insert(selindex,ino.ParseView());
                LV.Items.RemoveAt(selindex + 1);
               
            }
            
        }

        private int NextId(int num)
        {
            int new_id = 0;
            var ls = Curitem.OrderBy(x => x.incomeid).ToList();
            for (int i = 0; i < Curitem.Count-1; i++)
            {
               
                int cur_id = ls[i].incomeid;
                if(cur_id+1 != ls[i+1].incomeid)
                {
                    new_id = cur_id + 1;
                    if (new_id > num)
                    {
                        return new_id;
                    }
                }
            }
            int maxid = ls.Last().incomeid;
            int result = maxid + 1;
            return Math.Max(maxid,result);
        }

        private bool ExistID(int num)
        {
            foreach(IncomeInfo ii in Curitem)
            {
                int id = ii.incomeid;
                if (id == num)
                {
                    return true;
                }
            }
            return false;
        }
        // <summary>
        // 删除
        // </summary>
        private void btn_income_delete_Click(object sender, EventArgs e)
        {
            var sels = LV.SelectedItems;
            if (sels.Count > 0) // 删除多项
            {
                if(MessageHelper.Query("提升","确认删除吗？") == DialogResult.OK)
                {
                    for (int i = sels.Count - 1; i >= 0; i--)
                    {
                        int num = int.Parse(sels[i].SubItems[0].Text);
                        LV.Items.Remove(sels[i]);                        
                        Curitem.RemoveAt(Curitem.FindIndex(x => x.incomeid == num));
                    }
                }
            }

        }
        ///
        /// <summary>
        /// 3. 选择记录信息并加载到信息栏
        /// </summary>
        /// 
        private void LvIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LV.SelectedItems.Count>0)
            {
                var info = LV.SelectedItems[0].SubItems;

                // 信息栏
                int r_num = int.Parse(info[0].Text);
                string r_item = info[1].Text;
                string r_desc = info[2].Text;
                int r_price = int.Parse(info[3].Text);

                cbx_income_name.SelectedIndex = IncomeItem.FindIndex(x => x == r_item);
                txt_income_code.Text = r_num.ToString();
                txt_income_desc.Text = r_desc;
                txt_income_price.Text = r_price.ToString();

                selindex = LV.SelectedIndices[0];
                actype = 2;
                btn_income_new.Text = "修改";
            }
            else
            {
                btn_income_new.Text = "新增";
                actype = 1;

                cbx_income_name.SelectedIndex = 0;
                txt_income_code.Text = "";
                txt_income_code.Enabled = true;
                txt_income_desc.Text = "";
                txt_income_price.Text = "";
            }
        }
        ///
        /// <summary>
        /// 6. 保存-- 将修改或删除后的其余信息重新写入文件
        /// </summary>
        /// 
        private void btn_income_save_Click(object sender, EventArgs e)
        {
            TextHelper.WriteMsg("编号\t名目\t描述\t金额\t时间", incomefilepath, false);
            foreach (IncomeInfo ii in Curitem.OrderBy(x => x.incomeid))
            {
                TextHelper.WriteMsg(ii.ToString(), incomefilepath, true);
            }

            // var order_list = Curitem.OrderByDescending(x => x.Key).Select(x => x.Value).ToList();
            //TextHelper.WriteMsgList(order_list, incomefilepath, true);
            MessageHelper.Info("提示", "保存成功");

        }

        /// <summary>
        /// 7. 查询-- 查询符合条件的收入信息
        /// </summary>
        private void btn_income_query_Click(object sender, EventArgs e)
        {
            string s_desc = txt_income_desc2.Text.Trim() ?? string.Empty;
            string s_item = (cbx_income_name2.SelectedItem as string).Trim() ?? string.Empty;
            string s_price = txt_income_price2.Text.Trim() ?? string.Empty;


            var filterResult = Curitem.Where(x =>
            {
                // 按制表符分割
                string[] arr = x.ToString().Split('\t');
                // 必须至少分割出3段，否则直接不匹配
                if (arr.Length < 3)
                    return false;
                // 三个条件同时成立
                bool cond1 = string.IsNullOrWhiteSpace(s_price) || arr[3] == s_price;
                bool cond2 = string.IsNullOrWhiteSpace(s_item) || arr[1] == s_item;
                bool cond3 = string.IsNullOrWhiteSpace(s_desc) || arr[2] == s_desc;
                
                return cond1 && cond2 && cond3;
            }).ToList();

            LV.Items.Clear();
            foreach(var item in filterResult)
            {
                LV.Items.Add((item as IncomeInfo).ParseView());
            }
            
        }

        private void btn_income_allrecord_Click(object sender, EventArgs e)
        {
            LV.Items.Clear();
            foreach(var item in Curitem)
            {
                LV.Items.Add(item.ParseView());
            }

        }


        
    }
}
