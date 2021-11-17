
namespace bài_6
{
    partial class Form1
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
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMin = new System.Windows.Forms.CheckBox();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btnLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(98, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép toán";
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(19, 114);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(57, 21);
            this.rdChia.TabIndex = 7;
            this.rdChia.TabStop = true;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            this.rdChia.Click += new System.EventHandler(this.rdChia_Click);
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(18, 85);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(63, 21);
            this.rdNhan.TabIndex = 6;
            this.rdNhan.TabStop = true;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            this.rdNhan.Click += new System.EventHandler(this.rdNhan_Click);
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(19, 57);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(51, 21);
            this.rdTru.TabIndex = 5;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            this.rdTru.Click += new System.EventHandler(this.rdTru_Click);
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(19, 30);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(62, 21);
            this.rdCong.TabIndex = 4;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            this.rdCong.Click += new System.EventHandler(this.rdCong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMin);
            this.groupBox2.Controls.Add(this.chkMax);
            this.groupBox2.Location = new System.Drawing.Point(373, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "So sánh";
            // 
            // chkMin
            // 
            this.chkMin.AutoSize = true;
            this.chkMin.Location = new System.Drawing.Point(32, 60);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(52, 21);
            this.chkMin.TabIndex = 5;
            this.chkMin.Text = "Min";
            this.chkMin.UseVisualStyleBackColor = true;
            this.chkMin.Click += new System.EventHandler(this.chkMin_Click);
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(32, 31);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(55, 21);
            this.chkMax.TabIndex = 4;
            this.chkMax.Text = "Max";
            this.chkMax.UseVisualStyleBackColor = true;
            this.chkMax.Click += new System.EventHandler(this.chkMax_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(18, 23);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(66, 17);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "Nhập a =";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(18, 64);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(66, 17);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "Nhập b =";
            // 
            // lblKetqua
            // 
            this.lblKetqua.AutoSize = true;
            this.lblKetqua.Location = new System.Drawing.Point(18, 106);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(69, 17);
            this.lblKetqua.TabIndex = 3;
            this.lblKetqua.Text = "Kết quả =";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(138, 20);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 4;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(138, 61);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 5;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // txtKetqua
            // 
            this.txtKetqua.Location = new System.Drawing.Point(138, 103);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(100, 22);
            this.txtKetqua.TabIndex = 6;
            // 
            // btnLai
            // 
            this.btnLai.Location = new System.Drawing.Point(169, 399);
            this.btnLai.Name = "btnLai";
            this.btnLai.Size = new System.Drawing.Size(75, 23);
            this.btnLai.TabIndex = 7;
            this.btnLai.Text = "Làm lại";
            this.btnLai.UseVisualStyleBackColor = true;
            this.btnLai.Click += new System.EventHandler(this.btnLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(370, 399);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKetqua);
            this.groupBox3.Controls.Add(this.lblA);
            this.groupBox3.Controls.Add(this.lblB);
            this.groupBox3.Controls.Add(this.lblKetqua);
            this.groupBox3.Controls.Add(this.txtB);
            this.groupBox3.Controls.Add(this.txtA);
            this.groupBox3.Location = new System.Drawing.Point(169, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 147);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 470);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btnLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

