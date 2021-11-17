using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QuanLyBanHang1
{
    public partial class SanPham : Form
    {
        bool cmbCanChange = false;
        public SanPham()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from tblHang";
            DataTable tblH = DAO.getDataToTable(sql);
            datagridviewHang.DataSource = tblH;
            datagridviewHang.Columns[0].HeaderText = "Ma hang";
            datagridviewHang.AllowUserToAddRows = false;
            datagridviewHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            cmbCanChange = true;

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            cmbCanChange = false;
            DAO.SetupConnection();
            try
            {
                DAO.openConnection();
                string sql = "select * from tblChatlieu";
                DAO.FillCombo(sql, cmbChatLieu, "machatlieu", "tenchatlieu");
                cmbChatLieu.SelectedIndex = -1;
                LoadDataToGridView();
                DAO.closeConnection();
                cmbCanChange = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void datagridviewHang_Click(object sender, EventArgs e)
        {
            if (datagridviewHang.Rows.Count < 1)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    DAO.openConnection();
                    string ma, sql;
                    txtMaHang.Text = datagridviewHang.CurrentRow.Cells["mahang"].Value.ToString().Trim();
                    ma = datagridviewHang.CurrentRow.Cells["machatlieu"].Value.ToString().Trim();
                    sql = "select tenchatlieu from tblChatlieu wher machatlieu = '" + ma + "'";
                    cmbChatLieu.Text = DAO.GetFieldValue(sql);
                    picAnh.Image = Image.FromFile(txtAnh.Text);
                    DAO.closeConnection();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
         
        }

        private void cmbChatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCanChange)
            {
                try
                {
                    DAO.openConnection();
                    string sql, ma;
                    ma = cmbChatLieu.SelectedValue.ToString();
                    sql = "select * from tblHang where machatlieu='" + ma + "'";
                    DataTable tbl = DAO.getDataToTable(sql);
                    datagridviewHang.DataSource = datagridviewHang;
                    DAO.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text==""||txtTenHang.Text=="")
            {
                MessageBox.Show("khong duoc de trong!");
                if (txtMaHang.Text == "") txtMaHang.Focus();
                else txtTenHang.Focus();
            }
            string sql_check_key = "select * from tblHang where mahang ='" + txtMaHang.Text.ToString().Trim() + "";
            if (DAO.check_key_exist(sql_check_key)==true)
            {
                MessageBox.Show("du lieu trung");
                return;
            }
            string ma = cmbChatLieu.SelectedValue.ToString().Trim();
            string sql = "insert into tblHang (mahang,machetlieu,tenhang,soluong,dongia,anh)" +
                " values ('" + txtMaHang.Text.Trim() + "',N'" + ma + "',N'" + txtTenHang.Text.Trim() + "'" +
                ",N'" + txtSoLuong.Text.Trim() + "',N'" + txtGia.Text.Trim() + "',N'" + txtAnh.Text.Trim() +"')";
            try
            {
                DAO.openConnection();
                DAO.executeNonquery(sql);
                LoadDataToGridView();
                DAO.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
