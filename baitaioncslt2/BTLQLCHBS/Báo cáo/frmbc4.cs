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
    public partial class frmbc4 : Form
    {
        public frmbc4()
        {
            InitializeComponent();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
               this.Close();
           }
        }

        private void frmbc4ss_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            load_DataGridView();
            string sql;
            sql = "select manv, tennv from tblnhanvien";
            Class.Functions.FillCombo(sql, cbonv, "tennv", "manv");
            cbonv.SelectedIndex = -1;
            for (int i = 2021; i >= 2010; i--)
            {
                cbonam.Items.Add(i);
            }
            cbonam.SelectedIndex = 0;
            cbothang.Items.Add("Cả năm");
            for (int i = 1; i <= 12; i++)
            {
                cbothang.Items.Add(i);
            }
            cbothang.SelectedIndex = 0;

        }
        DataTable tblds;
        private void load_DataGridView()
        {
            string sql;
            sql = "select makhach,tenkhach, dienthoai, diachi from tblkhachhang where 1 = 0";
            tblds = Class.Functions.GetDatatoTable(sql);
            dtgv.DataSource = tblds;
            dtgv.Columns[0].HeaderText = "Mã khách hàng";
            dtgv.Columns[1].HeaderText = "Tên khách hàng";
            dtgv.Columns[2].HeaderText = "Điện thoại";
            dtgv.Columns[3].HeaderText = "Địa chỉ";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.AllowUserToAddRows = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cbonv_TextChanged(object sender, EventArgs e)
        {
            string sql;
            if (cbonv.Text == "")
            {
                txttnv.Text = "";
            }
            sql = "select tennv from tblnhanvien where manv = N'" + cbonv.Text + "'";
            txttnv.Text = Class.Functions.GetFieldValues(sql);
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            if (cbonv.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn nhân viên thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonv.Focus();
                return;
            }
            if (cbonam.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonv.Focus();
            }
            if (cbothang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonv.Focus();
                return;
            }
            string sql;
            switch (cbothang.Text)
            {
                case "Cả năm":
                    sql = "select makhach, tenkhach, dienthoai, diachi from tblkhachhang where  makhach not in (select makhach from tblhdban where month(ngayban) between 1 and 12)";
                    tblds = Class.Functions.GetDatatoTable(sql);
                    dtgv.DataSource = tblds;
                    break;
                default:
                    sql = "select makhach, tenkhach, dienthoai, diachi from tblkhachhang where  makhach not  in (select makhach from tblhdban where month(ngayban) = " + cbothang.Text + ")";
                    tblds = Class.Functions.GetDatatoTable(sql);
                    dtgv.DataSource = tblds;
                    break;
            }
        }
    }
}
