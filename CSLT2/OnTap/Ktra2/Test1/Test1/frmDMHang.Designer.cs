
namespace Test1
{
    partial class frmDMHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDMHH = new System.Windows.Forms.Label();
            this.lblMahang = new System.Windows.Forms.Label();
            this.lblTenhang = new System.Windows.Forms.Label();
            this.lblMachatlieu = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblDongianhap = new System.Windows.Forms.Label();
            this.lblDongiaban = new System.Windows.Forms.Label();
            this.lblAnh = new System.Windows.Forms.Label();
            this.lblGhichu = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTenhang = new System.Windows.Forms.TextBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.txtDongiaban = new System.Windows.Forms.TextBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.cboMachatlieu = new System.Windows.Forms.ComboBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDMHH
            // 
            this.lblDMHH.AutoSize = true;
            this.lblDMHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMHH.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDMHH.Location = new System.Drawing.Point(249, 9);
            this.lblDMHH.Name = "lblDMHH";
            this.lblDMHH.Size = new System.Drawing.Size(259, 25);
            this.lblDMHH.TabIndex = 0;
            this.lblDMHH.Text = "DANH MỤC HÀNG HÓA";
            // 
            // lblMahang
            // 
            this.lblMahang.AutoSize = true;
            this.lblMahang.Location = new System.Drawing.Point(34, 58);
            this.lblMahang.Name = "lblMahang";
            this.lblMahang.Size = new System.Drawing.Size(49, 13);
            this.lblMahang.TabIndex = 1;
            this.lblMahang.Text = "Mã hàng";
            // 
            // lblTenhang
            // 
            this.lblTenhang.AutoSize = true;
            this.lblTenhang.Location = new System.Drawing.Point(34, 94);
            this.lblTenhang.Name = "lblTenhang";
            this.lblTenhang.Size = new System.Drawing.Size(53, 13);
            this.lblTenhang.TabIndex = 2;
            this.lblTenhang.Text = "Tên hàng";
            // 
            // lblMachatlieu
            // 
            this.lblMachatlieu.AutoSize = true;
            this.lblMachatlieu.Location = new System.Drawing.Point(34, 129);
            this.lblMachatlieu.Name = "lblMachatlieu";
            this.lblMachatlieu.Size = new System.Drawing.Size(65, 13);
            this.lblMachatlieu.TabIndex = 3;
            this.lblMachatlieu.Text = "Mã chất liệu";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(34, 160);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(52, 13);
            this.lblSoluong.TabIndex = 4;
            this.lblSoluong.Text = "Số  lượng";
            // 
            // lblDongianhap
            // 
            this.lblDongianhap.AutoSize = true;
            this.lblDongianhap.Location = new System.Drawing.Point(34, 188);
            this.lblDongianhap.Name = "lblDongianhap";
            this.lblDongianhap.Size = new System.Drawing.Size(71, 13);
            this.lblDongianhap.TabIndex = 5;
            this.lblDongianhap.Text = "Đơn giá nhập";
            // 
            // lblDongiaban
            // 
            this.lblDongiaban.AutoSize = true;
            this.lblDongiaban.Location = new System.Drawing.Point(34, 216);
            this.lblDongiaban.Name = "lblDongiaban";
            this.lblDongiaban.Size = new System.Drawing.Size(65, 13);
            this.lblDongiaban.TabIndex = 6;
            this.lblDongiaban.Text = "Đơn giá bán";
            // 
            // lblAnh
            // 
            this.lblAnh.AutoSize = true;
            this.lblAnh.Location = new System.Drawing.Point(358, 58);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(26, 13);
            this.lblAnh.TabIndex = 7;
            this.lblAnh.Text = "Ảnh";
            // 
            // lblGhichu
            // 
            this.lblGhichu.AutoSize = true;
            this.lblGhichu.Location = new System.Drawing.Point(358, 129);
            this.lblGhichu.Name = "lblGhichu";
            this.lblGhichu.Size = new System.Drawing.Size(44, 13);
            this.lblGhichu.TabIndex = 8;
            this.lblGhichu.Text = "Ghi chú";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(37, 241);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(732, 168);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(37, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(128, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(228, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(318, 415);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(410, 415);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 14;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(506, 415);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(598, 415);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 16;
            this.btnHienthi.Text = "Hiển thị DS";
            this.btnHienthi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(694, 415);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 17;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(111, 58);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(168, 20);
            this.txtMahang.TabIndex = 18;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(111, 153);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(168, 20);
            this.txtSoluong.TabIndex = 19;
            // 
            // txtTenhang
            // 
            this.txtTenhang.Location = new System.Drawing.Point(111, 91);
            this.txtTenhang.Name = "txtTenhang";
            this.txtTenhang.Size = new System.Drawing.Size(168, 20);
            this.txtTenhang.TabIndex = 20;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Location = new System.Drawing.Point(111, 181);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(168, 20);
            this.txtDongianhap.TabIndex = 21;
            // 
            // txtDongiaban
            // 
            this.txtDongiaban.Location = new System.Drawing.Point(111, 209);
            this.txtDongiaban.Name = "txtDongiaban";
            this.txtDongiaban.Size = new System.Drawing.Size(168, 20);
            this.txtDongiaban.TabIndex = 22;
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(417, 51);
            this.txtAnh.MaximumSize = new System.Drawing.Size(500, 500);
            this.txtAnh.MinimumSize = new System.Drawing.Size(100, 5);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(133, 20);
            this.txtAnh.TabIndex = 23;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(417, 122);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(200, 20);
            this.txtGhichu.TabIndex = 24;
            // 
            // cboMachatlieu
            // 
            this.cboMachatlieu.FormattingEnabled = true;
            this.cboMachatlieu.Location = new System.Drawing.Point(111, 121);
            this.cboMachatlieu.Name = "cboMachatlieu";
            this.cboMachatlieu.Size = new System.Drawing.Size(168, 21);
            this.cboMachatlieu.TabIndex = 25;
            this.cboMachatlieu.SelectedIndexChanged += new System.EventHandler(this.cboMachatlieu_SelectedIndexChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(568, 49);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(49, 22);
            this.btnOpen.TabIndex = 26;
            this.btnOpen.Text = "Mở";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // picAnh
            // 
            this.picAnh.Location = new System.Drawing.Point(623, 49);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(171, 122);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 27;
            this.picAnh.TabStop = false;
            // 
            // frmDMHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cboMachatlieu);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.txtDongiaban);
            this.Controls.Add(this.txtDongianhap);
            this.Controls.Add(this.txtTenhang);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblGhichu);
            this.Controls.Add(this.lblAnh);
            this.Controls.Add(this.lblDongiaban);
            this.Controls.Add(this.lblDongianhap);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblMachatlieu);
            this.Controls.Add(this.lblTenhang);
            this.Controls.Add(this.lblMahang);
            this.Controls.Add(this.lblDMHH);
            this.Name = "frmDMHang";
            this.Text = "Danh mục hàng hoá";
            this.Load += new System.EventHandler(this.frmDMHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMHH;
        private System.Windows.Forms.Label lblMahang;
        private System.Windows.Forms.Label lblTenhang;
        private System.Windows.Forms.Label lblMachatlieu;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblDongianhap;
        private System.Windows.Forms.Label lblDongiaban;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.Label lblGhichu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTenhang;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.TextBox txtDongiaban;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.ComboBox cboMachatlieu;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox picAnh;
    }
}