using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android_Language_Helper.resources.requests;

namespace Android_Language_Helper.resources.makers
{
    interface FileMadeCallback
    {
        void onXlsxFileMade();
        void onXmlFileMade(XmlRequest xmlRequest);

    }
}
