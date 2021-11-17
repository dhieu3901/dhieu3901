using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vidu2_Chuong4
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

            MessageBox.Show("Hello!!!");
            Application.Run(new FrmMain());
        }
    }
}
