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
    public partial class frmtkkhach : Form
    {
        DataTable tbltkk;
        public frmtkkhach()
        {
            InitializeComponent();
        }

        private void frmtkkhach_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ResetValues();
            dgtkkhach.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmakhach.Focus();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmakhach.Text == "") && (txttenkhach.Text == "") && (txtdiachi.Text == "") && (txtdienthoai.Text == ""))

            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblkhachhang WHERE 1=1";
            if (txtmakhach.Text != "")
                sql = sql + " AND makhach Like N'%" + txtmakhach.Text + "%'";
            if (txttenkhach.Text != "")
                sql = sql + " AND tenkhach Like N'%" + txttenkhach.Text + "%'";
            if (txtdiachi.Text != "")
                sql = sql + " AND diachi Like N'%" + txtdiachi.Text + "%'";
            if (txtdienthoai.Text != "")
                sql = sql + " AND dienthoai Like N'%" + txtdienthoai.Text + "%'";
            tbltkk = Class.Functions.GetDatatoTable(sql);
            if (tbltkk.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tbltkk.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgtkkhach.DataSource = tbltkk;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dgtkkhach.Columns[0].HeaderText = "Mã khách";
            dgtkkhach.Columns[1].HeaderText = "Tên khách";
            dgtkkhach.Columns[2].HeaderText = "Số điện thoại";
            dgtkkhach.Columns[3].HeaderText = "Địa chỉ";
            dgtkkhach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtkkhach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtkkhach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtkkhach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtkkhach.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtkkhach.AllowUserToAddRows = false;
            dgtkkhach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgtkkhach.DataSource = null;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }
    }
}
