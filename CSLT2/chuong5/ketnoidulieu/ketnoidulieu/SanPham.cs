using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ketnoidulieu
{
    public partial class SanPham : Form
    {
        bool cmbCanChange = false;
        public SanPham()    
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT mahang, tenhang, machatlieu, soluong, dongia, anh from tblHang";
            DataTable tblH = DAO.getDatatoTable(sql);
            // cau hinh bang
            datagridviewHang.DataSource = tblH;
            datagridviewHang.Columns[0].HeaderText = "Mã hàng";
            datagridviewHang.Columns[1].HeaderText = "Tên hàng";
            datagridviewHang.Columns[2].HeaderText = "Chất liệu";
            datagridviewHang.Columns[3].HeaderText = "Số lượng";
            datagridviewHang.Columns[4].HeaderText = "Đơn giá";
            datagridviewHang.Columns[5].HeaderText = "Ảnh";
            datagridviewHang.Columns[0].Width = 80;
            datagridviewHang.Columns[1].Width = 140;
            datagridviewHang.Columns[2].Width = 80;
            datagridviewHang.Columns[3].Width = 100;
            datagridviewHang.Columns[4].Width = 100;
            datagridviewHang.Columns[5].Width = 100;
            datagridviewHang.AllowUserToAddRows = false;
            datagridviewHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            cmbCanChange = true;
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            cmbCanChange = false;
            DAO.setupConnection();
            try
            {
                DAO.openConnection();
                string sql;                
                txtMaHang.Enabled = false;
                btnLuu.Enabled = false;
                btnBoQua.Enabled = false;                
                sql = "SELECT Machatlieu,  Tenchatlieu from tblChatlieu";
                DAO.FillCombo(sql, cmbChatLieu, "Machatlieu", "Tenchatlieu");
                cmbChatLieu.SelectedIndex = -1;
                LoadDataGridView();
                DAO.closeConnection();
                cmbCanChange = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
           
            string machatlieu;
            string sql;
            if (btnThem.Enabled == false)
            {   
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (datagridviewHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try {
                DAO.openConnection();
                txtMaHang.Text = datagridviewHang.CurrentRow.Cells["mahang"].Value.ToString();
                txtTenHang.Text = datagridviewHang.CurrentRow.Cells["tenhang"].Value.ToString();
                txtSoLuong.Text = datagridviewHang.CurrentRow.Cells["soluong"].Value.ToString();
                txtGia.Text = datagridviewHang.CurrentRow.Cells["dongia"].Value.ToString();
                txtAnh.Text = datagridviewHang.CurrentRow.Cells["anh"].Value.ToString();
                machatlieu = datagridviewHang.CurrentRow.Cells["Machatlieu"].Value.ToString();
                sql = "SELECT tenchatlieu FROM tblChatlieu WHERE Machatlieu='" + machatlieu + "'";
                cmbChatLieu.Text = DAO.GetFieldValues(sql);             
                picAnh.Image = Image.FromFile(txtAnh.Text);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoQua.Enabled = true;
                DAO.closeConnection();
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }
           
        }

        private void cmbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCanChange)
            {
                try
                {
                    DAO.openConnection();
                    string ma = cmbChatLieu.SelectedValue.ToString();
                    string sql = "SELECT mahang, tenhang, machatlieu, soluong, dongia, anh from tblHang" +
                        " where machatlieu = '" + ma + "'";

                    DataTable mytable = DAO.getDatatoTable(sql);
                    datagridviewHang.DataSource = mytable;
                    DAO.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
                return;
        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }

        }

            private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHang.Text = "";
            txtMaHang.Enabled = true;
            txtAnh.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtTenHang.Text = "";
            btnLuu.Enabled = true;
            cmbCanChange = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // check du lieu ko dc trong
            if(txtMaHang.Text.Trim() == "")
            {
                MessageBox.Show("ko dc bo trong ma hang");
                txtMaHang.Focus();
                return;
            }
            if(txtTenHang.Text.Trim() == "")
            {
                MessageBox.Show("ko dc de trong ten hang");
                txtTenHang.Focus();
                return;
            }
            string sql_check_key = "select * from tblhang where mahang ='" + txtMaHang.Text.Trim() + "'";
            if(DAO.check_key_exits(sql_check_key) == true)
            {
                MessageBox.Show("ma hang da ton tai");
                txtMaHang.Focus();
                return;
            }
            /// tuong tu viet cho cac texbox con lai
            string machatlieu = cmbChatLieu.SelectedValue.ToString();
            string sql = "insert into tblhang (mahang, machatlieu, tenhang, anh, dongia, soluong) " +
                "values ('" + txtMaHang.Text.Trim() + "','" + machatlieu + "', N'" 
                + txtTenHang.Text.Trim() + "',N'" +
                txtAnh.Text.Trim() + "'," + txtGia.Text.Trim() + "," + txtSoLuong.Text.Trim() + ")";
            MessageBox.Show(sql);
            try
            {
                DAO.openConnection();
                DAO.excecuteQueury(sql);
                MessageBox.Show("cap nhat du lieu thanh cong");
                LoadDataGridView();
                DAO.closeConnection();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


      
    }
}
