using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Android_Language_Helper.resources;
using Android_Language_Helper.resources.excel;

namespace Android_Language_Helper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TranslatorForm());

        }

     
    }
}

