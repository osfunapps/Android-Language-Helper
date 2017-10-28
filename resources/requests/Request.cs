using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Language_Helper.resources.requests
{
    public class Request
    {
        public Request(string inputPath, string outputPath)
        {
            this.inputPath = inputPath;
            this.outputPath = outputPath;
        }

        private string inputPath, outputPath, language;
        protected string type;
        protected static string XLSX = "xlsx";
        protected static string XML = "xml";

        public string InputPath
        {
            get => inputPath;
            set => inputPath = value;
        }

        public string OutputPath
        {
            get => outputPath;
            set => outputPath = value;
        }

        public string Language
        {
            get => language;
            set => language = value;
        }

        public void getRequestType(RequestCallback requestCallback)
        {
            if (type.Equals(XLSX))
                requestCallback.onXlsxRequest((XlsxRequest) this);
            else
                requestCallback.onXmlRequest((XmlRequest) this);
        }
    }
}
