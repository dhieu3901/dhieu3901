using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Trainning_1
{
    public partial class QuanLyBanHang : Form
    {
        public QuanLyBanHang()
        {
            InitializeComponent();
        }

        private void mnuDMChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmDMCL = new frmDMChatLieu();
            frmDMCL.ShowDialog();
        }
    }
}
