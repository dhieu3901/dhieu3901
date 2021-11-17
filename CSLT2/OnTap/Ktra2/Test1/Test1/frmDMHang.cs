using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    public partial class frmDMHang : Form
    {
        bool cmbCanChange = false;
        public frmDMHang()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView()
        {
            string sql = "select * from tblHang";
            DataTable tblH = DAO.GetDataToTable(sql);
            dataGridView.DataSource = tblH;
            dataGridView.Columns[0].HeaderText = "Mã hàng";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].HeaderText = "Tên hàng";
            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[2].HeaderText = "Mã chất liệu";
            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[3].HeaderText = "Số lượng";
            dataGridView.Columns[3].Width = 80;
            dataGridView.Columns[4].HeaderText = "Đơn giá nhập";
            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[5].HeaderText = "Đơn giá bán";
            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[6].HeaderText = "Ảnh";
            dataGridView.Columns[6].Width = 100;
            dataGridView.Columns[7].HeaderText = "Ghi chú";
            dataGridView.Columns[7].Width = 150;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.AllowUserToAddRows = false;
            cmbCanChange = true;
        }

        private void frmDMHang_Load(object sender, EventArgs e)
        {
            cmbCanChange = false;
            DAO.SetUpConnection();
            try
            {
                DAO.OpenConnection();
                btnLuu.Enabled = false;
                txtMahang.Enabled = false;
                txtDongiaban.Enabled = false;
                txtDongianhap.Enabled = false;
                btnLuu.Enabled = false;
                string sql = "select Machatlieu, Tenchatlieu from tblChatlieu";
                DAO.FillCombo(sql, cboMachatlieu, "Machatlieu", "Tenchatlieu");
                cboMachatlieu.SelectedIndex = -1;
                LoadDataToGridView();
                DAO.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            string machatlieu;
            string sql;
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                DAO.OpenConnection();
                txtMahang.Text = dataGridView.CurrentRow.Cells["Mahang"].Value.ToString();
                txtTenhang.Text = dataGridView.CurrentRow.Cells["Tenhang"].Value.ToString();
                txtSoluong.Text = dataGridView.CurrentRow.Cells["Soluong"].Value.ToString();
                txtDongianhap.Text = dataGridView.CurrentRow.Cells["Dongianhap"].Value.ToString();
                txtDongiaban.Text = dataGridView.CurrentRow.Cells["Dongiaban"].Value.ToString();
                txtAnh.Text = dataGridView.CurrentRow.Cells["Anh"].Value.ToString();
                machatlieu = dataGridView.CurrentRow.Cells["Machatlieu"].Value.ToString();
                sql = "SELECT Tenchatlieu FROM tblChatlieu WHERE Machatlieu='" + machatlieu + "'";
                cboMachatlieu.Text = DAO.GetFieldValue(sql);
                picAnh.Image = Image.FromFile(txtAnh.Text);
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoqua.Enabled = true;
                DAO.CloseConnection();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

            }
        }

        private void cboMachatlieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCanChange)
            {
                try
                {
                    DAO.OpenConnection();
                    string ma = cboMachatlieu.SelectedValue.ToString();
                    string sql = "select * from tblHang where Machatlieu = '" + ma + "'";
                    DataTable tblCbo = DAO.GetDataToTable(sql);
                    dataGridView.DataSource = tblCbo;
                    DAO.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void ClearTextBox()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtSoluong.Text = "";
            txtGhichu.Text = "";
            txtDongianhap.Text = "";
            txtDongiaban.Text = "";
            txtAnh.Text = "";
            cmbCanChange = false;
        }
        private void btnOpen_Click(object sender, EventArgs e)
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
            ClearTextBox();
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMahang.Enabled = true;
            txtTenhang.Enabled = true;
            txtDongiaban.Enabled = true;
            txtDongianhap.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon xoa?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from tblHang where Mahang = '" + txtMahang.Text + "'";
                    DAO.OpenConnection();
                    DAO.ExecuteQuery(sql);
                    LoadDataToGridView();
                    DAO.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Khong duoc de trong Ma hang");
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Khong duoc de trong ten hang");
                txtTenhang.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Khong duoc de trong so luongg");
                txtSoluong.Focus();
                return;
            }
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Khong duoc de trong Anh");
                txtAnh.Focus();
                return;
            }
            if (txtDongiaban.Text == "")
            {
                MessageBox.Show("Khong duoc de trong don gia ban");
                txtDongiaban.Focus();
                return;
            }
            if (txtDongianhap.Text == "")
            {
                MessageBox.Show("Khong duoc de trong don gia nhap");
                txtDongianhap.Focus();
                return;
            }
            if (cboMachatlieu.Text == "")
            {
                MessageBox.Show("Hay chon chat lieu");
                cboMachatlieu.Focus();
                return;
            }
            try
            {
                string sql = "update tblHang set Tenhang=N'" + txtTenhang.Text + "'," +
                    "Soluong='" + txtSoluong.Text + "'," +
                    "Machatlieu='" + cboMachatlieu.SelectedValue.ToString() + "'," +
                    "Dongianhap='" + txtDongianhap.Text + "'," +
                    "Dongiaban='" + txtDongiaban.Text + "'," +
                    "Anh='" + txtAnh.Text + "'," +
                    "Ghichu=N'" + txtGhichu.Text + "'" +
                    "WHERE Mahang = '" + txtMahang.Text + "'";
                DAO.OpenConnection();
                DAO.ExecuteQuery(sql);
                LoadDataToGridView();
                DAO.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Khong duoc de trong Ma hang");
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text == "")
            {
                MessageBox.Show("Khong duoc de trong ten hang");
                txtTenhang.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Khong duoc de trong so luongg");
                txtSoluong.Focus();
                return;
            }
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Khong duoc de trong Anh");
                txtAnh.Focus();
                return;
            }
            if (txtDongiaban.Text == "")
            {
                MessageBox.Show("Khong duoc de trong don gia ban");
                txtDongiaban.Focus();
                return;
            }
            if (txtDongianhap.Text == "")
            {
                MessageBox.Show("Khong duoc de trong don gia nhap");
                txtDongianhap.Focus();
                return;
            }
            if (cboMachatlieu.Text == "")
            {
                MessageBox.Show("Hay chon chat lieu");
                cboMachatlieu.Focus();
                return;
            }
            string sqlCheck = "select * from tblHang where Mahang ='" + txtMahang.Text + "'";
            if (DAO.CheckKey(sqlCheck) == true)
            {
                MessageBox.Show("Du lieu trung!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            try
            {
                string machatlieu = cboMachatlieu.SelectedValue.ToString();
                string sql = "insert into tblHang (Mahang,Tenhang,Machatlieu,Soluong,Dongianhap,Dongiaban,Anh,Ghichu)" +
                    "values (N'" + txtMahang.Text + "',N'" + txtTenhang.Text + "',N'" + machatlieu + "',N'" + txtSoluong.Text + "'," +
                    "N'" + txtDongianhap.Text + "',N'" + txtDongiaban.Text + "',N'" + txtAnh.Text + "',N'" + txtGhichu.Text + "')";
                DAO.OpenConnection();
                DAO.ExecuteQuery(sql);
                LoadDataToGridView();
                DAO.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahang.Text == "") && (txtTenhang.Text == "") && (cboMachatlieu.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT* from tblHang WHERE 1 = 1";
            if (txtMahang.Text != "")
                sql += "AND Mahang LIKE N'%" + txtMahang.Text + "%'";
            if (txtTenhang.Text != "")
                sql += "AND Tenhang LIKE N'%" + txtTenhang.Text + "%'";
            if (cboMachatlieu.Text != "")
                sql += " AND Machatlieu LIKE '%" + cboMachatlieu.SelectedValue + "%'";
            DataTable tblH = DAO.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + " bản ghithoả mãn điều kiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView.DataSource = tblH;
            ClearTextBox();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblHang";
            DataTable tblH = DAO.GetDataToTable(sql);
            dataGridView.DataSource = tblH;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon dong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
