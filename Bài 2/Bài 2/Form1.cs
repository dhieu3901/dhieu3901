using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bài_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKetqua_Click(object sender, EventArgs e)
        {
            if(txtThang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tháng !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtThang.Focus();
                return;
            }
            if(txtNam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập năm !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNam.Focus();
                return;
            }
            int thang, nam, ngay=0;
            thang = Convert.ToInt32(txtThang.Text);
            nam = Convert.ToInt32(txtNam.Text);
            if (thang > 12 || thang < 0)
            {
                MessageBox.Show("Bạn phải nhập tháng trong [1,12]", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtThang.Focus();
                txtThang.Text = "";
                return;
            }
            if (nam < 1900)
            {
                MessageBox.Show("Bạn phải nhập năm có giá trị >= 1900", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNam.Focus();
                txtNam.Text = "";
                return;
            }
            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    ngay = 30;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ngay = 31;
                    break;
                case 2:
                    if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
                        ngay = 29;
                    else
                        ngay = 28;
                    break;
            }
            lblKetqua.Text = "Tháng " + thang + " năm " + nam + " có " + ngay + " ngày";
            btnKetqua.Enabled = false;
            btnLamlai.Enabled = true;
            txtThang.ReadOnly = true;
            txtNam.ReadOnly = true;


        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtThang.Text = "";
            txtThang.ReadOnly = false;
            txtThang.Focus();
            txtNam.Text = "";          
            txtNam.ReadOnly = false;
            txtNam.Focus();
            btnKetqua.Enabled = true;
            lblKetqua.Text = "Kết quả: ";

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat =
            MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch(thoat)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || Convert.ToInt32(e.KeyChar) == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void txtNam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || Convert.ToInt32(e.KeyChar) == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
