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
    public partial class frmtksach : Form
    {
        DataTable tbltks;

        public frmtksach()
        {
            InitializeComponent();
        }

        private void frmtksach_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            ResetValues();
            dgtksach.DataSource = null;
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmasach.Focus();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmasach.Text == "") && (txttensach.Text == "") && (txtmaloai.Text == "") && (txtsoluong.Text == "") && (txtgiaban.Text == "") && (txtmalv.Text == "") && (txtmatg.Text == "") && (txtmanxb.Text == "") && (txtmann.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM tblkhosach WHERE 1=1";
            if (txtmasach.Text != "") 
                sql = sql + " AND masach Like N'%" + txtmasach.Text + "%'";
            if (txttensach.Text != "") 
                sql = sql + " AND tensach Like N'%" + txttensach.Text + "%'";
            if (txtmaloai.Text != "") 
                sql = sql + " AND maloaisach Like N'%" + txtmaloai.Text + "%'";
            if (txtsoluong.Text != "") 
                sql = sql + " AND soluong Like N'%" + txtsoluong.Text + "%'";
            if (txtgiaban.Text != "") 
                sql = sql + " AND dongiaban Like N'%" + txtgiaban.Text + "%'";
            if (txtmalv.Text != "") 
                sql = sql + " AND malinhvuc Like N'%" + txtmalv.Text + "%'";
            if (txtmanxb.Text != "") 
                sql = sql + " AND manxb Like N'%" + txtmanxb.Text + "%'";
            if (txtmatg.Text != "") 
                sql = sql + " AND matg Like N'%" + txtmatg.Text + "%'";
            if (txtmann.Text != "") 
                sql = sql + " AND mangonngu Like N'%" + txtmann.Text + "%'";
            tbltks = Class.Functions.GetDatatoTable(sql);
            if (tbltks.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tbltks.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgtksach.DataSource = tbltks;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            dgtksach.Columns[0].HeaderText = "Mã Sách";
            dgtksach.Columns[1].HeaderText = "Tên Sách";
            dgtksach.Columns[2].HeaderText = "Số lượng";
            dgtksach.Columns[3].HeaderText = "Đơn giá bán ";
            dgtksach.Columns[4].HeaderText = "Mã loại Sách ";
            dgtksach.Columns[5].HeaderText = "Mã tác giả ";
            dgtksach.Columns[6].HeaderText = "Mã NXB ";
            dgtksach.Columns[7].HeaderText = "Mã lĩnh vực ";
            dgtksach.Columns[8].HeaderText = "Mã ngôn ngữ ";
            dgtksach.Columns[9].HeaderText = "Ảnh ";
            dgtksach.Columns[10].HeaderText = "Số trang ";
            dgtksach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgtksach.AllowUserToAddRows = false;
            dgtksach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            this.Close();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgtksach.DataSource = null;
        }


    }
}
