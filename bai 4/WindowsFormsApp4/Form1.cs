using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        int n;
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập a !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNhap.Focus();
                return;
            }
            n = Convert.ToInt32(txtNhap.Text);
            string ds = "";
            a = new int[n];
            Random rd = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = rd.Next(0, 100);
                ds += a[i].ToString() + " ";
            }
            lblDayso.Text = "Dãy số: " + Convert.ToString(ds);
            txtNhap.ReadOnly = true;
            btnNhap.Enabled = false;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += a[i];
            }
            lblSum.Text = "Tổng dãy số: " + Convert.ToString(sum);
            btnSum.Enabled = false;
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int swap = a[i];
                        a[i] = a[j];
                        a[j] = swap;
                    }
                }
            }
            string s = "";
            for (int i = 0; i < n; i++)
            {
                s += Convert.ToString(a[i]) + " ";
            }
            lblSapxep.Text = "Sắp xếp: " + s;
            btnSapxep.Enabled = false;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtNhap.ReadOnly = false;
            btnNhap.Enabled = true;
            btnSum.Enabled = true;
            btnSapxep.Enabled = true;
            txtNhap.Text = "";
            lblDayso.Text = "Dãy số: ";
            lblSapxep.Text = "Sắp xếp: ";
            lblSum.Text = "Tổng dãy số:";
            txtNhap.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();

        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
