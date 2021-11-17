using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult exit =
            MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(exit == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            //    return
            //}
            switch(exit)
            {
                case DialogResult.Yes:        
                    Application.Exit();
                        break;
                case DialogResult.No:
                    break;
            }
           
        }

        private void btnSum_Click(object sender, EventArgs e)
        {

            if(txtNum2.Text=="")
            {
                MessageBox.Show("Nhap so thu 2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum2.Focus();
                return;
            }
            if (txtNum1.Text == "")
            {
                MessageBox.Show("Nhap so thu 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNum1.Focus();
                return;
            }
            float a, b, c;
            a = Convert.ToSingle(txtNum2.Text);
            b = Convert.ToSingle(txtNum1.Text);
            c = a + b;        
            lblsum.Text = "Sum: " +c.ToString();
            txtNum2.ReadOnly = true;
            txtNum1.ReadOnly = true;        
            lblsum.Visible = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            txtNum2.Text = "";
            txtNum1.Text = "";
            lblsum.Text = "";
            txtNum2.ReadOnly = false;
            txtNum1.ReadOnly = false;
            lblsum.Enabled = true;
            lblsum.Visible = false;
            lblsum.Visible = false;
            txtNum2.Focus();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( ((e.KeyChar >= '0') && (e.KeyChar <= '9')) || 
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
    }
}
