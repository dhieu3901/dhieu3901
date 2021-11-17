using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace Chương_7
{
    public partial class frmDMKhachhang : Form
    {
        // Khai báo biến toàn cục
        DataTable tblKH;
        public frmDMKhachhang()
        {
            InitializeComponent();
        }

        private void frmDMKhachhang_Load(object sender, EventArgs e)
        {
            txtMakhach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dgDMKhachhang();
        }
        private void Load_dgDMKhachhang()
        {
            string sql;
            sql = "SELECT makhach, tenkhach, diachi, dienthoai FROM tblKhach";
            tblKH = Class.Functions.GetDataToTable(sql);
            dgDMKhachhang.DataSource = tblKH;
            dgDMKhachhang.Columns[0].HeaderText = "Mã khách";
            dgDMKhachhang.Columns[1].HeaderText = "Tên khách";
            dgDMKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgDMKhachhang.Columns[3].HeaderText = "Điện thoại";
            dgDMKhachhang.Columns[0].Width = 100;
            dgDMKhachhang.Columns[1].Width = 150;
            dgDMKhachhang.Columns[2].Width = 150;
            dgDMKhachhang.Columns[3].Width = 150;
            dgDMKhachhang.AllowUserToAddRows = false;
            dgDMKhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMakhach.Text = "";
            txtTenkhach.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMakhach.Enabled = true;
            txtMakhach.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMakhach.Focus();
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "SELECT makhach FROM tblKhach WHERE makhach=N'" + txtMakhach.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo",
 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhach.Focus();
                txtMakhach.Text = "";
                return;
            }
            sql = "INSERT INTO tblKhach(makhach,tenkhach,diachi,dienthoai) VALUES (N'" +
txtMakhach.Text.Trim() + "',N'" + txtTenkhach.Text.Trim() + "',N'" +
txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "')";
            Class.Functions.RunSql(sql);
            Load_dgDMKhachhang();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhach.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "UPDATE tblKhach SET  tenkhach=N'" + txtTenkhach.Text.Trim().ToString()
                  + "',diachi=N'" + txtDiachi.Text.Trim().ToString() + "',dienthoai='" +
                mskDienthoai.Text.ToString() + "' WHERE makhach=N'" + txtMakhach.Text + "'";
            Class.Functions.RunSql(sql);
            Load_dgDMKhachhang();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhach WHERE makhach=N'" + txtMakhach.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_dgDMKhachhang();
                ResetValues();
            }

        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMakhach.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void dgDMKhachhang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhach.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            txtMakhach.Text = dgDMKhachhang.CurrentRow.Cells["makhach"].Value.ToString();
            txtTenkhach.Text = dgDMKhachhang.CurrentRow.Cells["tenkhach"].Value.ToString();
            txtDiachi.Text = dgDMKhachhang.CurrentRow.Cells["diachi"].Value.ToString();
            mskDienthoai.Text = dgDMKhachhang.CurrentRow.Cells["dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
    }
}
