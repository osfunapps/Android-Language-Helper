using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_Language_Helper.resources
{
    class StringObj
    {
        private string stringToTranslate, code;

        public StringObj(string stringToTranslate, string code)
        {
            this.stringToTranslate = stringToTranslate;
            this.code = code;
        }

        public string StringToTranslate
        {
            get => stringToTranslate;
            set => stringToTranslate = value;
        }

        public string Code
        {
            get => code;
            set => code = value;
        }
    }
}
