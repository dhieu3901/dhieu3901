using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _15_TranDuyTrungHieu_22A4040135
{
    public partial class frmDMSachtruyen : Form
    {
        DataTable tblHH;
        public frmDMSachtruyen()
        {
            InitializeComponent();
        }

        private void frmDMSachtruyen_Load(object sender, EventArgs e)
        {
            Class.ABC.Connect();
            txtmasach.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_dgDMSachtruyen();
            Class.ABC.FillCombo("SELECT MaNXB, TenNXB FROM tblNXB", cbomaNXB, "MaNXB", "TenNXB");
            cbomaNXB.SelectedIndex = -1;
            ResetValues();
        }
        
        private void Load_dgDMSachtruyen()
        {
            string sql;
            sql = "SELECT Masach, Tensach, MaNXB, soluong,giasach FROM tblSachTruyen ";
            tblHH = Class.ABC.GetDataToTable(sql);
            dgDMSachtruyen.DataSource = tblHH;
            dgDMSachtruyen.Columns[0].HeaderText = "Mã sách";
            dgDMSachtruyen.Columns[1].HeaderText = "Tên sách";
            dgDMSachtruyen.Columns[2].HeaderText = "NXB";
            dgDMSachtruyen.Columns[3].HeaderText = "Số lượng";
            dgDMSachtruyen.Columns[4].HeaderText = "Giá sách";
            dgDMSachtruyen.AllowUserToAddRows = false;
            dgDMSachtruyen.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtmasach.Text = "";
            txttensach.Text = "";
            cbomaNXB.Text = "";
            txtsoluong.Text = "";
            txtgiasach.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon dong khong", "THong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmasach.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasach.Focus();
                return;
            }
            if (txttensach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttensach.Focus();
                return;
            }
            if (cbomaNXB.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập NXB", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomaNXB.Focus();
                return;
            }
            if (txtgiasach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giá sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiasach.Focus();
                return;
            }
            if (txtsoluong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }

            sql = "SELECT Masach FROM tblSachTruyen WHERE Masach=N'" + txtmasach.Text.Trim() + "'";
            if (Class.ABC.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmasach.Focus();
                txtmasach.Text = "";
                return;
            }
            sql = "INSERT INTO tblSachTruyen(Masach,Tensach,MaNXB,Soluong,Giasach) VALUES(N'" + txtmasach.Text.Trim() +
                    "',N'" + txttensach.Text.Trim() + "',N'" + cbomaNXB.SelectedValue.ToString() + "'," + txtsoluong.Text.Trim() + "," + txtgiasach.Text + ")";
            Class.ABC.RunSql(sql);
            Load_dgDMSachtruyen();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtmasach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmasach.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtmasach.Enabled = true;
            txtmasach.Focus();
            txtsoluong.Enabled = true;
        }

        private void dgDMSachtruyen_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasach.Focus();
                return;
            }
            if (tblHH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmasach.Text = dgDMSachtruyen.CurrentRow.Cells["Masach"].Value.ToString();
            txttensach.Text = dgDMSachtruyen.CurrentRow.Cells["Tensach"].Value.ToString();
            ma = dgDMSachtruyen.CurrentRow.Cells["MaNXB"].Value.ToString();
            cbomaNXB.Text = Class.ABC.GetFieldValues("SELECT MaNXB FROM tblSachTruyen WHERE MaNXB = N'" + ma + "'");
            txtsoluong.Text = dgDMSachtruyen.CurrentRow.Cells["Soluong"].Value.ToString();
            txtgiasach.Text = dgDMSachtruyen.CurrentRow.Cells["Giasach"].Value.ToString();
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
    }
}
