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
            this.SuspendLayout();
            // 
            // bt_DangXuat
            // 
            this.bt_DangXuat.Location = new System.Drawing.Point(930, 506);
            this.bt_DangXuat.Name = "bt_DangXuat";
            this.bt_DangXuat.Size = new System.Drawing.Size(125, 36);
            this.bt_DangXuat.TabIndex = 0;
            this.bt_DangXuat.Text = "Đăng Xuất";
            this.bt_DangXuat.UseVisualStyleBackColor = true;
            this.bt_DangXuat.Click += new System.EventHandler(this.bt_DangXuat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bt_DangXuat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_DangXuat;
    }
}