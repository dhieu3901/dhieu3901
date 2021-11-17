using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _15_TranDuyTrungHieu_22A4040135.Class
{
    class ABC
    {
        public static SqlConnection Conn;  //Khai báo đối tượng kết nối
        public static string connString;   //Khai báo biến chứa chuỗi kết nối

        public static void Connect()
        {
            //Thiết lập giá trị cho chuỗi kết nối
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C#\15_TranDuyTrungHieu_22A4040135\15_TranDuyTrungHieu_22A4040135\22A4040135.mdf;Integrated Security=True;Connect Timeout=30";
            Conn = new SqlConnection();         		//Cấp phát đối tượng
            Conn.ConnectionString = connString; 		//Kết nối
            Conn.Open();                        		//Mở kết nối
            //MessageBox.Show("Ket noi thanh cong", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose();     //Giải phóng tài nguyên
                Conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter();	// Khai báo
            // Tạo đối tượng Command thực hiện câu lệnh SELECT        
            Mydata.SelectCommand = new SqlCommand();
            Mydata.SelectCommand.Connection = ABC.Conn; 	// Kết nối CSDL
            Mydata.SelectCommand.CommandText = sql;	// Gán câu lệnh SELECT
            DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
            Mydata.Fill(table); 	//Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, ABC.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;		                // Khai báo đối tượng SqlCommand
            cmd = new SqlCommand();	         // Khởi tạo đối tượng
            cmd.Connection = ABC.Conn;	  // Gán kết nối
            cmd.CommandText = sql;			  // Gán câu lệnh SQL
            try
            {
                cmd.ExecuteNonQuery();		  // Thực hiện câu lệnh SQL
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ABC.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter Mydata = new SqlDataAdapter(sql, ABC.Conn);
            DataTable table = new DataTable();
            Mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;    // Truong gia tri
            cbo.DisplayMember = ten;    // Truong hien thi
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, ABC.Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
    }
}
