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
    public partial class frmtacgia : Form
    {
        DataTable tbltg;
        public frmtacgia()
        {
            InitializeComponent();
        }

        private void frmtacgia_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtmatg.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            ResetValues();
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT matg, tentg, gioitinh, ngaysinh,diachi FROM tbltacgia";
            tbltg = Class.Functions.GetDatatoTable(sql);
            dgtacgia.DataSource = tbltg;
            dgtacgia.Columns[0].HeaderText = "Mã tác giả ";
            dgtacgia.Columns[1].HeaderText = "Tên tác giả";
            dgtacgia.Columns[2].HeaderText = "Giới tính ";
            dgtacgia.Columns[3].HeaderText = "Ngày sinh";
            dgtacgia.Columns[4].HeaderText =  "Địa chỉ";
            dgtacgia.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtacgia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtacgia.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtacgia.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtacgia.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtacgia.AllowUserToAddRows = false;
            dgtacgia.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgtacgia_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmatg.Focus();
                return;
            }
            if (tbltg.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmatg.Text = dgtacgia.CurrentRow.Cells["matg"].Value.ToString();
            txttentg.Text = dgtacgia.CurrentRow.Cells["tentg"].Value.ToString();
            if (dgtacgia.CurrentRow.Cells["gioitinh"].Value.ToString() == "Nam")
                chknam.Checked = true;
            else
                chknam.Checked = false;
            txtdiachi.Text = dgtacgia.CurrentRow.Cells["diachi"].Value.ToString();
            mskngaysinh.Text = dgtacgia.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txttentg.Enabled = true;
            txtdiachi.Enabled = true;
            mskngaysinh.Enabled = true;
            chknam.Enabled = true;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmatg.Enabled = true;
            txttentg.Enabled = true;
            txtdiachi.Enabled = true;
            mskngaysinh.Enabled = true;
            chknam.Enabled = true;
            txtmatg.Focus();
        }
        private void ResetValues()
        {
            txtmatg.Text = "";
            txttentg.Text = "";
            chknam.Checked = false;
            txtdiachi.Text = "";
            mskngaysinh.Text = "";
            txttentg.Enabled = false;
            txtdiachi.Enabled = false;
            mskngaysinh.Enabled = false;
            chknam.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtmatg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmatg.Focus();
                return;
            }
            if (txttentg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentg.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mskngaysinh.Text == " / /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            if (chknam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT matg FROM tbltacgia WHERE matg = N'" + txtmatg.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã tác giả này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); txtmatg.Focus();
                txtmatg.Text = "";
                return;
            }
            else if (MessageBox.Show("Thông tin đã được lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "INSERT INTO tbltacgia(matg, tentg, gioitinh, diachi, ngaysinh) VALUES(N'" + txtmatg.Text.Trim() + "', N'" + txttentg.Text.Trim() + "',N'" + gt + "',N'" + txtdiachi.Text.Trim() + "','" + Class.Functions.ConvertDateTime(mskngaysinh.Text) + "')";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnxoa.Enabled = true;
                btnthem.Enabled = true;
                btnsua.Enabled = true;
                btnboqua.Enabled = false;
                btnluu.Enabled = false;
                txtmatg.Enabled = false;
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tbltg.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmatg.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttentg.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttentg.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }


            if (mskngaysinh.Text == " / /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskngaysinh.Text = "";
                mskngaysinh.Focus();
                return;
            }
            if (chknam.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            if (MessageBox.Show("Thông tin đã được sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "UPDATE tbltacgia SET tentg=N'" + txttentg.Text.Trim().ToString() + "',diachi=N'" + txtdiachi.Text.Trim().ToString() + "',gioitinh=N'" + gt + "',ngaysinh='" + Class.Functions.ConvertDateTime(mskngaysinh.Text) + "' WHERE matg=N'" + txtmatg.Text + "'";
                Class.Functions.RunSql(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;
            }        
        }



        private void btnboqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnboqua.Enabled = false;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmatg.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbltg.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmatg.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tbltacgia WHERE matg=N'" + txtmatg.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
                btnboqua.Enabled = false;
                MessageBox.Show("Thông tin đã được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
