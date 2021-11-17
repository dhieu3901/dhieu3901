using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Chuong5_QlyNhanVien
{
    class DAO
    {
        public static SqlConnection con;
        public static void SetUpConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS;" +
                "Initial Catalog=QuanLyNhanVien;Integrated Security=True";
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
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mydata = new DataTable();
            myadapter.Fill(mydata);
            return mydata;
        }
        public static void ExecuteNonQuery(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            mycommand.ExecuteNonQuery();
        }
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            SqlDataReader myread = mycommand.ExecuteReader();
            return myread;
        }
    }
}
