using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyBanHang1
{
    class DAO
    {
        public static SqlConnection con;
        public static string connectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS;" +
            "Initial Catalog=quanlybanhang;Integrated Security=True";
        public static void SetupConnection()
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
        public static DataTable getDataToTable(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            return tbl;
        }
        public static void executeNonquery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public static void FillCombo (string sql, ComboBox cmb, string ma, string ten)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            cmb.DataSource = tbl;
            cmb.DisplayMember = ten;
            cmb.ValueMember = ma;
        }
        public static string GetFieldValue (string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
                ma = rd.GetValue(0).ToString();
            rd.Close();
            return ma;
        }
        public static bool check_key_exist (string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            if (tbl.Rows.Count >= 1)
            {
                return true;
            }
            else return false;
        }
    }
}
