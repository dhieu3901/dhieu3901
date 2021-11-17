using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Hienthidulieu
{
    class DAO
    {
        public static SqlConnection con;
        private static string connectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS" +
                ";Initial Catalog=quanlybanhang;Integrated Security=True";
        public static void setupConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
        }
        public static void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static DataTable getDatatoTable(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            return mytable;
        }
        public static void executeQueury(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            mycommand.ExecuteNonQuery();
        }
    }
}
