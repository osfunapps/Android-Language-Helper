using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Language_Helper.resources.requests
{
    public class XlsxRequest : Request
    {
        private string appName, appDescription;

        public string AppName
        {
            get => appName;
            set => appName = value;
        }

        public string AppDescription
        {
            get => appDescription;
            set => appDescription = value;
        }

    
        public XlsxRequest(string inputPath, string outputPath) : base(inputPath, outputPath)
        {
            this.type = Request.XLSX;
        }
    }

}
