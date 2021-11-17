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
    public partial class frmDMChatLieu : Form
    {
        DataTable tblCL;
        public frmDMChatLieu()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView()
        {
            string sql = "select * from tblChatlieu";
            DataTable tblDMCL = DAO.GetDataToTable(sql);
            dataGridView.DataSource = tblCL;
            dataGridView.Columns[0].HeaderText = "Ma hang";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].HeaderText = "Ten hang";
            dataGridView.Columns[1].Width = 100;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.AllowUserToAddRows = false;
        }

        private void frmDMChatLieu_Load(object sender, EventArgs e)
        {
            DAO.SetUpConnection();
            try
            {
                DAO.openConnection();
                LoadDataToGridView();
                DAO.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewCL_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count==0)
            {
                MessageBox.Show("Chua co du lieu");
                txtmachatlieu.Focus();
                return;
            }
            txtmachatlieu.Text = dataGridView.CurrentRow.Cells["Machatlieu"].Value.ToString().Trim();
            txttenchatlieu.Text = dataGridView.CurrentRow.Cells["Tenchatlieu"].Value.ToString().Trim();
        }

        public void ClearTextBox()
        {
            txtmachatlieu.Text = "";
            txttenchatlieu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnluu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon xoa?","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    DAO.openConnection();
                    string sql = "delete from tblChatlieu where Machatlieu = '" + txtmachatlieu.Text + "'";
                    DAO.ExecuteQuery(sql);
                    LoadDataToGridView();
                    DAO.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttenchatlieu.Text=="")
            {
                MessageBox.Show("Ko duoc de trong ten chat lieu");
                txttenchatlieu.Focus();
                return;
            }
            try
            {
                string sql = "update tblChatlieu set Tenchatlieu ='" + txttenchatlieu.Text + "' WHERE Machatlieu ='" + txtmachatlieu.Text + "'";
                DAO.openConnection();
                DAO.ExecuteQuery(sql);
                LoadDataToGridView();
                DAO.closeConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmachatlieu.Text==""||txttenchatlieu.Text=="")
            {
                MessageBox.Show("Khong duoc de trong!");
                if (txtmachatlieu.Text == "") txtmachatlieu.Focus();
                else txttenchatlieu.Focus();
                return;
            }
            string sqlCheck = "select * from tblChatlieu where Machatlieu='" + txtmachatlieu.Text + "'";
            if (DAO.CheckKey(sqlCheck)==true)
            {
                MessageBox.Show("Du lieu trung");
                txtmachatlieu.Focus();
                return;
            }
            try
            {
                string sql = "insert into tblChatlieu (Machatlieu, Tenchatlieu) values (N'" + txtmachatlieu.Text + "',N'" + txttenchatlieu.Text + "')";
                DAO.openConnection();
                DAO.ExecuteQuery(sql);
                LoadDataToGridView();
                DAO.closeConnection();
                ClearTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat ctrinh?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
