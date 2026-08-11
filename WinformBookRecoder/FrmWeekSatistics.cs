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
using System.Globalization;
namespace WinformBookRecoder
{
    public partial class FrmWeekSatistics : Form
    {
        public FrmWeekSatistics()
        {
            InitializeComponent();
        }

        private List<RecordInfo> recordlist = new List<RecordInfo>();
        private decimal weekintotal = 0.0M, weekextotal = 0.0M, weekbenefit = 0.0M;
        private List<WeekInfo> wlist = new List<WeekInfo>();

        private void FrmWeekSatistics_Load(object sender, EventArgs e)
        {
            StatisticWeek();
        }

        private void StatisticWeek()
        {
            // 加载收支记录
            recordlist = CommonHelper.GetAllRecord();
            // 进行周统计
            WeekStatistic();
            // 
            Load_StateInfo();
        }

        private void Load_StateInfo()
        {
            lb_exp_week.Text = weekbenefit.ToString();
            lb_exp_expand_week.Text = weekextotal.ToString();
            lb_exp_income_week.Text = weekintotal.ToString();
        }

        private void btn_exp_resatistic_Click(object sender, EventArgs e)
        {
            StatisticWeek();
        }

        private void WeekStatistic()
        {
            weekintotal = 0.0M;
            weekextotal = 0.0M;
            weekbenefit = 0.0M;

            int thisweekofYear = GetWeekNum(DateTime.Now);
            // 获取日期总数
            List<string> date = recordlist.Select(r => r.time.ToString("yyyy-MM-dd")).Distinct().ToList();

            // 获取记录年份总数
            List<int> years = date.Select(r =>DateTime.Parse(r).Year).Distinct().ToList();
            foreach(int year in years)
            {   // 当年收支数据
                var yearrecord = recordlist.Where(r => r.time.Year == year);
                // 当年日期数据
                var yeardate = date.Where(d => DateTime.Parse(d).Year == year);

                // 当年，每条收支数据对应的周数数据(不重复列表)
                List<int> yearweek = yeardate.Select(r => GetWeekNum(DateTime.Parse(r))).Distinct().ToList();


                // 统计周数数据
                foreach(int week in yearweek)
                {
                    decimal wintotal = 0.0M, wextotal = 0.0M, wbenefit = 0.0M;
                    //当前周的日期和记录
                    var thisweek_date = yeardate.Where(r => GetWeekNum(DateTime.Parse(r)) == week);
                    var thisweek_record = yearrecord.Where(r => GetWeekNum(r.time) == week);
                    foreach (var w in thisweek_date)
                    {
                        decimal dintotal = 0.0M, dextotal = 0.0M, dbenefit = 0.0M;
                        List<RecordInfo> cur_record = thisweek_record.Where(r => r.time.ToString("yyyy-MM-dd") == w).ToList();
                        if(cur_record.Count>0)
                        {
                            foreach(var cur in cur_record)
                            {
                                if(cur.itemtype == "收入")
                                {
                                    dintotal += cur.money;
                                }
                                else
                                {
                                    dextotal += cur.money;
                                }
                            }
                            dbenefit = dintotal - dextotal;
                        }
                        wintotal += dintotal;
                        wextotal += dextotal;
                        wbenefit += dbenefit;
                    }
                    if(week == thisweekofYear)
                    {
                        weekintotal = wintotal;
                        weekextotal = wextotal;
                        weekbenefit = wbenefit;
                    }
                    wlist.Add(new WeekInfo()
                    {
                        Year = year.ToString(),
                        weeknum = week.ToString(),
                        intotal= wintotal,
                        extotal = wextotal,
                        profittotal = wbenefit
                    });
                }

                // 显示数据
                if (wlist.Count > 0)
                {
                    var highex_list = wlist.Select(r => r.extotal).ToList();
                    decimal highex = highex_list.Max();
                    decimal lowex = highex_list.Min();
                    foreach (WeekInfo week in wlist)
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = week.Year;
                        li.SubItems.Add(week.weeknum.ToString());
                        li.SubItems.Add(week.intotal.ToString());
                        li.SubItems.Add(week.extotal.ToString());
                        li.SubItems.Add(week.profittotal.ToString());

                        lvweek.Items.Add(li);
                    }
                }
            }

        }
        private int GetWeekNum(DateTime dt)
        {
            CultureInfo cl = new CultureInfo("zh-CN");
            return cl.Calendar.GetWeekOfYear(dt, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
        }
    }
}
