namespace Hỗ_Trợ_GV
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_xinchao = new System.Windows.Forms.Label();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_tinhluong = new System.Windows.Forms.Button();
            this.bnt_lichday = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_htgv = new System.Windows.Forms.Label();
            this.TM_autoNoti = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.LB_xinchao);
            this.panel1.Controls.Add(this.btn_dangxuat);
            this.panel1.Controls.Add(this.btn_thongke);
            this.panel1.Controls.Add(this.btn_tinhluong);
            this.panel1.Controls.Add(this.bnt_lichday);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 36);
            this.panel1.TabIndex = 1;
            // 
            // LB_xinchao
            // 
            this.LB_xinchao.AutoSize = true;
            this.LB_xinchao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_xinchao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LB_xinchao.Location = new System.Drawing.Point(8, 9);
            this.LB_xinchao.Name = "LB_xinchao";
            this.LB_xinchao.Size = new System.Drawing.Size(60, 22);
            this.LB_xinchao.TabIndex = 3;
            this.LB_xinchao.Text = "label1";
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dangxuat.AutoSize = true;
            this.btn_dangxuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_dangxuat.FlatAppearance.BorderSize = 3;
            this.btn_dangxuat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_dangxuat.Location = new System.Drawing.Point(1117, 2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(97, 33);
            this.btn_dangxuat.TabIndex = 1;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_thongke.AutoSize = true;
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Location = new System.Drawing.Point(982, -7);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(126, 52);
            this.btn_thongke.TabIndex = 2;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_tinhluong
            // 
            this.btn_tinhluong.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_tinhluong.AutoSize = true;
            this.btn_tinhluong.FlatAppearance.BorderSize = 0;
            this.btn_tinhluong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tinhluong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tinhluong.ForeColor = System.Drawing.Color.White;
            this.btn_tinhluong.Location = new System.Drawing.Point(835, -8);
            this.btn_tinhluong.Name = "btn_tinhluong";
            this.btn_tinhluong.Size = new System.Drawing.Size(126, 52);
            this.btn_tinhluong.TabIndex = 1;
            this.btn_tinhluong.Text = "Tính lương";
            this.btn_tinhluong.UseVisualStyleBackColor = true;
            this.btn_tinhluong.Click += new System.EventHandler(this.btn_tinhluong_Click);
            // 
            // bnt_lichday
            // 
            this.bnt_lichday.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bnt_lichday.AutoSize = true;
            this.bnt_lichday.FlatAppearance.BorderSize = 0;
            this.bnt_lichday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_lichday.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_lichday.ForeColor = System.Drawing.Color.White;
            this.bnt_lichday.Location = new System.Drawing.Point(688, -7);
            this.bnt_lichday.Name = "bnt_lichday";
            this.bnt_lichday.Size = new System.Drawing.Size(126, 52);
            this.bnt_lichday.TabIndex = 0;
            this.bnt_lichday.Text = "Lịch dạy";
            this.bnt_lichday.UseVisualStyleBackColor = true;
            this.bnt_lichday.Click += new System.EventHandler(this.bnt_lichday_Click);
            // 
            // pn_main
            // 
            this.pn_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_main.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_main.Location = new System.Drawing.Point(0, 73);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(1220, 638);
            this.pn_main.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lb_htgv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 37);
            this.panel2.TabIndex = 3;
            // 
            // lb_htgv
            // 
            this.lb_htgv.AutoSize = true;
            this.lb_htgv.BackColor = System.Drawing.Color.Transparent;
            this.lb_htgv.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_htgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_htgv.Location = new System.Drawing.Point(2, 0);
            this.lb_htgv.Name = "lb_htgv";
            this.lb_htgv.Size = new System.Drawing.Size(225, 32);
            this.lb_htgv.TabIndex = 0;
            this.lb_htgv.Text = "Hỗ trợ giảng viên";
            // 
            // TM_autoNoti
            // 
            this.TM_autoNoti.Enabled = true;
            this.TM_autoNoti.Interval = 5000;
            this.TM_autoNoti.Tick += new System.EventHandler(this.TM_autoNoti_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_tinhluong;
        private System.Windows.Forms.Button bnt_lichday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_htgv;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Label LB_xinchao;
        private System.Windows.Forms.Timer TM_autoNoti;
    }
}