using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ketnoidulieu
{
    class DAO
    {
        public static SqlConnection con;
        private static string connectionString = "Data Source=DESKTOP-PEEQMRS\\SQLEXPRESS;" +
            "Initial Catalog=quanlybanhang;Integrated Security=True";
        public static void setupConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
        }
        public static void openConnection()
        {
            if (con.State == ConnectionState.Closed) {
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
        public static  DataTable getDatatoTable(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            return mytable;
        }
        public static void excecuteQueury(string sql)
        {
            SqlCommand mycommand = new SqlCommand(sql, con);
            mycommand.ExecuteNonQuery();
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }


        public static bool check_key_exits(string sql)
        {
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable mytable = new DataTable();
            myadapter.Fill(mytable);
            if (mytable.Rows.Count >= 1)
            {
                return true;
            }
            else
                return false;

        }


    }
}
