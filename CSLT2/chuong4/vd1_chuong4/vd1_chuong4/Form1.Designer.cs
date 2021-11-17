
namespace vd1_chuong4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSothu1 = new System.Windows.Forms.TextBox();
            this.txtSothu2 = new System.Windows.Forms.TextBox();
            this.btnTinhtong = new System.Windows.Forms.Button();
            this.labelTong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 2";
            // 
            // txtSothu1
            // 
            this.txtSothu1.Location = new System.Drawing.Point(158, 52);
            this.txtSothu1.Name = "txtSothu1";
            this.txtSothu1.Size = new System.Drawing.Size(265, 20);
            this.txtSothu1.TabIndex = 2;
            this.txtSothu1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSothu2
            // 
            this.txtSothu2.Location = new System.Drawing.Point(158, 84);
            this.txtSothu2.Name = "txtSothu2";
            this.txtSothu2.Size = new System.Drawing.Size(265, 20);
            this.txtSothu2.TabIndex = 3;
            // 
            // btnTinhtong
            // 
            this.btnTinhtong.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTinhtong.Location = new System.Drawing.Point(240, 156);
            this.btnTinhtong.Name = "btnTinhtong";
            this.btnTinhtong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhtong.TabIndex = 4;
            this.btnTinhtong.Text = "Tinh Tong";
            this.btnTinhtong.UseVisualStyleBackColor = true;
            this.btnTinhtong.Click += new System.EventHandler(this.btnTinhtong_Click);
            // 
            // labelTong
            // 
            this.labelTong.AutoSize = true;
            this.labelTong.Location = new System.Drawing.Point(89, 211);
            this.labelTong.Name = "labelTong";
            this.labelTong.Size = new System.Drawing.Size(0, 13);
            this.labelTong.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTong);
            this.Controls.Add(this.btnTinhtong);
            this.Controls.Add(this.txtSothu2);
            this.Controls.Add(this.txtSothu1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSothu1;
        private System.Windows.Forms.TextBox txtSothu2;
        private System.Windows.Forms.Button btnTinhtong;
        private System.Windows.Forms.Label labelTong;
    }
}

