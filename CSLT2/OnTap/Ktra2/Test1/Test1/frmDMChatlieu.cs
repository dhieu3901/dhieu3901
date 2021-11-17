using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Test1
{
    public partial class frmDMChatlieu : Form
    {
        public frmDMChatlieu()
        {
            InitializeComponent();
        }
        public void LoadDataToGridView()
        {
            string sql = "select * from tblChatlieu";
            DataTable tblCL = DAO.GetDataToTable(sql);
            dataGridView.DataSource = tblCL;
            dataGridView.Columns[0].HeaderText = "Ma chat lieu";
            dataGridView.Columns[0].Width = 100;
            dataGridView.Columns[1].HeaderText = "Ma hang";
            dataGridView.Columns[1].Width = 100;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void frmDMChatlieu_Load(object sender, EventArgs e)
        {
            DAO.SetUpConnection();
            try
            {
                DAO.OpenConnection();
                btnLuu.Enabled = false;
                LoadDataToGridView();
                DAO.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count==0)
            {
                MessageBox.Show("Chua co du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtMachatlieu.Text = dataGridView.CurrentRow.Cells["Machatlieu"].Value.ToString().Trim();
            txtTenchatlieu.Text = dataGridView.CurrentRow.Cells["Tenchatlieu"].Value.ToString().Trim();
            txtMachatlieu.Enabled = false;
        }
        public void ClearTextBox()
        {
            txtMachatlieu.Text = "";
            txtTenchatlieu.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnLuu.Enabled = true;
            txtMachatlieu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon xoa?","THONG BAO",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                ==System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    string sql = "delete from tblChatlieu where Machatlieu ='" + txtMachatlieu.Text + "'";
                    DAO.OpenConnection();
                    DAO.ExecuteQuery(sql);
                    LoadDataToGridView();
                    DAO.CloseConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenchatlieu.Text=="")
            {
                MessageBox.Show("Du lieu trong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenchatlieu.Focus();
                return;
            }

            try
            {
                string sql = "update tblChatlieu set Tenchatlieu = '" + txtTenchatlieu.Text + "' where Machatlieu = '" + txtMachatlieu.Text + "'";
               DAO.OpenConnection();
                DAO.ExecuteQuery(sql);
                LoadDataToGridView();
                DAO.CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMachatlieu.Text==""||txtTenchatlieu.Text=="")
            {
                MessageBox.Show("Du lieu thieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtMachatlieu.Text == "") txtMachatlieu.Focus();
                else txtTenchatlieu.Focus();
                return;
            }
            string sqlcheck = "select * from tblChatlieu where Machatlieu = '" + txtMachatlieu.Text + "'";
            if (DAO.CheckKey(sqlcheck)==true)
            {
                MessageBox.Show("Du lieu trung", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachatlieu.Focus();
                return;
            }
            try
            {
                string sql = "insert into tblChatlieu (Machatlieu, Tenchatlieu) values ('" + txtMachatlieu.Text + "',N'" + txtTenchatlieu.Text + "')";
                DAO.OpenConnection();
                DAO.ExecuteQuery(sql);
                LoadDataToGridView();
                DAO.CloseConnection();
                ClearTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            btnLuu.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac muon dong danh muc?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }
    }
}
