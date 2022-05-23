namespace Quanlybantrasua
{
    partial class Themmon
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
            this.Tenloaihanghoa = new System.Windows.Forms.ComboBox();
            this.txttenhh = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.tm_thoat = new System.Windows.Forms.Button();
            this.tm_luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.butAddLHH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại hàng hóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hàng hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá:";
            // 
            // Tenloaihanghoa
            // 
            this.Tenloaihanghoa.FormattingEnabled = true;
            this.Tenloaihanghoa.Location = new System.Drawing.Point(255, 96);
            this.Tenloaihanghoa.Name = "Tenloaihanghoa";
            this.Tenloaihanghoa.Size = new System.Drawing.Size(200, 24);
            this.Tenloaihanghoa.TabIndex = 3;
            // 
            // txttenhh
            // 
            this.txttenhh.Location = new System.Drawing.Point(255, 150);
            this.txttenhh.Name = "txttenhh";
            this.txttenhh.Size = new System.Drawing.Size(200, 22);
            this.txttenhh.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(252, 199);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(200, 22);
            this.txtGia.TabIndex = 5;
            // 
            // tm_thoat
            // 
            this.tm_thoat.BackColor = System.Drawing.Color.Red;
            this.tm_thoat.Location = new System.Drawing.Point(109, 265);
            this.tm_thoat.Name = "tm_thoat";
            this.tm_thoat.Size = new System.Drawing.Size(88, 72);
            this.tm_thoat.TabIndex = 6;
            this.tm_thoat.Text = "Thoát";
            this.tm_thoat.UseVisualStyleBackColor = false;
            this.tm_thoat.Click += new System.EventHandler(this.tm_thoat_Click);
            // 
            // tm_luu
            // 
            this.tm_luu.BackColor = System.Drawing.Color.Blue;
            this.tm_luu.Location = new System.Drawing.Point(334, 265);
            this.tm_luu.Name = "tm_luu";
            this.tm_luu.Size = new System.Drawing.Size(88, 72);
            this.tm_luu.TabIndex = 7;
            this.tm_luu.Text = "Lưu";
            this.tm_luu.UseVisualStyleBackColor = false;
            this.tm_luu.Click += new System.EventHandler(this.tm_luu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(137, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 69);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thêm món";
            // 
            // butAddLHH
            // 
            this.butAddLHH.BackColor = System.Drawing.Color.Blue;
            this.butAddLHH.Location = new System.Drawing.Point(488, 84);
            this.butAddLHH.Name = "butAddLHH";
            this.butAddLHH.Size = new System.Drawing.Size(88, 47);
            this.butAddLHH.TabIndex = 7;
            this.butAddLHH.Text = "Thêm";
            this.butAddLHH.UseVisualStyleBackColor = false;
            this.butAddLHH.Click += new System.EventHandler(this.butAddLHH_Click);
            // 
            // Themmon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butAddLHH);
            this.Controls.Add(this.tm_luu);
            this.Controls.Add(this.tm_thoat);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txttenhh);
            this.Controls.Add(this.Tenloaihanghoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Themmon";
            this.Text = "Themmon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Tenloaihanghoa;
        private System.Windows.Forms.TextBox txttenhh;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button tm_thoat;
        private System.Windows.Forms.Button tm_luu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butAddLHH;
    }
}