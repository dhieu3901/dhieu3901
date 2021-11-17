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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        DataTable tblnv;
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtmnv.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            cbomcv.Enabled = false;
            txttnv.Enabled = false;
            txtdiachi.Enabled = false;
            msksdt.Enabled = false;
            Class.Functions.FillCombo("select macv,tencv from tblcongviec", cbomcv, "macv", "tencv");
            cbomcv.SelectedIndex = -1;
            load_dtgv();
        }
        private void load_dtgv()
        {
            string sql;
            sql = "select manv,tennv,diachi,dienthoai,macv from tblnhanvien";
            tblnv = Class.Functions.GetDatatoTable(sql);
            dtgv.DataSource = tblnv;
            dtgv.Columns[0].HeaderText = "Mã nhân viên";
            dtgv.Columns[1].HeaderText = "Tên nhân viên";
            dtgv.Columns[2].HeaderText = "Địa chỉ";
            dtgv.Columns[3].HeaderText = "Điện thoại";
            dtgv.Columns[4].HeaderText = "Mã CV";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.AllowUserToAddRows = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dtgv_Click(object sender, EventArgs e)
        {
            if(btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnboqua.Enabled = true;
            cbomcv.Enabled = true;
            txttnv.Enabled = true;
            txtdiachi.Enabled = true;
            msksdt.Enabled = true;
            txtmnv.Text = dtgv.CurrentRow.Cells["manv"].Value.ToString();
            txttnv.Text = dtgv.CurrentRow.Cells["tennv"].Value.ToString();
            string ma = dtgv.CurrentRow.Cells["macv"].Value.ToString();
            cbomcv.Text = Class.Functions.GetFieldValues("select tencv from tblcongviec where macv = N'" + ma + "'");
            txtdiachi.Text = dtgv.CurrentRow.Cells["diachi"].Value.ToString();
            msksdt.Text = dtgv.CurrentRow.Cells["dienthoai"].Value.ToString();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset_values();
            btnthem.Enabled = true;
            btndong.Enabled = true;
            txtmnv.Enabled = false;
            cbomcv.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            txtmnv.Enabled = false;
            cbomcv.Enabled = false;
            txttnv.Enabled = false;
            txtdiachi.Enabled = false;
            msksdt.Enabled = false;
        }
        private void reset_values()
        {
            txtmnv.Text = "";
            txttnv.Text = "";
            cbomcv.Text = "";
            msksdt.Text = "";
            txtdiachi.Text = "";


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            reset_values();
            txtmnv.Enabled = true;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btndong.Enabled = true;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            cbomcv.Enabled = true;
            txttnv.Enabled = true;
            txtdiachi.Enabled = true;
            msksdt.Enabled = true;
            txtmnv.Focus();

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            
            if(txtmnv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmnv.Focus();
                return;
            }
            sql = "select manv from tblnhanvien where manv = N'" + txtmnv.Text + "'";
            if (Class.Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("Mã nhân viên đã được sử dụng, vui lòng chọn mã khác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmnv.Focus();
                return;
            }
            if(txttnv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttnv.Focus();
                return;
            }
            if(cbomcv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã công việc cho nhân viên mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbomcv.Focus();
                return;
            }
            if(txtdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if(msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên mới!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            else if (MessageBox.Show("Thông tin đã được lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "insert into tblnhanvien values(N'" + txtmnv.Text + "', N'" + txttnv.Text + "', N'" + msksdt.Text + "', N'" + txtdiachi.Text + "', N'" + cbomcv.SelectedValue.ToString() + "')";
                Class.Functions.RunSql(sql);
                load_dtgv();
                btnthem.Enabled = true;
                btnboqua.Enabled = false;
                btnluu.Enabled = false;
                txtmnv.Enabled = false;
                txttnv.Enabled = false;
                txtdiachi.Enabled = false;
                msksdt.Enabled = false;
                cbomcv.Enabled = false;
                btnxoa.Enabled = true;
                btnsua.Enabled = true;
                reset_values();
            }        
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmnv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nảo cả!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmnv.Focus();
                return;
            }
            if (txttnv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttnv.Focus();
                return;
            }
            if (txtdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ nhân viên sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdiachi.Focus();
                return;
            }
            if (msksdt.Text == "(   )    -")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại nhân viên sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msksdt.Focus();
                return;
            }
            if(cbomcv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã công việc sửa đổi!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbomcv.Focus();
                return;
            }       
            else if (MessageBox.Show("Thông tin đã được sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                string sql;
                sql = "update tblnhanvien set tennv = N'" + txttnv.Text + "', dienthoai = N'" + msksdt.Text + "', diachi = N'" + txtdiachi.Text + "', macv = N'" + cbomcv.SelectedValue.ToString() + "' where manv = N'" + txtmnv.Text + "'";
                Class.Functions.RunSql(sql);
                load_dtgv();
                btnluu.Enabled = false;
                btnboqua.Enabled = false;
                btnthem.Enabled = true;
                cbomcv.Enabled = false;
                txttnv.Enabled = false;
                txtdiachi.Enabled = false;
                msksdt.Enabled = false;
                reset_values();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmnv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (MessageBox.Show("Bạn có muốn xóa dòng này đi không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Thông tin đã được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sql = "delete tblnhanvien where manv = N'" + txtmnv.Text + "'";
                Class.Functions.RunSqlDel(sql);
                load_dtgv();
                reset_values();
                txttnv.Enabled = false;
                txtdiachi.Enabled = false;
                msksdt.Enabled = false;
                cbomcv.Enabled = false;
                btnboqua.Enabled = false;
            }
            
        }
    }
}
