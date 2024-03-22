namespace Hỗ_Trợ_GV
{
    partial class DatLich
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
            this.CB_truong = new System.Windows.Forms.ComboBox();
            this.CB_monhoc = new System.Windows.Forms.ComboBox();
            this.LB_shiftinfo = new System.Windows.Forms.Label();
            this.BT_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_AddSubject = new System.Windows.Forms.Button();
            this.BT_ThemTruong = new System.Windows.Forms.Button();
            this.CB_color = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CB_truong
            // 
            this.CB_truong.FormattingEnabled = true;
            this.CB_truong.Location = new System.Drawing.Point(38, 103);
            this.CB_truong.Name = "CB_truong";
            this.CB_truong.Size = new System.Drawing.Size(375, 24);
            this.CB_truong.TabIndex = 0;
            this.CB_truong.SelectedIndexChanged += new System.EventHandler(this.CB_truong_SelectedIndexChanged);
            // 
            // CB_monhoc
            // 
            this.CB_monhoc.FormattingEnabled = true;
            this.CB_monhoc.Location = new System.Drawing.Point(38, 207);
            this.CB_monhoc.Name = "CB_monhoc";
            this.CB_monhoc.Size = new System.Drawing.Size(375, 24);
            this.CB_monhoc.TabIndex = 1;
            // 
            // LB_shiftinfo
            // 
            this.LB_shiftinfo.AutoSize = true;
            this.LB_shiftinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_shiftinfo.Location = new System.Drawing.Point(313, 9);
            this.LB_shiftinfo.Name = "LB_shiftinfo";
            this.LB_shiftinfo.Size = new System.Drawing.Size(58, 22);
            this.LB_shiftinfo.TabIndex = 2;
            this.LB_shiftinfo.Text = "label1";
            // 
            // BT_save
            // 
            this.BT_save.Location = new System.Drawing.Point(504, 320);
            this.BT_save.Name = "BT_save";
            this.BT_save.Size = new System.Drawing.Size(85, 35);
            this.BT_save.TabIndex = 3;
            this.BT_save.Text = "Lưu";
            this.BT_save.UseVisualStyleBackColor = true;
            this.BT_save.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trường";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn học";
            // 
            // BT_AddSubject
            // 
            this.BT_AddSubject.Location = new System.Drawing.Point(128, 320);
            this.BT_AddSubject.Name = "BT_AddSubject";
            this.BT_AddSubject.Size = new System.Drawing.Size(93, 35);
            this.BT_AddSubject.TabIndex = 6;
            this.BT_AddSubject.Text = "Thêm Môn";
            this.BT_AddSubject.UseVisualStyleBackColor = true;
            this.BT_AddSubject.Click += new System.EventHandler(this.BT_AddSubject_Click);
            // 
            // BT_ThemTruong
            // 
            this.BT_ThemTruong.Location = new System.Drawing.Point(290, 320);
            this.BT_ThemTruong.Name = "BT_ThemTruong";
            this.BT_ThemTruong.Size = new System.Drawing.Size(136, 35);
            this.BT_ThemTruong.TabIndex = 7;
            this.BT_ThemTruong.Text = "Thêm Trường";
            this.BT_ThemTruong.UseVisualStyleBackColor = true;
            this.BT_ThemTruong.Click += new System.EventHandler(this.BT_ThemTruong_Click);
            // 
            // CB_color
            // 
            this.CB_color.FormattingEnabled = true;
            this.CB_color.Location = new System.Drawing.Point(518, 154);
            this.CB_color.Name = "CB_color";
            this.CB_color.Size = new System.Drawing.Size(151, 24);
            this.CB_color.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Màu";
            // 
            // DatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 413);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_color);
            this.Controls.Add(this.BT_ThemTruong);
            this.Controls.Add(this.BT_AddSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_save);
            this.Controls.Add(this.LB_shiftinfo);
            this.Controls.Add(this.CB_monhoc);
            this.Controls.Add(this.CB_truong);
            this.Name = "DatLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatLich";
            this.Load += new System.EventHandler(this.DatLich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_truong;
        private System.Windows.Forms.ComboBox CB_monhoc;
        private System.Windows.Forms.Label LB_shiftinfo;
        private System.Windows.Forms.Button BT_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_AddSubject;
        private System.Windows.Forms.Button BT_ThemTruong;
        private System.Windows.Forms.ComboBox CB_color;
        private System.Windows.Forms.Label label3;
    }
}