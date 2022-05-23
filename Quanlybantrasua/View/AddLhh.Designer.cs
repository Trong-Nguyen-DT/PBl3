namespace Quanlybantrasua.View
{
    partial class AddLhh
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
            this.TenLhh = new System.Windows.Forms.Label();
            this.txtTlhh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TenLhh
            // 
            this.TenLhh.AutoSize = true;
            this.TenLhh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLhh.Location = new System.Drawing.Point(42, 73);
            this.TenLhh.Name = "TenLhh";
            this.TenLhh.Size = new System.Drawing.Size(206, 29);
            this.TenLhh.TabIndex = 0;
            this.TenLhh.Text = "Tên loại hàng hóa";
            // 
            // txtTlhh
            // 
            this.txtTlhh.Location = new System.Drawing.Point(287, 73);
            this.txtTlhh.Name = "txtTlhh";
            this.txtTlhh.Size = new System.Drawing.Size(217, 22);
            this.txtTlhh.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddLhh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTlhh);
            this.Controls.Add(this.TenLhh);
            this.Name = "AddLhh";
            this.Text = "AddLhh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenLhh;
        private System.Windows.Forms.TextBox txtTlhh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}