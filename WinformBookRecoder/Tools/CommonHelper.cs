using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WinformBookRecoder.Models;
namespace WinformBookRecoder.Tools
{
    public class CommonHelper
    {
        public static string storepath = "";
        public static string datafilepath = "";
        public static string ItemPath = "";
        public static string IncomePath = "";
        public static string OutcomePath = "";
        public static string DayPath = "";
        public static string WeekPath = "";
        public static string MonthPath = "";
        
        // 获取指定命名列表
        public static List<string> Load_ItemData(int itemtype)  
        {
            List<string> saves = new List<string>();
            string typename = "";
            switch(itemtype)
            {
                case 0: typename = "收入";break;
                case 1: typename = "支出"; break;
                default: typename = "其他"; break;
            }
            if (File.Exists(ItemPath))
            {
                
                List<string> data = new List<string>();
                data = TextHelper.ReadTextAllLines(ItemPath);

                foreach(string item in data)
                {
                    string itemt = item.Split('\t')[1];
                    string itemn = item.Split('\t')[2];
                    if (itemt == typename)
                    {
                        saves.Add(itemn);
                    }
                }
            }
            return saves;

        }

        public static List<IncomeInfo> Get_IncomeList()
        {
            List<IncomeInfo> Income_list = new List<IncomeInfo>();
            string incomepath = CommonHelper.IncomePath;

            List<string> datas = TextHelper.ReadTextAllLines(incomepath);

            foreach(string s in datas)
            {
                string[] arr = s.Trim().Split('\t');
                IncomeInfo ic = new IncomeInfo();
                
                ic.incomeid = int.TryParse(arr[0],out int idval)?0:idval;
                ic.incomeitem = arr[1];
                ic.incomedesc = arr[2];
                ic.money = decimal.Parse(arr[3]);
                ic.incometime = arr[4];

                Income_list.Add(ic);
            }
            return Income_list;
        }
    }
    
}
