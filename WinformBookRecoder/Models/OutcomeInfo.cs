using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformBookRecoder.Models
{
    public class OutComeInfo
    {

        public int outcomeid { get; set; }
        public string outcomeitem { get; set; }
        public string outcomedesc { get; set; }
        public decimal money { get; set; }
        public string outcometime { get; set; }

        public ListViewItem ParseView()
        {
            ListViewItem lv = new ListViewItem(outcomeid.ToString());
            lv.SubItems.Add(outcomeitem);
            lv.SubItems.Add(outcomedesc);
            lv.SubItems.Add(money.ToString());
            lv.SubItems.Add(outcometime);
            return lv;
        }
        public OutComeInfo ParseString(string outcome)
        {
            // 重置当前对象，避免上次残留数据
            outcomeid = 0;
            outcomeitem = "-";
            outcomedesc = "-";
            money = 0m;
            outcometime = "-";

            // 入参为空直接返回默认对象
            if (string.IsNullOrWhiteSpace(outcome))
                return this;

            string[] arr = outcome.Trim().Split('\t');

            // 索引0：outcomeid
            if (arr.Length >= 1 && int.TryParse(arr[0].Trim(), out int outcome_out))
            {
                outcomeid = outcome_out;
            }

            // 索引1：outcomeitem
            if (arr.Length >= 2 && !string.IsNullOrWhiteSpace(arr[1]))
            {
                outcomeitem = arr[1].Trim();
            }

            // 索引2：outcomedesc
            if (arr.Length >= 3 && !string.IsNullOrWhiteSpace(arr[2]))
            {
                outcomedesc = arr[2].Trim();
            }

            // 索引3：money（decimal类型，安全转换）
            if (arr.Length >= 4 && decimal.TryParse(arr[3].Trim(), out decimal moneyVal))
            {
                money = moneyVal;
            }

            // 索引4：outcometime
            if (arr.Length >= 5 && !string.IsNullOrWhiteSpace(arr[4]))
            {
                outcometime = arr[4].Trim();
            }

            return this;
        }
        public override string ToString()
        {
            return $"{outcomeid}\t{outcomeitem}\t{outcomedesc}\t{money.ToString()}\t{outcometime}";
        }
    }
}
