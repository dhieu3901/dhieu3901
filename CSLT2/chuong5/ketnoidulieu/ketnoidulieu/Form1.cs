using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ketnoidulieu
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
            // kết nối cơ sở dữ liệu
           // SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-4G918BK\\SQLEXPRESS;" +
                "Initial Catalog=quanlybanhang;Integrated Security=True";
            try
            {
                con.Open();
                // thiet  lap cầu nối tới cơ sở dữ liệu
                string sql = "select * from tblchatlieu";
                SqlDataAdapter mydata = new SqlDataAdapter(sql,con);
                DataTable mytable = new DataTable();
                mydata.Fill(mytable);
                // hien thi du lieu
                dataGridView1.DataSource = mytable;
                //dong ket noi
                con.Close();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string macl = txtmacl.Text;
            string tencl = txttencl.Text;
            string sql = "insert into tblchatlieu values ('" + macl + "',N'" 
                                                          + tencl + "')";
            MessageBox.Show(sql);
            try
            {
                // thuc hien viec cap nhat du lie
                con.Open();
                SqlCommand mycommand = new SqlCommand(sql, con);
                mycommand.ExecuteNonQuery();
                // thuc hien lay du lieu ra data gridvie
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
