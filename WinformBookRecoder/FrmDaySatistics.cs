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

namespace WinformBookRecoder
{
    public partial class FrmDaySatistics : Form
    {
        public FrmDaySatistics()
        {
            InitializeComponent();

            // 统计日
            StatisticDay();
            
        }
        private List<RecordInfo> records = new List<RecordInfo>();
        private List<DayInfo> daystatistic = new List<DayInfo>();
        private decimal todayin = 0.0M, todayex = 0.0M, todayprofit = 0.0M, highex = 0.0M, lowex = 0.0M;
        private void StatisticDay()
        {
            todayin = 0.0M;
            todayex = 0.0M;
            todayprofit = 0.0M;
            highex = 0.0M;
            lowex = 0.0M;

            // 统计收支记录
            Load_Records();
            // 每日统计
            AnalyseDay();
            // 显示信息
            Load_StateInfo();
        }

        private void Load_StateInfo()
        {
            lb_exp_day.Text = "¥"+todayprofit.ToString();
            lb_exp_expand.Text = "¥" + todayex.ToString();
            lb_exp_income.Text = "¥" + todayin.ToString();
            lb_exp_highexp.Text = "¥" + highex.ToString();
            lb_exp_lowexp.Text = "¥" + lowex.ToString();

        }

        private void AnalyseDay()
        {
            // 构建日期列表
            List<string> res = records.Select(r => r.time.ToString("yyyy-MM-dd")).Distinct().ToList();
            // 选择数据
            
            foreach(var day in res)
            {
                var list = records.Where(r => r.time.ToString("yyyy-MM-dd") == day);
                decimal idx_intotal = 0.0M, idx_extotal = 0.0M, idx_profit = 0.0M;
                foreach(var d in list)
                {
                    if (d.itemtype == "收入")
                    {
                        idx_intotal += d.money;
                    }
                    else
                    {
                        idx_extotal += d.money;
                    }
                }
                idx_profit = idx_intotal - idx_extotal; // 当日收支

                if (day == DateTime.Today.ToString("yyyy-MM-dd"))
                {
                    todayin = idx_intotal;
                    todayex = idx_extotal;
                    todayprofit = idx_profit;
                }

                daystatistic.Add(new DayInfo()
                {
                    date = day,
                    intotal = idx_intotal,
                    extotal = idx_extotal,
                    profittotal = idx_profit
                });

            }
            

            // 显示数据
            if(daystatistic.Count>0)
            {
                var highex_list = daystatistic.Select(r => r.extotal).ToList();
                highex = highex_list.Max();
                lowex = highex_list.Min();
                foreach(DayInfo day in daystatistic)
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = day.date;
                    li.SubItems.Add(day.intotal.ToString());
                    li.SubItems.Add(day.extotal.ToString());
                    li.SubItems.Add(day.profittotal.ToString());

                    lvday.Items.Add(li);
                }
            }
        }


        private void btn_exp_resatistic_Click(object sender, EventArgs e)
        {
            records.Clear();
            daystatistic.Clear();
            lvday.Items.Clear();
            StatisticDay();
        }


        private void Load_Records()
        {   
            records = CommonHelper.GetAllRecord();
        }

    }
}
