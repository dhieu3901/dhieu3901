using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vd1_chuong4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinhtong_Click(object sender, EventArgs e)
        {
            float sothu1 = Convert.ToSingle(txtSothu1.Text);
            float sothu2 = Convert.ToSingle(txtSothu2.Text);
            float tong = sothu1 + sothu2;
            labelTong.Text = "Tổng của hai số trên là: " + tong.ToString();
        }
    }
}
