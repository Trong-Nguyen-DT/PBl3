﻿namespace Quanlybantrasua
{
    partial class Quanlyhanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quanlyhanghoa));
            this.timkiem = new System.Windows.Forms.Button();
            this.listtimkiem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sapxep = new System.Windows.Forms.ComboBox();
            this.Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.capnhat = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhsachhanhhoa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhanhhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // timkiem
            // 
            this.timkiem.Image = ((System.Drawing.Image)(resources.GetObject("timkiem.Image")));
            this.timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timkiem.Location = new System.Drawing.Point(973, 58);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(24, 24);
            this.timkiem.TabIndex = 20;
            this.timkiem.Text = "     search";
            this.timkiem.UseVisualStyleBackColor = true;
            // 
            // listtimkiem
            // 
            this.listtimkiem.FormattingEnabled = true;
            this.listtimkiem.Items.AddRange(new object[] {
            "Trà sữa",
            "Coffee"});
            this.listtimkiem.Location = new System.Drawing.Point(747, 59);
            this.listtimkiem.Name = "listtimkiem";
            this.listtimkiem.Size = new System.Drawing.Size(220, 24);
            this.listtimkiem.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sắp xếp";
            // 
            // sapxep
            // 
            this.sapxep.FormattingEnabled = true;
            this.sapxep.Items.AddRange(new object[] {
            "Trà sữa",
            "Coffee"});
            this.sapxep.Location = new System.Drawing.Point(135, 56);
            this.sapxep.Name = "sapxep";
            this.sapxep.Size = new System.Drawing.Size(199, 24);
            this.sapxep.TabIndex = 17;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(108, 617);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(108, 53);
            this.Them.TabIndex = 16;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 51);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản lí hàng hóa";
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(358, 617);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(108, 53);
            this.capnhat.TabIndex = 24;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(634, 617);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(108, 53);
            this.xoa.TabIndex = 25;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(899, 617);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(108, 53);
            this.thoat.TabIndex = 26;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listtimkiem);
            this.groupBox1.Controls.Add(this.timkiem);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 691);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // danhsachhanhhoa
            // 
            this.danhsachhanhhoa.BackgroundColor = System.Drawing.Color.White;
            this.danhsachhanhhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachhanhhoa.Location = new System.Drawing.Point(1, 86);
            this.danhsachhanhhoa.Name = "danhsachhanhhoa";
            this.danhsachhanhhoa.RowHeadersWidth = 51;
            this.danhsachhanhhoa.RowTemplate.Height = 24;
            this.danhsachhanhhoa.Size = new System.Drawing.Size(1086, 525);
            this.danhsachhanhhoa.TabIndex = 29;
            // 
            // Quanlyhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 700);
            this.Controls.Add(this.danhsachhanhhoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sapxep);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.groupBox1);
            this.Name = "Quanlyhanghoa";
            this.Text = "Quanlyhanghoa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhanhhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.ComboBox listtimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sapxep;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView danhsachhanhhoa;
    }
}