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
//<summary>
//1. MDI 窗体qiantao
//</summary>

namespace WinformBookRecoder
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        //private void ShowFrm(Form frm)
        //{   // 接受的参数是新创建的窗口实例。
        //    // 当前窗口未打开，则开启实例
        //    // 当前窗口已打开，则激活实例

        //    bool flag = false;
        //    flag = FrmIsOpen(frm.Name);
        //    if (!flag)
        //    {   // 当前窗口未打开
        //        frm.StartPosition = FormStartPosition.CenterScreen;
        //        frm.MdiParent = this;
        //        frm.Show();
        //    }
        //    else
        //    {   // 当前窗口已打开
        //        Form existingfrm = Application.OpenForms[frm.Name]; // 获取当前窗口实例
        //        existingfrm.Activate();
        //    }


        //    // 下面错误的是,打开的窗口是不是当前存在的
        //    //else
        //    //{
        //    //    frm.Activate();
        //    //}

        //}


        // 泛型写法
        private void ShowFrm<F>() where F:Form
        {  
            // 当前窗口未打开，则创建+开启实例
            // 当前窗口已打开，则激活实例
            Type ftype = typeof(F);
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == ftype) //当前打开的窗体中有泛型指定的类型
                {
                    f.Activate();
                    return; // 已打开，直接返回
                }
            }
            // 当前窗口未打开
            Form frm = Activator.CreateInstance<F>();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private bool FrmIsOpen(string s)
        {
            foreach (Form f in Application.OpenForms)
            {
                if(s == f.Name)
                {
                    return true;
                }
            }
            return false;
        }


        private void btn_name_Click(object sender, EventArgs e)
        {

            // FrmItemManage fim = new FrmItemManage(); //创建名目窗体
            //ShowFrm(fim);
            ShowFrm<FrmItemManage>();

        }

        private void btn_store_Click(object sender, EventArgs e)
        {
            //FrmPathConfig fpm = new FrmPathConfig();
            //ShowFrm(fpm);
            ShowFrm<FrmPathConfig>();
        }


        private void btn_income_Click(object sender, EventArgs e)
        {
            //FrmIncomeManage fima = new FrmIncomeManage(); 
            //ShowFrm<Form>(fima);
            ShowFrm<FrmIncomeManage>();
        }

        private void btn_outcome_Click(object sender, EventArgs e)
        {
            //FrmOutcomeManage fom = new FrmOutcomeManage();
            //ShowFrm(fom);
            ShowFrm<FrmOutcomeManage>();
        }

        private void btn_day_Click(object sender, EventArgs e)
        {
            //FrmDaySatistics fds = new FrmDaySatistics();
            //ShowFrm(fds);
            ShowFrm<FrmDaySatistics>();
        }

        private void btn_month_Click(object sender, EventArgs e)
        {
            //FrmWeekSatistics fws = new FrmWeekSatistics();
            //ShowFrm(fws);
            ShowFrm<FrmWeekSatistics>();
        }

        private void btn_year_Click(object sender, EventArgs e)
        {
            //FrmMonthSatistics fms = new FrmMonthSatistics();
            //ShowFrm(fms);
            ShowFrm<FrmMonthSatistics>();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.Confirm("退出框", "确定要退出吗？") == DialogResult.Yes)
            //if (MessageBox.Show("确定要退出吗？", "退出框", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Application.Exit();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // 从CommonHelper读取配置路径
            CommonHelper.datafilepath = AppHelper.GetValue("数据文件路径");
            string datafilepath = CommonHelper.datafilepath;
            if (!string.IsNullOrEmpty(datafilepath))
            {
                if (File.Exists(datafilepath)){
                    List<string> paths = new List<string>();
                    paths = TextHelper.ReadTextAllLines(datafilepath);
                    // 解析路径
                    if(0<paths.Count)
                    {
                        CommonHelper.storepath = paths[1].Split('-')[1].Trim();
                        CommonHelper.ItemPath = paths[2].Split('-')[1].Trim();
                        CommonHelper.IncomePath = paths[3].Split('-')[1].Trim();
                        CommonHelper.OutcomePath = paths[4].Split('-')[1].Trim();
                        CommonHelper.DayPath = paths[5].Split('-')[1].Trim();
                        CommonHelper.WeekPath = paths[6].Split('-')[1].Trim();
                        CommonHelper.MonthPath = paths[7].Split('-')[1].Trim();
                    }
                    
                }
            }

        }
    }
}
