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
    public partial class frmNXB : Form
    {
        DataTable tblnxb;
        public frmNXB()
        {
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtmanxb.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            Load_DataGridView();
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT manxb, tennxb, diachi, dienthoai FROM tblnxb";
            tblnxb = Class.Functions.GetDatatoTable(sql);
            dgnxb.DataSource = tblnxb;
            dgnxb.Columns[0].HeaderText = "Mã nhà xuất bản";
            dgnxb.Columns[1].HeaderText = "Tên nhà xuất bản";
            dgnxb.Columns[2].HeaderText = "Địa chỉ";
            dgnxb.Columns[3].HeaderText = "Điện thoại";
            dgnxb.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgnxb.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgnxb.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgnxb.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgnxb.AllowUserToAddRows = false;
            dgnxb.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtdiachi.Enabled = true;
            txttennxb.Enabled = true;
            mskdienthoai.Enabled = true;
            txtmanxb.Enabled = true;
            txtmanxb.Focus();
        }
        private void ResetValues()
        {
            txtmanxb.Text = "";
            txttennxb.Text = "";
            txtdiachi.Text = "";
            mskdienthoai.Text = "";
            txtmanxb.Enabled = false;
            txtdiachi.Enabled = false;
            txttennxb.Enabled = false;
            mskdienthoai.Enabled = false;

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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            this.Close();
        }

        private void dgnxb_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanxb.Focus();
                return;
            }
            if (tblnxb.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanxb.Text = dgnxb.CurrentRow.Cells["manxb"].Value.ToString();
            txttennxb.Text = dgnxb.CurrentRow.Cells["tennxb"].Value.ToString();
            txtdiachi.Text = dgnxb.CurrentRow.Cells["diachi"].Value.ToString();
            mskdienthoai.Text = dgnxb.CurrentRow.Cells["dienthoai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            txtdiachi.Enabled = true;
            txttennxb.Enabled = true;
            mskdienthoai.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnxb.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanxb.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblnxb WHERE manxb=N'" + txtmanxb.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
                MessageBox.Show("Thông tin đã được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnboqua.Enabled = false;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmanxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanxb.Focus();
                return;
            }
            if (txttennxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennxb.Focus();
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
            sql = "SELECT manxb FROM tblnxb WHERE manxb=N'" + txtmanxb.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã nhà xuất bản này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanxb.Focus();
                txtmanxb.Text = "";
                return;
            }
            else if (MessageBox.Show("Thông tin đã được lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "INSERT INTO tblnxb(manxb, tennxb, diachi, dienthoai) VALUES(N'" + txtmanxb.Text.Trim() + "',N'" + txttennxb.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + mskdienthoai.Text + "')";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnxoa.Enabled = true;
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnboqua.Enabled = false;
                btnluu.Enabled = false;
                txtmanxb.Enabled = false;
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnxb.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanxb.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennxb.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennxb.Focus();
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
                sql = "UPDATE tblnxb SET tennxb=N'" + txttennxb.Text.Trim().ToString() + "',diachi=N'" + txtdiachi.Text.Trim().ToString() + "',dienthoai='" + mskdienthoai.Text.ToString() + "' WHERE manxb=N'" + txtmanxb.Text + "'";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;
            }
            
        }
    }
}
