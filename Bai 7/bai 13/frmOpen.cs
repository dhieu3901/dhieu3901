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
    public partial class frmOpen : Form
    {
        public frmOpen()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap|*.bmp|Gif|*.gif|All files|*.*";
            dlgOpen.InitialDirectory = "D:\\";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chon hinh anh: ";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
            else
                MessageBox.Show("Bạn vừa ấn Cancel", "Open Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
