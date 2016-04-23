using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnipIt
{
    static class Program
    {
        public static bool MultiSnip { get; set; }
        public static string LastPrinterName { get; set; }
        /// <summary>
        /// The startup form, held for use with multi-snips
        /// </summary>
        public static MainForm ControllerForm { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ControllerForm = new MainForm();
            Application.Run(ControllerForm);
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
