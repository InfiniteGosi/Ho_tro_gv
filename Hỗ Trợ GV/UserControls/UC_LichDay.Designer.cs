namespace Hỗ_Trợ_GV.UserControls
{
    partial class UC_LichDay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LichDay));
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.LB_2 = new System.Windows.Forms.Label();
            this.LB_3 = new System.Windows.Forms.Label();
            this.LB_4 = new System.Windows.Forms.Label();
            this.LB_5 = new System.Windows.Forms.Label();
            this.LB_6 = new System.Windows.Forms.Label();
            this.LB_7 = new System.Windows.Forms.Label();
            this.LB_8 = new System.Windows.Forms.Label();
            this.LB_Ca1 = new System.Windows.Forms.Label();
            this.LB_Ca2 = new System.Windows.Forms.Label();
            this.LB_Ca3 = new System.Windows.Forms.Label();
            this.LB_Ca4 = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.PN_LapLich = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTN_LapLich = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // monthCalendar1
            // 
            resources.ApplyResources(this.monthCalendar1, "monthCalendar1");
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // LB_2
            // 
            resources.ApplyResources(this.LB_2, "LB_2");
            this.LB_2.Name = "LB_2";
            // 
            // LB_3
            // 
            resources.ApplyResources(this.LB_3, "LB_3");
            this.LB_3.Name = "LB_3";
            // 
            // LB_4
            // 
            resources.ApplyResources(this.LB_4, "LB_4");
            this.LB_4.Name = "LB_4";
            // 
            // LB_5
            // 
            resources.ApplyResources(this.LB_5, "LB_5");
            this.LB_5.Name = "LB_5";
            // 
            // LB_6
            // 
            resources.ApplyResources(this.LB_6, "LB_6");
            this.LB_6.Name = "LB_6";
            // 
            // LB_7
            // 
            resources.ApplyResources(this.LB_7, "LB_7");
            this.LB_7.Name = "LB_7";
            // 
            // LB_8
            // 
            resources.ApplyResources(this.LB_8, "LB_8");
            this.LB_8.Name = "LB_8";
            // 
            // LB_Ca1
            // 
            resources.ApplyResources(this.LB_Ca1, "LB_Ca1");
            this.LB_Ca1.Name = "LB_Ca1";
            // 
            // LB_Ca2
            // 
            resources.ApplyResources(this.LB_Ca2, "LB_Ca2");
            this.LB_Ca2.Name = "LB_Ca2";
            // 
            // LB_Ca3
            // 
            resources.ApplyResources(this.LB_Ca3, "LB_Ca3");
            this.LB_Ca3.Name = "LB_Ca3";
            // 
            // LB_Ca4
            // 
            resources.ApplyResources(this.LB_Ca4, "LB_Ca4");
            this.LB_Ca4.Name = "LB_Ca4";
            // 
            // PN_LapLich
            // 
            resources.ApplyResources(this.PN_LapLich, "PN_LapLich");
            this.PN_LapLich.Name = "PN_LapLich";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // BTN_LapLich
            // 
            this.BTN_LapLich.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BTN_LapLich.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BTN_LapLich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BTN_LapLich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            resources.ApplyResources(this.BTN_LapLich, "BTN_LapLich");
            this.BTN_LapLich.ForeColor = System.Drawing.Color.White;
            this.BTN_LapLich.Name = "BTN_LapLich";
            this.BTN_LapLich.Click += new System.EventHandler(this.BTN_LapLich_Click);
            // 
            // UC_LichDay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.BTN_LapLich);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.PN_LapLich);
            this.Controls.Add(this.LB_Ca4);
            this.Controls.Add(this.LB_Ca3);
            this.Controls.Add(this.LB_Ca2);
            this.Controls.Add(this.LB_Ca1);
            this.Controls.Add(this.LB_8);
            this.Controls.Add(this.LB_7);
            this.Controls.Add(this.LB_6);
            this.Controls.Add(this.LB_5);
            this.Controls.Add(this.LB_4);
            this.Controls.Add(this.LB_3);
            this.Controls.Add(this.LB_2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "UC_LichDay";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label LB_2;
        private System.Windows.Forms.Label LB_3;
        private System.Windows.Forms.Label LB_4;
        private System.Windows.Forms.Label LB_5;
        private System.Windows.Forms.Label LB_6;
        private System.Windows.Forms.Label LB_7;
        private System.Windows.Forms.Label LB_8;
        private System.Windows.Forms.Label LB_Ca1;
        private System.Windows.Forms.Label LB_Ca2;
        private System.Windows.Forms.Label LB_Ca3;
        private System.Windows.Forms.Label LB_Ca4;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.Panel PN_LapLich;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2Button BTN_LapLich;
    }
}
