using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLQLCHBS
{
    public partial class frmKhosach : Form
    {
        public frmKhosach()
        {
            InitializeComponent();
        }
        DataTable tblks;
        private void frmnhapsachmoi_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            load_DataGridView();
            Class.Functions.FillCombo("Select manxb , tennxb from tblnxb ", cboNxb, "manxb", "tennxb");
            cboNxb.SelectedIndex = -1;
            Class.Functions.FillCombo("Select matg , tentg from tbltacgia ", cboTg, "matg", "tentg");
            cboTg.SelectedIndex = -1;
            Class.Functions.FillCombo("Select maloaisach , tenloaisach from tblloaisach ", cboLoaisach, "maloaisach", "tenloaisach");
            cboLoaisach.SelectedIndex = -1;
            resetdulieu();
        }
        private void load_DataGridView()
        {
            string sql;
            sql = "select masach,tensach, soluong, dongianhap, dongiaban, maloaisach, matg, manxb, malinhvuc, mangonngu, sotrang from tblkhosach";
            tblks = Class.Functions.GetDatatoTable(sql);
            dtgv.DataSource = tblks;
            dtgv.Columns[0].HeaderText = "Mã Sách ";
            dtgv.Columns[1].HeaderText = "Tên Sách";
            dtgv.Columns[2].HeaderText = "Số Lượng";
            dtgv.Columns[3].HeaderText = "Đơn giá nhập";
            dtgv.Columns[4].HeaderText = "Đơn giá bán";
            dtgv.Columns[5].HeaderText = "Loại sách";
            dtgv.Columns[6].HeaderText = "Mã tác giả";
            dtgv.Columns[7].HeaderText = "Mã NXB";
            dtgv.Columns[8].HeaderText = "Lĩnh vực";
            dtgv.Columns[9].HeaderText = "Ngôn ngữ";
            dtgv.Columns[10].HeaderText = "Số trang";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.AllowUserToAddRows = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void resetdulieu()
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            cboNxb.Text = "";
            txtSoluong.Text = "0";
            txtDongianhap.Text = "0";
            txtDongiaban.Text = "0";
            cboLoaisach.Text = "";
            txtLinhvuc.Text = "";
            txtNgonngu.Text = "";
            txtSotrang.Text = "";
            cboTg.Text = "";
            txtAnh.Text = "";
            picAnh.Image = null;
            txtSoluong.Enabled = false;
            txtDongiaban.Enabled = false;
            txtDongianhap.Enabled = false;
            cboLoaisach.Enabled = false;
            cboTg.Enabled = false;
            txtLinhvuc.Enabled = false;
            txtNgonngu.Enabled = false;
            txtSotrang.Enabled = false;
            txtAnh.Enabled = false;
            btnOpen.Enabled = false;
            txtMasach.Enabled = true;
        }

        private void dtgv_Click(object sender, EventArgs e)
        {
            string manxb, mals, matg;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang co che do them moi du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasach.Focus();
                return;
            }
            if (tblks.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu trong bang!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }
            txtMasach.Text = dtgv.CurrentRow.Cells["masach"].Value.ToString();
            txtTensach.Text = dtgv.CurrentRow.Cells["tensach"].Value.ToString();
            manxb = dtgv.CurrentRow.Cells["manxb"].Value.ToString();
            cboNxb.Text = Class.Functions.GetFieldValues("select tennxb from tblnxb where manxb = N'" + manxb + "'");
            txtSoluong.Text = dtgv.CurrentRow.Cells["soluong"].Value.ToString();
            txtDongianhap.Text = dtgv.CurrentRow.Cells["dongianhap"].Value.ToString();
            txtDongiaban.Text = dtgv.CurrentRow.Cells["dongiaban"].Value.ToString();
            txtLinhvuc.Text = dtgv.CurrentRow.Cells["malinhvuc"].Value.ToString();
            txtNgonngu.Text = dtgv.CurrentRow.Cells["mangonngu"].Value.ToString();
            txtSotrang.Text = dtgv.CurrentRow.Cells["sotrang"].Value.ToString();
            mals = dtgv.CurrentRow.Cells["maloaisach"].Value.ToString();
            cboLoaisach.Text = Class.Functions.GetFieldValues("select tenloaisach from tblloaisach where maloaisach = N'" + mals + "'");
            matg = dtgv.CurrentRow.Cells["matg"].Value.ToString();
            cboTg.Text = Class.Functions.GetFieldValues("select tentg from tbltacgia where matg = N'" + matg + "'");
            txtAnh.Text = Class.Functions.GetFieldValues("select anh from tblkhosach where masach = N'" + txtMasach.Text + "'");
            picAnh.Image = Image.FromFile(txtAnh.Text);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
            txtSoluong.Enabled = true;
            txtDongiaban.Enabled = true;
            txtDongianhap.Enabled = true;
            cboLoaisach.Enabled = true;
            cboTg.Enabled = true;
            txtLinhvuc.Enabled = true;
            txtNgonngu.Enabled = true;
            txtSotrang.Enabled = true;
            txtAnh.Enabled = true;
            btnOpen.Enabled = true;
            txtMasach.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoqua.Enabled = true;
            resetdulieu();
            txtSoluong.Enabled = true;
            txtDongiaban.Enabled = true;
            txtDongianhap.Enabled = true;
            cboLoaisach.Enabled = true;
            cboTg.Enabled = true;
            txtLinhvuc.Enabled = true;
            txtNgonngu.Enabled = true;
            txtSotrang.Enabled = true;
            txtAnh.Enabled = true;
            btnOpen.Enabled = true;
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            resetdulieu();
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtMasach.Text == " ")
            {
                MessageBox.Show("Bạn phải nhập mã sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMasach.Focus();
                return;
            }
            if (txtTensach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTensach.Focus();
                return;
            }
            if(txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if(txtDongianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtLinhvuc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập lĩnh vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLinhvuc.Focus();
                return;
            }
            if(txtNgonngu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ngôn ngữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgonngu.Focus();
                return;
            }
            if(txtSotrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSotrang.Focus();
                return;
            }
            if (cboNxb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhà xuất bản", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNxb.Focus();
                return;
            }
            if(cboLoaisach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               cboLoaisach.Focus();
                return;
            }
            if(cboTg.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTg.Focus();
                return;
            }
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Ban phai chon anh minh hoa cho hang!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            double dgn,dgb;
            dgn = Convert.ToDouble(txtDongianhap.Text);
            dgb = dgn * 110 / 100;
            string sql;
            sql = "select masach from tblkhosach where masach = '" + txtMasach.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã sách này đã được sử dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasach.Text = "";
                txtMasach.Focus();
                return;
            }
            else if (MessageBox.Show("Thông tin đã được lưu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                sql = "insert into tblkhosach values(N'" + txtMasach.Text + "', N'" + txtTensach.Text + "'," + txtSoluong.Text + "," + txtDongianhap.Text + "," + dgb + ",N'" + cboLoaisach.SelectedValue.ToString() + "',N'" + cboTg.SelectedValue.ToString() + "', N'" + cboNxb.SelectedValue.ToString() + "',N'" + txtLinhvuc.Text + "',N'" + txtNgonngu.Text + "', N'" + txtAnh.Text + "', " + txtSotrang.Text + ")";
                Class.Functions.RunSql(sql);
                load_DataGridView();
                resetdulieu();
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnBoqua.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "bitmap(*.bmp)|*.bmp|Gif(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "D:\\C#\\baitaioncslt2\\baitaioncslt2\\Ảnh";
            dlgOpen.FilterIndex = 3;
            dlgOpen.Title = "Chon hinh anh de hien thi";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }
        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (tblks.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                return;
            }
            if (txtMasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTensach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTensach.Focus();
                return;
            }
            if (txtSoluong.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtDongianhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoluong.Focus();
                return;
            }
            if (txtLinhvuc.Text == "")
            {
                MessageBox.Show("Bạn phải nhập lĩnh vực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLinhvuc.Focus();
                return;
            }
            if (txtNgonngu.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã ngôn ngữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNgonngu.Focus();
                return;
            }
            if (txtSotrang.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số trang", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSotrang.Focus();
                return;
            }
            if (cboNxb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNxb.Focus();
                return;
            }
            if (cboLoaisach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập loại sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaisach.Focus();
                return;
            }
            if (cboTg.Text == "")
            {
                MessageBox.Show("Bạn phải nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTg.Focus();
                return;
            }
            if (txtAnh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn ảnh minh họa cho sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            else if (MessageBox.Show("Thông tin đã được sửa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.OK)
            {
                double dgn, dgb;
                dgn = Convert.ToDouble(txtDongianhap.Text);
                dgb = dgn * 110 / 100;
                string sql;
                sql = "update tblkhosach set tensach = N'" + txtTensach.Text + "', soluong = " + txtSoluong.Text + ", dongianhap = " + txtDongianhap.Text + " , dongiaban = " + dgb + " , maloaisach = N'" + cboLoaisach.SelectedValue.ToString() + "' , matg = N'" + cboTg.SelectedValue.ToString() + "' , manxb = N'" + cboNxb.SelectedValue.ToString() + "', malinhvuc = N'" + txtLinhvuc.Text + "', mangonngu = N'" + txtNgonngu.Text + "', anh = N'" + txtAnh.Text + "', sotrang = " + txtSotrang.Text + " where masach = N'" + txtMasach.Text + "'";
                Class.Functions.RunSql(sql);
                load_DataGridView();
                resetdulieu();
                btnBoqua.Enabled = false;
            }      
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //string sql;
            //if (tblks.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //if (txtMasach.Text == "")
            //{
            //    MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            //{
            //    sql = "Delete tblkhosach where masach = N'" + txtMasach.Text + "'";
            //    Class.Functions.RunSqlDel(sql);
            //    load_DataGridView();
            //    resetdulieu();
            //    btnBoqua.Enabled = false;
            //    MessageBox.Show("Thông tin đã được xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //txtMasach.Enabled = true;
            string sql;
            if (tblks.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMasach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                sql = "Delete tblkhosach where masach = N'" + txtMasach.Text + "'";
                Class.Functions.RunSqlDel(sql);
                load_DataGridView();
                resetdulieu();
            }
            txtMasach.Enabled = true;
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            if ((txtMasach.Text == "") && (txtTensach.Text == "") && (cboNxb.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMasach.Focus();
            }
            else
            {
                string sql;
                sql = "select * from tblkhosach where 1 = 1 ";
                if (txtMasach.Text != "")
                {
                    sql = sql + "and masach like '%" + txtMasach.Text + "%' ";
                }
                if (txtTensach.Text != "")
                {
                    sql = sql + " and tensach like '%" + txtTensach.Text + "%' ";
                }
                if (cboNxb.Text != "")
                {
                    sql = sql + " and manxb like '%" + cboNxb.SelectedValue.ToString() + "%'";
                }
                tblks = Class.Functions.GetDatatoTable(sql);
                if (tblks.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách bạn cần!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Có " + tblks.Rows.Count + " sách bạn cần tìm!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtgv.DataSource = tblks;
                    resetdulieu();
                }
            }
            resetdulieu();
        }

        private void btnhienthi_Click(object sender, EventArgs e)
        {
            load_DataGridView();
        }

    }
}
