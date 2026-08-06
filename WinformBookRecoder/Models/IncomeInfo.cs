using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBookRecoder.Models
{
    public class IncomeInfo
    {

        public int incomeid { get; set; }
        public string incomeitem { get; set; }
        public string incomedesc { get; set; }
        public decimal money { get; set; }
        public string incometime { get; set; }

        public ListViewItem ParseView()
        {
            ListViewItem lv = new ListViewItem(incomeid.ToString());
            lv.SubItems.Add(incomeitem);
            lv.SubItems.Add(incomedesc);
            lv.SubItems.Add(money.ToString());
            lv.SubItems.Add(incometime);
            return lv;
        }
        public IncomeInfo ParseString(string income)
        {
            // 重置当前对象，避免上次残留数据
            incomeid = 0;
            incomeitem = "-";
            incomedesc = "-";
            money = 0m;
            incometime = "-";

            // 入参为空直接返回默认对象
            if (string.IsNullOrWhiteSpace(income))
                return this;

            string[] arr = income.Trim().Split('\t');

            // 索引0：incomeid
            if (arr.Length >= 1 && int.TryParse(arr[0].Trim(), out int income_out))
            {
                incomeid = income_out;
            }

            // 索引1：incomeitem
            if (arr.Length >= 2 && !string.IsNullOrWhiteSpace(arr[1]))
            {
                incomeitem = arr[1].Trim();
            }

            // 索引2：incomedesc
            if (arr.Length >= 3 && !string.IsNullOrWhiteSpace(arr[2]))
            {
                incomedesc = arr[2].Trim();
            }

            // 索引3：money（decimal类型，安全转换）
            if (arr.Length >= 4 && decimal.TryParse(arr[3].Trim(), out decimal moneyVal))
            {
                money = moneyVal;
            }

            // 索引4：incometime
            if (arr.Length >= 5 && !string.IsNullOrWhiteSpace(arr[4]))
            {
                incometime = arr[4].Trim();
            }

            return this;
        }
        public override string ToString()
        {
            return $"{incomeid}\t{incomeitem}\t{incomedesc}\t{money.ToString()}\t{incometime}";
        }
    }
}
