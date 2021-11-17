using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bài_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtKetqua.Enabled = false;
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        private void rdCong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập a !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                rdCong.Checked = false;
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập b !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                rdCong.Checked = false;
                return;
            }
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtKetqua.Text = (a + b).ToString();
            txtA.Enabled = false;
            txtB.Enabled = false;

        }

        private void rdTru_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập a !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                rdTru.Checked = false;
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập b !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                rdTru.Checked = false;
                return;
            }
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtKetqua.Text = (a - b).ToString();
            txtA.Enabled = false;
            txtB.Enabled = false;
        }

        private void rdNhan_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập a !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                rdNhan.Checked = false;
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập b !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                rdNhan.Checked = false;
                return;
            }
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtKetqua.Text = (a * b).ToString();
            txtA.Enabled = false;
            txtB.Enabled = false;
        }

        private void rdChia_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập a !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                rdChia.Checked = false;
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập b !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                rdChia.Checked = false;
                return;
            }
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            txtKetqua.Text = (a / b).ToString();
            txtA.Enabled = false;
            txtB.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void btnLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtA.Enabled = true;
            txtB.Enabled = true;
            rdCong.Checked = false;
            rdTru.Checked = false;
            rdNhan.Checked = false;
            rdChia.Checked = false;

        }

        private void chkMax_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            if (chkMax.Checked == true)
            {
                if (a < b)
                    chkMax.Text = "Max = " + b.ToString();
                else
                    chkMax.Text = "Max = " + a.ToString();
            }
            else
                chkMax.Text = "Max";
        }

        private void chkMin_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            if (chkMin.Checked == true)
            {
                if (a > b)
                    chkMin.Text = "Min = " + b.ToString();
                else
                    chkMin.Text = "Min = " + a.ToString();
            }
            else
                chkMin.Text = "Min";
        }
    }
}
