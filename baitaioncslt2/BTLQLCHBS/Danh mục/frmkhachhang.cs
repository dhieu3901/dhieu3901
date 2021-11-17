using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BTLQLCHBS
{
    public partial class frmkhachhang : Form
    {

        public frmkhachhang()
        {
            InitializeComponent();
        }
        DataTable tblKH;

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtmakhach.Enabled = true;
            txttenkhach.Enabled = false;
            txtdiachi.Enabled = false;
            mskdienthoai.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "select makhach, tenkhach, diachi,  dienthoai from tblkhachhang";
            tblKH = Class.Functions.GetDatatoTable(sql);
            dgkhachhang.DataSource = tblKH;
            dgkhachhang.DataSource = tblKH;
            dgkhachhang.Columns[0].HeaderText = "Mã khách";
            dgkhachhang.Columns[1].HeaderText = "Tên khách";
            dgkhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgkhachhang.Columns[3].HeaderText = "Điện thoại";
            dgkhachhang.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgkhachhang.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgkhachhang.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgkhachhang.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgkhachhang.AllowUserToAddRows = false;
            dgkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void dgkhachhang_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); txtmakhach.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmakhach.Text = dgkhachhang.CurrentRow.Cells["makhach"].Value.ToString();
            txttenkhach.Text = dgkhachhang.CurrentRow.Cells["tenkhach"].Value.ToString();
            txtdiachi.Text = dgkhachhang.CurrentRow.Cells["diachi"].Value.ToString();
            mskdienthoai.Text = dgkhachhang.CurrentRow.Cells["dienthoai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            txttenkhach.Enabled = true;
            txtdiachi.Enabled = true;
            mskdienthoai.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmakhach.Enabled = true;
            txttenkhach.Enabled = true;
            txtdiachi.Enabled = true;
            mskdienthoai.Enabled = true;
            txtmakhach.Focus();
        }
        private void ResetValues()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
            txtmakhach.Enabled = false;
            txttenkhach.Enabled = false;
            txtdiachi.Enabled = false;
            mskdienthoai.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải số điện thoại của khách hàng ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            sql = "SELECT makhach FROM tblkhachhang WHERE makhach=N'" + txtmakhach.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtmakhach.Focus();
                txtmakhach.Text = "";
                return;
            }
            else if (MessageBox.Show("Thông tin đã được lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "INSERT INTO tblkhachhang(makhach, tenkhach, diachi, dienthoai) VALUES(N'" + txtmakhach.Text.Trim() + "',N'" + txttenkhach.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + mskdienthoai.Text + "')";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnxoa.Enabled = true;
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnboqua.Enabled = false;
                btnluu.Enabled = false;
                txtmakhach.Enabled = false;
            }
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblkhachhang WHERE makhach=N'" + txtmakhach.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;
                MessageBox.Show("Thông tin đã được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskdienthoai.Text == "( ) -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskdienthoai.Focus();
                return;
            }
            else if (MessageBox.Show("Thông tin đã được sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "UPDATE tblkhachhang SET tenkhach=N'" + txttenkhach.Text.Trim().ToString() + "',diachi=N'" + txtdiachi.Text.Trim().ToString() + "',dienthoai='" + mskdienthoai.Text.ToString() + "' WHERE makhach=N'" + txtmakhach.Text + "'";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;
            }      
        }
    }
}
