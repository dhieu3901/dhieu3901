
namespace vd1_chuong5
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
            this.lblMaCL = new System.Windows.Forms.Label();
            this.lblTenCL = new System.Windows.Forms.Label();
            this.txtMaCL = new System.Windows.Forms.TextBox();
            this.txtTenCL = new System.Windows.Forms.TextBox();
            this.dataGridChatLieu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý chất liệu";
            // 
            // lblMaCL
            // 
            this.lblMaCL.AutoSize = true;
            this.lblMaCL.Location = new System.Drawing.Point(51, 80);
            this.lblMaCL.Name = "lblMaCL";
            this.lblMaCL.Size = new System.Drawing.Size(65, 13);
            this.lblMaCL.TabIndex = 1;
            this.lblMaCL.Text = "Mã chất liệu";
            // 
            // lblTenCL
            // 
            this.lblTenCL.AutoSize = true;
            this.lblTenCL.Location = new System.Drawing.Point(47, 120);
            this.lblTenCL.Name = "lblTenCL";
            this.lblTenCL.Size = new System.Drawing.Size(69, 13);
            this.lblTenCL.TabIndex = 2;
            this.lblTenCL.Text = "Tên chất liệu";
            // 
            // txtMaCL
            // 
            this.txtMaCL.Location = new System.Drawing.Point(143, 77);
            this.txtMaCL.Name = "txtMaCL";
            this.txtMaCL.Size = new System.Drawing.Size(157, 20);
            this.txtMaCL.TabIndex = 3;
            // 
            // txtTenCL
            // 
            this.txtTenCL.Location = new System.Drawing.Point(143, 117);
            this.txtTenCL.Name = "txtTenCL";
            this.txtTenCL.Size = new System.Drawing.Size(157, 20);
            this.txtTenCL.TabIndex = 4;
            // 
            // dataGridChatLieu
            // 
            this.dataGridChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChatLieu.Location = new System.Drawing.Point(54, 160);
            this.dataGridChatLieu.Name = "dataGridChatLieu";
            this.dataGridChatLieu.Size = new System.Drawing.Size(308, 102);
            this.dataGridChatLieu.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 274);
            this.Controls.Add(this.dataGridChatLieu);
            this.Controls.Add(this.txtTenCL);
            this.Controls.Add(this.txtMaCL);
            this.Controls.Add(this.lblTenCL);
            this.Controls.Add(this.lblMaCL);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaCL;
        private System.Windows.Forms.Label lblTenCL;
        private System.Windows.Forms.TextBox txtMaCL;
        private System.Windows.Forms.TextBox txtTenCL;
        private System.Windows.Forms.DataGridView dataGridChatLieu;
    }
}

