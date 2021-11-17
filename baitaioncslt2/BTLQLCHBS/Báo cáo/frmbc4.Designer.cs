namespace BTLQLCHBS
{
    partial class frmbc4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttnv = new System.Windows.Forms.TextBox();
            this.cbonv = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btndong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbonam = new System.Windows.Forms.ComboBox();
            this.btnhienthi = new System.Windows.Forms.Button();
            this.cbothang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttnv);
            this.groupBox1.Controls.Add(this.cbonv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 149);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên lập báo cáo";
            // 
            // txttnv
            // 
            this.txttnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttnv.Location = new System.Drawing.Point(197, 91);
            this.txttnv.Name = "txttnv";
            this.txttnv.Size = new System.Drawing.Size(245, 24);
            this.txttnv.TabIndex = 11;
            // 
            // cbonv
            // 
            this.cbonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbonv.FormattingEnabled = true;
            this.cbonv.Location = new System.Drawing.Point(197, 30);
            this.cbonv.Name = "cbonv";
            this.cbonv.Size = new System.Drawing.Size(245, 26);
            this.cbonv.TabIndex = 10;
            this.cbonv.TextChanged += new System.EventHandler(this.cbonv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên nhân viên:";
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(332, 140);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(78, 38);
            this.btndong.TabIndex = 28;
            this.btndong.Text = "ĐÓNG\r\n";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(288, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "BÁO CÁO BÁN HÀNG ";
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(12, 269);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(902, 344);
            this.dtgv.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(11, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 51);
            this.label1.TabIndex = 25;
            this.label1.Text = "DANH SÁCH CÁC KHÁCH HÀNG KHÔNG MUA HÀNG THEO THÁNG\r\n\r\n\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbonam);
            this.groupBox2.Controls.Add(this.btnhienthi);
            this.groupBox2.Controls.Add(this.cbothang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btndong);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(485, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 197);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn báo cáo";
            // 
            // cbonam
            // 
            this.cbonam.FormattingEnabled = true;
            this.cbonam.Location = new System.Drawing.Point(148, 29);
            this.cbonam.Name = "cbonam";
            this.cbonam.Size = new System.Drawing.Size(262, 28);
            this.cbonam.TabIndex = 15;
            // 
            // btnhienthi
            // 
            this.btnhienthi.Location = new System.Drawing.Point(28, 140);
            this.btnhienthi.Name = "btnhienthi";
            this.btnhienthi.Size = new System.Drawing.Size(290, 38);
            this.btnhienthi.TabIndex = 14;
            this.btnhienthi.Text = "Hiển thị danh sách";
            this.btnhienthi.UseVisualStyleBackColor = true;
            this.btnhienthi.Click += new System.EventHandler(this.btnhienthi_Click);
            // 
            // cbothang
            // 
            this.cbothang.FormattingEnabled = true;
            this.cbothang.Location = new System.Drawing.Point(148, 90);
            this.cbothang.Name = "cbothang";
            this.cbothang.Size = new System.Drawing.Size(262, 28);
            this.cbothang.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Năm";
            // 
            // frmbc4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmbc4";
            this.Text = "frmbc4ss";
            this.Load += new System.EventHandler(this.frmbc4ss_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttnv;
        private System.Windows.Forms.ComboBox cbonv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbonam;
        private System.Windows.Forms.Button btnhienthi;
        private System.Windows.Forms.ComboBox cbothang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}