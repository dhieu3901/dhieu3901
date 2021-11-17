using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hienthidulieu
{
    public partial class ChatLieu : Form
    {
        public ChatLieu()
        {
            InitializeComponent();
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
            string sql = "select * from tblchatlieu";
            DataTable dataChatLieu = DAO.getDatatoTable(sql);
            dataGridviewChatLieu.DataSource = dataChatLieu;
        }
        private void Datagridview_click(object sender, EventArgs e)
        {
            txtMacl.Text = dataGridviewChatLieu.CurrentRow.Cells["machatlieu"].Value.ToString();
            txtTencl.Text = dataGridviewChatLieu.CurrentRow.Cells["tenchatlieu"].Value.ToString();
            txtMacl.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string macl = txtMacl.Text;
            string tencl = txtTencl.Text;
            string sql = "update tblchatlieu set tenchatlieu=N'" + tencl + "'" + "where machatlieu = '" + macl + "'";
            if (tencl == "")
            {
                MessageBox.Show("Ten chat lieu khong duoc de trong");
                txtTencl.Focus();
                return;
            }
            else
            {
                try
                {
                    DAO.openConnection();
                    DAO.executeQueury(sql);
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
