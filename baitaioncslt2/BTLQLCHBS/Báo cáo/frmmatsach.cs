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
    public partial class frmmatsach : Form
    {
        public frmmatsach()
        {
            InitializeComponent();
        }

        DataTable tblms;

        private void frmmatsach_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            txtmamat.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
            string sql;
            sql = "select masach, tensach from tblkhosach";
            Class.Functions.FillCombo(sql, cbomasach, "masach", "tensach");
            cbomasach.SelectedIndex = -1;
            load_dtgv();
        }
        private void load_dtgv()
        {
            string sql;
            sql = "select malanmat, tblmatsach.masach, tensach, ngaymat, soluongmat  from tblmatsach join tblkhosach on tblmatsach.masach = tblkhosach.masach";
            tblms = Class.Functions.GetDatatoTable(sql);
            dtgv.Columns[0].HeaderText = "Mã lần mất";
            dtgv.Columns[1].HeaderText = "Mã sách";
            dtgv.Columns[2].HeaderText = "Tên sách";
            dtgv.Columns[3].HeaderText = "Ngày mất";
            dtgv.Columns[4].HeaderText = "Số lượng mất";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.AllowUserToAddRows = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void reset_data()
        {
            txtmamat.Text = "";
            txtsoluong.Text = "";
            mskngaymat.Text = "";
            cbomasach.Text = "";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {

            txtmamat.Enabled = true;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            btnboqua.Enabled = true;
            reset_data();
        }

        private void dtgv_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở chế độ thêm mới dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblms.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnsua.Enabled = true;
            btnhuy.Enabled = true;
            btnboqua.Enabled = true;
            txtmamat.Text = dtgv.CurrentRow.Cells["malanmat"].Value.ToString();
            mskngaymat.Text = dtgv.CurrentRow.Cells["ngaymat"].Value.ToString();
            string masach = dtgv.CurrentRow.Cells["masach"].Value.ToString();
            cbomasach.Text = Class.Functions.GetFieldValues("select tensach from tblkhosach where masach = N'" + masach + "'");
            txtsoluong.Text = dtgv.CurrentRow.Cells["soluongmat"].Value.ToString();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            reset_data();
            btnthem.Enabled = true;
            btndong.Enabled = true;
            txtmamat.Enabled = false;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmamat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã lần mất!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamat.Text = "";
                txtmamat.Focus();
                return;
            }
            if (cbomasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sách!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomasach.Focus();
                return;

            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sách mất!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (mskngaymat.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn chưa nhập ngày mất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskngaymat.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaymat.Text))
            {
                MessageBox.Show("Nhập lại ngày mất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskngaymat.Text = "";
                mskngaymat.Focus();
                return;
            }
            string sql;
            sql = "select malanmat from tblmatsach where malanmat = N'" + txtmamat.Text + "'";
            if (Class.Functions.CheckKey(sql) == true)
            {
                MessageBox.Show("");
                txtmamat.Focus();
                return;
            }
            sql = "insert into tblmatsach values(N'" + txtmamat.Text + "', N'" + cbomasach.SelectedValue.ToString() + "', '" + Class.Functions.ConvertDateTime(mskngaymat.Text) + "', " + txtsoluong.Text + ")";
            Class.Functions.RunSql(sql);
            double sltk, slcon;
            sql = "select soluong from tblkhosach where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
            sltk = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            slcon = sltk - Convert.ToDouble(txtsoluong.Text);
            sql = "update tblkhosach set soluong = " + slcon + " where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
            Class.Functions.RunSql(sql);
            load_dtgv();
            reset_data();
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnboqua.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmamat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã lần mất!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmamat.Text = "";
                txtmamat.Focus();
                return;
            }
            if (cbomasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sách!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomasach.Focus();
                return;

            }
            if (txtsoluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng sách mất!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Focus();
                return;
            }
            if (mskngaymat.Text == "  /  /    ")
            {
                MessageBox.Show("Bạn chưa nhập ngày mất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskngaymat.Focus();
                return;
            }
            if (!Class.Functions.Isdate(mskngaymat.Text))
            {
                MessageBox.Show("Nhập lại ngày mất", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mskngaymat.Text = "";
                mskngaymat.Focus();
                return;
            }
            double slmatcu, slmatmoi, sltrongkho, slchenhlech, slcon;
            string sql, masach2;
            sql = "select masach from tblmatsach where malanmat = N'" + txtmamat.Text + "'";
            masach2 = Class.Functions.GetFieldValues(sql);
            sql = "select soluongmat from tblmatsach where malanmat = N'" + txtmamat.Text + "'";
            slmatcu = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            slmatmoi = Convert.ToDouble(txtsoluong.Text);
            sql = "select soluong from tblkhosach where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
            sltrongkho = Convert.ToInt32(Class.Functions.GetFieldValues(sql));
            if (cbomasach.SelectedValue.ToString() == masach2)
            {
                if (slmatcu > slmatmoi)
                {
                    slchenhlech = slmatcu - slmatmoi;
                    sltrongkho = sltrongkho + slchenhlech;
                }
                else if (slmatmoi > slmatcu)
                {
                    slchenhlech = slmatmoi - slmatcu;
                    sltrongkho = sltrongkho - slchenhlech;
                }
                else
                {
                    slchenhlech = 0;
                    sltrongkho = sltrongkho + slchenhlech;
                }
                sql = "update tblmatsach set masach = N'" + cbomasach.SelectedValue.ToString() + "', soluongmat = " + txtsoluong.Text + ", ngaymat = '" + Class.Functions.ConvertDateTime(mskngaymat.Text) + "' where malanmat = N'" + txtmamat.Text + "'";
                Class.Functions.RunSql(sql);
                sql = "update tblkhosach set soluong = " + sltrongkho + " where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
                Class.Functions.RunSql(sql);

            }
            else
            {
                slcon = sltrongkho - Convert.ToInt32(txtsoluong.Text);
                sql = "update tblmatsach set masach = N'" + cbomasach.SelectedValue.ToString() + "', soluongmat = " + txtsoluong.Text + ", ngaymat = '" + Class.Functions.ConvertDateTime(mskngaymat.Text) + "' where malanmat = N'" + txtmamat.Text + "'";
                Class.Functions.RunSql(sql);
                sql = "update tblkhosach set soluong = " + slcon + " where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
                Class.Functions.RunSql(sql);
            }
            load_dtgv();
            reset_data();
            btnboqua.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            if (tblms.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmamat.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string sql;
            double sltrongkho, slmatcu, slcon;
            sql = "select soluongmat from tblmatsach where malanmat = N'" + txtmamat.Text + "'";
            slmatcu = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            sql = "select soluong from tblkhosach where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
            sltrongkho = Convert.ToInt32(Class.Functions.GetFieldValues(sql));
            slcon = sltrongkho + slmatcu;
            if (MessageBox.Show("Bạn có muốn xóa dòng này đi không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "delete tblmatsach where malanmat = N'" + txtmamat.Text + "'";
                Class.Functions.RunSqlDel(sql);
                sql = "update tblkhosach set soluong = " + slcon + " where masach = N'" + cbomasach.SelectedValue.ToString() + "'";
                Class.Functions.RunSql(sql);
                load_dtgv();
                reset_data();
                btnhuy.Enabled = false;
                btnsua.Enabled = false;
            }
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
