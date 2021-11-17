using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            frmDMChatlieu frmDMCL = new frmDMChatlieu();
            frmDMCL.ShowDialog();
        }

        private void mnuHang_Click(object sender, EventArgs e)
        {
            frmDMHang frmDMH = new frmDMHang();
            frmDMH.ShowDialog();
        }
    }
}
