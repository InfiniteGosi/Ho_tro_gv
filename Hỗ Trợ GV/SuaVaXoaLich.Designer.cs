namespace Hỗ_Trợ_GV
{
    partial class SuaVaXoaLich
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_delete = new System.Windows.Forms.Button();
            this.LB_shiftinfo = new System.Windows.Forms.Label();
            this.CB_monhoc = new System.Windows.Forms.ComboBox();
            this.CB_truong = new System.Windows.Forms.ComboBox();
            this.BTN_sua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Trường";
            // 
            // BT_delete
            // 
            this.BT_delete.Location = new System.Drawing.Point(450, 246);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.Size = new System.Drawing.Size(85, 35);
            this.BT_delete.TabIndex = 9;
            this.BT_delete.Text = "Xóa";
            this.BT_delete.UseVisualStyleBackColor = true;
            this.BT_delete.Click += new System.EventHandler(this.BT_delete_Click);
            // 
            // LB_shiftinfo
            // 
            this.LB_shiftinfo.AutoSize = true;
            this.LB_shiftinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_shiftinfo.Location = new System.Drawing.Point(244, 9);
            this.LB_shiftinfo.Name = "LB_shiftinfo";
            this.LB_shiftinfo.Size = new System.Drawing.Size(58, 22);
            this.LB_shiftinfo.TabIndex = 8;
            this.LB_shiftinfo.Text = "label1";
            // 
            // CB_monhoc
            // 
            this.CB_monhoc.FormattingEnabled = true;
            this.CB_monhoc.Location = new System.Drawing.Point(107, 178);
            this.CB_monhoc.Name = "CB_monhoc";
            this.CB_monhoc.Size = new System.Drawing.Size(375, 24);
            this.CB_monhoc.TabIndex = 7;
            // 
            // CB_truong
            // 
            this.CB_truong.FormattingEnabled = true;
            this.CB_truong.Location = new System.Drawing.Point(107, 90);
            this.CB_truong.Name = "CB_truong";
            this.CB_truong.Size = new System.Drawing.Size(375, 24);
            this.CB_truong.TabIndex = 6;
            this.CB_truong.SelectedIndexChanged += new System.EventHandler(this.CB_truong_SelectedIndexChanged);
            // 
            // BTN_sua
            // 
            this.BTN_sua.Location = new System.Drawing.Point(330, 246);
            this.BTN_sua.Name = "BTN_sua";
            this.BTN_sua.Size = new System.Drawing.Size(85, 35);
            this.BTN_sua.TabIndex = 12;
            this.BTN_sua.Text = "Sửa";
            this.BTN_sua.UseVisualStyleBackColor = true;
            this.BTN_sua.Click += new System.EventHandler(this.BTN_sua_Click);
            // 
            // SuaVaXoaLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 307);
            this.Controls.Add(this.BTN_sua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_delete);
            this.Controls.Add(this.LB_shiftinfo);
            this.Controls.Add(this.CB_monhoc);
            this.Controls.Add(this.CB_truong);
            this.Name = "SuaVaXoaLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuaVaXoaLich";
            this.Load += new System.EventHandler(this.SuaVaXoaLich_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_delete;
        private System.Windows.Forms.Label LB_shiftinfo;
        private System.Windows.Forms.ComboBox CB_monhoc;
        private System.Windows.Forms.ComboBox CB_truong;
        private System.Windows.Forms.Button BTN_sua;
    }
}