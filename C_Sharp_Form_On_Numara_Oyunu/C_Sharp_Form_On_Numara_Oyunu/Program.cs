using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C_Sharp_Form_On_Numara_Oyunu
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
            Application.Run(new OnNumaraForm());
        }
    }
}