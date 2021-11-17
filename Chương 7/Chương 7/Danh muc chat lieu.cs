using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chương_7
{
    public partial class frmDMChatlieu : Form
    {
        DataTable tblCL;
        public frmDMChatlieu()
        {
            InitializeComponent();
        }

        private void frmDMChatlieu_Load(object sender, EventArgs e)
        {
            txtMachatlieu.Enabled = false;
            //txtTenchatlieu.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dgChatlieu();

        }
        private void Load_dgChatlieu()
        {
            
            string sql;
            sql = "SELECT Machatlieu, Tenchatlieu FROM tblChatlieu";
            tblCL = Class.Functions.GetDataToTable(sql);
            dgChatlieu.DataSource = tblCL;
            dgChatlieu.Columns[0].HeaderText = "Mã chất liệu";
            dgChatlieu.Columns[1].HeaderText = "Tên chất liệu";
            dgChatlieu.Columns[0].Width = 100;
            dgChatlieu.Columns[1].Width = 300;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgChatlieu.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgChatlieu.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgChatlieu_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMachatlieu.Text = dgChatlieu.CurrentRow.Cells["machatlieu"].Value.ToString();
            txtTenchatlieu.Text = dgChatlieu.CurrentRow.Cells["tenchatlieu"].Value.ToString();
            btnBoqua.Enabled = true;
        }
        private void resetvalue()
        {
            txtTenchatlieu.Text = "";
            txtMachatlieu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetvalue();
            txtMachatlieu.Enabled = true;
            txtMachatlieu.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChatlieu WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_dgChatlieu();
                resetvalue();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCL.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenchatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchatlieu.Focus();
                return;
            }
            sql = "UPDATE tblChatlieu SET Tenchatlieu=N'" + txtTenchatlieu.Text.ToString() +"' WHERE Machatlieu=N'" + txtMachatlieu.Text + "'";
            Class.Functions.RunSqlDel(sql);
            Load_dgChatlieu();
            resetvalue();
            btnBoqua.Enabled = false;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMachatlieu.Text == "")
            {
                MessageBox.Show("Chua nhap ma chat lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachatlieu.Focus();
                return;
            }
            if (txtTenchatlieu.Text == "")
            {
                MessageBox.Show("Chua nhap ten chat lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenchatlieu.Focus();
                return;
            }
            string sql;
            //kiem tra co bi trung khoa khong
            sql = "select machatlieu from tblChatlieu where machatlieu=N'" + txtMachatlieu.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachatlieu.Focus();
                txtMachatlieu.Text = "";
                return;
            }
            sql = "INSERT INTO tblChatlieu(machatlieu,tenchatlieu) VALUES(N'" +txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
            Class.Functions.RunSqlDel(sql);
            Load_dgChatlieu();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMachatlieu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat khong ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void txtMachatlieu_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");
        }

        private void txtTenchatlieu_KeyUp(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");
        }
    }
}
