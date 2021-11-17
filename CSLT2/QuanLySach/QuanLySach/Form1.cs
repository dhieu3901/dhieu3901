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

namespace QuanLySach
{
    public partial class QuanLySach : Form
    {
        public QuanLySach()
        {
            InitializeComponent();
        }
        private void LoadDataToGridView()
        {
            string sql = "select * from tblSach";
            DataTable tblS = global::QuanLySach.Load.getDataToTable(sql);
            dataGridViewSach.DataSource = tblS;
            dataGridViewSach.Columns[0].HeaderText = "Mã sách";
            dataGridViewSach.Columns[1].HeaderText = "Tên sách";
            dataGridViewSach.Columns[2].HeaderText = "Tác giả";
            dataGridViewSach.Columns[1].Width = 150;
            dataGridViewSach.AllowUserToAddRows = false;
            dataGridViewSach.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            global::QuanLySach.Load.SetUpConnection();
            try
            {
                global::QuanLySach.Load.openConnection();
                LoadDataToGridView();
                global::QuanLySach.Load.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridViewSach_Click(object sender, EventArgs e)
        {
            txtMasach.Text = dataGridViewSach.CurrentRow.Cells["Masach"].Value.ToString().Trim();
            txtTensach.Text = dataGridViewSach.CurrentRow.Cells["Tensach"].Value.ToString().Trim();
            txtTacgia.Text = dataGridViewSach.CurrentRow.Cells["Tacgia"].Value.ToString().Trim();
            txtMasach.Enabled = false;
        }
        private void ClearTextBox()
        {
            if (txtMasach.Enabled==false)
            {
                txtMasach.Enabled = true;
                txtMasach.Text = "";
            }
            txtTacgia.Text = "";
            txtTensach.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string masach = txtMasach.Text;
            string tensach = txtTensach.Text;
            string tacgia = txtTacgia.Text;
            if (masach == "" || tensach == "" || tacgia == "")
            {
                MessageBox.Show("Không được bỏ trống dữ liệu");
                if (masach == "") txtMasach.Focus();
                else if (tensach == "") txtTensach.Focus();
                else txtTacgia.Focus();
                return;
            }
            else
            {
                
                    global::QuanLySach.Load.openConnection();
                    string sql = "select Masach from tblSach";
                SqlDataReader rd = global::QuanLySach.Load.executeReader(sql);
                    while (rd.Read())
                        if (rd[0].ToString().Trim() == txtMasach.Text.Trim())
                        {
                            MessageBox.Show("Trùng dữ liệu");
                            txtMasach.Focus();
                            rd.Close();
                            return;
                        }
                    rd.Close();
                    sql = "insert into tblSach values ('" + masach + "',N'" + tensach + "',N'" + tacgia + "')";
                    try
                    {
                        global::QuanLySach.Load.executeNonQuery(sql);
                        LoadDataToGridView();
                        global::QuanLySach.Load.closeConnection();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string tensach = txtTensach.Text;
            string tacgia = txtTacgia.Text;
            string masach = txtMasach.Text;
            txtMasach.Enabled = false;
            if (tensach == "" || tacgia == "")
            {
                MessageBox.Show("Không được bỏ trống dữ liệu");
                if (tensach == "") txtTensach.Focus();
                else txtTacgia.Focus();
                return;
            }
            else
            {
                string sql = "update tblSach set Tensach = '" + tensach + "',Tacgia='" + tacgia + "' where Masach = '" + masach + "'";
                try
                {
                    global::QuanLySach.Load.openConnection();
                    global::QuanLySach.Load.executeNonQuery(sql);
                    LoadDataToGridView();
                    global::QuanLySach.Load.closeConnection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masach = txtMasach.Text;
            string sql = "delete from tblSach where Masach='" + masach + "'";
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                    ==System.Windows.Forms.DialogResult.Yes)
                {
                    global::QuanLySach.Load.openConnection();
                    global::QuanLySach.Load.executeNonQuery(sql);
                    LoadDataToGridView();
                    global::QuanLySach.Load.closeConnection();
                    ClearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
                Application.Exit();
        }
    }
}
