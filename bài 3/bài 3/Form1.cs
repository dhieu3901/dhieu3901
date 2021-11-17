using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {

            if (txtA.Text == "")
            {
                MessageBox.Show("Vui lòng nhập a !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Vui lòng nhập b !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }
            int a, b, c;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = 0;
            for(int i = a; i <= b; i++)
            {
                c += i;
            }
            lblsum.Text = "Sum: " + c.ToString();
            txtA.ReadOnly = true;
            txtB.ReadOnly = true;
            lblsum.Visible = true;

        }

        

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == '-') || (e.KeyChar == '.') ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            lblsum.Text = "";
            txtA.ReadOnly = false;
            txtB.ReadOnly = false;
            lblsum.Enabled = true;
            lblsum.Visible = false;
            lblsum.Visible = false;
            txtA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit =
            MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (exit)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
