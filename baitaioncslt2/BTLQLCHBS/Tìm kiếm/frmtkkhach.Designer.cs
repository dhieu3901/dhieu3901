
namespace BTLQLCHBS
{
    partial class frmtkkhach
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
            this.txtmakhach = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.dgtkkhach = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdienthoai = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtkkhach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên khách";
            // 
            // txtmakhach
            // 
            this.txtmakhach.Location = new System.Drawing.Point(127, 83);
            this.txtmakhach.Name = "txtmakhach";
            this.txtmakhach.Size = new System.Drawing.Size(157, 22);
            this.txtmakhach.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(545, 83);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(156, 22);
            this.txtdiachi.TabIndex = 7;
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(127, 137);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(157, 22);
            this.txttenkhach.TabIndex = 8;
            // 
            // dgtkkhach
            // 
            this.dgtkkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtkkhach.Location = new System.Drawing.Point(29, 187);
            this.dgtkkhach.Name = "dgtkkhach";
            this.dgtkkhach.RowHeadersWidth = 51;
            this.dgtkkhach.RowTemplate.Height = 24;
            this.dgtkkhach.Size = new System.Drawing.Size(673, 179);
            this.dgtkkhach.TabIndex = 9;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(29, 387);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(104, 44);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(313, 387);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(103, 44);
            this.btntimlai.TabIndex = 11;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(596, 387);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(104, 44);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(154, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(437, 45);
            this.label5.TabIndex = 14;
            this.label5.Text = "TÌM KIẾM KHÁCH HÀNG";
            // 
            // txtdienthoai
            // 
            this.txtdienthoai.Location = new System.Drawing.Point(545, 137);
            this.txtdienthoai.Name = "txtdienthoai";
            this.txtdienthoai.Size = new System.Drawing.Size(156, 22);
            this.txtdienthoai.TabIndex = 15;
            // 
            // frmtkkhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 460);
            this.Controls.Add(this.txtdienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgtkkhach);
            this.Controls.Add(this.txttenkhach);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtmakhach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmtkkhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmtkkhach";
            this.Load += new System.EventHandler(this.frmtkkhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtkkhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmakhach;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.DataGridView dgtkkhach;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdienthoai;
    }
}