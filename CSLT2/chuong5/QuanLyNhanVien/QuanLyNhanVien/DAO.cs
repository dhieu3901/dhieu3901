using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyNhanVien
{
    class DAO
    {
        //Câu 3.3
        public static SqlConnection con;
        private static string connectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS;" +
            "Initial Catalog=QlyNhanVien;Integrated Security=True";
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
        public static DataTable getDatatotable(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            return mytable;
        }
        public static void ExecuteNonQuery(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            mycommand.ExecuteNonQuery();
        }
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            SqlDataReader myreader = mycommand.ExecuteReader();
            return myreader;
        }
    }
}
