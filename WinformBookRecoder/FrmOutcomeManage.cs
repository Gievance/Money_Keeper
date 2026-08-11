using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBookRecoder.Models;
using WinformBookRecoder.Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.IO;
namespace WinformBookRecoder
{
    public partial class FrmOutcomeManage : Form
    {
        public FrmOutcomeManage()
        {
            InitializeComponent();
        }
        private List<OutComeInfo> Curitem = new List<OutComeInfo>();

        private int actype = 1; //1 新增 2修改
        private int selindex = -1;
        private List<string> OutComeItem = new List<string>(); // items
        private string outcomefilepath = CommonHelper.OutcomePath;
        private int lastid = 0;
        private void FrmOutcomeManage_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CommonHelper.ItemPath) || string.IsNullOrEmpty(outcomefilepath))
            {
                MessageHelper.Fail("提示", "未找到支出配置文件，请检查文件路径是否正确");
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
            Load_OutcomeData();

            // 补充
            label10.Text = label10.Text + outcomefilepath;

        }
        

        private void Load_OutcomeData()
        {
            outcomefilepath = CommonHelper.OutcomePath;
            if (!File.Exists(outcomefilepath))
            {   // 标题：编号\t名目\描述\t金额\t时间
                TextHelper.WriteMsg("编号\t名目\t描述\t金额\t时间", outcomefilepath, false);
            }
            else
            {
                List<string> outcomeinfo = new List<string>();
                outcomeinfo = TextHelper.ReadTextAllLines(outcomefilepath);

                for (int i = 1; i < outcomeinfo.Count; i++)
                {
                    string[] arr = outcomeinfo[i].Split('\t');
                    int s_id = int.Parse(arr[0]);

                    ListViewItem im = new ListViewItem(arr[0]);
                    im.SubItems.AddRange(arr.Skip(1).ToArray());
                    LVOutCome.Items.Add(im);

                    Curitem.Add(new OutComeInfo().ParseString(outcomeinfo[i]));
                    lastid = s_id;
                }

            }
        }
        private void Load_itemData()
        {
            // 加载名目类型
            OutComeItem = CommonHelper.Load_ItemData(0);
            //ItemList = TextHelper.ReadTextAllLines(itemconfigpath);

            //foreach (string item in ItemList)
            //{
            //    string itemtype = item.Split('\t')[1];
            //    string itemname = item.Split('\t')[2];
            //    if (itemtype == "收入")
            //    {
            //        outcomeItem.Add(itemname);
            //    }
            //}

            cbx_expand_name.DataSource = OutComeItem;
            cbx_expand_name2.DataSource = OutComeItem;

        }

        private void btn_expand_clear_Click(object sender, EventArgs e)
        {
            cbx_expand_name.SelectedIndex = 0;
            txt_expand_code.Text = "";
            txt_expand_code.Enabled = true;
            txt_expand_desc.Text = "";
            txt_expand_price.Text = "";

            btn_expand_new.Text = "新增";
            actype = 1;
        }

        private void btn_expand_new_Click(object sender, EventArgs e)
        {

            OutComeInfo ino = new OutComeInfo();
            ino.outcomeid = int.Parse(string.IsNullOrEmpty(txt_expand_code.Text) ? "0" : txt_expand_code.Text);
            ino.outcomeitem = cbx_expand_name.SelectedItem.ToString();
            ino.outcomedesc = string.IsNullOrEmpty(txt_expand_desc.Text) ? "-" : txt_expand_desc.Text;
            ino.money = Decimal.Parse(string.IsNullOrEmpty(txt_expand_price.Text) ? "0" : txt_expand_price.Text);
            ino.outcometime = DateTime.Now.ToString();

            string save_info = ino.ToString();

            if (actype == 1)
            {
                if (ExistID(ino.outcomeid))
                {
                    int num = 0;
                    do
                    {
                        num = NextId(ino.outcomeid);
                    }
                    while (num <= ino.outcomeid);
                    ino.outcomeid = num;
                    save_info = ino.ToString();
                }
                LVOutCome.Items.Add(ino.ParseView());
                Curitem.Add(new OutComeInfo().ParseString(save_info));

                var sortLV = LVOutCome.Items.Cast<ListViewItem>().OrderBy(x => int.TryParse(x.SubItems[0].Text, out int sval) ? sval : int.MaxValue).Select(item => (ListViewItem)item.Clone()).ToArray();
                LVOutCome.Items.Clear();
                LVOutCome.Items.AddRange(sortLV);

            }
            else
            {
                // 修改列表
                int idx = Curitem.FindIndex(x => x.outcomeid == ino.outcomeid);
                Curitem[idx] = new OutComeInfo().ParseString(save_info);
                LVOutCome.Items.Insert(selindex, ino.ParseView());
                LVOutCome.Items.RemoveAt(selindex + 1);

            }
        }

        private int NextId(int num)
        {
            int new_id = 0;
            var ls = Curitem.OrderBy(x => x.outcomeid).ToList();
            for (int i = 0; i < Curitem.Count - 1; i++)
            {

                int cur_id = ls[i].outcomeid;
                if (cur_id + 1 != ls[i + 1].outcomeid)
                {
                    new_id = cur_id + 1;
                    if (new_id > num)
                    {
                        return new_id;
                    }
                }
            }
            int maxid = ls.Last().outcomeid;
            int result = maxid + 1;
            return Math.Max(maxid, result);
        }

        private bool ExistID(int num)
        {
            foreach (OutComeInfo ii in Curitem)
            {
                int id = ii.outcomeid;
                if (id == num)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_expand_delete_Click(object sender, EventArgs e)
        {
            var sels = LVOutCome.SelectedItems;
            if (sels.Count > 0) // 删除多项
            {
                if (MessageHelper.Query("提升", "确认删除吗？") == DialogResult.OK)
                {
                    for (int i = sels.Count - 1; i >= 0; i--)
                    {
                        int num = int.Parse(sels[i].SubItems[0].Text);
                        LVOutCome.Items.Remove(sels[i]);
                        Curitem.RemoveAt(Curitem.FindIndex(x => x.outcomeid == num));
                    }
                }
            }
        }

        private void LVOutCome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LVOutCome.SelectedItems.Count > 0)
            {
                var info = LVOutCome.SelectedItems[0].SubItems;

                // 信息栏
                int r_num = int.Parse(info[0].Text);
                string r_item = info[1].Text;
                string r_desc = info[2].Text;
                int r_price = int.Parse(info[3].Text);

                cbx_expand_name.SelectedIndex = OutComeItem.FindIndex(x => x == r_item);
                txt_expand_code.Text = r_num.ToString();
                txt_expand_desc.Text = r_desc;
                txt_expand_price.Text = r_price.ToString();

                selindex = LVOutCome.SelectedIndices[0];
                actype = 2;
                btn_expand_new.Text = "修改";
            }
            else
            {
                btn_expand_new.Text = "新增";
                actype = 1;

                cbx_expand_name.SelectedIndex = 0;
                txt_expand_code.Text = "";
                txt_expand_code.Enabled = true;
                txt_expand_desc.Text = "";
                txt_expand_price.Text = "";
            }
        }

        private void btn_expand_save_Click(object sender, EventArgs e)
        {
            TextHelper.WriteMsg("编号\t名目\t描述\t金额\t时间", outcomefilepath, false);
            foreach (OutComeInfo ii in Curitem.OrderBy(x => x.outcomeid))
            {
                TextHelper.WriteMsg(ii.ToString(), outcomefilepath, true);
            }

            // var order_list = Curitem.OrderByDescending(x => x.Key).Select(x => x.Value).ToList();
            //TextHelper.WriteMsgList(order_list, outcomefilepath, true);
            MessageHelper.Info("提示", "保存成功");
        }

        private void btn_expand_query_Click(object sender, EventArgs e)
        {
            string s_desc = txt_expand_desc2.Text.Trim() ?? string.Empty;
            string s_item = (cbx_expand_name2.SelectedItem as string).Trim() ?? string.Empty;
            string s_price = txt_expand_price2.Text.Trim() ?? string.Empty;


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

            LVOutCome.Items.Clear();
            foreach (var item in filterResult)
            {
                LVOutCome.Items.Add((item as OutComeInfo).ParseView());
            }
        }

        private void btn_expand_allrecord_Click(object sender, EventArgs e)
        {
            LVOutCome.Items.Clear();
            foreach (var item in Curitem)
            {
                LVOutCome.Items.Add(item.ParseView());
            }
        }
    }

}
