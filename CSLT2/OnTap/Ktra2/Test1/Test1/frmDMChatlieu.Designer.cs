
namespace Test1
{
    partial class frmDMChatlieu
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
            this.lblMachatlieu = new System.Windows.Forms.Label();
            this.lblTenchatlieu = new System.Windows.Forms.Label();
            this.txtMachatlieu = new System.Windows.Forms.TextBox();
            this.txtTenchatlieu = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblDMCL = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMachatlieu
            // 
            this.lblMachatlieu.AutoSize = true;
            this.lblMachatlieu.Location = new System.Drawing.Point(62, 88);
            this.lblMachatlieu.Name = "lblMachatlieu";
            this.lblMachatlieu.Size = new System.Drawing.Size(65, 13);
            this.lblMachatlieu.TabIndex = 0;
            this.lblMachatlieu.Text = "Mã chất liệu";
            // 
            // lblTenchatlieu
            // 
            this.lblTenchatlieu.AutoSize = true;
            this.lblTenchatlieu.Location = new System.Drawing.Point(62, 130);
            this.lblTenchatlieu.Name = "lblTenchatlieu";
            this.lblTenchatlieu.Size = new System.Drawing.Size(69, 13);
            this.lblTenchatlieu.TabIndex = 1;
            this.lblTenchatlieu.Text = "Tên chất liệu";
            // 
            // txtMachatlieu
            // 
            this.txtMachatlieu.Location = new System.Drawing.Point(145, 81);
            this.txtMachatlieu.Name = "txtMachatlieu";
            this.txtMachatlieu.Size = new System.Drawing.Size(217, 20);
            this.txtMachatlieu.TabIndex = 2;
            // 
            // txtTenchatlieu
            // 
            this.txtTenchatlieu.Location = new System.Drawing.Point(145, 123);
            this.txtTenchatlieu.Name = "txtTenchatlieu";
            this.txtTenchatlieu.Size = new System.Drawing.Size(217, 20);
            this.txtTenchatlieu.TabIndex = 3;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(65, 163);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(680, 221);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // lblDMCL
            // 
            this.lblDMCL.AutoSize = true;
            this.lblDMCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDMCL.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblDMCL.Location = new System.Drawing.Point(249, 23);
            this.lblDMCL.Name = "lblDMCL";
            this.lblDMCL.Size = new System.Drawing.Size(287, 29);
            this.lblDMCL.TabIndex = 5;
            this.lblDMCL.Text = "DANH MỤC CHẤT LIỆU";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(65, 402);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(182, 402);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(307, 402);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(437, 402);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(556, 402);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 10;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(670, 402);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmDMChatlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblDMCL);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txtTenchatlieu);
            this.Controls.Add(this.txtMachatlieu);
            this.Controls.Add(this.lblTenchatlieu);
            this.Controls.Add(this.lblMachatlieu);
            this.Name = "frmDMChatlieu";
            this.Text = "Danh mục chất liệu";
            this.Load += new System.EventHandler(this.frmDMChatlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMachatlieu;
        private System.Windows.Forms.Label lblTenchatlieu;
        private System.Windows.Forms.TextBox txtMachatlieu;
        private System.Windows.Forms.TextBox txtTenchatlieu;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblDMCL;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnDong;
    }
}