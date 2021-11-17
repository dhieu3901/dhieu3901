using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ketnoidulieu
{
    public partial class ChatLieu : Form
    {
        public ChatLieu()
        {
            InitializeComponent();
        }

        private void txtmacl_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Datagriview_click(object sender, EventArgs e)
        {
            txtmacl.Text = datagridviewChatLieu.CurrentRow.Cells["machatlieu"].Value.ToString();
            txtTencl.Text = datagridviewChatLieu.CurrentRow.Cells["tenchatlieu"].Value.ToString();
            txtmacl.Enabled = false;
        }

        private void ChatLieu_Load(object sender, EventArgs e)
        {
            DAO.setupConnection();
            try
            {
                DAO.openConnection();
                LoadDataToGridview();
                DAO.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void LoadDataToGridview()
        {
            string sql = "select  * from tblChatLieu";
            DataTable datachatlieu = DAO.getDatatoTable(sql);
            datagridviewChatLieu.DataSource = datachatlieu;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string macl = txtmacl.Text;
            string tencl = txtTencl.Text.Trim();
            string sql = "update tblchatlieu set tenchatlieu = N'" + tencl + "'" +
                "where machatlieu = '" + macl + "'";
            if (tencl == "")
            {
                MessageBox.Show("ten chat lieu ko dc de trong");
                txtTencl.Focus();
                return;
            }
            else
            {
                try
                {
                    DAO.openConnection();
                    DAO.excecuteQueury(sql);
                    LoadDataToGridview();
                    DAO.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

        }
    }
}
