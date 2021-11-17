using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chương_7
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)             
                Application.Exit();
        }

        private void mnuChatlieu_Click(object sender, EventArgs e)
        {
            frmDMChatlieu f = new frmDMChatlieu();
            f.Show();
        }

        private void mnuNhanvien_Click(object sender, EventArgs e)
        {
            frmDMNhanvien f = new frmDMNhanvien();
            f.Show();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            frmDMKhachhang f = new frmDMKhachhang();
            f.Show();
        }

        private void mnuHanghoa_Click(object sender, EventArgs e)
        {
            frmDMHang f = new frmDMHang();
            f.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonBan f = new frmHoadonBan();
            f.Show();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimHDBan f = new frmTimHDBan();
            f.Show();
        }
    }
}
