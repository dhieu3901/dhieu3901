using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vd1_chuong5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=localhost\\SQLEXPRESS;" +
                "Initial Catalog=quanlybanhang;Integrated Security=True";
            try
            {
                con.Open();
                string sql = "select *from tblChatlieu";
                SqlDataAdapter myData = new SqlDataAdapter(sql, con);
                DataTable mytable = new DataTable();
                myData.Fill(mytable);
                dataGridChatLieu.DataSource = mytable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
