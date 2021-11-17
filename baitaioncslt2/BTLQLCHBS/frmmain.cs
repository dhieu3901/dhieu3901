using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQLCHBS
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien f = new frmnhanvien();
            f.Show();
        }

        private void khoSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang f = new frmkhachhang();
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhacc f = new frmnhacc();
            f.Show();
        }

        private void hóaĐơnBánSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhdbansach f = new frmhdbansach();
            f.Show();
        }

        private void hóaĐơnNhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhdnhap f = new frmhdnhap();
            f.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmbc1 f = new frmbc1();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hóaĐơnCóTổngTiềnHàngLớnNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbc2 f = new frmbc2();
            f.Show();
        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbc3 f = new frmbc3();
            f.Show();
        }

        private void danhSáchCácKháchHàngKhôngMuaHàngTheoThángChọnTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbc4 f = new frmbc4();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhosach f = new frmKhosach();
            f.Show();
        }

        private void báoCáoMấtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmatsach f = new frmmatsach();
            f.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNXB f = new frmNXB();
            f.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtacgia f = new frmtacgia();
            f.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtkkhach f = new frmtkkhach();
            f.Show();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtksach f = new frmtksach();
            f.Show();
        }

        private void tìmKiếmHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKHDBan f = new frmTKHDBan();
            f.Show();
        }

        private void tìmKiếmHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKHDNhap f = new frmTKHDNhap();
            f.Show();
        }
    }
}
