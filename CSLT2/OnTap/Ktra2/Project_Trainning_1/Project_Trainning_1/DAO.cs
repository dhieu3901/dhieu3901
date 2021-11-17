using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Trainning_1
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
        public static void openConnection()
        {
            if (con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void closeConnection()
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
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count > 0)
                return true;
            else return false;
        }
        public static void FillCombo (string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            cbo.DataSource = tbl;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static string GetFieldValues (string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                ma = rd.GetValue(0).ToString();
            return ma;
        }
    }
}
