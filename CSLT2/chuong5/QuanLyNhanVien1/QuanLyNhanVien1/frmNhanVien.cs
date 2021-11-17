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

namespace QuanLyNhanVien1
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from tblNhanvien";
            DataTable dataNhanvien = DAO.GetDatatoTable(sql);
            dataGridViewNhanvien.DataSource = dataNhanvien;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DAO.SetupConnection();
            try
            {
                DAO.openConnection();
                LoadDataToGridView();
                DAO.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dataGridViewNhanvien_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = dataGridViewNhanvien.CurrentRow.Cells["MaNV"].Value.ToString().Trim();
            txtHoten.Text = dataGridViewNhanvien.CurrentRow.Cells["Hoten"].Value.ToString().Trim();
            txtQuequan.Text = dataGridViewNhanvien.CurrentRow.Cells["Quequan"].Value.ToString().Trim();
            txtMaNV.Enabled = false;
        }
        private void ClearTextBox()
        {
            if (txtMaNV.Enabled==false)
            {
                txtMaNV.Enabled = true;
                txtMaNV.Text= "";
                return;
            }
            txtHoten.Text = "";
            txtQuequan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string hoten = txtHoten.Text;
            string quequan = txtQuequan.Text;
            if (quequan==""||hoten=="")
            {
                MessageBox.Show("Dữ liệu thiếu");
                if (quequan == "") txtQuequan.Focus();
                else txtQuequan.Focus();
            }
            else
            {
                string sql = "update tblNhanvien set Hoten=N'" + hoten + "',Quequan=N'" + quequan + "'where MaNV=N'"+manv+"'";
                try
                {
                    DAO.openConnection();
                    DAO.ExecuteNonQuery(sql);
                    LoadDataToGridView();
                    DAO.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            string hoten = txtHoten.Text;
            string quequan = txtQuequan.Text;
            if (quequan == "" || hoten == ""||manv=="")
            {
                MessageBox.Show("Dữ liệu thiếu");
                if (quequan == "") txtQuequan.Focus();
                else if (quequan == "") txtQuequan.Focus();
                else txtMaNV.Focus();
            }
            else
            {
                DAO.openConnection();
                string sql = "select MaNV from tblNhanvien";
                SqlDataReader rd = DAO.ExecuteReader(sql);
                while (rd.Read())
                    if(rd[0].ToString().Trim()==txtMaNV.Text.Trim())
                    {
                        MessageBox.Show("Dữ liệu trùng");
                        txtMaNV.Focus();
                        rd.Close();
                        return;
                    }
                rd.Close();
                sql = "insert into tblNhanvien values ('" + manv + "',N'" + hoten + "',N'" + quequan + "')";
                try
                {
                    DAO.ExecuteNonQuery(sql);
                    LoadDataToGridView();
                    DAO.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manv = txtMaNV.Text;
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==System.Windows.Forms.DialogResult.Yes)
            {
                string sql = "delete Manv from tblNhanvien where MaNV='" + manv + "'";
                try
                {
                    DAO.openConnection();
                    DAO.ExecuteNonQuery(sql);
                    LoadDataToGridView();
                    DAO.closeConnection();
                    ClearTextBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát chương trình?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
