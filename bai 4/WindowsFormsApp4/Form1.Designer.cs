
namespace WindowsFormsApp4
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDayso = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblSapxep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(245, 108);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(176, 33);
            this.txtNhap.TabIndex = 0;
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.Location = new System.Drawing.Point(95, 327);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(91, 37);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSum.Location = new System.Drawing.Point(207, 327);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(91, 37);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "Tính tổng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSapxep
            // 
            this.btnSapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapxep.Location = new System.Drawing.Point(318, 327);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(91, 37);
            this.btnSapxep.TabIndex = 3;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamlai.Location = new System.Drawing.Point(432, 327);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(91, 37);
            this.btnLamlai.TabIndex = 4;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(545, 327);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập n = ";
            // 
            // lblDayso
            // 
            this.lblDayso.AutoSize = true;
            this.lblDayso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayso.Location = new System.Drawing.Point(114, 159);
            this.lblDayso.Name = "lblDayso";
            this.lblDayso.Size = new System.Drawing.Size(67, 20);
            this.lblDayso.TabIndex = 7;
            this.lblDayso.Text = "Dãy số:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.Location = new System.Drawing.Point(114, 206);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(105, 20);
            this.lblSum.TabIndex = 8;
            this.lblSum.Text = "Tổng dãy số:";
            // 
            // lblSapxep
            // 
            this.lblSapxep.AutoSize = true;
            this.lblSapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSapxep.Location = new System.Drawing.Point(114, 251);
            this.lblSapxep.Name = "lblSapxep";
            this.lblSapxep.Size = new System.Drawing.Size(74, 20);
            this.lblSapxep.TabIndex = 9;
            this.lblSapxep.Text = "Sắp xếp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSapxep);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblDayso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhap);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dãy số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDayso;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblSapxep;
    }
}

