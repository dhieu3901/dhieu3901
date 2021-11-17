
namespace Vidu2_Chuong4
{
    partial class FrmMain
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
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(82, 54);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(82, 103);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "b:";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(82, 233);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(114, 13);
            this.lblTong.TabIndex = 2;
            this.lblTong.Text = "Tổng của 2 số trên là: ";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(189, 47);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(193, 20);
            this.txtA.TabIndex = 3;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(189, 96);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(193, 20);
            this.txtB.TabIndex = 4;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.check_KeyPress);
            // 
            // btnTinhTong
            // 
            this.btnTinhTong.Location = new System.Drawing.Point(233, 166);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(75, 23);
            this.btnTinhTong.TabIndex = 5;
            this.btnTinhTong.Text = "Tính tổng";
            this.btnTinhTong.UseVisualStyleBackColor = true;
            this.btnTinhTong.Click += new System.EventHandler(this.btnTinhTong_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTinhTong;
    }
}