using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chuong5_QlyNhanVien
{
    public partial class frmQlyNhanVien : Form
    {
        public frmQlyNhanVien()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql = "Select * from tblNhanvien";
            dataGridView1.DataSource = DAO.GetDataToTable(sql);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void DataGridView_Click(object sender,DataGridViewCellEventArgs e)
        {   
            txtMaNhanVien.Text = dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString().Trim();
            txtHoTen.Text = dataGridView1.CurrentRow.Cells["HoTen"].Value.ToString().Trim();
            txtQueQuan.Text = dataGridView1.CurrentRow.Cells["QueQuan"].Value.ToString().Trim();
            txtMaNhanVien.Enabled = false;
        }
        private void frmQlyNhanVien_Load(object sender, EventArgs e)
        {
            DAO.SetUpConnection();
            try
            {
                DAO.OpenConnection();
                LoadDataGridView();
                DAO.CloseConnection();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtMaNhanVien.Text;
            string hoten = txtHoTen.Text;
            string quequan = txtQueQuan.Text;
            if (hoten == "" || quequan == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                if (hoten == "") txtHoTen.Focus();
                else txtQueQuan.Focus();
                return;
            }
            else
            {
                string sql = "update tblNhanvien"
                            + " set HoTen =N'" + hoten + "',QueQuan =N'" + quequan + "'"
                            + "where MaNV='" + manv+"'";
                try
                {
                    DAO.OpenConnection();
                    DAO.ExecuteNonQuery(sql);
                    LoadDataGridView();
                    DAO.CloseConnection();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string manhanvien = txtMaNhanVien.Text;
            string tennhanvien = txtHoTen.Text;
            string quequan = txtQueQuan.Text;
            if (manhanvien == "" || tennhanvien == "" || quequan == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!");
                if (manhanvien == "") txtMaNhanVien.Focus();
                else if (tennhanvien == "") txtHoTen.Focus();
                else txtQueQuan.Focus();
                return;
            }
            else
            {
                try
                {
                    DAO.OpenConnection();
                    string sql = "select MaNV from tblNhanVien";
                    SqlDataReader rd = DAO.ExecuteReader(sql);
                    while (rd.Read())
                        if (rd[0].ToString().Trim() == txtMaNhanVien.Text.Trim())
                        {
                            MessageBox.Show("Mã nhân viên không hợp lệ!");
                            txtMaNhanVien.Focus();
                            rd.Close();
                            return;
                        }
                    rd.Close();
                    sql = "insert into tblNhanvien values('" + manhanvien + "',N'" + tennhanvien + "',N'" + quequan + "')";
                    DAO.ExecuteNonQuery(sql);
                    LoadDataGridView();
                    DAO.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        private void ClearTextBox()
        {
            if (txtMaNhanVien.Enabled == false)
            {
                txtMaNhanVien.Enabled = true;
                txtMaNhanVien.Text = "";
            }
            else txtMaNhanVien.Text = "";
            txtHoTen.Text = "";
            txtQueQuan.Text = "";
            txtMaNhanVien.Focus();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manhanvien = txtMaNhanVien.Text;
            string sql = "delete from tblNhanvien where MaNV='" + manhanvien + "'";
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    DAO.OpenConnection();
                    DAO.ExecuteNonQuery(sql);
                    LoadDataGridView();
                    DAO.CloseConnection();
                    ClearTextBox();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
        }
    }
}
