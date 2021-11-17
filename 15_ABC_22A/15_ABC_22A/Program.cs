using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _15_ABC_22A
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Class.ABC.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDMHanghoa());

        }
    }
}
