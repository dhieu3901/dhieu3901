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

namespace QuanLySach
{
    class Load
    {
        public static SqlConnection con;
        public static string connectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS;" +
            "Initial Catalog=QuanLySach;Integrated Security=True";
        public static void SetUpConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
        }
        public static void openConnection()
        {
            if(con.State==ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void closeConnection()
        {
            if(con.State==ConnectionState.Open)
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
        public static void executeNonQuery (string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }
        public static SqlDataReader executeReader (string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rd = cmd.ExecuteReader();
            return rd;
        }
    }
}
