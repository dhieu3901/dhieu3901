
namespace QuanLyBanHang1
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
            this.lblMacl = new System.Windows.Forms.Label();
            this.lblTencl = new System.Windows.Forms.Label();
            this.txtMacl = new System.Windows.Forms.TextBox();
            this.txtTencl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMacl
            // 
            this.lblMacl.AutoSize = true;
            this.lblMacl.Location = new System.Drawing.Point(79, 36);
            this.lblMacl.Name = "lblMacl";
            this.lblMacl.Size = new System.Drawing.Size(32, 13);
            this.lblMacl.TabIndex = 0;
            this.lblMacl.Text = "mã cl";
            // 
            // lblTencl
            // 
            this.lblTencl.AutoSize = true;
            this.lblTencl.Location = new System.Drawing.Point(79, 110);
            this.lblTencl.Name = "lblTencl";
            this.lblTencl.Size = new System.Drawing.Size(33, 13);
            this.lblTencl.TabIndex = 1;
            this.lblTencl.Text = "tên cl";
            // 
            // txtMacl
            // 
            this.txtMacl.Location = new System.Drawing.Point(163, 29);
            this.txtMacl.Name = "txtMacl";
            this.txtMacl.Size = new System.Drawing.Size(232, 20);
            this.txtMacl.TabIndex = 2;
            // 
            // txtTencl
            // 
            this.txtTencl.Location = new System.Drawing.Point(163, 103);
            this.txtTencl.Name = "txtTencl";
            this.txtTencl.Size = new System.Drawing.Size(232, 20);
            this.txtTencl.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(417, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(163, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTencl);
            this.Controls.Add(this.txtMacl);
            this.Controls.Add(this.lblTencl);
            this.Controls.Add(this.lblMacl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMacl;
        private System.Windows.Forms.Label lblTencl;
        private System.Windows.Forms.TextBox txtMacl;
        private System.Windows.Forms.TextBox txtTencl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
    }
}

