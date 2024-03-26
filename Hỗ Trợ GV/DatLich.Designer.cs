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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_truong
            // 
            this.CB_truong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_truong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_truong.FormattingEnabled = true;
            this.CB_truong.Location = new System.Drawing.Point(40, 122);
            this.CB_truong.Name = "CB_truong";
            this.CB_truong.Size = new System.Drawing.Size(375, 28);
            this.CB_truong.TabIndex = 0;
            this.CB_truong.SelectedIndexChanged += new System.EventHandler(this.CB_truong_SelectedIndexChanged);
            // 
            // CB_monhoc
            // 
            this.CB_monhoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_monhoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_monhoc.FormattingEnabled = true;
            this.CB_monhoc.Location = new System.Drawing.Point(40, 213);
            this.CB_monhoc.Name = "CB_monhoc";
            this.CB_monhoc.Size = new System.Drawing.Size(375, 28);
            this.CB_monhoc.TabIndex = 1;
            // 
            // LB_shiftinfo
            // 
            this.LB_shiftinfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LB_shiftinfo.AutoSize = true;
            this.LB_shiftinfo.Font = new System.Drawing.Font("GMV DIN Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_shiftinfo.ForeColor = System.Drawing.Color.White;
            this.LB_shiftinfo.Location = new System.Drawing.Point(3, 5);
            this.LB_shiftinfo.Name = "LB_shiftinfo";
            this.LB_shiftinfo.Size = new System.Drawing.Size(59, 31);
            this.LB_shiftinfo.TabIndex = 2;
            this.LB_shiftinfo.Text = "label1";
            // 
            // BT_save
            // 
            this.BT_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.BT_save.FlatAppearance.BorderSize = 0;
            this.BT_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_save.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_save.ForeColor = System.Drawing.Color.White;
            this.BT_save.Location = new System.Drawing.Point(344, 395);
            this.BT_save.Name = "BT_save";
            this.BT_save.Size = new System.Drawing.Size(91, 43);
            this.BT_save.TabIndex = 3;
            this.BT_save.Text = "Lưu";
            this.BT_save.UseVisualStyleBackColor = false;
            this.BT_save.Click += new System.EventHandler(this.BT_save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GMV DIN Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label1.Location = new System.Drawing.Point(35, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trường:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GMV DIN Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Môn Học:";
            // 
            // BT_AddSubject
            // 
            this.BT_AddSubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_AddSubject.BackColor = System.Drawing.Color.Teal;
            this.BT_AddSubject.FlatAppearance.BorderSize = 0;
            this.BT_AddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_AddSubject.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddSubject.ForeColor = System.Drawing.Color.White;
            this.BT_AddSubject.Location = new System.Drawing.Point(12, 395);
            this.BT_AddSubject.Name = "BT_AddSubject";
            this.BT_AddSubject.Size = new System.Drawing.Size(137, 43);
            this.BT_AddSubject.TabIndex = 6;
            this.BT_AddSubject.Text = "Thêm Môn";
            this.BT_AddSubject.UseVisualStyleBackColor = false;
            this.BT_AddSubject.Click += new System.EventHandler(this.BT_AddSubject_Click);
            // 
            // BT_ThemTruong
            // 
            this.BT_ThemTruong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BT_ThemTruong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(153)))), ((int)(((byte)(112)))));
            this.BT_ThemTruong.FlatAppearance.BorderSize = 0;
            this.BT_ThemTruong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThemTruong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ThemTruong.ForeColor = System.Drawing.Color.White;
            this.BT_ThemTruong.Location = new System.Drawing.Point(178, 395);
            this.BT_ThemTruong.Name = "BT_ThemTruong";
            this.BT_ThemTruong.Size = new System.Drawing.Size(137, 43);
            this.BT_ThemTruong.TabIndex = 7;
            this.BT_ThemTruong.Text = "Thêm Trường";
            this.BT_ThemTruong.UseVisualStyleBackColor = false;
            this.BT_ThemTruong.Click += new System.EventHandler(this.BT_ThemTruong_Click);
            // 
            // CB_color
            // 
            this.CB_color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CB_color.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_color.FormattingEnabled = true;
            this.CB_color.Location = new System.Drawing.Point(40, 304);
            this.CB_color.Name = "CB_color";
            this.CB_color.Size = new System.Drawing.Size(151, 28);
            this.CB_color.TabIndex = 8;
            this.CB_color.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CB_color_DrawItem);
            this.CB_color.SelectedIndexChanged += new System.EventHandler(this.CB_color_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GMV DIN Pro Cond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.label3.Location = new System.Drawing.Point(35, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Màu:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel4.Location = new System.Drawing.Point(12, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(424, 1);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel3.Location = new System.Drawing.Point(435, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 328);
            this.panel3.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 328);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.LB_shiftinfo);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 42);
            this.panel2.TabIndex = 20;
            // 
            // DatLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_color);
            this.Controls.Add(this.BT_ThemTruong);
            this.Controls.Add(this.BT_AddSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_save);
            this.Controls.Add(this.CB_monhoc);
            this.Controls.Add(this.CB_truong);
            this.Name = "DatLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatLich";
            this.Load += new System.EventHandler(this.DatLich_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}