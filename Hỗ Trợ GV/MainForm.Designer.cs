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
            this.bt_DangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.btn_TinhLuong = new Guna.UI2.WinForms.Guna2Button();
            this.btn_LichDay = new Guna.UI2.WinForms.Guna2Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.Location = new System.Drawing.Point(930, 12);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(125, 36);
            this.bt_DangXuat.TabIndex = 0;
            this.bt_DangXuat.Text = "Đăng xuất";
            this.bt_DangXuat.UseVisualStyleBackColor = true;
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.bt_DangXuat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 57);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hỗ trợ giáo viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_ThongKe);
            this.panel2.Controls.Add(this.btn_TinhLuong);
            this.panel2.Controls.Add(this.btn_LichDay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 61);
            this.panel2.TabIndex = 3;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_ThongKe.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_ThongKe.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_ThongKe.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_ThongKe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ThongKe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ThongKe.FillColor = System.Drawing.Color.White;
            this.btn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ThongKe.ForeColor = System.Drawing.Color.Black;
            this.btn_ThongKe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ThongKe.Location = new System.Drawing.Point(353, 0);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(180, 61);
            this.btn_ThongKe.TabIndex = 2;
            this.btn_ThongKe.Text = "Thống kê";
            // 
            // btn_TinhLuong
            // 
            this.btn_TinhLuong.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_TinhLuong.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_TinhLuong.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_TinhLuong.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_TinhLuong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TinhLuong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TinhLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TinhLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TinhLuong.FillColor = System.Drawing.Color.White;
            this.btn_TinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TinhLuong.ForeColor = System.Drawing.Color.Black;
            this.btn_TinhLuong.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_TinhLuong.Location = new System.Drawing.Point(176, 0);
            this.btn_TinhLuong.Name = "btn_TinhLuong";
            this.btn_TinhLuong.Size = new System.Drawing.Size(180, 61);
            this.btn_TinhLuong.TabIndex = 1;
            this.btn_TinhLuong.Text = "Tính lương";
            this.btn_TinhLuong.Click += new System.EventHandler(this.btn_TinhLuong_Click);
            // 
            // btn_LichDay
            // 
            this.btn_LichDay.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_LichDay.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_LichDay.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_LichDay.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btn_LichDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LichDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LichDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LichDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LichDay.FillColor = System.Drawing.Color.White;
            this.btn_LichDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LichDay.ForeColor = System.Drawing.Color.Black;
            this.btn_LichDay.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_LichDay.Location = new System.Drawing.Point(0, 0);
            this.btn_LichDay.Name = "btn_LichDay";
            this.btn_LichDay.Size = new System.Drawing.Size(180, 61);
            this.btn_LichDay.TabIndex = 0;
            this.btn_LichDay.Text = "Lịch dạy";
            this.btn_LichDay.Click += new System.EventHandler(this.btn_LichDay_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 118);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1067, 436);
            this.panelContainer.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_DangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btn_LichDay;
        private Guna.UI2.WinForms.Guna2Button btn_ThongKe;
        private Guna.UI2.WinForms.Guna2Button btn_TinhLuong;
    }
}