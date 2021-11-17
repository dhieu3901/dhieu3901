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

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from tblNhanvien";
            DataTable dataNhanVien = DAO.getDatatotable(sql);
            dataGridViewNhanVien.DataSource = dataNhanVien;
        }

        //Câu 3.4 Load
        private void Form1_Load(object sender, EventArgs e)
        {
            DAO.setupConnection();
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
        //Câu 3.4 Click
        private void DataGridView_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtManv.Text = dataGridViewNhanVien.CurrentRow.Cells["M aNV"].Value.ToString().Trim();
            txtHoten.Text = dataGridViewNhanVien.CurrentRow.Cells["Hoten"].Value.ToString().Trim();
            txtQuequan.Text = dataGridViewNhanVien.CurrentRow.Cells["Quequan"].Value.ToString().Trim();
            txtManv.Enabled = false;
        }
        //Câu 3.4 Thêm mới
        private void ClearTextBox()
        {
            if (txtManv.Enabled == false)
            {
                txtManv.Enabled = true;
                txtManv.Text = "";
            }
            else txtManv.Text = "";
            txtHoten.Text = "";
            txtQuequan.Text = "";
            txtManv.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        //Câu 3.4 Hủy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        //Câu 3.4 Lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string manhanvien = txtManv.Text;
            string tennhanvien = txtHoten.Text;
            string quenhanvien = txtQuequan.Text;
            if (manhanvien == "" || tennhanvien == "" || quenhanvien == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu");
                if (manhanvien == "") txtManv.Focus();
                else if (tennhanvien == "") txtHoten.Focus();
                else txtQuequan.Focus();
                return;
            }
            else
            {
                    DAO.openConnection();
                    string sql = "select MaNV from tblNhanVien";
                    SqlDataReader rd = DAO.ExecuteReader(sql);
                    while (rd.Read())
                        if (rd[0].ToString().Trim() == txtManv.Text.Trim())
                        {
                            MessageBox.Show("Mã nhân viên không hợp lệ");
                            txtManv.Focus();
                            rd.Close();
                            return;
                        }
                    rd.Close();
                    sql = "insert into tblNhanVien values('" + manhanvien + "',N'" + tennhanvien + "',N'" + quenhanvien + "')";
                try
                {
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

        //Câu 3.4 Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            string manhanvien = txtManv.Text;
            string hotennhanvien = txtHoten.Text;
            string quenhanvien = txtQuequan.Text;
            if (hotennhanvien == "" || quenhanvien == "")
            {
                MessageBox.Show("Dữ liệu không để trống");
                if (hotennhanvien == "") txtHoten.Focus();
                else txtQuequan.Focus();
                return;
            }
            else
            {
                string sql = "Update tblNhanVien"
                            + "set Hoten = '" + hotennhanvien + "',Quequan='" + quenhanvien + "'"
                            + "where MaNV='" + manhanvien + "'";
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
        //Câu 3.4 Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string manhanvien = txtManv.Text;
            string sql = "delete from tblNhanVien where MaNV='" + manhanvien + "'";
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên!?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == System.Windows.Forms.DialogResult.Yes)
                {
                    DAO.openConnection();
                    DAO.ExecuteNonQuery(sql);
                    LoadDataToGridView();
                    DAO.closeConnection();
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
            
        //Câu 3.4 Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Nofications", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
