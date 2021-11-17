using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTLQLCHBS
{
    public partial class frmhdbansach : Form
    {
        public frmhdbansach()
        {
            InitializeComponent();
        }
        DataTable tblhdb;
        private void frmhdbansach_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
            btnluu.Enabled = false;
            btninhoadon.Enabled = false;
            btnluu.Enabled = false;
            txtmhd.ReadOnly = true;
            txttnv.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            mskdienthoai.ReadOnly = true;
            txttenkh.ReadOnly = true;
            txttensach.ReadOnly = true;
            txtdongia.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txttheloai.Enabled = false;
            txttg.Enabled = false;
            txtnxb.Enabled = false;
            txtlinhvuc.Enabled = false;
            txtngonngu.Enabled = false;
            txtsotrang.Enabled = false;
            txtsoluong.Text = "0";
            txtgiamgia.Text = "0";
            txttongtien.Text = "0";
            txtdongia.Text = "0";
            txtthanhtien.Text = "0";
            string sql;
            sql = "select makhach,tenkhach from tblkhachhang";
            Class.Functions.FillCombo(sql, cbomkh, "tenkhach", "makhach");
            cbomkh.SelectedIndex = -1;
            sql = "select manv,tennv from tblnhanvien";
            Class.Functions.FillCombo(sql, cbomnv, "tennv", "manv");
            cbomnv.SelectedIndex = -1;
            sql = "select masach,tensach from tblkhosach";
            Class.Functions.FillCombo(sql, cbomasach, "tensach", "masach");
            cbomasach.SelectedIndex = -1;
            sql = "select sohdban from tblhdban";
            Class.Functions.FillCombo(sql, cbomahoadon, "sohdban", "sohdban");
            cbomahoadon.SelectedIndex = -1;
            if (txtmhd.Text != "")
            {

                btnhhd.Enabled = true;
                btninhoadon.Enabled = true;
                load_thongtin();
            }
            load_dtgv();
        }
        private void load_dtgv()
        {
            string sql;
            sql = "select a.masach, b.tensach, a.soluongban, b.dongiaban, a.khuyenmai, a.thanhtien from tblchitiethdban as a, tblkhosach as b where a.sohdban = N'" + txtmhd.Text + "' and a.masach = b.masach";
            tblhdb = Class.Functions.GetDatatoTable(sql);
            dtgv.DataSource = tblhdb;
            dtgv.Columns[0].HeaderText = "Mã hàng";
            dtgv.Columns[1].HeaderText = "Tên sách ";
            dtgv.Columns[2].HeaderText = "Số lượng"; ;
            dtgv.Columns[3].HeaderText = "Đơn giá";
            dtgv.Columns[4].HeaderText = "Giảm giá";
            dtgv.Columns[5].HeaderText = "Thành tiền";
            dtgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dtgv.AllowUserToAddRows = false;
            dtgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void load_thongtin()
        {
            string sql;
            sql = "select ngayban from tblhdban where sohdban = '" + txtmhd.Text + "'";
            textBox1.Text = Class.Functions.ConvertDateTime(Class.Functions.GetFieldValues(sql));
            sql = "select manv from tblhdban where sohdban = '" + txtmhd.Text + "'";
            cbomnv.Text = Class.Functions.GetFieldValues(sql);
            sql = "select makhach from tblhdban where sohdban = '" + txtmhd.Text + "'";
            cbomkh.Text = Class.Functions.GetFieldValues(sql);
            sql = "select tongtien from tblhdban where sohdban = '" + txtmhd.Text + "'";
            txttongtien.Text = Class.Functions.GetFieldValues(sql);
            txtbangchu.Text = "" + Class.Functions.ChuyenSoSangChu(txttongtien.Text);
        }
        private void btnthd_Click(object sender, EventArgs e)
        {
            btnhhd.Enabled = true;
            btnluu.Enabled = true;
            btninhoadon.Enabled = true;
            btnthd.Enabled = false;
            reset_data();
            txtsoluong.Text = "0";
            txtmhd.Text = Class.Functions.CreateKey("HDB");
            load_dtgv();
        }
        private void reset_data()
        {
            txtmhd.Text = "";
            textBox1.Text = DateTime.Now.ToShortDateString();
            cbomnv.Text = "";
            txttnv.Text = "";
            cbomkh.Text = "";
            txttongtien.Text = "";
            txtdiachi.Text = "";
            txtbangchu.Text = "";
            txtdongia.Text = "";
            txtgiamgia.Text = "0";
            txtsoluong.Text = "0";
            txttongtien.Text = "0";
            txttensach.Text = "";
            txttenkh.Text = "";
            txtthanhtien.Text = "0";
            mskdienthoai.Text = "";
            cbomasach.Text = "";
            txttheloai.Text = "";
            txttg.Text = "";
            txtsotrang.Text = "";
            txtngonngu.Text = "";
            txtlinhvuc.Text = "";
            txtnxb.Text = "";
        }
        private void reset_ttsach()
        {
            cbomasach.Text = "";
            txttensach.Text = "";
            txttheloai.Text = "";
            txttg.Text = "";
            txtnxb.Text = "";
            txtlinhvuc.Text = "";
            txtsotrang.Text = "";
            txtngonngu.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";
            txtthanhtien.Text = "";
            txtgiamgia.Text = "";
        }
        private void cbomnv_TextChanged_1(object sender, EventArgs e)
        {
            string sql;
            if (cbomnv.Text == "")
            {
                txttnv.Text = "";
            }
            sql = "select tennv from tblnhanvien where manv = N'" + cbomnv.Text + "'";
            txttnv.Text = Class.Functions.GetFieldValues(sql);
        }

        private void cbomkh_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomkh.Text == "")
            {
                txttenkh.Text = "";
                txtdiachi.Text = "";
                mskdienthoai.Text = "";
            }

            // Khi kich chon Ma nhan vien thi ten nhan vien se tu dong hien ra 
            str = "Select tenkhach from tblkhachhang where makhach = N'" + cbomkh.Text + "'";
            txttenkh.Text = Class.Functions.GetFieldValues(str);
            str = "Select diachi from tblkhachhang where makhach = N'" + cbomkh.Text + "'";
            txtdiachi.Text = Class.Functions.GetFieldValues(str);
            str = "Select dienthoai from tblkhachhang where makhach = N'" + cbomkh.Text + "'";
            mskdienthoai.Text = Class.Functions.GetFieldValues(str);
        }

        private void cbomasach_TextChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = "0";
            txtthanhtien.Text = "0";
            txtgiamgia.Text = "0";
            string sql;
            if (cbomasach.Text == "")
            {
                txttensach.Text = "";
                txtdongia.Text = "0";
                txttheloai.Text = "";
                txttg.Text = "";
                txtnxb.Text = "";
                txtlinhvuc.Text = "";
                txtngonngu.Text = "";
                txtsoluong.Text = "";
            }
            sql = "select tensach from tblkhosach where masach = '" + cbomasach.Text + "'";
            txttensach.Text = Class.Functions.GetFieldValues(sql);
            sql = "select dongiaban from tblkhosach where masach = '" + cbomasach.Text + "'";
            txtdongia.Text = Class.Functions.GetFieldValues(sql);
            sql = "select tenloaisach from tblloaisach join tblkhosach on tblloaisach.maloaisach = tblkhosach.maloaisach where masach = N'" + cbomasach.Text + "'";
            txttheloai.Text = Class.Functions.GetFieldValues(sql);
            sql = "select tentg from tbltacgia join tblkhosach on tbltacgia.matg = tblkhosach.matg where masach = N'" + cbomasach.Text + "'";
            txttg.Text = Class.Functions.GetFieldValues(sql);
            sql = "select tennxb from tblnxb join tblkhosach on tblnxb.manxb = tblkhosach.manxb where masach = N'" + cbomasach.Text + "'";
            txtnxb.Text = Class.Functions.GetFieldValues(sql);
            sql = "select malinhvuc from tblkhosach where masach = N'" + cbomasach.Text + "'";
            txtlinhvuc.Text = Class.Functions.GetFieldValues(sql);
            sql = "select mangonngu from tblkhosach where masach = N'" + cbomasach.Text + "'";
            txtngonngu.Text = Class.Functions.GetFieldValues(sql);
            sql = "select sotrang from tblkhosach where masach = N'" + cbomasach.Text + "'";
            txtsotrang.Text = Class.Functions.GetFieldValues(sql);
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            double soluong, dongia, giamgia, thanhtien;
            if (txtsoluong.Text == "")
            {
                soluong = 0;
            }
            else
            {
                soluong = Convert.ToDouble(txtsoluong.Text);
            }
            if (txtdongia.Text == "")
            {
                dongia = 0;
            }
            else
            {
                dongia = Convert.ToDouble(txtdongia.Text);
            }
            if (txtgiamgia.Text == "")
            {
                giamgia = 0;
            }
            else
            {
                giamgia = Convert.ToDouble(txtgiamgia.Text);
            }
            thanhtien = soluong * dongia - soluong * dongia * giamgia / 100;

            txtthanhtien.Text = thanhtien.ToString();
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            double soluong, dongia, giamgia, thanhtien;
            if (txtsoluong.Text == "")
            {
                soluong = 0;
            }
            else
            {
                soluong = Convert.ToDouble(txtsoluong.Text);
            }
            if (txtdongia.Text == "")
            {
                dongia = 0;
            }
            else
            {
                dongia = Convert.ToDouble(txtdongia.Text);
            }
            if (txtgiamgia.Text == "")
            {
                giamgia = 0;
            }
            else
            {
                giamgia = Convert.ToDouble(txtgiamgia.Text);
            }
            thanhtien = soluong * dongia - soluong * dongia * giamgia / 100;

            txtthanhtien.Text = thanhtien.ToString();
        }
        private void btnthd_Click_1(object sender, EventArgs e)
        {
            btnhhd.Enabled = true;
            btnluu.Enabled = true;
            btninhoadon.Enabled = true;
            btnthd.Enabled = false;
            reset_data();
            txtsoluong.Text = "0";
            txtmhd.Text = Class.Functions.CreateKey("HDB");
            cbomnv.Enabled = true;
            cbomkh.Enabled = true;
            load_dtgv();
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, tongmoi;
            sql = "SELECT sohdban FROM tblhdban WHERE sohdban=N'" + txtmhd.Text + "'";
            if (!Class.Functions.CheckKey(sql))
            {
                if (cbomnv.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã nhân viên!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomnv.Focus();
                    return;
                }
                if (cbomkh.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mã khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbomkh.Focus();
                    return;
                }
                sql = "insert into tblhdban values(N'" + txtmhd.Text + "',N'" + cbomnv.Text + "','" + Class.Functions.ConvertDateTime(textBox1.Text) + "',N'" + cbomkh.Text + "'," + txttongtien.Text + ")";
                Class.Functions.RunSql(sql);
            }
            if (cbomasach.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mã sách!", "Thôngbáo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomasach.Focus();
                return;
            }
            if (txtsoluong.Text == "" || txtsoluong.Text =="0")
            {
                MessageBox.Show("Bạn phải nhập số lượng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtsoluong.Focus();
                return;
            }
            if (txtgiamgia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập thông tin khuyến mại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtgiamgia.Focus();
                return;
            }
            sql = "Select masach from tblchitiethdban where masach = '" + cbomasach.Text + "' and sohdban = '" + txtmhd.Text + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Bạn đã mua sách này!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                reset_ttsach();
                cbomasach.Focus();
                return;
            }
            sql = "select soluong from tblkhosach where masach = N'" + cbomasach.Text + "'";
            sl = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn: " + sl, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "insert into tblchitiethdban values(N'" + txtmhd.Text + "',N'" + cbomasach.Text + "'," + txtsoluong.Text + "," + txtgiamgia.Text + "," + txtthanhtien.Text + ")";
            Class.Functions.RunSql(sql);
            load_dtgv();
            SLcon = sl - Convert.ToDouble(txtsoluong.Text);
            sql = "Update tblkhosach  set soluong = " + SLcon + " where masach = N'" + cbomasach.Text + "'";
            Class.Functions.RunSql(sql);
            sql = "select tongtien from tblhdban where  sohdban = '" + txtmhd.Text + "'";
            tong = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            sql = "Update  tblhdban set tongtien = " + tongmoi + " Where sohdban = N'" + txtmhd.Text + "'";
            Class.Functions.RunSql(sql);
            txttongtien.Text = Convert.ToString(tongmoi);
            txtbangchu.Text = Class.Functions.ChuyenSoSangChu(tongmoi.ToString());
            reset_ttsach();
            btnluu.Enabled = true;
            btnthd.Enabled = true;
            btninhoadon.Enabled = true;
            btnhhd.Enabled = true;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đóng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void updatesoluong_sach(string sohoadon, string masach)
        {
            double s, sl, slcon;
            string sql;
            sql = "select soluongban from tblchitiethdban where masach = '" + masach + "'";
            s = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            sql = "select soluong from tblkhosach where masach = '" + masach + "'";
            sl = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            slcon = s + sl;
            sql = "Delete tblchitiethdban where sohdban = '" + sohoadon + "' and masach = '" + masach + "'";
            Class.Functions.RunSqlDel(sql);
            sql = "Update tblkhosach set soluong = " + slcon + " where masach = '" + masach + "'";
            Class.Functions.RunSql(sql);
        }
        private void updatetongtien(string sohoadon, double thanhtien)
        {
            double tong, tongmoi;
            string sql;
            sql = "select tongtien from tblhdban where sohdban = '" + sohoadon + "'";
            tong = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            tongmoi = tong - thanhtien;
            sql = "update tblhdban set tongtien =" + tongmoi + "where sohdban = '" + sohoadon + "'";
            Class.Functions.RunSql(sql);
            txttongtien.Text = tongmoi.ToString();
            txtbangchu.Text = Class.Functions.ChuyenSoSangChu(tongmoi.ToString());
        }
        private void btnhhd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string[] masach = new string[50];
                string sql;
                int n = 0;
                sql = "select masach from tblchitiethdban where sohdban = '" + txtmhd.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, Class.Functions.Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    masach[n] = reader.GetString(0).ToString();
                    n = n + 1;
                }
                reader.Close();
                for (int i = 0; i < n; i++)
                {
                    updatesoluong_sach(txtmhd.Text, masach[i]);
                }
                sql = "delete tblhdban where sohdban = '" + txtmhd.Text + "'";
                Class.Functions.RunSqlDel(sql);
                reset_data();
                load_dtgv();
                btnhhd.Enabled = false;
                btninhoadon.Enabled = false;
                btnthd.Enabled = true;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            cbomkh.Enabled = false;
            if (cbomahoadon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbomahoadon.Focus();
                return;
            }
            txtmhd.Text = cbomahoadon.Text;
            load_thongtin();
            load_dtgv();

            btnhhd.Enabled = true;
            btnluu.Enabled = true;
            btninhoadon.Enabled = true;
            cbomahoadon.SelectedIndex = -1;
            btnthd.Enabled = true;
            cbomnv.Enabled = false;

        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook;
            COMExcel.Worksheet exSheet;
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinSach;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A1:B1"].Value = "Shop Yêu Sách";

            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A2:C2"].Value = "Chùa Bộc - Đống Đa - Hà Nội";

            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0983776927";

            exRange.Range["C5:F5"].Font.Size = 16;
            exRange.Range["C5:F5"].Font.Name = "Times new roman";
            exRange.Range["C5:F5"].Font.Bold = true;
            exRange.Range["C5:F5"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["C5:F5"].MergeCells = true;
            exRange.Range["C5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C5:F5"].Value = "HÓA ĐƠN BÁN SÁCH";

            // Biểu diễn thông tin chung của hóa đơn bán
            sql = "SELECT a.sohdban, a.Ngayban, a.Tongtien, b.Tenkhach, b.Diachi, b.Dienthoai, c.Tennv FROM tblHDBan AS a, tblKhachhang AS b, tblNhanvien AS c WHERE a.soHDBan = N'" + txtmhd.Text + "' AND a.Makhach = b.Makhach AND a.Manv = c.Manv";
            tblThongtinHD = Class.Functions.GetDatatoTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:C9"].Font.Name = "Times new roman";
            exRange.Range["B6:B6"].Value = "Số hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongtinHD.Rows[0][5].ToString();
            // Lấy thông tin các mặt hàng
            sql = "SELECT b.Tensach, c.tentg, d.tennxb, b.Dongiaban, a.Soluongban,  a.khuyenmai, a.Thanhtien FROM tblChitietHDBan AS a , tblkhosach AS b, tbltacgia AS c, tblnxb as d WHERE a.soHDBan = N'" + txtmhd.Text + "' AND a.Masach = b.Masach" + " And b.matg = c.matg And b.manxb = d.manxb ";
            tblThongtinSach = Class.Functions.GetDatatoTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:K11"].Font.Bold = true;
            exRange.Range["A11:K11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["B11:C11"].ColumnWidth = 18;
            exRange.Range["D11:K11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên Sách";
            exRange.Range["C11:C11"].Value = "Tác giả";
            exRange.Range["D11:D11"].Value = "Nhà xuất bản";
            exRange.Range["E11:E11"].Value = "Đơn giá";
            exRange.Range["F11:F11"].Value = "Số lượng";
            exRange.Range["G11:G11"].Value = "Khuyến mại";
            exRange.Range["H11:H11"].Value = "Thành tiền";
            for (hang = 0; hang <= tblThongtinSach.Rows.Count - 1; hang++)
            {
                // Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinSach.Columns.Count - 1;
                cot++)
                    //    Điền thông tin hàng từ cột thứ 2, dòng 12
                    exSheet.Cells[cot + 2][hang + 12] =
                   tblThongtinSach.Rows[hang][cot].ToString();
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:H1"].MergeCells = true;
            exRange.Range["A1:H1"].Font.Bold = true;
            exRange.Range["A1:H1"].Font.Italic = true;
            exRange.Range["A1:H1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange.Range["A1:H1"].Value = "Bằng chữ: " + Class.Functions.ChuyenSoSangChu(tblThongtinHD.Rows[0][2].ToString());
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment =
            COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string masach;
            double thanhtien;
            if (tblhdb.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                masach = dtgv.CurrentRow.Cells["masach"].Value.ToString();
                capnhatlaihang(txtmhd.Text, masach);
                thanhtien = Convert.ToDouble(dtgv.CurrentRow.Cells["thanhtien"].Value.ToString());
                capnhatlaitongtien(txtmhd.Text, thanhtien);
                load_dtgv();
            }

        }
        private void capnhatlaihang(string mahoadon, string masach)
        {
            double s, sl, slcon;
            string sql;
            sql = "select soluongban from tblchitiethdban where masach = '" + masach + "'";
            s = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            sql = "select soluong from tblkhosach where masach = '" + masach + "'";
            sl = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            slcon = s + sl;
            sql = "Delete tblchitiethdban where sohdban = '" + mahoadon + "' and masach = '" + masach + "'";
            Class.Functions.RunSqlDel(sql);
            sql = "Update tblkhosach set soluong = " + slcon + " where masach = '" + masach + "'";
            Class.Functions.RunSql(sql);
        }
        private void capnhatlaitongtien(string mahoadon, double thanhtien)
        {
            double tong, tongmoi;
            string sql;
            sql = "select tongtien from tblhdban where sohdban = '" + mahoadon + "'";
            tong = Convert.ToDouble(Class.Functions.GetFieldValues(sql));
            tongmoi = tong - thanhtien;
            sql = "update tblhdban set tongtien =" + tongmoi + "where sohdban = '" + mahoadon + "'";
            Class.Functions.RunSql(sql);
            txttongtien.Text = tongmoi.ToString();
            txtbangchu.Text = Class.Functions.ChuyenSoSangChu(tongmoi.ToString());
        }
    }
}