
namespace Hỗ_Trợ_GV
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LB_From = new System.Windows.Forms.Label();
            this.LB_To = new System.Windows.Forms.Label();
            this.BT_LoadThongKe = new System.Windows.Forms.Button();
            this.dTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.dTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB_From
            // 
            this.LB_From.AutoSize = true;
            this.LB_From.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_From.ForeColor = System.Drawing.Color.White;
            this.LB_From.Location = new System.Drawing.Point(9, 8);
            this.LB_From.Name = "LB_From";
            this.LB_From.Size = new System.Drawing.Size(80, 22);
            this.LB_From.TabIndex = 3;
            this.LB_From.Text = "Từ ngày:";
            // 
            // LB_To
            // 
            this.LB_To.AutoSize = true;
            this.LB_To.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_To.ForeColor = System.Drawing.Color.White;
            this.LB_To.Location = new System.Drawing.Point(234, 8);
            this.LB_To.Name = "LB_To";
            this.LB_To.Size = new System.Drawing.Size(89, 22);
            this.LB_To.TabIndex = 4;
            this.LB_To.Text = "Đến ngày:";
            // 
            // BT_LoadThongKe
            // 
            this.BT_LoadThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_LoadThongKe.BackColor = System.Drawing.Color.Teal;
            this.BT_LoadThongKe.FlatAppearance.BorderSize = 0;
            this.BT_LoadThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_LoadThongKe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LoadThongKe.ForeColor = System.Drawing.Color.White;
            this.BT_LoadThongKe.Location = new System.Drawing.Point(1011, 35);
            this.BT_LoadThongKe.Name = "BT_LoadThongKe";
            this.BT_LoadThongKe.Size = new System.Drawing.Size(137, 45);
            this.BT_LoadThongKe.TabIndex = 5;
            this.BT_LoadThongKe.Text = "Thống Kê";
            this.BT_LoadThongKe.UseVisualStyleBackColor = false;
            this.BT_LoadThongKe.Click += new System.EventHandler(this.BT_LoadThongKe_Click);
            // 
            // dTP_TuNgay
            // 
            this.dTP_TuNgay.CustomFormat = "yyyy-MM-dd";
            this.dTP_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_TuNgay.Location = new System.Drawing.Point(103, 9);
            this.dTP_TuNgay.Name = "dTP_TuNgay";
            this.dTP_TuNgay.Size = new System.Drawing.Size(96, 22);
            this.dTP_TuNgay.TabIndex = 6;
            // 
            // dTP_DenNgay
            // 
            this.dTP_DenNgay.CustomFormat = "yyyy-MM-dd";
            this.dTP_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_DenNgay.Location = new System.Drawing.Point(338, 9);
            this.dTP_DenNgay.Name = "dTP_DenNgay";
            this.dTP_DenNgay.Size = new System.Drawing.Size(97, 22);
            this.dTP_DenNgay.TabIndex = 7;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(38, 92);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1110, 466);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.dTP_TuNgay);
            this.panel1.Controls.Add(this.LB_From);
            this.panel1.Controls.Add(this.dTP_DenNgay);
            this.panel1.Controls.Add(this.LB_To);
            this.panel1.Location = new System.Drawing.Point(38, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 40);
            this.panel1.TabIndex = 9;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1202, 583);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BT_LoadThongKe);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongKe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LB_From;
        private System.Windows.Forms.Label LB_To;
        private System.Windows.Forms.Button BT_LoadThongKe;
        private System.Windows.Forms.DateTimePicker dTP_TuNgay;
        private System.Windows.Forms.DateTimePicker dTP_DenNgay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
    }
}