
namespace BTLQLCHBS
{
    partial class frmtksach
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgtksach = new System.Windows.Forms.DataGridView();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntimlai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtmasach = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmaloai = new System.Windows.Forms.TextBox();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmalv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmatg = new System.Windows.Forms.TextBox();
            this.txtmanxb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmann = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtksach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(334, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÌM KIẾM SÁCH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá bán";
            // 
            // dgtksach
            // 
            this.dgtksach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtksach.Location = new System.Drawing.Point(32, 236);
            this.dgtksach.Name = "dgtksach";
            this.dgtksach.RowHeadersWidth = 51;
            this.dgtksach.RowTemplate.Height = 24;
            this.dgtksach.Size = new System.Drawing.Size(891, 260);
            this.dgtksach.TabIndex = 6;
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(80, 519);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(118, 39);
            this.btntimkiem.TabIndex = 7;
            this.btntimkiem.Text = "Tìm kiếm ";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntimlai
            // 
            this.btntimlai.Location = new System.Drawing.Point(424, 519);
            this.btntimlai.Name = "btntimlai";
            this.btntimlai.Size = new System.Drawing.Size(118, 39);
            this.btntimlai.TabIndex = 8;
            this.btntimlai.Text = "Tìm lại";
            this.btntimlai.UseVisualStyleBackColor = true;
            this.btntimlai.Click += new System.EventHandler(this.btntimlai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(768, 519);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(118, 39);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtmasach
            // 
            this.txtmasach.Location = new System.Drawing.Point(126, 83);
            this.txtmasach.Name = "txtmasach";
            this.txtmasach.Size = new System.Drawing.Size(154, 22);
            this.txtmasach.TabIndex = 10;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Location = new System.Drawing.Point(446, 132);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(154, 22);
            this.txtgiaban.TabIndex = 12;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(446, 83);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(154, 22);
            this.txtsoluong.TabIndex = 13;
            // 
            // txtmaloai
            // 
            this.txtmaloai.Location = new System.Drawing.Point(126, 181);
            this.txtmaloai.Name = "txtmaloai";
            this.txtmaloai.Size = new System.Drawing.Size(154, 22);
            this.txtmaloai.TabIndex = 14;
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(126, 132);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(154, 22);
            this.txttensach.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(663, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mã NXB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã lĩnh vực";
            // 
            // txtmalv
            // 
            this.txtmalv.Location = new System.Drawing.Point(769, 181);
            this.txtmalv.Name = "txtmalv";
            this.txtmalv.Size = new System.Drawing.Size(154, 22);
            this.txtmalv.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(663, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mã tác giả ";
            // 
            // txtmatg
            // 
            this.txtmatg.Location = new System.Drawing.Point(769, 132);
            this.txtmatg.Name = "txtmatg";
            this.txtmatg.Size = new System.Drawing.Size(154, 22);
            this.txtmatg.TabIndex = 22;
            // 
            // txtmanxb
            // 
            this.txtmanxb.Location = new System.Drawing.Point(769, 83);
            this.txtmanxb.Name = "txtmanxb";
            this.txtmanxb.Size = new System.Drawing.Size(154, 22);
            this.txtmanxb.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(349, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mã ngôn ngữ";
            // 
            // txtmann
            // 
            this.txtmann.Location = new System.Drawing.Point(446, 182);
            this.txtmann.Name = "txtmann";
            this.txtmann.Size = new System.Drawing.Size(154, 22);
            this.txtmann.TabIndex = 25;
            // 
            // frmtksach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 585);
            this.Controls.Add(this.txtmann);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmanxb);
            this.Controls.Add(this.txtmatg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtmalv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttensach);
            this.Controls.Add(this.txtmaloai);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txtmasach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntimlai);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.dgtksach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmtksach";
            this.Text = "frmtksach";
            this.Load += new System.EventHandler(this.frmtksach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtksach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgtksach;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntimlai;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtmasach;
        private System.Windows.Forms.TextBox txtgiaban;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.TextBox txtmaloai;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmalv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtmatg;
        private System.Windows.Forms.TextBox txtmanxb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtmann;
    }
}