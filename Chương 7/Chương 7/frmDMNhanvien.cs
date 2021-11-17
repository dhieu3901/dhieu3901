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
    public partial class frmDMNhanvien : Form
    {
        DataTable tblNV;
        public frmDMNhanvien()
        {
            InitializeComponent();
        }

        private void frmDMNhanvien_Load(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dgNhanvien();
        }
        private void Load_dgNhanvien()
        {
            string sql;
            sql = "SELECT manhanvien, tennhanvien, gioitinh, diachi, dienthoai, ngaysinh FROM tblNhanvien";
            tblNV = Class.Functions.GetDataToTable(sql);
            dgNhanvien.DataSource = tblNV;
            dgNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgNhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgNhanvien.Columns[2].HeaderText = "Giới tính";
            dgNhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgNhanvien.Columns[4].HeaderText = "Điện thoại";
            dgNhanvien.Columns[5].HeaderText = "Ngày sinh";
            dgNhanvien.Columns[0].Width = 100;
            dgNhanvien.Columns[1].Width = 150;
            dgNhanvien.Columns[2].Width = 100;
            dgNhanvien.Columns[3].Width = 150;
            dgNhanvien.Columns[4].Width = 100;
            dgNhanvien.Columns[5].Width = 100;
            dgNhanvien.AllowUserToAddRows = false;
            dgNhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgNhanvien_Click(object sender, EventArgs e)
        {
            {
                if (btnThem.Enabled == false)
                {
                    MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtManhanvien.Focus();
                    return;
                }
                if (tblNV.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                txtManhanvien.Text = dgNhanvien.CurrentRow.Cells["manhanvien"].Value.ToString();
                txtTennhanvien.Text = dgNhanvien.CurrentRow.Cells["tennhanvien"].Value.ToString();
                if (dgNhanvien.CurrentRow.Cells["gioitinh"].Value.ToString() == "Nam")
                    chkGioitinh.Checked = true;
                else
                    chkGioitinh.Checked = false;
                txtDiachi.Text = dgNhanvien.CurrentRow.Cells["diachi"].Value.ToString();
                mskDienthoai.Text = dgNhanvien.CurrentRow.Cells["dienthoai"].Value.ToString();
                mskNgaysinh.Text = dgNhanvien.CurrentRow.Cells["ngaysinh"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnBoqua.Enabled = true;
            }
        }
        private void ResetValues()
        {
            txtManhanvien.Text = "";
            txtTennhanvien.Text = "";
            chkGioitinh.Checked = false;
            txtDiachi.Text = "";
            mskNgaysinh.Text = "";
            mskDienthoai.Text = ""; 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtManhanvien.Enabled = true;
            txtManhanvien.Focus();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValues();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
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
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Class.Functions.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE tblNhanvien SET  " +
                    "tennhanvien=N'" + txtTennhanvien.Text.Trim().ToString() + "'," +
                    "diachi=N'" + txtDiachi.Text.Trim().ToString() +"'," +
                    "dienthoai='" + mskDienthoai.Text.ToString() + "'," +
                    "gioitinh=N'" + gt +"'" +"," +
                    "ngaysinh='" + Class.Functions.ConvertDateTime(mskNgaysinh.Text) +
                    "' WHERE manhanvien=N'" + txtManhanvien.Text + "'";
            Class.Functions.RunSqlDel(sql);
            Load_dgNhanvien();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtManhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblNhanvien WHERE manhanvien=N'" + txtManhanvien.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_dgNhanvien();
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
            txtManhanvien.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtManhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                return;
            }
            if (txtTennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTennhanvien.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     ")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Class.Functions.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT manhanvien FROM tblNhanvien WHERE manhanvien=N'" + txtManhanvien.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManhanvien.Focus();
                txtManhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO tblNhanvien(manhanvien,tennhanvien,gioitinh,diachi,dienthoai,ngaysinh) VALUES(N'" + txtManhanvien.Text.Trim() + "', N'" + txtTennhanvien.Text.Trim() + "', N'" + gt + "', N'" + txtDiachi.Text.Trim() + "', '" + mskDienthoai.Text + "', '" + Class.Functions.ConvertDateTime(mskNgaysinh.Text) + "')";
            Class.Functions.RunSqlDel(sql);
            Load_dgNhanvien();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtManhanvien.Enabled = false;
        }
    }
}
