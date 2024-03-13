namespace Hỗ_Trợ_GV
{
    partial class LenLich
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
            this.CB_ChonNgay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CB_ChonCa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CB_ChonMon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // CB_ChonNgay
            // 
            this.CB_ChonNgay.BackColor = System.Drawing.Color.Transparent;
            this.CB_ChonNgay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_ChonNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ChonNgay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_ChonNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_ChonNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_ChonNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CB_ChonNgay.ItemHeight = 30;
            this.CB_ChonNgay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.CB_ChonNgay.Location = new System.Drawing.Point(108, 75);
            this.CB_ChonNgay.Name = "CB_ChonNgay";
            this.CB_ChonNgay.Size = new System.Drawing.Size(140, 36);
            this.CB_ChonNgay.TabIndex = 1;
            // 
            // CB_ChonCa
            // 
            this.CB_ChonCa.BackColor = System.Drawing.Color.Transparent;
            this.CB_ChonCa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_ChonCa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ChonCa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_ChonCa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_ChonCa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_ChonCa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CB_ChonCa.ItemHeight = 30;
            this.CB_ChonCa.Items.AddRange(new object[] {
            "Shift 1",
            "Shift 2",
            "Shift 3",
            "Shift 4"});
            this.CB_ChonCa.Location = new System.Drawing.Point(108, 218);
            this.CB_ChonCa.Name = "CB_ChonCa";
            this.CB_ChonCa.Size = new System.Drawing.Size(140, 36);
            this.CB_ChonCa.TabIndex = 2;
            // 
            // CB_ChonMon
            // 
            this.CB_ChonMon.BackColor = System.Drawing.Color.Transparent;
            this.CB_ChonMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_ChonMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ChonMon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_ChonMon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CB_ChonMon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_ChonMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CB_ChonMon.ItemHeight = 30;
            this.CB_ChonMon.Items.AddRange(new object[] {
            "Subject 1",
            "Subject 2",
            "Subject 3"});
            this.CB_ChonMon.Location = new System.Drawing.Point(108, 347);
            this.CB_ChonMon.Name = "CB_ChonMon";
            this.CB_ChonMon.Size = new System.Drawing.Size(140, 36);
            this.CB_ChonMon.TabIndex = 3;
            // 
            // LenLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_ChonMon);
            this.Controls.Add(this.CB_ChonCa);
            this.Controls.Add(this.CB_ChonNgay);
            this.Name = "LenLich";
            this.Text = "LenLich";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox CB_ChonCa;
        private Guna.UI2.WinForms.Guna2ComboBox CB_ChonMon;
        public Guna.UI2.WinForms.Guna2ComboBox CB_ChonNgay;
    }
}