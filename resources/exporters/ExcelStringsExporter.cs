using System.Collections.Generic;
using Android_Language_Helper.resources;
using Android_Language_Helper.resources.requests;
using Codaxy.Xlio;

namespace Android_Language_Helper
{
    internal class ExcelStringsExporter
    {
        private Sheet sheet;
        private string language;
        private XmlRequest xmlObject;

        public ExcelStringsExporter(XmlRequest xmlObject)
        {
            this.xmlObject = xmlObject;
            var workbook = Workbook.Load(xmlObject.InputPath);
            sheet = workbook.Sheets[0];
        }

        public List<StringObj> exportStrings()
        {
            List<StringObj> stringObjList = new List<StringObj>();
            this.language = sheet.SheetName;
            xmlObject.Translation = language.Substring(0, language.LastIndexOf(" "));
            int rows = sheet.Data.Rows.Count;

            var translatedCells = sheet[3, 2, 3 + (rows), 2];
            var programCells = sheet[3, 5, 3 + (rows), 5];


            for (int i = 0; i < rows; i++)
            {
                
                if (translatedCells[i].Value == null)continue;
                StringObj stringObj = new StringObj(translatedCells[i].Value.ToString(), programCells[i].Value.ToString());
                stringObjList.Add(stringObj);
            }

            return stringObjList;
        }

        public string Language
        {
            get => language;
            set => language = value;
        }
    }
}