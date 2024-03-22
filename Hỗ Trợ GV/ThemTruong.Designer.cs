namespace Hỗ_Trợ_GV
{
    partial class ThemTruong
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
            this.LB_MaTruong = new System.Windows.Forms.Label();
            this.LB_TenTruong = new System.Windows.Forms.Label();
            this.LB_Luong1Ca = new System.Windows.Forms.Label();
            this.TB_MaTruong = new System.Windows.Forms.TextBox();
            this.TB_TenTruong = new System.Windows.Forms.TextBox();
            this.TB_Luong1Ca = new System.Windows.Forms.TextBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.LB_ThemTruongTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LB_MaTruong
            // 
            this.LB_MaTruong.AutoSize = true;
            this.LB_MaTruong.Location = new System.Drawing.Point(97, 114);
            this.LB_MaTruong.Name = "LB_MaTruong";
            this.LB_MaTruong.Size = new System.Drawing.Size(72, 16);
            this.LB_MaTruong.TabIndex = 0;
            this.LB_MaTruong.Text = "Mã Trường";
            // 
            // LB_TenTruong
            // 
            this.LB_TenTruong.AutoSize = true;
            this.LB_TenTruong.Location = new System.Drawing.Point(97, 193);
            this.LB_TenTruong.Name = "LB_TenTruong";
            this.LB_TenTruong.Size = new System.Drawing.Size(77, 16);
            this.LB_TenTruong.TabIndex = 1;
            this.LB_TenTruong.Text = "Tên Trường";
            // 
            // LB_Luong1Ca
            // 
            this.LB_Luong1Ca.AutoSize = true;
            this.LB_Luong1Ca.Location = new System.Drawing.Point(97, 274);
            this.LB_Luong1Ca.Name = "LB_Luong1Ca";
            this.LB_Luong1Ca.Size = new System.Drawing.Size(98, 16);
            this.LB_Luong1Ca.TabIndex = 2;
            this.LB_Luong1Ca.Text = "Lương 1 ca dạy";
            // 
            // TB_MaTruong
            // 
            this.TB_MaTruong.Location = new System.Drawing.Point(230, 107);
            this.TB_MaTruong.Name = "TB_MaTruong";
            this.TB_MaTruong.Size = new System.Drawing.Size(344, 22);
            this.TB_MaTruong.TabIndex = 3;
            // 
            // TB_TenTruong
            // 
            this.TB_TenTruong.Location = new System.Drawing.Point(230, 193);
            this.TB_TenTruong.Name = "TB_TenTruong";
            this.TB_TenTruong.Size = new System.Drawing.Size(344, 22);
            this.TB_TenTruong.TabIndex = 4;
            // 
            // TB_Luong1Ca
            // 
            this.TB_Luong1Ca.Location = new System.Drawing.Point(230, 268);
            this.TB_Luong1Ca.Name = "TB_Luong1Ca";
            this.TB_Luong1Ca.Size = new System.Drawing.Size(344, 22);
            this.TB_Luong1Ca.TabIndex = 5;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(485, 321);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(89, 35);
            this.BT_Save.TabIndex = 6;
            this.BT_Save.Text = "Lưu";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // LB_ThemTruongTitle
            // 
            this.LB_ThemTruongTitle.AutoSize = true;
            this.LB_ThemTruongTitle.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ThemTruongTitle.Location = new System.Drawing.Point(178, 9);
            this.LB_ThemTruongTitle.Name = "LB_ThemTruongTitle";
            this.LB_ThemTruongTitle.Size = new System.Drawing.Size(386, 68);
            this.LB_ThemTruongTitle.TabIndex = 7;
            this.LB_ThemTruongTitle.Text = "Thêm Trường";
            // 
            // ThemTruong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 387);
            this.Controls.Add(this.LB_ThemTruongTitle);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.TB_Luong1Ca);
            this.Controls.Add(this.TB_TenTruong);
            this.Controls.Add(this.TB_MaTruong);
            this.Controls.Add(this.LB_Luong1Ca);
            this.Controls.Add(this.LB_TenTruong);
            this.Controls.Add(this.LB_MaTruong);
            this.Name = "ThemTruong";
            this.Text = "ThemTruong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_MaTruong;
        private System.Windows.Forms.Label LB_TenTruong;
        private System.Windows.Forms.Label LB_Luong1Ca;
        private System.Windows.Forms.TextBox TB_MaTruong;
        private System.Windows.Forms.TextBox TB_TenTruong;
        private System.Windows.Forms.TextBox TB_Luong1Ca;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label LB_ThemTruongTitle;
    }
}