using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace vd1_chuong5
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
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source = localhost\\SQLEXPRESS;" +
            //    "Initial Catalog = quanlybanhang; Integrated Security = True";
            //try
            //{
            //    con.Open();
            //    MessageBox.Show("Mở kết nối thành công");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

            Application.Run(new Form1());
        }
    }
}
