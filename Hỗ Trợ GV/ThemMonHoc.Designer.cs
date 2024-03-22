namespace Hỗ_Trợ_GV
{
    partial class ThemMonHoc
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
            this.CB_Truong = new System.Windows.Forms.ComboBox();
            this.TB_MaMon = new System.Windows.Forms.TextBox();
            this.TB_TenMon = new System.Windows.Forms.TextBox();
            this.LB_MaMon = new System.Windows.Forms.Label();
            this.LB_TenMon = new System.Windows.Forms.Label();
            this.LB_TenTruong = new System.Windows.Forms.Label();
            this.BT_ThemTruong = new System.Windows.Forms.Button();
            this.BT_Save = new System.Windows.Forms.Button();
            this.LB_FormThemMon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_Truong
            // 
            this.CB_Truong.FormattingEnabled = true;
            this.CB_Truong.Location = new System.Drawing.Point(209, 252);
            this.CB_Truong.Name = "CB_Truong";
            this.CB_Truong.Size = new System.Drawing.Size(336, 24);
            this.CB_Truong.TabIndex = 0;
            // 
            // TB_MaMon
            // 
            this.TB_MaMon.Location = new System.Drawing.Point(209, 101);
            this.TB_MaMon.Name = "TB_MaMon";
            this.TB_MaMon.Size = new System.Drawing.Size(164, 22);
            this.TB_MaMon.TabIndex = 1;
            // 
            // TB_TenMon
            // 
            this.TB_TenMon.Location = new System.Drawing.Point(209, 178);
            this.TB_TenMon.Name = "TB_TenMon";
            this.TB_TenMon.Size = new System.Drawing.Size(336, 22);
            this.TB_TenMon.TabIndex = 2;
            // 
            // LB_MaMon
            // 
            this.LB_MaMon.AutoSize = true;
            this.LB_MaMon.Location = new System.Drawing.Point(85, 101);
            this.LB_MaMon.Name = "LB_MaMon";
            this.LB_MaMon.Size = new System.Drawing.Size(55, 16);
            this.LB_MaMon.TabIndex = 3;
            this.LB_MaMon.Text = "Mã Môn";
            // 
            // LB_TenMon
            // 
            this.LB_TenMon.AutoSize = true;
            this.LB_TenMon.Location = new System.Drawing.Point(85, 184);
            this.LB_TenMon.Name = "LB_TenMon";
            this.LB_TenMon.Size = new System.Drawing.Size(85, 16);
            this.LB_TenMon.TabIndex = 4;
            this.LB_TenMon.Text = "Tên môn học";
            // 
            // LB_TenTruong
            // 
            this.LB_TenTruong.AutoSize = true;
            this.LB_TenTruong.Location = new System.Drawing.Point(85, 260);
            this.LB_TenTruong.Name = "LB_TenTruong";
            this.LB_TenTruong.Size = new System.Drawing.Size(71, 16);
            this.LB_TenTruong.TabIndex = 5;
            this.LB_TenTruong.Text = "Tên trường";
            // 
            // BT_ThemTruong
            // 
            this.BT_ThemTruong.Location = new System.Drawing.Point(431, 316);
            this.BT_ThemTruong.Name = "BT_ThemTruong";
            this.BT_ThemTruong.Size = new System.Drawing.Size(130, 30);
            this.BT_ThemTruong.TabIndex = 6;
            this.BT_ThemTruong.Text = "Thêm Trường";
            this.BT_ThemTruong.UseVisualStyleBackColor = true;
            this.BT_ThemTruong.Click += new System.EventHandler(this.BT_ThemTruong_Click);
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(590, 316);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(75, 30);
            this.BT_Save.TabIndex = 7;
            this.BT_Save.Text = "Lưu";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // LB_FormThemMon
            // 
            this.LB_FormThemMon.AutoSize = true;
            this.LB_FormThemMon.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FormThemMon.Location = new System.Drawing.Point(159, 9);
            this.LB_FormThemMon.Name = "LB_FormThemMon";
            this.LB_FormThemMon.Size = new System.Drawing.Size(527, 68);
            this.LB_FormThemMon.TabIndex = 8;
            this.LB_FormThemMon.Text = "THÊM MÔN HỌC";
            // 
            // ThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.LB_FormThemMon);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.BT_ThemTruong);
            this.Controls.Add(this.LB_TenTruong);
            this.Controls.Add(this.LB_TenMon);
            this.Controls.Add(this.LB_MaMon);
            this.Controls.Add(this.TB_TenMon);
            this.Controls.Add(this.TB_MaMon);
            this.Controls.Add(this.CB_Truong);
            this.Name = "ThemMonHoc";
            this.Text = "ThemMonHoc";
            this.Load += new System.EventHandler(this.ThemMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Truong;
        private System.Windows.Forms.TextBox TB_MaMon;
        private System.Windows.Forms.TextBox TB_TenMon;
        private System.Windows.Forms.Label LB_MaMon;
        private System.Windows.Forms.Label LB_TenMon;
        private System.Windows.Forms.Label LB_TenTruong;
        private System.Windows.Forms.Button BT_ThemTruong;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Label LB_FormThemMon;
    }
}