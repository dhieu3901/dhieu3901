using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQLCHBS
{
    public partial class frmnhacc : Form
    {
        public frmnhacc()
        {
            InitializeComponent();
        }
        DataTable tblncc;
        private void frmnhacc_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            reset_values();
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            btnxoa.Enabled = true;
            load_dtgv();
            btnsua.Enabled = true;
            btndong.Enabled = false;    
        }
        private void load_dtgv()
        {
            string sql;
            sql = "Select mancc,tenncc,diachi,dienthoai from tblnhacungcap";
            tblncc = Class.Functions.GetDatatoTable(sql);
            dtgv.DataSource = tblncc;
            dtgv.Columns[0].HeaderText = "Mã NCC";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].HeaderText = "Tên NCC";
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].HeaderText = "Địa chỉ";
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].HeaderText = "SDT";
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.AllowUserToAddRows = false; 
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dtgv_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            txtdiachi.Enabled = true;
            txttenncc.Enabled = true;
            msksdt.Enabled = true;
            txtmancc.Text = dtgv.CurrentRow.Cells["mancc"].Value.ToString();
            txttenncc.Text = dtgv.CurrentRow.Cells["tenncc"].Value.ToString();
            txtdiachi.Text = dtgv.CurrentRow.Cells["diachi"].Value.ToString();
            msksdt.Text = dtgv.CurrentRow.Cells["dienthoai"].Value.ToString();
        }
        private void reset_values()
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            msksdt.Text = "";
            txtmancc.Enabled = false;
            txtdiachi.Enabled = false;
            txttenncc.Enabled = false;
            msksdt.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btnsua.Enabled = false;
            txtmancc.Enabled = true;
            reset_values();
            txtmancc.Enabled = true;
            txtdiachi.Enabled = true;
            txttenncc.Enabled = true;
            msksdt.Enabled = true;
            txtmancc.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(txtmancc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmancc.Focus();
                return;
            }
            string sql;
            sql = "select mancc from tblnhacungcap where mancc = N'" + txtmancc.Text + "'";
            if (Class.Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("Mã NCC bị trùng, vui lòng nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmancc.Text = "";
                txtmancc.Focus();
                return;
            }
            if(txttenncc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenncc.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            else if (MessageBox.Show("Thông tin đã được lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "insert into tblnhacungcap values(N'" + txtmancc.Text + "',N'" + txttenncc.Text + "',N'" + txtdiachi.Text + "','" + msksdt.Text + "')";
                Class.Functions.RunSql(sql);
                load_dtgv();
                btnluu.Enabled = false;
                btnthem.Enabled = true;
                btnboqua.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                reset_values();
            }
            

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (MessageBox.Show("Bạn có muốn xóa dòng này đi không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "delete tblnhacungcap where mancc = N'" + txtmancc.Text + "'";
                Class.Functions.RunSqlDel(sql);
                load_dtgv();
                reset_values();
                btnboqua.Enabled = true;
                MessageBox.Show("Thông tin đã được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblncc.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmancc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp nảo cả!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmancc.Focus();
                return;
            }
            if (txttenncc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttenncc.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhà cung cấp sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhà cung cấp sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            
            else if (MessageBox.Show("Thông tin đã được sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                string sql;
                sql = "UPDATE tblnhacungcap SET tenncc = N'" + txttenncc.Text.Trim().ToString() + "', diachi = N'" + txtdiachi.Text.Trim().ToString() + "', dienthoai = N'" + msksdt.Text.Trim().ToString() + "' where mancc = N'" + txtmancc.Text + "'";
                Class.Functions.RunSql(sql);
                load_dtgv();
                reset_values();
                btnsua.Enabled = true;
                btnboqua.Enabled = false;
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset_values();
            btnboqua.Enabled = false;
            btnxoa.Enabled = true;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}
