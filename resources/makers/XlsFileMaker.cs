using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Android_Language_Helper.resources.makers;
using Android_Language_Helper.resources.requests;
using Codaxy.Xlio;

namespace Android_Language_Helper.resources.excel
{
    class XlsFileMaker
    {

        public FileMadeCallback callback;

        public XlsFileMaker(FileMadeCallback callback)
        {
            this.callback = callback;
        }

        public void makeXlsFile(string language, List<StringObj> stringsObjList, string xlsxOutputPath)
        {
            Workbook workbook = new Workbook();
            var sheet = workbook.Sheets.AddSheet(language + " Translation");

            setDefaultValues(workbook, sheet, language);
            var rows = stringsObjList.Count;

            setBorder(sheet, rows);

            //set cells
            setStyleAndStrings(sheet, stringsObjList, rows);
            workbook.Save(xlsxOutputPath);
            callback.onXlsxFileMade();
        }


        private static void setStyleAndStrings(Sheet sheet, List<StringObj> stringsObjList, int rows)
        {

            var cells = sheet[3, 0, 3 + (rows), 2];

            for (int i = 0; i < rows; i++)
            {
                //wrap text
                cells[i, 0].Style.Alignment.WrapText = true;
                cells[i, 1].Style.Alignment.WrapText = true;
                cells[i, 2].Style.Alignment.WrapText = true;

                //vertical alignment top
                cells[i, 0].Style.Alignment.Vertical = VerticalAlignment.Top; ;
                cells[i, 1].Style.Alignment.Vertical = VerticalAlignment.Top; ;
                cells[i, 2].Style.Alignment.Vertical = VerticalAlignment.Top; ;

                cells[i, 5].Value = stringsObjList[i].Code;
                cells[i, 1].Value = stringsObjList[i].StringToTranslate;
                if (stringsObjList[i].Code.Equals(FilesCoordinator.APP_NAME))
                {
                    cells[i, 0].Value = "This is the app name";
                    cells[i, 0].Style.Font.Bold = true;
                }
                if (stringsObjList[i].Code.Equals(FilesCoordinator.APP_SUMMARY))
                {
                    cells[i, 0].Value = "This is the app summary";
                    cells[i, 0].Style.Font.Bold = true;
                }


                else if (stringsObjList[i].Code.Equals(FilesCoordinator.APP_DESCRIPTION))
                {
                    cells[i, 0].Value = "This is the app description";
                    cells[i, 0].Style.Font.Bold = true;
                }
            }

        }



        private static void setBorder(Sheet sheet, int rows)
        {
            var cellsToBorder = sheet[2, 0, rows + 2, 2];
            cellsToBorder.SetOutsideBorder(new BorderEdge { Color = Color.Black, Style = BorderStyle.Medium });
        }

        private static void setDefaultValues(Workbook workbook, Sheet sheet, string language)
        {
            //set default values
            workbook.DefaultFont.Name = "Arial";
            workbook.DefaultFont.Size = 12;
            sheet.DefaultColumnWidth = 65;

            //set titles
            sheet["A1"].Value = "Translation Project";
            sheet["A1"].Style.Font.Size = 22;

            sheet["A3"].Value = "Help/Tips";
            sheet["A3"].Style.Font.Color = Color.Red;
            sheet["A3"].Style.Font.Size = 16;
            sheet["A3"].Style.Alignment.Horizontal = HorizontalAlignment.Center;

            sheet["B3"].Value = "English";
            sheet["B3"].Style.Font.Color = Color.Red;
            sheet["B3"].Style.Font.Size = 18;
            sheet["B3"].Style.Alignment.Horizontal = HorizontalAlignment.Center;

            sheet["C3"].Value = language;
            sheet["C3"].Style.Font.Color = Color.Red;
            sheet["C3"].Style.Font.Size = 18;
            sheet["C3"].Style.Alignment.Horizontal = HorizontalAlignment.Center;

            sheet["F3"].Value = "Code (DO NOT CHANGE)";
            sheet["F3"].Style.Font.Color = Color.Red;
            sheet["F3"].Style.Font.Size = 16;
            sheet["F3"].Style.Alignment.Horizontal = HorizontalAlignment.Center;

        }
    }

}
