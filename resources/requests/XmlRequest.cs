using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Language_Helper.resources.requests
{
    public class XmlRequest : Request
    {
        /** a type caller for this request object **/
        public void getRequestType(RequestCallback requestCallback)
        {
            requestCallback.onXmlRequest(this);
        }

        public XmlRequest(string inputPath, string outputPath) : base(inputPath, outputPath)
        {
            this.type = Request.XML;
        }

        public string TranslatedAppName { get; set; }
        public string TranslatedAppDescription { get; set; }
        public string Translation { get; set; }
        public string TranslatedAppSummary { get; set; }
    }


}
