using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 工具类
namespace WinformBookRecoder.Tools
{
    public class MessageHelper
    {

        public static void Info(string title,string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Fail(string title, string msg)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult Query(string title, string msg)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static DialogResult Confirm(string title, string msg)
        {
            return MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
