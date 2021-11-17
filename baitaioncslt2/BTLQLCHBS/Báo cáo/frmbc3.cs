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
    public partial class frmbc3 : Form
    {
        public frmbc3()
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

        private void frmbc3_Load(object sender, EventArgs e)
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
            for (int i = 1; i <= 4; i++)
            {
                cboquy.Items.Add(i);
            }
            cboquy.SelectedIndex = -1;

        }
        DataTable tblds;
        private void load_DataGridView()
        {
            string sql;
            sql = "select sohdban,tennv,ngayban, tenkhach, tongtien from tblhdban join tblnhanvien on tblhdban.manv = tblnhanvien.manv join tblkhachhang on tblhdban.makhach = tblkhachhang.makhach where 1 = 0";
            tblds = Class.Functions.GetDatatoTable(sql);
            dtgv.DataSource = tblds;
            dtgv.Columns[0].HeaderText = "Số HDB";
            dtgv.Columns[1].HeaderText = "Tên nhân viên";
            dtgv.Columns[2].HeaderText = "Ngày bán";
            dtgv.Columns[3].HeaderText = "Tên khách";
            dtgv.Columns[4].HeaderText = "Tổng tiền";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            if (cboquy.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn quý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbonv.Focus();
                return;
            }
            string sql;
            switch (cboquy.Text)
            {
                case "1":
                    sql = "select sohdban,tennv,ngayban, tenkhach, tongtien from tblhdban join tblnhanvien on tblhdban.manv = tblnhanvien.manv join tblkhachhang on tblhdban.makhach = tblkhachhang.makhach  where month(ngayban)  between 1 and 3";
                    tblds = Class.Functions.GetDatatoTable(sql);
                    dtgv.DataSource = tblds;
                    break;
                case "2":
                    sql = "select sohdban,tennv,ngayban, tenkhach, tongtien from tblhdban join tblnhanvien on tblhdban.manv = tblnhanvien.manv join tblkhachhang on tblhdban.makhach = tblkhachhang.makhach  where month(ngayban)  between 4 and 6";
                    tblds = Class.Functions.GetDatatoTable(sql);
                    dtgv.DataSource = tblds;
                    break;
                case "3":
                    sql = "select sohdban,tennv,ngayban, tenkhach, tongtien from tblhdban join tblnhanvien on tblhdban.manv = tblnhanvien.manv join tblkhachhang on tblhdban.makhach = tblkhachhang.makhach  where month(ngayban)  between 7 and 9";
                    tblds = Class.Functions.GetDatatoTable(sql);
                    dtgv.DataSource = tblds;
                    break;
                case "4":
                    sql = "select sohdban,tennv,ngayban, tenkhach, tongtien from tblhdban join tblnhanvien on tblhdban.manv = tblnhanvien.manv join tblkhachhang on tblhdban.makhach = tblkhachhang.makhach  where month(ngayban)  between 10 and 12";
                    tblds = Class.Functions.GetDatatoTable(sql);
                    dtgv.DataSource = tblds;
                    break;
                default:
                    break;
            }
        }
    }
}
