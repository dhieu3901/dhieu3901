using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Test1
{
    class DAO
    {
        public static SqlConnection con;
        private static string connectionString = "Data Source=localhost\\SQLEXPRESS;" +
            "Initial Catalog=QlyBanHang1.1;Integrated Security=True;Pooling=False";
        public static void SetUpConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
        }
        public static void OpenConnection()
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void CloseConnection()
        {
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static DataTable GetDataToTable (string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            return tbl;
        }
        public static void ExecuteQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql,con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count>0)
            {
                return true;
            }
            else return false;
        }
        public static string GetFieldValue (string sql)
        {
            string ma="";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                ma = rd.GetValue(0).ToString();
            rd.Close();
            return ma;
        }
        public static void FillCombo(string sql, ComboBox cmbo,string ma,string ten)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            cmbo.DataSource = tbl;
            cmbo.ValueMember = ma;
            cmbo.DisplayMember=ten;
        }
    }
}
