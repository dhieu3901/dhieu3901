using System;
using System.Windows.Forms;

namespace bai_13
{
    public partial class frmBai13 : Form
    {
        public frmBai13()
        {
            InitializeComponent();
        }

        string phuong, hinh="";
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (e.KeyChar == ',') || (e.KeyChar == '.'))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            if(txtTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if(chkDienthoai.Checked == false && chkEmail.Checked == false && chkFax.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn hình thức liên lạc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (rdSec.Checked == false && rdThetinDung.Checked == false && rdTienmat.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn phương thức thanh toán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string hangmua = "";
            for( int i = 0 ;i < lstDamua.Items.Count ; i++ )
            {
                hangmua = hangmua + lstDamua.Items[i] + ", ";
            }
            if(MessageBox.Show("Họ tên khách: "+txtTen.Text + "\n"+"Địa chỉ: "+txtDiachi.Text +"\n"+"Hàng đặt mua: "+hangmua+"\n"+"Phương thức thanh toán: "+phuong+"\n"+"Hình thức liên lạc: "+hinh,"Danh sách đã mua",MessageBoxButtons.OK,MessageBoxIcon.Information)==System.Windows.Forms.DialogResult.OK)
            {
                txtTen.Text = "";
                txtDiachi.Text = "";
                rdSec.Checked = false;
                rdThetinDung.Checked = false;
                rdTienmat.Checked = false;
                chkDienthoai.Checked = false;
                chkEmail.Checked = false;
                chkFax.Checked = false;
                lstDamua.Items.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstMathang.Items.Add("Kỹ năng lập trình Visual Basic 6.0");
            lstMathang.Items.Add("Tự học ASP trong 21 ngày");
            lstMathang.Items.Add("Tự học PHP & My SQL  trong 21 ngày");
            lstMathang.Items.Add("Bài tập Visual Basic 6.0");
            lstMathang.Items.Add("Tin học căn bản");
            lstMathang.Items.Add("Đến với Word 2000");
            lstMathang.Items.Add("Đến với Excel 2000");
            lstMathang.Items.Add("Bài tập C cơ bản và nâng cao");
            lstMathang.Items.Add("SQL server");
        }



private void rdTienmat_CheckedChanged(object sender, EventArgs e)
        {
            phuong = rdTienmat.Text;
        }

        private void rdSec_CheckedChanged(object sender, EventArgs e)
        {
            phuong = rdSec.Text;
        }

        private void rdThetinDung_CheckedChanged(object sender, EventArgs e)
        {
            phuong = rdThetinDung.Text;
        }

        private void chkDienthoai_CheckedChanged(object sender, EventArgs e)
        {
            hinh = hinh + chkDienthoai.Text + ", ";
        }

        private void chkFax_CheckedChanged(object sender, EventArgs e)
        {
            hinh = hinh + chkFax.Text + ", ";
        }

        private void chkEmail_CheckedChanged(object sender, EventArgs e)
        {
            hinh = hinh + chkEmail.Text + ", ";
        }

        private void lstMathang_DoubleClick(object sender, EventArgs e)
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            int d = 0;
            for (int i = 0; i < lstDamua.Items.Count; i++)
            {
                if (lstMathang.SelectedItem == lstDamua.Items[i])
                {
                    d = d + 1;
                    break;
                }
            }
            if (d == 0)
            {
                lstDamua.Items.Add(lstMathang.SelectedItem);
            }
            else
            {
                MessageBox.Show("Bạn đã chọn sách" + lstMathang.SelectedItem, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void lstDamua_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa sách" + lstDamua.SelectedItem, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==System.Windows.Forms.DialogResult.Yes)
            {
                lstDamua.Items.Remove(lstDamua.SelectedItem);
            }
        }
    }
}






