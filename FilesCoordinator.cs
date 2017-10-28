using System.Collections.Generic;
using System.Windows.Forms;
using Android_Language_Helper.resources;
using Android_Language_Helper.resources.excel;
using Android_Language_Helper.resources.makers;
using Android_Language_Helper.resources.requests;

namespace Android_Language_Helper
{
    internal class FilesCoordinator : RequestCallback
    {

        public static string APP_NAME = "App Name";
        public static string APP_DESCRIPTION = "App Description";
        private string FILE_MADE = "file made!";
        private FileMadeCallback callback;

        public FilesCoordinator(FileMadeCallback callback)
        {
            this.callback = callback;

        }

        public void coordinateFiles(Request request)
        {
            request.getRequestType(this);
        }


        public void onXlsxRequest(XlsxRequest xlsxObject)
        {
            XmlStringsExporter xmlStringsExporter = new XmlStringsExporter(xlsxObject.InputPath);
            List<StringObj> stringsToTranslate = xmlStringsExporter.exportStrings();
            XlsFileMaker xlsFileMaker = new XlsFileMaker(callback);

            stringsToTranslate.Add(new StringObj(xlsxObject.AppDescription, APP_DESCRIPTION));
            stringsToTranslate.Insert(0, new StringObj(xlsxObject.AppName, APP_NAME));
            xlsFileMaker.makeXlsFile(xlsxObject.Language, stringsToTranslate, xlsxObject.OutputPath);
        }




        public void onXmlRequest(XmlRequest xmlObject)
        {
            //todo change excel input
            List<StringObj> stringObjList = new ExcelStringsExporter(xmlObject).exportStrings();
            XmlFileMaker xmlFileMaker = new XmlFileMaker(callback);
            xmlFileMaker.makeXmlFile(stringObjList, xmlObject);
        }
    }
}