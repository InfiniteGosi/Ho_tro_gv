namespace Hỗ_Trợ_GV
{
    partial class UserControlBlank
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
            this.LB_shift = new System.Windows.Forms.Label();
            this.TM_datlich = new System.Windows.Forms.Timer(this.components);
            this.TM_suaxoalich = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LB_shift
            // 
            this.LB_shift.AutoSize = true;
            this.LB_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_shift.Location = new System.Drawing.Point(3, 45);
            this.LB_shift.Name = "LB_shift";
            this.LB_shift.Size = new System.Drawing.Size(0, 16);
            this.LB_shift.TabIndex = 0;
            // 
            // TM_datlich
            // 
            this.TM_datlich.Tick += new System.EventHandler(this.TM_datlich_Tick);
            // 
            // TM_suaxoalich
            // 
            this.TM_suaxoalich.Tick += new System.EventHandler(this.TM_suaxoalich_Tick);
            // 
            // UserControlBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LB_shift);
            this.Name = "UserControlBlank";
            this.Size = new System.Drawing.Size(192, 127);
            this.Load += new System.EventHandler(this.UserControlBlank_Load);
            this.Click += new System.EventHandler(this.UserControlBlank_Click);
            this.MouseEnter += new System.EventHandler(this.UserControlBlank_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControlBlank_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_shift;
        private System.Windows.Forms.Timer TM_datlich;
        private System.Windows.Forms.Timer TM_suaxoalich;
    }
}
