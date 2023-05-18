namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_DSDH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DSDH));
            this.btn_reload = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.dgv_ds_dh_chua_pay = new System.Windows.Forms.DataGridView();
            this.TabC1 = new System.Windows.Forms.TabControl();
            this.TabP1 = new System.Windows.Forms.TabPage();
            this.TabP2 = new System.Windows.Forms.TabPage();
            this.dgv_ds_dh_da_pay = new System.Windows.Forms.DataGridView();
            this.dgv_dh_chitiet = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_huydh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_dh_chua_pay)).BeginInit();
            this.TabC1.SuspendLayout();
            this.TabP1.SuspendLayout();
            this.TabP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_dh_da_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dh_chitiet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_reload
            // 
            this.btn_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reload.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reload.Location = new System.Drawing.Point(12, 501);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(242, 36);
            this.btn_reload.TabIndex = 2;
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
            this.btn_thoat.Location = new System.Drawing.Point(729, 501);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(96, 36);
            this.btn_thoat.TabIndex = 3;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // dgv_ds_dh_chua_pay
            // 
            this.dgv_ds_dh_chua_pay.AllowUserToAddRows = false;
            this.dgv_ds_dh_chua_pay.AllowUserToOrderColumns = true;
            this.dgv_ds_dh_chua_pay.AllowUserToResizeRows = false;
            this.dgv_ds_dh_chua_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ds_dh_chua_pay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ds_dh_chua_pay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ds_dh_chua_pay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ds_dh_chua_pay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ds_dh_chua_pay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ds_dh_chua_pay.ColumnHeadersHeight = 30;
            this.dgv_ds_dh_chua_pay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ds_dh_chua_pay.EnableHeadersVisualStyles = false;
            this.dgv_ds_dh_chua_pay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ds_dh_chua_pay.Location = new System.Drawing.Point(6, 6);
            this.dgv_ds_dh_chua_pay.MultiSelect = false;
            this.dgv_ds_dh_chua_pay.Name = "dgv_ds_dh_chua_pay";
            this.dgv_ds_dh_chua_pay.ReadOnly = true;
            this.dgv_ds_dh_chua_pay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ds_dh_chua_pay.RowHeadersVisible = false;
            this.dgv_ds_dh_chua_pay.RowHeadersWidth = 62;
            this.dgv_ds_dh_chua_pay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ds_dh_chua_pay.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.dgv_ds_dh_chua_pay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_dh_chua_pay.Size = new System.Drawing.Size(869, 222);
            this.dgv_ds_dh_chua_pay.TabIndex = 0;
            this.dgv_ds_dh_chua_pay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ds_dh_chua_pay_CellClick);
            // 
            // TabC1
            // 
            this.TabC1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabC1.Controls.Add(this.TabP1);
            this.TabC1.Controls.Add(this.TabP2);
            this.TabC1.Location = new System.Drawing.Point(13, 11);
            this.TabC1.Name = "TabC1";
            this.TabC1.SelectedIndex = 0;
            this.TabC1.Size = new System.Drawing.Size(811, 260);
            this.TabC1.TabIndex = 0;
            this.TabC1.Click += new System.EventHandler(this.TabC1_Click);
            // 
            // TabP1
            // 
            this.TabP1.Controls.Add(this.dgv_ds_dh_chua_pay);
            this.TabP1.Location = new System.Drawing.Point(4, 29);
            this.TabP1.Name = "TabP1";
            this.TabP1.Padding = new System.Windows.Forms.Padding(3);
            this.TabP1.Size = new System.Drawing.Size(881, 227);
            this.TabP1.TabIndex = 0;
            this.TabP1.Text = "DANH SÁCH ĐƠN HÀNG CHƯA THANH TOÁN";
            this.TabP1.UseVisualStyleBackColor = true;
            // 
            // TabP2
            // 
            this.TabP2.Controls.Add(this.dgv_ds_dh_da_pay);
            this.TabP2.Location = new System.Drawing.Point(4, 29);
            this.TabP2.Name = "TabP2";
            this.TabP2.Padding = new System.Windows.Forms.Padding(3);
            this.TabP2.Size = new System.Drawing.Size(803, 227);
            this.TabP2.TabIndex = 1;
            this.TabP2.Text = "DANH SÁCH ĐƠN HÀNG ĐÃ THANH TOÁN";
            this.TabP2.UseVisualStyleBackColor = true;
            // 
            // dgv_ds_dh_da_pay
            // 
            this.dgv_ds_dh_da_pay.AllowUserToAddRows = false;
            this.dgv_ds_dh_da_pay.AllowUserToOrderColumns = true;
            this.dgv_ds_dh_da_pay.AllowUserToResizeRows = false;
            this.dgv_ds_dh_da_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ds_dh_da_pay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ds_dh_da_pay.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ds_dh_da_pay.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ds_dh_da_pay.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ds_dh_da_pay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ds_dh_da_pay.ColumnHeadersHeight = 30;
            this.dgv_ds_dh_da_pay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ds_dh_da_pay.EnableHeadersVisualStyles = false;
            this.dgv_ds_dh_da_pay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ds_dh_da_pay.Location = new System.Drawing.Point(6, 6);
            this.dgv_ds_dh_da_pay.MultiSelect = false;
            this.dgv_ds_dh_da_pay.Name = "dgv_ds_dh_da_pay";
            this.dgv_ds_dh_da_pay.ReadOnly = true;
            this.dgv_ds_dh_da_pay.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ds_dh_da_pay.RowHeadersVisible = false;
            this.dgv_ds_dh_da_pay.RowHeadersWidth = 62;
            this.dgv_ds_dh_da_pay.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_ds_dh_da_pay.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.dgv_ds_dh_da_pay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_dh_da_pay.Size = new System.Drawing.Size(797, 222);
            this.dgv_ds_dh_da_pay.TabIndex = 0;
            this.dgv_ds_dh_da_pay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ds_dh_da_pay_CellClick);
            // 
            // dgv_dh_chitiet
            // 
            this.dgv_dh_chitiet.AllowUserToAddRows = false;
            this.dgv_dh_chitiet.AllowUserToOrderColumns = true;
            this.dgv_dh_chitiet.AllowUserToResizeRows = false;
            this.dgv_dh_chitiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_dh_chitiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_dh_chitiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_dh_chitiet.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dh_chitiet.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dh_chitiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_dh_chitiet.ColumnHeadersHeight = 30;
            this.dgv_dh_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_dh_chitiet.EnableHeadersVisualStyles = false;
            this.dgv_dh_chitiet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_dh_chitiet.Location = new System.Drawing.Point(13, 290);
            this.dgv_dh_chitiet.MultiSelect = false;
            this.dgv_dh_chitiet.Name = "dgv_dh_chitiet";
            this.dgv_dh_chitiet.ReadOnly = true;
            this.dgv_dh_chitiet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_dh_chitiet.RowHeadersVisible = false;
            this.dgv_dh_chitiet.RowHeadersWidth = 62;
            this.dgv_dh_chitiet.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_dh_chitiet.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.dgv_dh_chitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dh_chitiet.Size = new System.Drawing.Size(807, 206);
            this.dgv_dh_chitiet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ĐƠN HÀNG CHI TIẾT";
            // 
            // btn_huydh
            // 
            this.btn_huydh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_huydh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_huydh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huydh.Location = new System.Drawing.Point(260, 501);
            this.btn_huydh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_huydh.Name = "btn_huydh";
            this.btn_huydh.Size = new System.Drawing.Size(242, 36);
            this.btn_huydh.TabIndex = 8;
            this.btn_huydh.Text = "&HỦY ĐƠN HÀNG";
            this.btn_huydh.UseVisualStyleBackColor = true;
            this.btn_huydh.Visible = false;
            this.btn_huydh.Click += new System.EventHandler(this.btn_huydh_Click);
            // 
            // Frm_DSDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(837, 549);
            this.Controls.Add(this.btn_huydh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_dh_chitiet);
            this.Controls.Add(this.TabC1);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_reload);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_DSDH";
            this.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.Frm_DSDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_dh_chua_pay)).EndInit();
            this.TabC1.ResumeLayout(false);
            this.TabP1.ResumeLayout(false);
            this.TabP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_dh_da_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dh_chitiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridView dgv_ds_dh_chua_pay;
        private System.Windows.Forms.TabControl TabC1;
        private System.Windows.Forms.TabPage TabP1;
        private System.Windows.Forms.TabPage TabP2;
        private System.Windows.Forms.DataGridView dgv_ds_dh_da_pay;
        private System.Windows.Forms.DataGridView dgv_dh_chitiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_huydh;
    }
}