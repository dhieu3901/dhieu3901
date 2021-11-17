using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bai_13
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void bàiTập13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai13 f = new frmBai13();
            f.Show();
        }

        private void bàiTập6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai6 f = new frmBai6();
            f.Show();
        }

        private void bàiTập7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai7 f = new frmBai7();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOpen f = new frmOpen();
            f.Show();
        }
    }
}
