namespace Hỗ_Trợ_GV
{
    partial class DangNhap
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
            this.tb_Ten = new System.Windows.Forms.TextBox();
            this.TB_MK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.BtnDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Ten
            // 
            this.tb_Ten.Location = new System.Drawing.Point(305, 148);
            this.tb_Ten.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(247, 22);
            this.tb_Ten.TabIndex = 0;
            // 
            // TB_MK
            // 
            this.TB_MK.Location = new System.Drawing.Point(305, 217);
            this.TB_MK.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MK.Name = "TB_MK";
            this.TB_MK.Size = new System.Drawing.Size(247, 22);
            this.TB_MK.TabIndex = 1;
            this.TB_MK.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.Location = new System.Drawing.Point(351, 300);
            this.BtnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(123, 61);
            this.BtnDangNhap.TabIndex = 4;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = true;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.Location = new System.Drawing.Point(633, 417);
            this.BtnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.Size = new System.Drawing.Size(123, 61);
            this.BtnDangKy.TabIndex = 5;
            this.BtnDangKy.Text = "Đăng Ký";
            this.BtnDangKy.UseVisualStyleBackColor = true;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(108, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(629, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "CÔNG CỤ HỖ TRỢ GIÁO VIÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(589, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chưa có tài khoản? Đăng ký ngay";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDangKy);
            this.Controls.Add(this.BtnDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_MK);
            this.Controls.Add(this.tb_Ten);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.TextBox TB_MK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Button BtnDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}