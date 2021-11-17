namespace BTLQLCHBS
{
    partial class frmmatsach
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
            this.btnthem = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbomasach = new System.Windows.Forms.ComboBox();
            this.txtmamat = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.mskngaymat = new System.Windows.Forms.MaskedTextBox();
            this.btnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(32, 515);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(82, 37);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm BC";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(600, 515);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(82, 37);
            this.btnboqua.TabIndex = 1;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(458, 515);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(82, 37);
            this.btnhuy.TabIndex = 2;
            this.btnhuy.Text = "Hủy BC";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(742, 515);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(82, 37);
            this.btndong.TabIndex = 3;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // lb
            // 
            this.lb.Location = new System.Drawing.Point(493, 91);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(96, 30);
            this.lb.TabIndex = 6;
            this.lb.Text = "Tên sách";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(493, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày mất";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(29, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mã lần mất";
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(32, 211);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(794, 283);
            this.dtgv.TabIndex = 12;
            this.dtgv.Click += new System.EventHandler(this.dtgv_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "THÔNG BÁO MẤT SÁCH";
            // 
            // cbomasach
            // 
            this.cbomasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbomasach.FormattingEnabled = true;
            this.cbomasach.Location = new System.Drawing.Point(621, 92);
            this.cbomasach.Name = "cbomasach";
            this.cbomasach.Size = new System.Drawing.Size(203, 28);
            this.cbomasach.TabIndex = 14;
            // 
            // txtmamat
            // 
            this.txtmamat.Location = new System.Drawing.Point(154, 98);
            this.txtmamat.Multiline = true;
            this.txtmamat.Name = "txtmamat";
            this.txtmamat.Size = new System.Drawing.Size(218, 30);
            this.txtmamat.TabIndex = 15;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(621, 157);
            this.txtsoluong.Multiline = true;
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(203, 30);
            this.txtsoluong.TabIndex = 17;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(174, 515);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(82, 37);
            this.btnluu.TabIndex = 18;
            this.btnluu.Text = "Lưu BC";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // mskngaymat
            // 
            this.mskngaymat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskngaymat.Location = new System.Drawing.Point(154, 157);
            this.mskngaymat.Mask = "00/00/0000";
            this.mskngaymat.Name = "mskngaymat";
            this.mskngaymat.Size = new System.Drawing.Size(218, 27);
            this.mskngaymat.TabIndex = 19;
            this.mskngaymat.ValidatingType = typeof(System.DateTime);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(316, 515);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(82, 37);
            this.btnsua.TabIndex = 20;
            this.btnsua.Text = "Sửa BC";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // frmmatsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 582);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.mskngaymat);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtmamat);
            this.Controls.Add(this.cbomasach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnthem);
            this.Name = "frmmatsach";
            this.Text = "frmmatsach";
            this.Load += new System.EventHandler(this.frmmatsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbomasach;
        private System.Windows.Forms.TextBox txtmamat;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.MaskedTextBox mskngaymat;
        private System.Windows.Forms.Button btnsua;
    }
}