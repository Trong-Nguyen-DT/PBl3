namespace Quanlybantrasua
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.sapxep = new System.Windows.Forms.ComboBox();
            this.Them = new System.Windows.Forms.Button();
            this.capnhat = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.danhsachhanghoa = new System.Windows.Forms.DataGridView();
            this.paneltrai = new System.Windows.Forms.Panel();
            this.TLC = new System.Windows.Forms.Panel();
            this.btDT = new System.Windows.Forms.Button();
            this.btNV = new System.Windows.Forms.Button();
            this.btHH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhanghoa)).BeginInit();
            this.paneltrai.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PowderBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 170);
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
            this.sapxep.Location = new System.Drawing.Point(381, 166);
            this.sapxep.Name = "sapxep";
            this.sapxep.Size = new System.Drawing.Size(199, 24);
            this.sapxep.TabIndex = 17;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(250, 617);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(108, 53);
            this.Them.TabIndex = 16;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // capnhat
            // 
            this.capnhat.Location = new System.Drawing.Point(591, 617);
            this.capnhat.Name = "capnhat";
            this.capnhat.Size = new System.Drawing.Size(108, 53);
            this.capnhat.TabIndex = 24;
            this.capnhat.Text = "Cập nhật";
            this.capnhat.UseVisualStyleBackColor = true;
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(899, 617);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(108, 53);
            this.thoat.TabIndex = 26;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(605, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 27;
            // 
            // danhsachhanghoa
            // 
            this.danhsachhanghoa.BackgroundColor = System.Drawing.Color.White;
            this.danhsachhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsachhanghoa.Location = new System.Drawing.Point(316, 196);
            this.danhsachhanghoa.Name = "danhsachhanghoa";
            this.danhsachhanghoa.ReadOnly = true;
            this.danhsachhanghoa.RowHeadersWidth = 51;
            this.danhsachhanghoa.RowTemplate.Height = 24;
            this.danhsachhanghoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.danhsachhanghoa.Size = new System.Drawing.Size(721, 425);
            this.danhsachhanghoa.TabIndex = 29;
            // 
            // paneltrai
            // 
            this.paneltrai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.paneltrai.Controls.Add(this.TLC);
            this.paneltrai.Controls.Add(this.btDT);
            this.paneltrai.Controls.Add(this.btNV);
            this.paneltrai.Controls.Add(this.btHH);
            this.paneltrai.Controls.Add(this.panel2);
            this.paneltrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneltrai.ForeColor = System.Drawing.Color.White;
            this.paneltrai.Location = new System.Drawing.Point(0, 0);
            this.paneltrai.Name = "paneltrai";
            this.paneltrai.Size = new System.Drawing.Size(250, 679);
            this.paneltrai.TabIndex = 30;
            // 
            // TLC
            // 
            this.TLC.BackColor = System.Drawing.Color.White;
            this.TLC.Location = new System.Drawing.Point(1, 150);
            this.TLC.Name = "TLC";
            this.TLC.Size = new System.Drawing.Size(10, 115);
            this.TLC.TabIndex = 31;
            // 
            // btDT
            // 
            this.btDT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btDT.FlatAppearance.BorderSize = 0;
            this.btDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDT.ForeColor = System.Drawing.Color.White;
            this.btDT.Location = new System.Drawing.Point(12, 380);
            this.btDT.Name = "btDT";
            this.btDT.Size = new System.Drawing.Size(235, 115);
            this.btDT.TabIndex = 31;
            this.btDT.Text = "   Doanh Thu";
            this.btDT.UseVisualStyleBackColor = false;
            this.btDT.Click += new System.EventHandler(this.btDT_Click);
            // 
            // btNV
            // 
            this.btNV.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btNV.FlatAppearance.BorderSize = 0;
            this.btNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNV.ForeColor = System.Drawing.Color.White;
            this.btNV.Location = new System.Drawing.Point(12, 265);
            this.btNV.Name = "btNV";
            this.btNV.Size = new System.Drawing.Size(235, 115);
            this.btNV.TabIndex = 31;
            this.btNV.Text = "   Nhân Viên";
            this.btNV.UseVisualStyleBackColor = false;
            this.btNV.Click += new System.EventHandler(this.btNV_Click);
            // 
            // btHH
            // 
            this.btHH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btHH.FlatAppearance.BorderSize = 0;
            this.btHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHH.ForeColor = System.Drawing.Color.White;
            this.btHH.Location = new System.Drawing.Point(12, 150);
            this.btHH.Name = "btHH";
            this.btHH.Size = new System.Drawing.Size(235, 115);
            this.btHH.TabIndex = 31;
            this.btHH.Text = "   Hàng Hóa";
            this.btHH.UseVisualStyleBackColor = false;
            this.btHH.Click += new System.EventHandler(this.btHH_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 150);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(250, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(995, 53);
            this.panel3.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TG);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(250, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(995, 97);
            this.panel4.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quản lý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chức Vụ:";
            // 
            // TG
            // 
            this.TG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TG.AutoSize = true;
            this.TG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TG.Location = new System.Drawing.Point(778, 36);
            this.TG.Name = "TG";
            this.TG.Size = new System.Drawing.Size(131, 29);
            this.TG.TabIndex = 0;
            this.TG.Text = "HH:mm:ss";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nguyễn Văn Trọng Nguyên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin chào:";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Quanlyhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1245, 679);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.paneltrai);
            this.Controls.Add(this.danhsachhanghoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sapxep);
            this.Controls.Add(this.Them);
            this.Name = "Quanlyhanghoa";
            this.Text = "Quanlyhanghoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.danhsachhanghoa)).EndInit();
            this.paneltrai.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sapxep;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button capnhat;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView danhsachhanghoa;
        private System.Windows.Forms.Panel paneltrai;
        private System.Windows.Forms.Button btHH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel TLC;
        private System.Windows.Forms.Button btDT;
        private System.Windows.Forms.Button btNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
    }
}