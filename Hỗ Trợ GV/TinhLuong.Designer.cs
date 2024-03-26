
namespace Hỗ_Trợ_GV
{
    partial class TinhLuong
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
            this.dataGV_TinhLuong = new System.Windows.Forms.DataGridView();
            this.BT_LoadData = new System.Windows.Forms.Button();
            this.BT_ExportExcel = new System.Windows.Forms.Button();
            this.dTP_TuNgay = new System.Windows.Forms.DateTimePicker();
            this.dTP_DenNgay = new System.Windows.Forms.DateTimePicker();
            this.LB_TuNgay = new System.Windows.Forms.Label();
            this.LB_DenNgay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_TinhLuong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV_TinhLuong
            // 
            this.dataGV_TinhLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_TinhLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_TinhLuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV_TinhLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_TinhLuong.Location = new System.Drawing.Point(55, 86);
            this.dataGV_TinhLuong.Name = "dataGV_TinhLuong";
            this.dataGV_TinhLuong.ReadOnly = true;
            this.dataGV_TinhLuong.RowHeadersWidth = 51;
            this.dataGV_TinhLuong.RowTemplate.Height = 24;
            this.dataGV_TinhLuong.Size = new System.Drawing.Size(1093, 449);
            this.dataGV_TinhLuong.TabIndex = 0;
            // 
            // BT_LoadData
            // 
            this.BT_LoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_LoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.BT_LoadData.FlatAppearance.BorderSize = 0;
            this.BT_LoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_LoadData.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LoadData.ForeColor = System.Drawing.Color.White;
            this.BT_LoadData.Location = new System.Drawing.Point(1011, 35);
            this.BT_LoadData.Name = "BT_LoadData";
            this.BT_LoadData.Size = new System.Drawing.Size(137, 45);
            this.BT_LoadData.TabIndex = 1;
            this.BT_LoadData.Text = "Tải dữ liệu";
            this.BT_LoadData.UseVisualStyleBackColor = false;
            this.BT_LoadData.Click += new System.EventHandler(this.BT_LoadData_Click);
            // 
            // BT_ExportExcel
            // 
            this.BT_ExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_ExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(174)))), ((int)(((byte)(104)))));
            this.BT_ExportExcel.FlatAppearance.BorderSize = 0;
            this.BT_ExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ExportExcel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ExportExcel.ForeColor = System.Drawing.Color.White;
            this.BT_ExportExcel.Location = new System.Drawing.Point(859, 35);
            this.BT_ExportExcel.Name = "BT_ExportExcel";
            this.BT_ExportExcel.Size = new System.Drawing.Size(137, 45);
            this.BT_ExportExcel.TabIndex = 2;
            this.BT_ExportExcel.Text = "Xuất File Excel";
            this.BT_ExportExcel.UseVisualStyleBackColor = false;
            this.BT_ExportExcel.Click += new System.EventHandler(this.BT_ExportExcel_Click);
            // 
            // dTP_TuNgay
            // 
            this.dTP_TuNgay.CustomFormat = "yyyy-MM-dd";
            this.dTP_TuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_TuNgay.Location = new System.Drawing.Point(96, 8);
            this.dTP_TuNgay.Name = "dTP_TuNgay";
            this.dTP_TuNgay.Size = new System.Drawing.Size(116, 22);
            this.dTP_TuNgay.TabIndex = 3;
            // 
            // dTP_DenNgay
            // 
            this.dTP_DenNgay.CustomFormat = "yyyy-MM-dd";
            this.dTP_DenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_DenNgay.Location = new System.Drawing.Point(329, 8);
            this.dTP_DenNgay.Name = "dTP_DenNgay";
            this.dTP_DenNgay.Size = new System.Drawing.Size(116, 22);
            this.dTP_DenNgay.TabIndex = 4;
            // 
            // LB_TuNgay
            // 
            this.LB_TuNgay.AutoSize = true;
            this.LB_TuNgay.Font = new System.Drawing.Font("GMV DIN Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TuNgay.ForeColor = System.Drawing.Color.White;
            this.LB_TuNgay.Location = new System.Drawing.Point(27, 5);
            this.LB_TuNgay.Name = "LB_TuNgay";
            this.LB_TuNgay.Size = new System.Drawing.Size(63, 26);
            this.LB_TuNgay.TabIndex = 5;
            this.LB_TuNgay.Text = "Từ ngày:";
            // 
            // LB_DenNgay
            // 
            this.LB_DenNgay.AutoSize = true;
            this.LB_DenNgay.Font = new System.Drawing.Font("GMV DIN Pro Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DenNgay.ForeColor = System.Drawing.Color.White;
            this.LB_DenNgay.Location = new System.Drawing.Point(252, 5);
            this.LB_DenNgay.Name = "LB_DenNgay";
            this.LB_DenNgay.Size = new System.Drawing.Size(71, 26);
            this.LB_DenNgay.TabIndex = 6;
            this.LB_DenNgay.Text = "Đến ngày:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.LB_TuNgay);
            this.panel1.Controls.Add(this.LB_DenNgay);
            this.panel1.Controls.Add(this.dTP_TuNgay);
            this.panel1.Controls.Add(this.dTP_DenNgay);
            this.panel1.Location = new System.Drawing.Point(38, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 40);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel2.Location = new System.Drawing.Point(38, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 475);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel3.Location = new System.Drawing.Point(38, 549);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1128, 2);
            this.panel3.TabIndex = 9;
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 583);
            this.Controls.Add(this.BT_LoadData);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BT_ExportExcel);
            this.Controls.Add(this.dataGV_TinhLuong);
            this.Name = "TinhLuong";
            this.Text = "TinhLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_TinhLuong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_TinhLuong;
        private System.Windows.Forms.Button BT_LoadData;
        private System.Windows.Forms.Button BT_ExportExcel;
        private System.Windows.Forms.DateTimePicker dTP_TuNgay;
        private System.Windows.Forms.DateTimePicker dTP_DenNgay;
        private System.Windows.Forms.Label LB_TuNgay;
        private System.Windows.Forms.Label LB_DenNgay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}