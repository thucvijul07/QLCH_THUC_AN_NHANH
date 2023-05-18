namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_TTDH
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TTDH));
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.dgv_ds_dh_chua_thanh_toan = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_dh_chua_thanh_toan)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(12, 258);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(142, 36);
            this.btn_reload.TabIndex = 1;
            this.btn_reload.Text = "&CẬP NHẬT DỮ LIỆU";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(631, 258);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(77, 36);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "TH&OÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DANH SÁCH ĐƠN HÀNG CHƯA THANH TOÁN";
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(160, 258);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(463, 36);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "CẬP &NHẬT TRẠNG THÁI THANH TOÁN CHO ĐƠN HÀNG ĐANG CHỌN";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_capnhat_thanhtoan_Click);
            // 
            // dgv_ds_dh_chua_thanh_toan
            // 
            this.dgv_ds_dh_chua_thanh_toan.AllowUserToAddRows = false;
            this.dgv_ds_dh_chua_thanh_toan.AllowUserToOrderColumns = true;
            this.dgv_ds_dh_chua_thanh_toan.AllowUserToResizeRows = false;
            this.dgv_ds_dh_chua_thanh_toan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ds_dh_chua_thanh_toan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ds_dh_chua_thanh_toan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ds_dh_chua_thanh_toan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ds_dh_chua_thanh_toan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ds_dh_chua_thanh_toan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ds_dh_chua_thanh_toan.ColumnHeadersHeight = 30;
            this.dgv_ds_dh_chua_thanh_toan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ds_dh_chua_thanh_toan.EnableHeadersVisualStyles = false;
            this.dgv_ds_dh_chua_thanh_toan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ds_dh_chua_thanh_toan.Location = new System.Drawing.Point(14, 26);
            this.dgv_ds_dh_chua_thanh_toan.MultiSelect = false;
            this.dgv_ds_dh_chua_thanh_toan.Name = "dgv_ds_dh_chua_thanh_toan";
            this.dgv_ds_dh_chua_thanh_toan.ReadOnly = true;
            this.dgv_ds_dh_chua_thanh_toan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ds_dh_chua_thanh_toan.RowHeadersVisible = false;
            this.dgv_ds_dh_chua_thanh_toan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ds_dh_chua_thanh_toan.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.dgv_ds_dh_chua_thanh_toan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_dh_chua_thanh_toan.Size = new System.Drawing.Size(693, 226);
            this.dgv_ds_dh_chua_thanh_toan.TabIndex = 0;
            // 
            // Frm_TTDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(720, 308);
            this.Controls.Add(this.dgv_ds_dh_chua_thanh_toan);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_TTDH";
            this.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.Frm_TTDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_dh_chua_thanh_toan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridView dgv_ds_dh_chua_thanh_toan;
    }
}