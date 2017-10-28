using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Android_Language_Helper.resources;

namespace Android_Language_Helper
{
    internal class XmlStringsExporter
    {
        private XmlDataDocument document;

        public XmlStringsExporter(string xmlFilePath)
        {
            document = new XmlDataDocument();
            document.Load(new FileStream(xmlFilePath, FileMode.Open, FileAccess.Read));
        }

        public List<StringObj> exportStrings()
        {
            List<StringObj> stringsToTranslate = new List<StringObj>();
            foreach (XmlNode child in document.ChildNodes[0].ChildNodes)
            {
                if (isComment(child) || isNotTranslateable(child))continue;
                StringObj stringObj = new StringObj(child.InnerText, child.Attributes["name"].Value.ToString());
                stringsToTranslate.Add(stringObj);
            }

            return stringsToTranslate;
        }

        private bool isComment(XmlNode child)
        {
            return child.Name.Equals("#comment");
        }

        private bool isNotTranslateable(XmlNode child)
        {
            return child.Attributes["translatable"] != null && child.Attributes["translatable"].Value.Equals("false");
        }


        public XmlDataDocument Document
        {
            get => document;
            set => document = value;
        }
    }
}