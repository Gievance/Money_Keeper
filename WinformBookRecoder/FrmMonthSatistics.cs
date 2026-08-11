using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformBookRecoder.Models;
using WinformBookRecoder.Tools;

namespace WinformBookRecoder
{
    public partial class FrmMonthSatistics : Form
    {
        public FrmMonthSatistics()
        {
            InitializeComponent();
        }

        private void FrmMonthSatistics_Load(object sender, EventArgs e)
        {
            StatisticMonth();
        }
        decimal thismonthin = 0.0M, thismonthout = 0.0M, thismonthbenefit = 0.0M;
        private List<RecordInfo> records = new List<RecordInfo>();
        private List<MonthInfo> mlist = new List<MonthInfo>();
        private void StatisticMonth()
        {
            records = CommonHelper.GetAllRecord();
            MonthStatistic();
            Load_StateInfo();                                 
        }
        private int GetMonthNum(DateTime dt)
        {
            CultureInfo cl = new CultureInfo("zh-CN");
            return cl.Calendar.GetMonth(dt);
        }

        private void btn_exp_resatistic_Click(object sender, EventArgs e)
        {
            StatisticMonth();
        }

        private void MonthStatistic()
        {
            thismonthin = 0.0M;
            thismonthout = 0.0M;
            thismonthbenefit = 0.0M;

            // 获取当前月数
            var thismonthnum = GetMonthNum(DateTime.Now);

            // 获取日期数据
            var date = records.Select(r => r.time.ToString("yyyy-MM-dd")).Distinct().ToList();
            // 获取年份数据
            var years = date.Select(r => DateTime.Parse(r).Year).Distinct().ToList();

            foreach (var year in years)
            {
                // 统计当年数据
                var thisyear_record = records.Where(r => r.time.Year == year); // 当年的记录数据
                var thisyear_date = date.Where(r => DateTime.Parse(r).Year == year);// 当前的日期数据

                var thisyear_months= thisyear_date.Select(r => GetMonthNum(DateTime.Parse(r))).Distinct().ToList();// 包含哪些月份

                foreach(var month in thisyear_months)
                {
                    decimal mintotal = 0.0M, mextotal = 0.0M, mbenefit = 0.0M;
                    var thismonth_record = thisyear_record.Where(r => GetMonthNum(r.time) == month).ToList();
                    if (thismonth_record.Count > 0)
                    {
                        foreach(var day in thismonth_record)
                        {
                            // 当前月每日记录
                            decimal dintotal = 0.0M, dextotal = 0.0M;

                            if(day.itemtype == "收入")
                            {
                                dintotal += day.money;
                            }
                            else
                            {
                                dextotal += day.money;
                            }

                            mintotal += dintotal;
                            mextotal += dextotal;
                        }
                        mbenefit = mintotal - mextotal;
                    }
                    if(month == thismonthnum)
                    {
                        thismonthin = mintotal;
                        thismonthout = mextotal;
                        thismonthbenefit = mbenefit;
                    }

                    mlist.Add(new MonthInfo()
                    {
                        Year = year.ToString(),
                        monthnum = month.ToString(),
                        intotal = mintotal,
                        extotal = mextotal,
                        profittotal = mbenefit
                    });
                }               
            }

            foreach(var d in mlist)
            {   lvmonth.Items.Clear();
                ListViewItem li = new ListViewItem();
                li.Text = d.Year;
                li.SubItems.Add(d.monthnum);
                li.SubItems.Add(d.intotal.ToString());
                li.SubItems.Add(d.extotal.ToString());
                li.SubItems.Add(d.profittotal.ToString());
                lvmonth.Items.Add(li);
            }

        }
        private void Load_StateInfo()
        {
            lb_exp_month.Text = thismonthbenefit.ToString();
            lb_exp_income_month.Text = thismonthin.ToString();
            lb_exp_expand_month.Text = thismonthout.ToString();

        }
    }
}
