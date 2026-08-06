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
using System.IO;

namespace WinformBookRecoder
{
    public partial class FrmPathConfig : Form
    {
        public FrmPathConfig()
        {
            InitializeComponent();
        }

        private void FrmPathConfig_Load(object sender, EventArgs e)
        {   // 逻辑：FrmMain_Load 将DataFilePath读取到CommonHelper工具中。FrmPathConfig则进行读取。
            if(CommonHelper.storepath != "")
            {   txt_config_storepath.Text = CommonHelper.storepath;
                txt_config_namefile.Text = Path.GetFileName(CommonHelper.ItemPath);
                txt_config_incomefile.Text = Path.GetFileName(CommonHelper.IncomePath);
                txt_config_outcomefile.Text = Path.GetFileName(CommonHelper.OutcomePath);
                txt_config_dayfile.Text = Path.GetFileName(string.IsNullOrEmpty(CommonHelper.DayPath)?"未成功读取":CommonHelper.DayPath);
                txt_config_weekfile.Text = Path.GetFileName(string.IsNullOrEmpty(CommonHelper.WeekPath) ? "未成功读取" : CommonHelper.WeekPath);
                txt_config_monthfile.Text = Path.GetFileName(string.IsNullOrEmpty(CommonHelper.MonthPath)? "未成功读取" : CommonHelper.MonthPath);
            }
        }

        private string selPath =""; // 用户选择的文件夹路径
        private void btn_config_select_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            fdb.SelectedPath = @"E:\C#";
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                txt_config_storepath.Text = fdb.SelectedPath;
                selPath = fdb.SelectedPath;
            }
        }

        private void btn_config_confirm_Click(object sender, EventArgs e)
        {
            // 检查配置文件夹路径是否为空并检查路径是否存在
            if (string.IsNullOrEmpty(txt_config_storepath.Text))
            {
                MessageHelper.Fail("提示","请选择文件夹路径:");
                btn_config_confirm.Focus(); // 重新
                return;
            }
            selPath = txt_config_storepath.Text.Trim();
            if (!Directory.Exists(selPath))
            {
                Directory.CreateDirectory(selPath);
            }

            // 获取配置文件名
            string itemPath = string.IsNullOrEmpty(txt_config_namefile.Text)? "item.txt": txt_config_namefile.Text.Trim();
            string incomePath = string.IsNullOrEmpty(txt_config_incomefile.Text) ? "income.txt": txt_config_incomefile.Text.Trim();
            string outcomePath = string.IsNullOrEmpty(txt_config_outcomefile.Text) ? "outcome.txt": txt_config_outcomefile.Text.Trim();
            string dayPath = string.IsNullOrEmpty(txt_config_dayfile.Text) ? "day.txt": txt_config_dayfile.Text.Trim();
            string weekPath = string.IsNullOrEmpty(txt_config_weekfile.Text) ? "week.txt": txt_config_weekfile.Text.Trim();
            string monthPath = string.IsNullOrEmpty(txt_config_monthfile.Text) ? "month.txt": txt_config_monthfile.Text.Trim();

            txt_config_namefile.Text = itemPath;
            txt_config_incomefile.Text = incomePath;
            txt_config_outcomefile.Text = outcomePath;
            txt_config_dayfile.Text = dayPath;
            txt_config_weekfile.Text = weekPath;
            txt_config_monthfile.Text = monthPath;

            // 检查文件名后缀是否正确
            if (!itemPath.EndsWith(".txt") || !incomePath.EndsWith(".txt") || !outcomePath.EndsWith(".txt") || !dayPath.EndsWith(".txt") || !weekPath.EndsWith(".txt") || !monthPath.EndsWith(".txt"))
            {
                MessageHelper.Fail("提示", "文件名后缀不正确,请检查:");
                btn_config_confirm.Focus(); // 重新
                return;
            }

            // 将配置信息写入app.config文件
            string appConfigPath = Path.Combine(selPath, "DataFileSet.txt");
            AppHelper.SetValue("数据文件路径", appConfigPath);

            // 将文件路径写入配置文件DataFileSet.txt中
            TextHelper.WriteMsg("数据文件路径:", appConfigPath, false);
            List<string> msglist = new List<string>();
            msglist.Add("存储目录路径-" + selPath);
            msglist.Add("名目数据路径-" + Path.Combine(selPath,itemPath));
            msglist.Add("收入数据路径-" + Path.Combine(selPath, incomePath));
            msglist.Add("支出数据路径-" + Path.Combine(selPath, outcomePath));
            msglist.Add("日统计数据路径-" + Path.Combine(selPath, dayPath));
            msglist.Add("周统计数据路径-" + Path.Combine(selPath, weekPath));
            msglist.Add("月统计数据路径-" + Path.Combine(selPath, monthPath));
            TextHelper.WriteMsgList(msglist, appConfigPath,true);


            // 将配置信息写入CommonHelper类中
            CommonHelper.storepath = selPath; // 保存配置文件夹路径
            CommonHelper.ItemPath = Path.Combine(selPath, itemPath);
            CommonHelper.IncomePath = Path.Combine(selPath, incomePath);
            CommonHelper.OutcomePath = Path.Combine(selPath, outcomePath);
            CommonHelper.DayPath = Path.Combine(selPath, dayPath);
            CommonHelper.WeekPath = Path.Combine(selPath, weekPath);
            CommonHelper.MonthPath = Path.Combine(selPath, monthPath);

            MessageHelper.Info("提示", "配置成功,请返回主界面:");
        }
    }
}
