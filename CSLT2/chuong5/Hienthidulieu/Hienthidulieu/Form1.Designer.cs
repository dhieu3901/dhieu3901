
namespace Hienthidulieu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmacl = new System.Windows.Forms.Label();
            this.lbltencl = new System.Windows.Forms.Label();
            this.txtmacl = new System.Windows.Forms.TextBox();
            this.txttencl = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(134, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 117);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblmacl
            // 
            this.lblmacl.AutoSize = true;
            this.lblmacl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmacl.Location = new System.Drawing.Point(66, 50);
            this.lblmacl.Name = "lblmacl";
            this.lblmacl.Size = new System.Drawing.Size(74, 15);
            this.lblmacl.TabIndex = 1;
            this.lblmacl.Text = "Mã chất liệu";
            // 
            // lbltencl
            // 
            this.lbltencl.AutoSize = true;
            this.lbltencl.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltencl.Location = new System.Drawing.Point(66, 98);
            this.lbltencl.Name = "lbltencl";
            this.lbltencl.Size = new System.Drawing.Size(78, 15);
            this.lbltencl.TabIndex = 2;
            this.lbltencl.Text = "Tên chất liệu";
            // 
            // txtmacl
            // 
            this.txtmacl.Location = new System.Drawing.Point(162, 47);
            this.txtmacl.Name = "txtmacl";
            this.txtmacl.Size = new System.Drawing.Size(179, 20);
            this.txtmacl.TabIndex = 3;
            // 
            // txttencl
            // 
            this.txttencl.Location = new System.Drawing.Point(162, 95);
            this.txttencl.Name = "txttencl";
            this.txttencl.Size = new System.Drawing.Size(179, 20);
            this.txttencl.TabIndex = 4;
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnthem.Location = new System.Drawing.Point(162, 295);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 342);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttencl);
            this.Controls.Add(this.txtmacl);
            this.Controls.Add(this.lbltencl);
            this.Controls.Add(this.lblmacl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblmacl;
        private System.Windows.Forms.Label lbltencl;
        private System.Windows.Forms.TextBox txtmacl;
        private System.Windows.Forms.TextBox txttencl;
        private System.Windows.Forms.Button btnthem;
    }
}

