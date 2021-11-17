using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            txtdisplay.Text= "Hello World !!!";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text=" ";
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
