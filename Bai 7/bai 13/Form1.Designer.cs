
namespace bai_13
{
    partial class frmBai13
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
            this.lstMathang = new System.Windows.Forms.ListBox();
            this.lstDamua = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdThetinDung = new System.Windows.Forms.RadioButton();
            this.rdSec = new System.Windows.Forms.RadioButton();
            this.rdTienmat = new System.Windows.Forms.RadioButton();
            this.grbHinhthuc = new System.Windows.Forms.GroupBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkFax = new System.Windows.Forms.CheckBox();
            this.chkDienthoai = new System.Windows.Forms.CheckBox();
            this.btnDongy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grbHinhthuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMathang
            // 
            this.lstMathang.FormattingEnabled = true;
            this.lstMathang.ItemHeight = 16;
            this.lstMathang.Location = new System.Drawing.Point(25, 110);
            this.lstMathang.Name = "lstMathang";
            this.lstMathang.Size = new System.Drawing.Size(253, 116);
            this.lstMathang.TabIndex = 0;
            this.lstMathang.DoubleClick += new System.EventHandler(this.lstMathang_DoubleClick);
            // 
            // lstDamua
            // 
            this.lstDamua.FormattingEnabled = true;
            this.lstDamua.ItemHeight = 16;
            this.lstDamua.Location = new System.Drawing.Point(312, 110);
            this.lstDamua.Name = "lstDamua";
            this.lstDamua.Size = new System.Drawing.Size(253, 116);
            this.lstDamua.TabIndex = 1;
            this.lstDamua.DoubleClick += new System.EventHandler(this.lstDamua_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdThetinDung);
            this.groupBox1.Controls.Add(this.rdSec);
            this.groupBox1.Controls.Add(this.rdTienmat);
            this.groupBox1.Location = new System.Drawing.Point(57, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // rdThetinDung
            // 
            this.rdThetinDung.AutoSize = true;
            this.rdThetinDung.Location = new System.Drawing.Point(11, 73);
            this.rdThetinDung.Name = "rdThetinDung";
            this.rdThetinDung.Size = new System.Drawing.Size(109, 21);
            this.rdThetinDung.TabIndex = 2;
            this.rdThetinDung.TabStop = true;
            this.rdThetinDung.Text = "Thẻ tín dụng";
            this.rdThetinDung.UseVisualStyleBackColor = true;
            this.rdThetinDung.CheckedChanged += new System.EventHandler(this.rdThetinDung_CheckedChanged);
            // 
            // rdSec
            // 
            this.rdSec.AutoSize = true;
            this.rdSec.Location = new System.Drawing.Point(11, 48);
            this.rdSec.Name = "rdSec";
            this.rdSec.Size = new System.Drawing.Size(53, 21);
            this.rdSec.TabIndex = 1;
            this.rdSec.TabStop = true;
            this.rdSec.Text = "Séc";
            this.rdSec.UseVisualStyleBackColor = true;
            this.rdSec.CheckedChanged += new System.EventHandler(this.rdSec_CheckedChanged);
            // 
            // rdTienmat
            // 
            this.rdTienmat.AutoSize = true;
            this.rdTienmat.Location = new System.Drawing.Point(11, 21);
            this.rdTienmat.Name = "rdTienmat";
            this.rdTienmat.Size = new System.Drawing.Size(84, 21);
            this.rdTienmat.TabIndex = 0;
            this.rdTienmat.TabStop = true;
            this.rdTienmat.Text = "Tiền mặt";
            this.rdTienmat.UseVisualStyleBackColor = true;
            this.rdTienmat.CheckedChanged += new System.EventHandler(this.rdTienmat_CheckedChanged);
            // 
            // grbHinhthuc
            // 
            this.grbHinhthuc.Controls.Add(this.chkEmail);
            this.grbHinhthuc.Controls.Add(this.chkFax);
            this.grbHinhthuc.Controls.Add(this.chkDienthoai);
            this.grbHinhthuc.Location = new System.Drawing.Point(349, 240);
            this.grbHinhthuc.Name = "grbHinhthuc";
            this.grbHinhthuc.Size = new System.Drawing.Size(178, 100);
            this.grbHinhthuc.TabIndex = 0;
            this.grbHinhthuc.TabStop = false;
            this.grbHinhthuc.Text = "Hình thức liên lạc";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(15, 76);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(64, 21);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkEmail_CheckedChanged);
            // 
            // chkFax
            // 
            this.chkFax.AutoSize = true;
            this.chkFax.Location = new System.Drawing.Point(15, 48);
            this.chkFax.Name = "chkFax";
            this.chkFax.Size = new System.Drawing.Size(52, 21);
            this.chkFax.TabIndex = 1;
            this.chkFax.Text = "Fax";
            this.chkFax.UseVisualStyleBackColor = true;
            this.chkFax.CheckedChanged += new System.EventHandler(this.chkFax_CheckedChanged);
            // 
            // chkDienthoai
            // 
            this.chkDienthoai.AutoSize = true;
            this.chkDienthoai.Location = new System.Drawing.Point(15, 24);
            this.chkDienthoai.Name = "chkDienthoai";
            this.chkDienthoai.Size = new System.Drawing.Size(94, 21);
            this.chkDienthoai.TabIndex = 0;
            this.chkDienthoai.Text = "Điện thoại";
            this.chkDienthoai.UseVisualStyleBackColor = true;
            this.chkDienthoai.CheckedChanged += new System.EventHandler(this.chkDienthoai_CheckedChanged);
            // 
            // btnDongy
            // 
            this.btnDongy.Location = new System.Drawing.Point(102, 365);
            this.btnDongy.Name = "btnDongy";
            this.btnDongy.Size = new System.Drawing.Size(75, 23);
            this.btnDongy.TabIndex = 3;
            this.btnDongy.Text = "Đồng ý";
            this.btnDongy.UseVisualStyleBackColor = true;
            this.btnDongy.Click += new System.EventHandler(this.btnDongy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(393, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ tên khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Danh sách các mặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hàng đặt mua";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(125, 29);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(125, 22);
            this.txtTen.TabIndex = 9;
            this.txtTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTen_KeyPress);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(364, 26);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(143, 41);
            this.txtDiachi.TabIndex = 10;
            // 
            // frmBai13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 411);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbHinhthuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstDamua);
            this.Controls.Add(this.lstMathang);
            this.Name = "frmBai13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 13";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbHinhthuc.ResumeLayout(false);
            this.grbHinhthuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMathang;
        private System.Windows.Forms.ListBox lstDamua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdThetinDung;
        private System.Windows.Forms.RadioButton rdSec;
        private System.Windows.Forms.RadioButton rdTienmat;
        private System.Windows.Forms.GroupBox grbHinhthuc;
        private System.Windows.Forms.Button btnDongy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkFax;
        private System.Windows.Forms.CheckBox chkDienthoai;
    }
}

