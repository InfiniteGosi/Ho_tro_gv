
namespace Hỗ_Trợ_GV
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SendVerify = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_Code = new System.Windows.Forms.TextBox();
            this.PN_EPW = new System.Windows.Forms.Panel();
            this.TB_PassVerify = new System.Windows.Forms.TextBox();
            this.PN_PW = new System.Windows.Forms.Panel();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.PN_Email = new System.Windows.Forms.Panel();
            this.TB_NhapEmail = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_SendVerify);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_Register);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TB_Code);
            this.panel1.Controls.Add(this.PN_EPW);
            this.panel1.Controls.Add(this.TB_PassVerify);
            this.panel1.Controls.Add(this.PN_PW);
            this.panel1.Controls.Add(this.TB_Pass);
            this.panel1.Controls.Add(this.PN_Email);
            this.panel1.Controls.Add(this.TB_NhapEmail);
            this.panel1.Location = new System.Drawing.Point(316, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 559);
            this.panel1.TabIndex = 0;
            // 
            // btn_SendVerify
            // 
            this.btn_SendVerify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_SendVerify.BackgroundImage")));
            this.btn_SendVerify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SendVerify.ForeColor = System.Drawing.Color.Black;
            this.btn_SendVerify.Location = new System.Drawing.Point(363, 396);
            this.btn_SendVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendVerify.Name = "btn_SendVerify";
            this.btn_SendVerify.Size = new System.Drawing.Size(76, 33);
            this.btn_SendVerify.TabIndex = 9;
            this.btn_SendVerify.UseVisualStyleBackColor = true;
            this.btn_SendVerify.Click += new System.EventHandler(this.btn_SendVerify_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("GMV DIN Pro Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(29, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 43);
            this.label4.TabIndex = 11;
            this.label4.Text = "TRANG ĐĂNG KÝ";
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("GMV DIN Pro Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Register.Location = new System.Drawing.Point(0, 506);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(502, 53);
            this.btn_Register.TabIndex = 10;
            this.btn_Register.Text = "ĐĂNG KÝ";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(37, 427);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 2);
            this.panel2.TabIndex = 9;
            // 
            // TB_Code
            // 
            this.TB_Code.BackColor = System.Drawing.Color.White;
            this.TB_Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Code.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Code.ForeColor = System.Drawing.Color.Silver;
            this.TB_Code.Location = new System.Drawing.Point(37, 406);
            this.TB_Code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Code.Multiline = true;
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(309, 22);
            this.TB_Code.TabIndex = 8;
            this.TB_Code.Text = "CODE";
            this.TB_Code.Enter += new System.EventHandler(this.TB_Code_Enter);
            this.TB_Code.Leave += new System.EventHandler(this.TB_Code_Leave);
            // 
            // PN_EPW
            // 
            this.PN_EPW.BackColor = System.Drawing.Color.Gainsboro;
            this.PN_EPW.Location = new System.Drawing.Point(37, 324);
            this.PN_EPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_EPW.Name = "PN_EPW";
            this.PN_EPW.Size = new System.Drawing.Size(402, 2);
            this.PN_EPW.TabIndex = 7;
            // 
            // TB_PassVerify
            // 
            this.TB_PassVerify.BackColor = System.Drawing.Color.White;
            this.TB_PassVerify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PassVerify.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_PassVerify.ForeColor = System.Drawing.Color.Silver;
            this.TB_PassVerify.Location = new System.Drawing.Point(37, 304);
            this.TB_PassVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PassVerify.Multiline = true;
            this.TB_PassVerify.Name = "TB_PassVerify";
            this.TB_PassVerify.PasswordChar = '*';
            this.TB_PassVerify.Size = new System.Drawing.Size(402, 22);
            this.TB_PassVerify.TabIndex = 5;
            this.TB_PassVerify.Text = "Nhập lại mật khẩu";
            this.TB_PassVerify.Enter += new System.EventHandler(this.TB_PassVerify_Enter);
            this.TB_PassVerify.Leave += new System.EventHandler(this.TB_PassVerify_Leave);
            // 
            // PN_PW
            // 
            this.PN_PW.BackColor = System.Drawing.Color.Gainsboro;
            this.PN_PW.Location = new System.Drawing.Point(37, 222);
            this.PN_PW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_PW.Name = "PN_PW";
            this.PN_PW.Size = new System.Drawing.Size(402, 2);
            this.PN_PW.TabIndex = 4;
            // 
            // TB_Pass
            // 
            this.TB_Pass.BackColor = System.Drawing.Color.White;
            this.TB_Pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Pass.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Pass.ForeColor = System.Drawing.Color.Silver;
            this.TB_Pass.Location = new System.Drawing.Point(37, 202);
            this.TB_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_Pass.Multiline = true;
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.PasswordChar = '*';
            this.TB_Pass.Size = new System.Drawing.Size(402, 22);
            this.TB_Pass.TabIndex = 3;
            this.TB_Pass.Text = "Mật khẩu";
            this.TB_Pass.Enter += new System.EventHandler(this.TB_Pass_Enter);
            this.TB_Pass.Leave += new System.EventHandler(this.TB_Pass_Leave);
            // 
            // PN_Email
            // 
            this.PN_Email.BackColor = System.Drawing.Color.Gainsboro;
            this.PN_Email.Location = new System.Drawing.Point(37, 120);
            this.PN_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PN_Email.Name = "PN_Email";
            this.PN_Email.Size = new System.Drawing.Size(402, 2);
            this.PN_Email.TabIndex = 2;
            // 
            // TB_NhapEmail
            // 
            this.TB_NhapEmail.BackColor = System.Drawing.Color.White;
            this.TB_NhapEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_NhapEmail.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NhapEmail.ForeColor = System.Drawing.Color.Silver;
            this.TB_NhapEmail.Location = new System.Drawing.Point(37, 100);
            this.TB_NhapEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_NhapEmail.Multiline = true;
            this.TB_NhapEmail.Name = "TB_NhapEmail";
            this.TB_NhapEmail.Size = new System.Drawing.Size(402, 22);
            this.TB_NhapEmail.TabIndex = 1;
            this.TB_NhapEmail.Text = "Email";
            this.TB_NhapEmail.Enter += new System.EventHandler(this.TB_NhapEmail_Enter);
            this.TB_NhapEmail.Leave += new System.EventHandler(this.TB_NhapEmail_Leave);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(309, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 574);
            this.panel3.TabIndex = 1;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1134, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_Code;
        private System.Windows.Forms.Panel PN_EPW;
        private System.Windows.Forms.TextBox TB_PassVerify;
        private System.Windows.Forms.Panel PN_PW;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.Panel PN_Email;
        private System.Windows.Forms.TextBox TB_NhapEmail;
        private System.Windows.Forms.Button btn_SendVerify;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
    }
}

