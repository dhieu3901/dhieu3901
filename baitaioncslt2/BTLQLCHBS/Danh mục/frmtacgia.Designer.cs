
namespace BTLQLCHBS
{
    partial class frmtacgia
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
            this.dgtacgia = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmatg = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttentg = new System.Windows.Forms.TextBox();
            this.mskngaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chknam = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtacgia
            // 
            this.dgtacgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtacgia.Location = new System.Drawing.Point(22, 204);
            this.dgtacgia.Name = "dgtacgia";
            this.dgtacgia.RowHeadersWidth = 51;
            this.dgtacgia.RowTemplate.Height = 24;
            this.dgtacgia.Size = new System.Drawing.Size(792, 217);
            this.dgtacgia.TabIndex = 0;
            this.dgtacgia.Click += new System.EventHandler(this.dgtacgia_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(22, 450);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 41);
            this.btnthem.TabIndex = 1;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(159, 450);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(98, 41);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(440, 450);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 41);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(296, 450);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(98, 41);
            this.btnsua.TabIndex = 4;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Location = new System.Drawing.Point(578, 450);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(98, 41);
            this.btnboqua.TabIndex = 5;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(716, 450);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(98, 41);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát ";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "BẢNG TÁC GIẢ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã tác giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên tác giả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày sinh";
            // 
            // txtmatg
            // 
            this.txtmatg.Location = new System.Drawing.Point(131, 71);
            this.txtmatg.Name = "txtmatg";
            this.txtmatg.Size = new System.Drawing.Size(176, 22);
            this.txtmatg.TabIndex = 12;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(578, 71);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(173, 22);
            this.txtdiachi.TabIndex = 13;
            // 
            // txttentg
            // 
            this.txttentg.Location = new System.Drawing.Point(131, 124);
            this.txttentg.Name = "txttentg";
            this.txttentg.Size = new System.Drawing.Size(176, 22);
            this.txttentg.TabIndex = 14;
            // 
            // mskngaysinh
            // 
            this.mskngaysinh.Location = new System.Drawing.Point(578, 124);
            this.mskngaysinh.Mask = "00/00/0000";
            this.mskngaysinh.Name = "mskngaysinh";
            this.mskngaysinh.Size = new System.Drawing.Size(173, 22);
            this.mskngaysinh.TabIndex = 15;
            this.mskngaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giới tính";
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.Location = new System.Drawing.Point(131, 177);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(59, 21);
            this.chknam.TabIndex = 17;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = true;
            // 
            // frmtacgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 515);
            this.Controls.Add(this.chknam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskngaysinh);
            this.Controls.Add(this.txttentg);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmatg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgtacgia);
            this.Name = "frmtacgia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmtacgia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtacgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtacgia;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmatg;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttentg;
        private System.Windows.Forms.MaskedTextBox mskngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chknam;
    }
}