using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlybanhang1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với ctrinh QLBH");
        }

        private void menuDangNhap_Click(object sender, EventArgs e)
        {
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
        }

        private void menuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khói chương trình?", "Thông báo",
                MessageBoxButtons.YesNo)
                == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
