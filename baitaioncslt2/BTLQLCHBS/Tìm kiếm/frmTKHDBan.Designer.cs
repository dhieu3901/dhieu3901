
namespace BTLQLCHBS
{
    partial class frmTKHDBan
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
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(135, 86);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(177, 22);
            this.txtMaHDBan.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã khách hàng:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(593, 124);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(177, 22);
            this.txtTongtien.TabIndex = 39;
            this.txtTongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongtien_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(466, 129);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "Tổng tiền:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(516, 506);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(97, 43);
            this.btnDong.TabIndex = 40;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(200, 506);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 43);
            this.btnTimkiem.TabIndex = 41;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(135, 161);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(177, 22);
            this.txtManhanvien.TabIndex = 42;
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(593, 85);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(177, 22);
            this.txtMakhach.TabIndex = 43;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(135, 126);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(53, 22);
            this.txtThang.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tháng";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(259, 124);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(53, 22);
            this.txtNam.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Năm";
            // 
            // btnTimlai
            // 
            this.btnTimlai.Location = new System.Drawing.Point(358, 506);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(97, 43);
            this.btnTimlai.TabIndex = 48;
            this.btnTimlai.Text = "Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 470);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(320, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "Kích đúp một hóa đơn để hiển thị thông tin chi tiết";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(32, 202);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(738, 253);
            this.DataGridView.TabIndex = 50;
            this.DataGridView.DoubleClick += new System.EventHandler(this.DataGridView_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("VDBrevia Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(540, 44);
            this.label5.TabIndex = 51;
            this.label5.Text = "TÌM KIẾM HÓA ĐƠN BÁN SÁCH ";
            // 
            // frmTKHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHDBan);
            this.Controls.Add(this.label1);
            this.Name = "frmTKHDBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TIM HOA DON BAN";
            this.Load += new System.EventHandler(this.frmTimHDBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView DataGridView;
        public System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label label5;
    }
}