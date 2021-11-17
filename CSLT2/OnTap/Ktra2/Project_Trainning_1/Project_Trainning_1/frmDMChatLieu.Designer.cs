
namespace Project_Trainning_1
{
    partial class frmDMChatLieu
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblmachatlieu = new System.Windows.Forms.Label();
            this.lbltenchatlieu = new System.Windows.Forms.Label();
            this.txtmachatlieu = new System.Windows.Forms.TextBox();
            this.txttenchatlieu = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(178, 7);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(210, 26);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Danh Mục Chất Liệu";
            // 
            // lblmachatlieu
            // 
            this.lblmachatlieu.AutoSize = true;
            this.lblmachatlieu.Location = new System.Drawing.Point(32, 40);
            this.lblmachatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmachatlieu.Name = "lblmachatlieu";
            this.lblmachatlieu.Size = new System.Drawing.Size(65, 13);
            this.lblmachatlieu.TabIndex = 1;
            this.lblmachatlieu.Text = "Mã chất liệu";
            // 
            // lbltenchatlieu
            // 
            this.lbltenchatlieu.AutoSize = true;
            this.lbltenchatlieu.Location = new System.Drawing.Point(32, 83);
            this.lbltenchatlieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltenchatlieu.Name = "lbltenchatlieu";
            this.lbltenchatlieu.Size = new System.Drawing.Size(69, 13);
            this.lbltenchatlieu.TabIndex = 2;
            this.lbltenchatlieu.Text = "Tên chất liệu";
            // 
            // txtmachatlieu
            // 
            this.txtmachatlieu.Location = new System.Drawing.Point(136, 37);
            this.txtmachatlieu.Margin = new System.Windows.Forms.Padding(2);
            this.txtmachatlieu.Name = "txtmachatlieu";
            this.txtmachatlieu.Size = new System.Drawing.Size(370, 20);
            this.txtmachatlieu.TabIndex = 3;
            // 
            // txttenchatlieu
            // 
            this.txttenchatlieu.Location = new System.Drawing.Point(136, 80);
            this.txttenchatlieu.Margin = new System.Windows.Forms.Padding(2);
            this.txttenchatlieu.Name = "txttenchatlieu";
            this.txttenchatlieu.Size = new System.Drawing.Size(370, 20);
            this.txttenchatlieu.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(34, 322);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(371, 322);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(56, 19);
            this.btnboqua.TabIndex = 7;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(285, 322);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(56, 19);
            this.btnluu.TabIndex = 8;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(116, 322);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(56, 19);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(202, 322);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(56, 19);
            this.btnsua.TabIndex = 10;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(449, 322);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(56, 19);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 140);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(470, 150);
            this.dataGridView.TabIndex = 12;
            // 
            // frmDMChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 366);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txttenchatlieu);
            this.Controls.Add(this.txtmachatlieu);
            this.Controls.Add(this.lbltenchatlieu);
            this.Controls.Add(this.lblmachatlieu);
            this.Controls.Add(this.lblTieuDe);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDMChatLieu";
            this.Text = "Danh Mục Chất Liệu";
            this.Load += new System.EventHandler(this.frmDMChatLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblmachatlieu;
        private System.Windows.Forms.Label lbltenchatlieu;
        private System.Windows.Forms.TextBox txtmachatlieu;
        private System.Windows.Forms.TextBox txttenchatlieu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}