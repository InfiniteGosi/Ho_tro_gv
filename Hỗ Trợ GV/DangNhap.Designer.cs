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
            this.BtnDangNhap = new System.Windows.Forms.Button();
            this.BtnDangKy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Ten
            // 
            this.tb_Ten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Ten.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ten.ForeColor = System.Drawing.Color.Silver;
            this.tb_Ten.Location = new System.Drawing.Point(53, 123);
            this.tb_Ten.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Ten.Multiline = true;
            this.tb_Ten.Name = "tb_Ten";
            this.tb_Ten.Size = new System.Drawing.Size(402, 28);
            this.tb_Ten.TabIndex = 0;
            this.tb_Ten.Text = "Tài khoản";
            this.tb_Ten.Enter += new System.EventHandler(this.tb_Ten_Enter);
            this.tb_Ten.Leave += new System.EventHandler(this.tb_Ten_Leave);
            // 
            // TB_MK
            // 
            this.TB_MK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_MK.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_MK.ForeColor = System.Drawing.Color.Silver;
            this.TB_MK.Location = new System.Drawing.Point(53, 207);
            this.TB_MK.Margin = new System.Windows.Forms.Padding(4);
            this.TB_MK.Multiline = true;
            this.TB_MK.Name = "TB_MK";
            this.TB_MK.Size = new System.Drawing.Size(402, 28);
            this.TB_MK.TabIndex = 1;
            this.TB_MK.Text = "Mật khẩu";
            this.TB_MK.UseSystemPasswordChar = true;
            this.TB_MK.Enter += new System.EventHandler(this.tb_MK_Enter);
            this.TB_MK.Leave += new System.EventHandler(this.tb_MK_Leave);
            // 
            // BtnDangNhap
            // 
            this.BtnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.BtnDangNhap.FlatAppearance.BorderSize = 0;
            this.BtnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDangNhap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDangNhap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDangNhap.Location = new System.Drawing.Point(0, 316);
            this.BtnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangNhap.Name = "BtnDangNhap";
            this.BtnDangNhap.Size = new System.Drawing.Size(251, 55);
            this.BtnDangNhap.TabIndex = 4;
            this.BtnDangNhap.Text = "Đăng Nhập";
            this.BtnDangNhap.UseVisualStyleBackColor = false;
            this.BtnDangNhap.Click += new System.EventHandler(this.BtnDangNhap_Click);
            // 
            // BtnDangKy
            // 
            this.BtnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.BtnDangKy.FlatAppearance.BorderSize = 0;
            this.BtnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDangKy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDangKy.ForeColor = System.Drawing.Color.Gray;
            this.BtnDangKy.Location = new System.Drawing.Point(250, 316);
            this.BtnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDangKy.Name = "BtnDangKy";
            this.BtnDangKy.Size = new System.Drawing.Size(251, 55);
            this.BtnDangKy.TabIndex = 5;
            this.BtnDangKy.Text = "Đăng Ký";
            this.BtnDangKy.UseVisualStyleBackColor = false;
            this.BtnDangKy.Click += new System.EventHandler(this.BtnDangKy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GMV DIN Pro Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(53, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "CÔNG CỤ HỖ TRỢ GIÁO VIÊN";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tb_Ten);
            this.panel1.Controls.Add(this.TB_MK);
            this.panel1.Controls.Add(this.BtnDangKy);
            this.panel1.Controls.Add(this.BtnDangNhap);
            this.panel1.Location = new System.Drawing.Point(316, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 371);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(53, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 2);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(53, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 2);
            this.panel2.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(310, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 387);
            this.panel4.TabIndex = 8;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Ten;
        private System.Windows.Forms.TextBox TB_MK;
        private System.Windows.Forms.Button BtnDangNhap;
        private System.Windows.Forms.Button BtnDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}