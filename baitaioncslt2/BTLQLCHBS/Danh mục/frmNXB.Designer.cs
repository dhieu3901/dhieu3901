
namespace BTLQLCHBS
{
    partial class frmNXB
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
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttennxb = new System.Windows.Forms.TextBox();
            this.mskdienthoai = new System.Windows.Forms.MaskedTextBox();
            this.dgnxb = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgnxb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(264, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "NHÀ XUẤT BẢN";
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(133, 90);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(190, 22);
            this.txtmanxb.TabIndex = 5;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(589, 93);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(183, 22);
            this.txtdiachi.TabIndex = 6;
            // 
            // txttennxb
            // 
            this.txttennxb.Location = new System.Drawing.Point(133, 159);
            this.txttennxb.Name = "txttennxb";
            this.txttennxb.Size = new System.Drawing.Size(190, 22);
            this.txttennxb.TabIndex = 7;
            // 
            // mskdienthoai
            // 
            this.mskdienthoai.Location = new System.Drawing.Point(589, 159);
            this.mskdienthoai.Mask = "(999) 000-0000";
            this.mskdienthoai.Name = "mskdienthoai";
            this.mskdienthoai.Size = new System.Drawing.Size(183, 22);
            this.mskdienthoai.TabIndex = 8;
            // 
            // dgnxb
            // 
            this.dgnxb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgnxb.Location = new System.Drawing.Point(33, 197);
            this.dgnxb.Name = "dgnxb";
            this.dgnxb.RowHeadersWidth = 51;
            this.dgnxb.RowTemplate.Height = 24;
            this.dgnxb.Size = new System.Drawing.Size(739, 215);
            this.dgnxb.TabIndex = 9;
            this.dgnxb.Click += new System.EventHandler(this.dgnxb_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(35, 430);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(80, 37);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(168, 430);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(80, 37);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(299, 430);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(80, 37);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(430, 430);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(80, 37);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(561, 430);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(80, 37);
            this.btnboqua.TabIndex = 14;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(692, 430);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(80, 37);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 490);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgnxb);
            this.Controls.Add(this.mskdienthoai);
            this.Controls.Add(this.txttennxb);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmanxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmNXB";
            this.Text = "frmNXB";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgnxb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttennxb;
        private System.Windows.Forms.MaskedTextBox mskdienthoai;
        private System.Windows.Forms.DataGridView dgnxb;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnthoat;
    }
}