using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WinformBookRecoder.Tools
{
    /// <summary>
    /// app.Config文件中appSettings节点读写
    /// </summary>
    public class AppHelper
    {
        /// <summary>
        /// 设置节点的值，若该节点不存在，则创建一个新appSetting的节点。
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool SetValue(string key, string value)
        {
            XmlDocument cfgDoc = new XmlDocument();
            string path = ((Assembly.GetEntryAssembly()).GetName()).Name + ".exe.config";
            cfgDoc.Load(path);
            XmlElement root = cfgDoc.DocumentElement;
            XmlNode node = cfgDoc.SelectSingleNode("//appSettings");
            if (node == null)
            {
                node = cfgDoc.CreateElement("appSettings");
                root.AppendChild(node);

            }
            XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
            if (addElem != null)
            {
                addElem.SetAttribute("value", value);
            }
            else
            {
                XmlElement entry = cfgDoc.CreateElement("add");
                entry.SetAttribute("key", key);
                entry.SetAttribute("value", value);
                node.AppendChild(entry);
            }
            cfgDoc.Save(path);
            return true;
        }

        /// <summary>
        /// 获取appSettings中节点的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            XmlDocument cfgDoc = new XmlDocument();
            string path = ((Assembly.GetEntryAssembly()).GetName()).Name + ".exe.config";
            cfgDoc.Load(path);
            XmlElement root = cfgDoc.DocumentElement;
            XmlNode node = cfgDoc.SelectSingleNode("//appSettings");
            if (node != null)
            {
                XmlElement addElem = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
                if (addElem != null)
                {
                    return addElem.GetAttribute("value");
                }
            }
            return "";
        }
    }
}
