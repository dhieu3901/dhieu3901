using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hienthidulieu
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kết nói với CSDL
            //SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS" +
                ";Initial Catalog=quanlybanhang;Integrated Security=True";
            try
            {
                con.Open();
                //Thiết lập cầu nối tới CSDL
                string sql = "select * from tblchatlieu";
                SqlDataAdapter mydata = new SqlDataAdapter(sql, con);
                DataTable mytable = new DataTable();
                mydata.Fill(mytable);
                dataGridView1.DataSource = mytable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string macl = txtmacl.Text;
            string tencl = txttencl.Text;
            string sql = "insert into tblchatlieu values ('" + macl + "',N'" + tencl + "')";
            MessageBox.Show(sql);
            try
            {
                //Thực hiện cập nhật dữ liệu
                con.Open();
                SqlCommand mycommand = new SqlCommand(sql, con);
                mycommand.ExecuteNonQuery();
                //Thực hiện lấy dữ liệu ra
                sql = "select * from tblchatlieu";
                SqlDataAdapter myadater = new SqlDataAdapter(sql, con);
                DataTable mytable = new DataTable();
                myadater.Fill(mytable);
                dataGridView1.DataSource = mytable;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
