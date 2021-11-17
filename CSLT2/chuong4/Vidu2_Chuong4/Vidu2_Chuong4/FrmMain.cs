using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vidu2_Chuong4
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            try
            {
                float a = Convert.ToSingle(txtA.Text);
                float b = Convert.ToSingle(txtB.Text);
                float tong = a + b;
                lblTong.Text = "Tổng của 2 số trên là: " + tong.ToString();
            }
            catch(Exception ex)
            {
                lblTong.Text = ex.ToString();
            }
        }
        private void check_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
