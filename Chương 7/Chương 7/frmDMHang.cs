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
    public partial class frmDMHang : Form
    {
        DataTable tblH;
        public frmDMHang()
        {
            InitializeComponent();
        }

        private void frmDMHang_Load(object sender, EventArgs e)
        {
            txtMahang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dgDMHanghoa();
            Class.Functions.FillCombo("SELECT machatlieu, tenchatlieu FROM tblChatlieu",cboMachatlieu, "machatlieu", "tenchatlieu");
            cboMachatlieu.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_dgDMHanghoa()
        {
            string sql;
            sql = "SELECT mahang, tenhang, machatlieu, soluong, dongianhap, dongiaban FROM tblHang";
            tblH = Class.Functions.GetDataToTable(sql);
            dgDMHanghoa.DataSource = tblH;
            dgDMHanghoa.Columns[0].HeaderText = "Mã hàng";
            dgDMHanghoa.Columns[1].HeaderText = "Tên hàng";
            dgDMHanghoa.Columns[2].HeaderText = "Chất liệu";
            dgDMHanghoa.Columns[3].HeaderText = "Số lượng";
            dgDMHanghoa.Columns[4].HeaderText = "Đơn giá nhập";
            dgDMHanghoa.Columns[5].HeaderText = "Đơn giá bán";
            dgDMHanghoa.Columns[0].Width = 80;
            dgDMHanghoa.Columns[1].Width = 140;
            dgDMHanghoa.Columns[2].Width = 80;
            dgDMHanghoa.Columns[3].Width = 80;
            dgDMHanghoa.Columns[4].Width = 100;
            dgDMHanghoa.Columns[5].Width = 100;
            dgDMHanghoa.AllowUserToAddRows = false;
            dgDMHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            cboMachatlieu.Text = "";
            txtSoluong.Text = "0";
            txtDongianhap.Text = "0";
            txtDongiaban.Text = "0";
            txtSoluong.Enabled = true;
            txtDongianhap.Enabled = true;
            txtDongiaban.Enabled = true;
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhichu.Text = "";
        }

        private void dgDMHanghoa_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            txtMahang.Text = dgDMHanghoa.CurrentRow.Cells["mahang"].Value.ToString();
            txtTenhang.Text = dgDMHanghoa.CurrentRow.Cells["tenhang"].Value.ToString();
            ma = dgDMHanghoa.CurrentRow.Cells["machatlieu"].Value.ToString();
            cboMachatlieu.Text = Class.Functions.GetFieldValues("SELECT tenchatlieu FROM tblChatlieu WHERE machatlieu = N'" + ma + "'");

            txtSoluong.Text = dgDMHanghoa.CurrentRow.Cells["soluong"].Value.ToString();
            txtDongianhap.Text = dgDMHanghoa.CurrentRow.Cells["dongianhap"].Value.ToString();
            txtDongiaban.Text = dgDMHanghoa.CurrentRow.Cells["dongiaban"].Value.ToString();
            txtAnh.Text = Class.Functions.GetFieldValues("SELECT anh FROM tblHang WHERE mahang = N'" + txtMahang.Text + "'");
            picAnh.Image = Image.FromFile(txtAnh.Text);
            txtGhichu.Text = Class.Functions.GetFieldValues("SELECT ghichu FROM tblHang WHERE mahang = N'" + txtMahang.Text + "'");
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMahang.Enabled = true;
            txtMahang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK,
 MessageBoxIcon.Warning);
                txtTenhang.Focus();
                return;
            }
            if (cboMachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachatlieu.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            sql = "SELECT mahang FROM tblHang WHERE mahang=N'" + txtMahang.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMahang.Focus();
                txtMahang.Text = "";
                return;
            }
            sql = "INSERT INTO tblHang(mahang,tenhang,machatlieu,soluong,dongianhap,dongiaban,anh,ghichu) VALUES(N'" + txtMahang.Text.Trim() +
                    "',N'" + txtTenhang.Text.Trim() + "',N'" + cboMachatlieu.SelectedValue.ToString() + "'," + txtSoluong.Text.Trim() +
"," + txtDongianhap.Text + "," + txtDongiaban.Text +
              ",'" + txtAnh.Text + "',N'" + txtGhichu.Text.Trim() + "')";
            Class.Functions.RunSql(sql);
            Load_dgDMHanghoa();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMahang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Warning);
                txtTenhang.Focus();
                return;
            }
            if (cboMachatlieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachatlieu.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE tblHang SET  tenhang=N'" + txtTenhang.Text.Trim().ToString() +
                "',machatlieu=N'" + cboMachatlieu.SelectedValue.ToString() +
                "',soluong=N'" + txtSoluong.Text.Trim().ToString() +
                "',dongiaban=N'" + txtDongiaban.Text.Trim().ToString() +
                "',dongianhap=N'" + txtDongianhap.Text.Trim().ToString() +
                "',anh='" + txtAnh.Text +
                "',ghichu=N'" + txtGhichu.Text + "' WHERE mahang=N'" + txtMahang.Text + "'";
            Class.Functions.RunSql(sql);
            Load_dgDMHanghoa();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblHang WHERE mahang=N'" + txtMahang.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_dgDMHanghoa();
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
            txtMahang.Enabled = false;

        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMahang.Text == "") && (txtTenhang.Text == "") && (cboMachatlieu.Text ==
""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblHang WHERE 1=1";
            if (txtMahang.Text != "")
                sql = sql + " AND mahang Like N'%" + txtMahang.Text + "%'";
            if (txtTenhang.Text != "")
                sql = sql + " AND tenhang Like N'%" + txtTenhang.Text + "%'";
            if (cboMachatlieu.Text != "")
                sql = sql + " AND machatlieu Like N'%" + cboMachatlieu.SelectedValue + "%'";
            tblH = Class.Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblH.Rows.Count + " bản ghi thỏa mãn điều kiện!!!",
"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            dgDMHanghoa.DataSource = tblH;
            ResetValues();

        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT mahang, tenhang, machatlieu, soluong, dongianhap, dongiaban, anh,ghichu FROM tblHang";
            tblH = Class.Functions.GetDataToTable(sql);
            dgDMHanghoa.DataSource = tblH;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
