
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_TinhLuong)).BeginInit();
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
            this.dataGV_TinhLuong.Location = new System.Drawing.Point(79, 121);
            this.dataGV_TinhLuong.Name = "dataGV_TinhLuong";
            this.dataGV_TinhLuong.ReadOnly = true;
            this.dataGV_TinhLuong.RowHeadersWidth = 51;
            this.dataGV_TinhLuong.RowTemplate.Height = 24;
            this.dataGV_TinhLuong.Size = new System.Drawing.Size(1036, 428);
            this.dataGV_TinhLuong.TabIndex = 0;
            // 
            // BT_LoadData
            // 
            this.BT_LoadData.Location = new System.Drawing.Point(978, 70);
            this.BT_LoadData.Name = "BT_LoadData";
            this.BT_LoadData.Size = new System.Drawing.Size(137, 23);
            this.BT_LoadData.TabIndex = 1;
            this.BT_LoadData.Text = "Tải dữ liệu";
            this.BT_LoadData.UseVisualStyleBackColor = true;
            this.BT_LoadData.Click += new System.EventHandler(this.BT_LoadData_Click);
            // 
            // BT_ExportExcel
            // 
            this.BT_ExportExcel.Location = new System.Drawing.Point(762, 70);
            this.BT_ExportExcel.Name = "BT_ExportExcel";
            this.BT_ExportExcel.Size = new System.Drawing.Size(132, 23);
            this.BT_ExportExcel.TabIndex = 2;
            this.BT_ExportExcel.Text = "Xuất File Excel";
            this.BT_ExportExcel.UseVisualStyleBackColor = true;
            this.BT_ExportExcel.Click += new System.EventHandler(this.BT_ExportExcel_Click);
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 583);
            this.Controls.Add(this.BT_ExportExcel);
            this.Controls.Add(this.BT_LoadData);
            this.Controls.Add(this.dataGV_TinhLuong);
            this.Name = "TinhLuong";
            this.Text = "TinhLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_TinhLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV_TinhLuong;
        private System.Windows.Forms.Button BT_LoadData;
        private System.Windows.Forms.Button BT_ExportExcel;
    }
}