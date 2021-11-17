using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void chkGiamgia_Click(object sender, EventArgs e)
        {
            if (chkGiamgia.Checked == true)
            {
                rd5.Visible = true;
                rd10.Visible = true;
                rd5.Checked = true;
            }
            else
            {
                rd5.Visible = false;
                rd10.Visible = false;
                rd5.Checked = false;
            }
        }

        private void txtDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == ',') ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtSoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd5.Visible = false;
            rd10.Visible = false;
            txtTongtien.Enabled = false;
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hàng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMahang.Focus();
                return;
            }
            if (txtDongia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Đơn giá !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDongia.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Số lượng !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            
            float a, b;
            a = Convert.ToSingle(txtDongia.Text);
            b = Convert.ToSingle(txtSoluong.Text);
            txtDongia.Enabled = false;
            txtMahang.Enabled = false;
            txtSoluong.Enabled = false;
            if (chkGiamgia.Checked == true)
            {
                if(rd5.Checked == true)
                {
                    txtTongtien.Text = (a * b * 0.95).ToString();
                }
                else
                {
                    txtTongtien.Text = (a * b * 0.9).ToString();
                }
            }
            else
                txtTongtien.Text = (a * b).ToString();
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtDongia.Enabled = true;
            txtMahang.Enabled = true;
            txtSoluong.Enabled = true;
            txtDongia.Text = "";
            txtMahang.Text = "";
            txtSoluong.Text = "";
            txtTongtien.Text = "";
            rd5.Visible = false;
            rd10.Visible = false;
            chkGiamgia.Checked = false;
        }

        private void rd5_CheckedChanged(object sender, EventArgs e)
        {
            txtTongtien.Text = "";
        }

        private void rd10_CheckedChanged(object sender, EventArgs e)
        {
            txtTongtien.Text = "";
        }
    }
}
