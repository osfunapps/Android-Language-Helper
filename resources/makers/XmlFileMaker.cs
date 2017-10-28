using System;
using System.Collections.Generic;
using System.Xml;
using Android_Language_Helper.resources;
using Android_Language_Helper.resources.makers;
using Android_Language_Helper.resources.requests;

namespace Android_Language_Helper
{
    internal class XmlFileMaker
    {
        //interface
        public FileMadeCallback callback;

        //strings
        private string TAG_STRING = "string";
        private string ATT_NAME = "name";


        public XmlFileMaker(FileMadeCallback callback)
        {
            this.callback = callback;
        }

        public void makeXmlFile(List<StringObj> stringObjList, XmlRequest xmlRequest)
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlElement resourcesNode = xmlDocument.CreateElement("resources");
            foreach (StringObj stringObj in stringObjList)
            {
                if (stringObj.Code.Equals(FilesCoordinator.APP_NAME))
                {
                    xmlRequest.TranslatedAppName = stringObj.StringToTranslate;
                    continue;
                }
                else if (stringObj.Code.Equals(FilesCoordinator.APP_DESCRIPTION))
                {
                    xmlRequest.TranslatedAppDescription = stringObj.StringToTranslate;
                    continue;
                }
                else if (stringObj.Code.Equals(FilesCoordinator.APP_SUMMARY))
                {
                    xmlRequest.TranslatedAppSummary = stringObj.StringToTranslate;
                    continue;
                }

                XmlElement stringNode = xmlDocument.CreateElement(TAG_STRING);
                stringNode.SetAttribute(ATT_NAME, stringObj.Code);
                stringNode.InnerText = stringObj.StringToTranslate;
                resourcesNode.AppendChild(stringNode);
            }

            xmlDocument.AppendChild(resourcesNode);
            xmlDocument.Save(xmlRequest.OutputPath);
            callback.onXmlFileMade(xmlRequest);
        }
    }
}