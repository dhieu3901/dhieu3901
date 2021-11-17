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
    public partial class frmTKHDNhap : Form
    {
        DataTable tblHDN;
        public frmTKHDNhap()
        {
            InitializeComponent();
        }

        private void frmTimHDNhap_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ResetValues();
            DataGridView.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtMaHDNhap.Focus();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHDNhap.Text == "") && (txtThang.Text == "") && (txtNam.Text == "") &&
               (txtManhanvien.Text == "") && (txtMancc.Text == "") &&
               (txtTongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yeu cau ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblhdnhap WHERE 1=1";
            if (txtMaHDNhap.Text != "")
                sql = sql + " AND sohdnhap Like N'%" + txtMaHDNhap.Text + "%'";
            if (txtThang.Text != "")
                sql = sql + " AND MONTH(ngaynhap) =" + txtThang.Text;
            if (txtNam.Text != "")
                sql = sql + " AND YEAR(ngaynhap) =" + txtNam.Text;
            if (txtManhanvien.Text != "")
                sql = sql + " AND manv Like N'%" + txtManhanvien.Text + "%'";
            if (txtMancc.Text != "")
                sql = sql + " AND mancc Like N'%" + txtMancc.Text + "%'";
            if (txtTongtien.Text != "")
                sql = sql + " AND tongtien <=" + txtTongtien.Text;
            tblHDN = Class.Functions.GetDatatoTable(sql);
            if (tblHDN.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblHDN.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblHDN;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Mã HĐN";
            DataGridView.Columns[1].HeaderText = "Mã nhân viên";
            DataGridView.Columns[2].HeaderText = "Ngày nhập";
            DataGridView.Columns[3].HeaderText = "Mã NCC";
            DataGridView.Columns[4].HeaderText = "Tổng tiền";
            DataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
        }

        private void txtTongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void DataGridView_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = DataGridView.CurrentRow.Cells["sohdnhap"].Value.ToString();
                frmhdnhap frm = new frmhdnhap();
                frm.txtmhd.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

    }
}
