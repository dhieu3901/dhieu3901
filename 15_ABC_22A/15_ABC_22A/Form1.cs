using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace _15_ABC_22A
{
    public partial class frmDMHanghoa : Form
    {
        DataTable tblHH;
        public frmDMHanghoa()
        {
            InitializeComponent();
        }

        private void frmDMHanghoa_Load(object sender, EventArgs e)
        {
            txtAnh.Enabled = false;
            txtMahang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dgDMHanghoa();
            Class.ABC.FillCombo("SELECT Mamau, Tenmau FROM tblMausac", cboMamau, "Mamau", "Tenmau");
            cboMamau.SelectedIndex = -1;
            Load_dgDMHanghoa();
        }
        private void Load_dgDMHanghoa()
        {
            string sql;
            sql = "SELECT Mahang,Tenhang,Mamau,Soluong,Thoigianbaohanh FROM tblHanghoa";
            tblHH = Class.ABC.GetDataToTable(sql);
            dgDMHanghoa.DataSource = tblHH;
            dgDMHanghoa.Columns[0].HeaderText = "Mã hàng";
            dgDMHanghoa.Columns[1].HeaderText = "Tên hàng";
            dgDMHanghoa.Columns[2].HeaderText = "Mã màu";
            dgDMHanghoa.Columns[3].HeaderText = "Số lượng";
            dgDMHanghoa.Columns[4].HeaderText = "Thời gian bảo hành";
            dgDMHanghoa.Columns[0].Width = 70;
            dgDMHanghoa.Columns[1].Width = 120;
            dgDMHanghoa.Columns[2].Width = 70;
            dgDMHanghoa.Columns[3].Width = 70;
            dgDMHanghoa.Columns[4].Width = 120;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            dgDMHanghoa.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            dgDMHanghoa.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void resetvalue()
        {
            txtAnh.Text = "";
            txtMahang.Text = "";
            txtSoluong.Text = "";
            txtTenhang.Text = "";
            txtThoigianBaohanh.Text = "";
            cboMamau.Text = "";
            picAnh.Image = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            resetvalue();
            txtMahang.Enabled = true;
            txtMahang.Focus();
        }

        private void dgDMHanghoa_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMahang.Text = dgDMHanghoa.CurrentRow.Cells["Mahang"].Value.ToString();
            txtSoluong.Text = dgDMHanghoa.CurrentRow.Cells["Soluong"].Value.ToString();
            txtTenhang.Text = dgDMHanghoa.CurrentRow.Cells["Tenhang"].Value.ToString();
            txtThoigianBaohanh.Text = dgDMHanghoa.CurrentRow.Cells["Thoigianbaohanh"].Value.ToString();
            ma = dgDMHanghoa.CurrentRow.Cells["Mamau"].Value.ToString();
            cboMamau.Text = Class.ABC.GetFieldValues("SELECT Tenmau FROM tblMausac WHERE Mamau = N'" + ma + "'");
            txtAnh.Text = Class.ABC.GetFieldValues("SELECT Anh FROM tblHanghoa WHERE Mahang = N'" + txtMahang.Text + "'");
            picAnh.Image = Image.FromFile(txtAnh.Text);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMahang.Focus();
                return;
            }
            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenhang.Focus();
                return;
            }
            if (cboMamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMamau.Focus();
                return;
            }
            if (txtSoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }
            if (txtThoigianBaohanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("chưa nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThoigianBaohanh.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("chưa chọn ảnh minh họa cho hàng", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            string sql;
            //kiem tra co bi trung khoa khong
            sql = "select Mahang from tblHanghoa where Mahang=N'" + txtMahang.Text + "'";
            if (Class.ABC.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMahang.Focus();
                txtMahang.Text = "";
                return;
            }
            sql = "INSERT INTO tblHanghoa(Mahang,Tenhang,Mamau,Soluong,Thoigianbaohanh,Anh) VALUES(N'" + txtMahang.Text.Trim() + "',N'" + txtTenhang.Text.Trim() + "',N'" + cboMamau.SelectedValue.ToString() + "',N'" + txtSoluong.Text.Trim() + "',N'" + txtThoigianBaohanh.Text.Trim() + "',N'" + txtAnh.Text.Trim() + "')";
            Class.ABC.RunSqlDel(sql);
            Load_dgDMHanghoa();
            resetvalue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMahang.Enabled = false;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            resetvalue();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMahang.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHH.Rows.Count == 0)
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
                sql = "DELETE tblHanghoa WHERE Mahang=N'" + txtMahang.Text + "'";
                Class.ABC.RunSqlDel(sql);
                Load_dgDMHanghoa();
                resetvalue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenhang.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoluong.Focus();
                return;
            }
            if (txtThoigianBaohanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập thời gian bảo hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThoigianBaohanh.Focus();
                return;
            }
            if (cboMamau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã màu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMamau.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE tblHanghoa SET  Tenhang=N'" + txtTenhang.Text.Trim().ToString() +
                "',Mamau=N'" + cboMamau.SelectedValue.ToString() +
                "',Soluong=N'" + txtSoluong.Text.Trim().ToString() +
                "',Thoigianbaohanh=N'" + txtThoigianBaohanh.Text.Trim().ToString() +
                //"',Tenhang=N'" + txtTenhang.Text.Trim().ToString() +
                "',anh='" + txtAnh.Text +
                 "' WHERE Mahang=N'" + txtMahang.Text + "'";
            Class.ABC.RunSql(sql);
            Load_dgDMHanghoa();
            resetvalue();
            btnBoqua.Enabled = false;
        }
    }
}
