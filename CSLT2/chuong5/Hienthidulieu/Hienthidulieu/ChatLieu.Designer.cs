
namespace Hienthidulieu
{
    partial class ChatLieu
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
            this.lblMacl = new System.Windows.Forms.Label();
            this.lblTencl = new System.Windows.Forms.Label();
            this.txtMacl = new System.Windows.Forms.TextBox();
            this.txtTencl = new System.Windows.Forms.TextBox();
            this.dataGridviewChatLieu = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMacl
            // 
            this.lblMacl.AutoSize = true;
            this.lblMacl.Location = new System.Drawing.Point(111, 85);
            this.lblMacl.Name = "lblMacl";
            this.lblMacl.Size = new System.Drawing.Size(65, 13);
            this.lblMacl.TabIndex = 0;
            this.lblMacl.Text = "Mã chất liệu";
            // 
            // lblTencl
            // 
            this.lblTencl.AutoSize = true;
            this.lblTencl.Location = new System.Drawing.Point(111, 157);
            this.lblTencl.Name = "lblTencl";
            this.lblTencl.Size = new System.Drawing.Size(69, 13);
            this.lblTencl.TabIndex = 1;
            this.lblTencl.Text = "Tên chất liệu";
            // 
            // txtMacl
            // 
            this.txtMacl.Location = new System.Drawing.Point(237, 78);
            this.txtMacl.Name = "txtMacl";
            this.txtMacl.Size = new System.Drawing.Size(148, 20);
            this.txtMacl.TabIndex = 2;
            // 
            // txtTencl
            // 
            this.txtTencl.Location = new System.Drawing.Point(237, 150);
            this.txtTencl.Name = "txtTencl";
            this.txtTencl.Size = new System.Drawing.Size(148, 20);
            this.txtTencl.TabIndex = 3;
            // 
            // dataGridviewChatLieu
            // 
            this.dataGridviewChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridviewChatLieu.Location = new System.Drawing.Point(170, 241);
            this.dataGridviewChatLieu.Name = "dataGridviewChatLieu";
            this.dataGridviewChatLieu.Size = new System.Drawing.Size(385, 109);
            this.dataGridviewChatLieu.TabIndex = 4;
            this.dataGridviewChatLieu.Click += new System.EventHandler(this.Datagridview_click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(198, 389);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(388, 389);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(296, 389);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(573, 389);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(427, 148);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(480, 389);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 10;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(101, 389);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridviewChatLieu);
            this.Controls.Add(this.txtTencl);
            this.Controls.Add(this.txtMacl);
            this.Controls.Add(this.lblTencl);
            this.Controls.Add(this.lblMacl);
            this.Name = "ChatLieu";
            this.Text = "ChatLieu";
            this.Load += new System.EventHandler(this.ChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridviewChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMacl;
        private System.Windows.Forms.Label lblTencl;
        private System.Windows.Forms.TextBox txtMacl;
        private System.Windows.Forms.TextBox txtTencl;
        private System.Windows.Forms.DataGridView dataGridviewChatLieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
    }
}