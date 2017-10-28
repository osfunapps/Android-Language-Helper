﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Language_Helper.resources.requests
{
    public interface RequestCallback
    {

        void onXlsxRequest(XlsxRequest xlsxObject);
        void onXmlRequest(XmlRequest xmlObject);
    }
}
