using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBookRecoder.Tools;
using WinformBookRecoder.Models;
using System.IO;
namespace WinformBookRecoder
{
    public partial class FrmItemManage : Form
    {
        public FrmItemManage()
        {
            InitializeComponent();
        }

        // 名目文件路径
        private string itemFilePath = "";
        private List<ItemType> it = new List<ItemType>();
        Dictionary<int, string> itemls = new Dictionary<int, string>();
        private int actStatus = 1; // 1新增 2修改
        private int selindex = -1;

        //<Summary>
        // 加载
        //</Summary>
        private void FrmItemManage_Load(object sender, EventArgs e)
        {
            itemFilePath = CommonHelper.ItemPath;
            if (string.IsNullOrEmpty(itemFilePath))
            {
                MessageHelper.Fail("提示", "未成功读取名目文件，请检查路径配置路径");
                // 禁用所有控件

                foreach(Control c in this.Controls)
                {
                    c.Enabled = false;
                }
                return;
            }
            label8.Text = label8.Text+itemFilePath;
            it.Add(new ItemType() { id = 1, name = "收入" });
            it.Add(new ItemType() { id = 2, name = "支出" });
            it.Add(new ItemType() { id = 3, name = "其他" });
            cm_item_type.SelectedIndex = -1;
            cm_item_type.DataSource = it;
            cm_item_type.DisplayMember = "name";
            cm_item_type.ValueMember ="id";
            Itemlist.Items.Clear();
            LoadItems();
        }

        private void LoadItems()
        {
            List<string> lines = TextHelper.ReadTextAllLines(itemFilePath);
            if(lines.Count > 1)
            {
                for(int i = 1; i < lines.Count; i++)
                {   // 编号\t类型\t名称
                    string[] arrs = lines[i].Split('\t');
                    Itemlist.Items.Add(arrs[0]+'\t'+arrs[1]+'\t'+arrs[2]);
                    itemls.Add(int.Parse(arrs[0]), lines[i]);
                }
            }
        }


        //<Summary>
        // 清空选项
        //</Summary>
        private void btn_item_clear_Click(object sender, EventArgs e)
        {   // 清空发生后，重置类型、编号、名称，左侧按钮恢复至新增
            cm_item_type.SelectedIndex=0; 
            txt_item_code.Text = "";
            txt_item_code.Enabled = true;
            txt_item_name.Text = "";

            btn_item_new.Text = "新增";
            actStatus = 1;
        }

        //<Summary>
        // 新建与修改选项
        //</Summary>
        private void btn_item_new_Click(object sender, EventArgs e)
        {
            // 从信息栏读取 编号 名称
            int new_id = -1;
            string new_name = "";
            if (!string.IsNullOrEmpty(txt_item_code.Text))
            {
                new_id = int.Parse(txt_item_code.Text.Trim()); //获取 信息栏的 编号
                if (actStatus == 1) 
                {
                    while (itemls.ContainsKey(new_id))
                    {
                        new_id++;
                    }
                }
                
            }
            else
            {
                MessageHelper.Fail("提示", "编号不能为空");
                return;
            }
            if (!string.IsNullOrEmpty(txt_item_name.Text))
            {
                new_name = txt_item_name.Text.Trim(); // 获取 信息栏的 名称 
                if (actStatus == 1&& ExistsName(new_name))
                {
                    MessageHelper.Fail("提示", "名称已存在");
                    return;
                }
            }
            else
            {
                MessageHelper.Fail("提示", "名称不能为空");
                return;
            }

            switch (actStatus)
            {
                case 1:// 新增，追加到文件
                    {
                        string save_line = $"{new_id}\t{(cm_item_type.SelectedItem as ItemType).name}\t{new_name}";
                        Itemlist.Items.Add(save_line);
                        itemls.Add(new_id, save_line);
                            // 追加到文件
                        if (!File.Exists(itemFilePath))
                        {
                            TextHelper.WriteMsg(save_line, itemFilePath, false);
                        }
                        else
                        {
                            TextHelper.WriteMsg(save_line, itemFilePath, true);
                        }
                    
                    };
                    break;
                default: //修改，修改列表
                    {
                        string save_line = $"{new_id}\t{(cm_item_type.SelectedItem as ItemType).name}\t{new_name}";
                        itemls[new_id] = save_line;
                        Itemlist.Items.Insert(selindex, save_line);
                        Itemlist.Items.RemoveAt(selindex + 1); // 删除旧的               
                    };
                    break;
            }

        }

        private bool ExistsName(string name)
        {
            foreach (int key in itemls.Keys)
            {
                string iName = itemls[key].Split('\t')[2];
                if (iName == name)
                    return true;
            }
            return false;

        }
        //<Summary>
        // 选择项改变-> 加载信息栏
        //</Summary>
        private void Itemlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Itemlist.SelectedItems.Count>0)
            {   // 多选情况下-> 选择第一项
                string sel = Itemlist.SelectedItems[0].ToString();
                string[] arrs = sel.Split('\t');

                int code = int.Parse(arrs[0]);
                string tp = arrs[1];
                string name = arrs[2];

                cm_item_type.SelectedIndex = it.FindIndex(x => x.name == tp);
                txt_item_code.Text = code.ToString();
                txt_item_code.Enabled = false;
                txt_item_name.Text = name;
                selindex = Itemlist.SelectedIndices[0];
                actStatus = 2;
                btn_item_new.Text = "修改";
            }
            else
            {   // 删除后，无选中项，修改信息栏状态
                btn_item_new.Text = "新增";
                actStatus = 1;
                cm_item_type.SelectedIndex = 0;
                txt_item_code.Text = "";
                txt_item_code.Enabled = true;
                txt_item_name.Text = "";

            }

        }
        //<Summary>
        // 删除选项
        //</Summary>
        // 列表中要删除，保存后，文件中也要删除。
        private void btn_item_delete_Click(object sender, EventArgs e)
        {
            var selItem = Itemlist.SelectedItems;
            if (selItem.Count > 0)
            {
                if(MessageHelper.Query("提示", "确认删除吗？") == DialogResult.OK)
                {
                    for(int i = selItem.Count-1; i >=0 ; i--)
                    {
                        string[] arrs = selItem[i].ToString().Split('\t');
                        int id = int.Parse(arrs[0]);
                        Itemlist.Items.Remove(selItem[i]);
                        itemls.Remove(id); 
                    }
                }
            }
        }
        //<Summary>
        // 保存选项
        //</Summary>
        private void btn_item_save_Click(object sender, EventArgs e)
        {
            TextHelper.WriteMsg("编号\t类型\t名称", itemFilePath, false);
            var order_list = itemls.OrderByDescending(x => x.Key).Select(x => x.Value).ToList();
            TextHelper.WriteMsgList(order_list, itemFilePath, true);
            MessageHelper.Info("提示", "保存成功");
        }
    }
}
