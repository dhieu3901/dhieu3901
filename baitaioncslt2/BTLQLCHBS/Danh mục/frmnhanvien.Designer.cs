namespace BTLQLCHBS
{
    partial class frmnhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.txttnv = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.msksdt = new System.Windows.Forms.MaskedTextBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndong = new System.Windows.Forms.Button();
            this.cbomcv = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Công việc";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(544, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(544, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(267, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(511, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(185, 98);
            this.txtmnv.Multiline = true;
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(200, 23);
            this.txtmnv.TabIndex = 6;
            // 
            // txttnv
            // 
            this.txttnv.Location = new System.Drawing.Point(185, 145);
            this.txttnv.Multiline = true;
            this.txttnv.Name = "txttnv";
            this.txttnv.Size = new System.Drawing.Size(200, 23);
            this.txttnv.TabIndex = 7;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(696, 139);
            this.txtdiachi.Multiline = true;
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(200, 23);
            this.txtdiachi.TabIndex = 9;
            // 
            // msksdt
            // 
            this.msksdt.Location = new System.Drawing.Point(696, 92);
            this.msksdt.Mask = "(999) 000-0000";
            this.msksdt.Name = "msksdt";
            this.msksdt.Size = new System.Drawing.Size(200, 22);
            this.msksdt.TabIndex = 10;
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(24, 239);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 24;
            this.dtgv.Size = new System.Drawing.Size(881, 268);
            this.dtgv.TabIndex = 11;
            this.dtgv.Click += new System.EventHandler(this.dtgv_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(24, 538);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(127, 40);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm nhân viên";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(192, 538);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(131, 40);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa danh sách";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(364, 538);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(122, 40);
            this.btnluu.TabIndex = 14;
            this.btnluu.Text = "Lưu danh sách";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(524, 538);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(120, 40);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa nhân viên";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(684, 538);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(94, 40);
            this.btnboqua.TabIndex = 16;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btndong
            // 
            this.btndong.Location = new System.Drawing.Point(816, 538);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(89, 40);
            this.btndong.TabIndex = 17;
            this.btndong.Text = "Đóng";
            this.btndong.UseVisualStyleBackColor = true;
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // cbomcv
            // 
            this.cbomcv.FormattingEnabled = true;
            this.cbomcv.Location = new System.Drawing.Point(185, 191);
            this.cbomcv.Name = "cbomcv";
            this.cbomcv.Size = new System.Drawing.Size(200, 24);
            this.cbomcv.TabIndex = 18;
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(933, 607);
            this.Controls.Add(this.cbomcv);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.msksdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txttnv);
            this.Controls.Add(this.txtmnv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmnhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmnhanvien";
            this.Load += new System.EventHandler(this.frmnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.TextBox txttnv;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.MaskedTextBox msksdt;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndong;
        private System.Windows.Forms.ComboBox cbomcv;
    }
}