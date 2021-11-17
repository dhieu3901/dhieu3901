
namespace bai_13
{
    partial class frmBai7
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
            this.btnThuchien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMahang = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.rd10 = new System.Windows.Forms.RadioButton();
            this.chkGiamgia = new System.Windows.Forms.CheckBox();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThuchien
            // 
            this.btnThuchien.Location = new System.Drawing.Point(241, 118);
            this.btnThuchien.Name = "btnThuchien";
            this.btnThuchien.Size = new System.Drawing.Size(94, 33);
            this.btnThuchien.TabIndex = 0;
            this.btnThuchien.Text = "Thực hiện";
            this.btnThuchien.UseVisualStyleBackColor = true;
            this.btnThuchien.Click += new System.EventHandler(this.btnThuchien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(488, 118);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 33);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblMahang
            // 
            this.lblMahang.AutoSize = true;
            this.lblMahang.Location = new System.Drawing.Point(39, 35);
            this.lblMahang.Name = "lblMahang";
            this.lblMahang.Size = new System.Drawing.Size(63, 17);
            this.lblMahang.TabIndex = 2;
            this.lblMahang.Text = "Mã hàng";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(39, 82);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(57, 17);
            this.lblDongia.TabIndex = 3;
            this.lblDongia.Text = "Đơn giá";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Location = new System.Drawing.Point(39, 128);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(64, 17);
            this.lblSoluong.TabIndex = 4;
            this.lblSoluong.Text = "Số lượng";
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(249, 37);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(68, 17);
            this.lblTongtien.TabIndex = 5;
            this.lblTongtien.Text = "Tổng tiền";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(114, 123);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(100, 22);
            this.txtSoluong.TabIndex = 6;
            this.txtSoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluong_KeyPress);
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(114, 77);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(100, 22);
            this.txtDongia.TabIndex = 7;
            this.txtDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDongia_KeyPress);
            // 
            // txtMahang
            // 
            this.txtMahang.Location = new System.Drawing.Point(114, 32);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(100, 22);
            this.txtMahang.TabIndex = 8;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(346, 32);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(125, 22);
            this.txtTongtien.TabIndex = 9;
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(364, 76);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(49, 21);
            this.rd5.TabIndex = 10;
            this.rd5.TabStop = true;
            this.rd5.Text = "5%";
            this.rd5.UseVisualStyleBackColor = true;
            this.rd5.CheckedChanged += new System.EventHandler(this.rd5_CheckedChanged);
            // 
            // rd10
            // 
            this.rd10.AutoSize = true;
            this.rd10.Location = new System.Drawing.Point(454, 76);
            this.rd10.Name = "rd10";
            this.rd10.Size = new System.Drawing.Size(57, 21);
            this.rd10.TabIndex = 11;
            this.rd10.TabStop = true;
            this.rd10.Text = "10%";
            this.rd10.UseVisualStyleBackColor = true;
            this.rd10.CheckedChanged += new System.EventHandler(this.rd10_CheckedChanged);
            // 
            // chkGiamgia
            // 
            this.chkGiamgia.AutoSize = true;
            this.chkGiamgia.Location = new System.Drawing.Point(250, 77);
            this.chkGiamgia.Name = "chkGiamgia";
            this.chkGiamgia.Size = new System.Drawing.Size(86, 21);
            this.chkGiamgia.TabIndex = 12;
            this.chkGiamgia.Text = "Giảm giá";
            this.chkGiamgia.UseVisualStyleBackColor = true;
            this.chkGiamgia.Click += new System.EventHandler(this.chkGiamgia_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Location = new System.Drawing.Point(364, 118);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(94, 33);
            this.btnLamlai.TabIndex = 13;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 190);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.chkGiamgia);
            this.Controls.Add(this.rd10);
            this.Controls.Add(this.rd5);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.lblTongtien);
            this.Controls.Add(this.lblSoluong);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.lblMahang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThuchien);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThuchien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMahang;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.RadioButton rd10;
        private System.Windows.Forms.CheckBox chkGiamgia;
        private System.Windows.Forms.Button btnLamlai;
    }
}

