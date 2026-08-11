using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformBookRecoder.Models
{
    public class RecordInfo
    {
        public int id { get; set; }
        public string itemtype { get; set; }
        public string itemname { get; set; }
        public string desc { get; set; }
        public decimal money { get; set; }
        public DateTime time { get; set; }

    }
}
