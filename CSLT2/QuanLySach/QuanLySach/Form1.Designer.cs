
namespace QuanLySach
{
    partial class QuanLySach
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
            this.lblMasach = new System.Windows.Forms.Label();
            this.lblTacgia = new System.Windows.Forms.Label();
            this.lblTensach = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMasach
            // 
            this.lblMasach.AutoSize = true;
            this.lblMasach.Location = new System.Drawing.Point(65, 24);
            this.lblMasach.Name = "lblMasach";
            this.lblMasach.Size = new System.Drawing.Size(48, 13);
            this.lblMasach.TabIndex = 0;
            this.lblMasach.Text = "Mã sách";
            // 
            // lblTacgia
            // 
            this.lblTacgia.AutoSize = true;
            this.lblTacgia.Location = new System.Drawing.Point(65, 75);
            this.lblTacgia.Name = "lblTacgia";
            this.lblTacgia.Size = new System.Drawing.Size(43, 13);
            this.lblTacgia.TabIndex = 1;
            this.lblTacgia.Text = "Tác giả";
            // 
            // lblTensach
            // 
            this.lblTensach.AutoSize = true;
            this.lblTensach.Location = new System.Drawing.Point(381, 24);
            this.lblTensach.Name = "lblTensach";
            this.lblTensach.Size = new System.Drawing.Size(52, 13);
            this.lblTensach.TabIndex = 2;
            this.lblTensach.Text = "Tên sách";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(130, 17);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(224, 20);
            this.txtMasach.TabIndex = 3;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Location = new System.Drawing.Point(130, 68);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(224, 20);
            this.txtTacgia.TabIndex = 4;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(442, 17);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(221, 20);
            this.txtTensach.TabIndex = 5;
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Location = new System.Drawing.Point(130, 172);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.Size = new System.Drawing.Size(533, 184);
            this.dataGridViewSach.TabIndex = 6;
            this.dataGridViewSach.Click += new System.EventHandler(this.dataGridViewSach_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(78, 394);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(178, 394);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(279, 394);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(384, 394);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(485, 394);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewSach);
            this.Controls.Add(this.txtTensach);
            this.Controls.Add(this.txtTacgia);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.lblTensach);
            this.Controls.Add(this.lblTacgia);
            this.Controls.Add(this.lblMasach);
            this.Name = "QuanLySach";
            this.Text = "Quản lý sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasach;
        private System.Windows.Forms.Label lblTacgia;
        private System.Windows.Forms.Label lblTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.DataGridView dataGridViewSach;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

