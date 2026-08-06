using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformBookRecoder.Tools
{
    /// <summary>
    /// 文本文件读写操作类
    /// </summary>
    public class TextHelper
    {
        /// <summary>
        /// 向指定文本文件写入一行信息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="filePath"></param>
        public static void WriteMsg(string msg, string filePath, bool bAppend)
        {   // 不设置编码会导致无法换行
            using (StreamWriter sw = new StreamWriter(filePath, bAppend,System.Text.Encoding.UTF8))
            {
                sw.WriteLine(msg);
            }
        }

        /// <summary>
        /// 向指定文本文件写入多行文本
        /// </summary>
        /// <param name="msgList"></param>
        /// <param name="filePath"></param>
        public static void WriteMsgList(List<string> msgList, string filePath, bool bAppend)
        {
            using (StreamWriter sw = new StreamWriter(filePath, bAppend))
            {
                foreach (string s in msgList)
                {
                    sw.WriteLine(s);
                }
            }
        }

        /// <summary>
        /// 读取文件所有行文本
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static List<string> ReadTextAllLines(string filePath)
        {
            List<string> lines = new List<string>();
            if (File.Exists(filePath))
            {
                lines = File.ReadLines(filePath).ToList();
            }
            return lines;
        }

    }
}
