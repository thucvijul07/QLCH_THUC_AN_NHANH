namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_MAKE_DH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MAKE_DH));
            this.btn_tao_dh = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_chitietdh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ds_ban = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_ds_hh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nbric_soluong = new System.Windows.Forms.NumericUpDown();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tao_dh
            // 
            this.btn_tao_dh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_tao_dh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tao_dh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tao_dh.Location = new System.Drawing.Point(275, 335);
            this.btn_tao_dh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tao_dh.Name = "btn_tao_dh";
            this.btn_tao_dh.Size = new System.Drawing.Size(349, 36);
            this.btn_tao_dh.TabIndex = 6;
            this.btn_tao_dh.Text = "&TẠO ĐƠN HÀNG";
            this.btn_tao_dh.UseVisualStyleBackColor = true;
            this.btn_tao_dh.Click += new System.EventHandler(this.btn_tao_dh_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(708, 335);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(98, 36);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "TH&OÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // dgv_chitietdh
            // 
            this.dgv_chitietdh.AllowUserToAddRows = false;
            this.dgv_chitietdh.AllowUserToOrderColumns = true;
            this.dgv_chitietdh.AllowUserToResizeRows = false;
            this.dgv_chitietdh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_chitietdh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_chitietdh.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_chitietdh.BackgroundColor = System.Drawing.Color.White;
            this.dgv_chitietdh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_chitietdh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_chitietdh.ColumnHeadersHeight = 30;
            this.dgv_chitietdh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_chitietdh.EnableHeadersVisualStyles = false;
            this.dgv_chitietdh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_chitietdh.Location = new System.Drawing.Point(26, 130);
            this.dgv_chitietdh.MultiSelect = false;
            this.dgv_chitietdh.Name = "dgv_chitietdh";
            this.dgv_chitietdh.ReadOnly = true;
            this.dgv_chitietdh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_chitietdh.RowHeadersVisible = false;
            this.dgv_chitietdh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_chitietdh.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 2, 10, 2);
            this.dgv_chitietdh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietdh.Size = new System.Drawing.Size(778, 194);
            this.dgv_chitietdh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHỌN BÀN ĂN";
            // 
            // cbo_ds_ban
            // 
            this.cbo_ds_ban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ds_ban.FormattingEnabled = true;
            this.cbo_ds_ban.Location = new System.Drawing.Point(119, 50);
            this.cbo_ds_ban.Name = "cbo_ds_ban";
            this.cbo_ds_ban.Size = new System.Drawing.Size(320, 21);
            this.cbo_ds_ban.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CHỌN MÓN";
            // 
            // cbo_ds_hh
            // 
            this.cbo_ds_hh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ds_hh.FormattingEnabled = true;
            this.cbo_ds_hh.Location = new System.Drawing.Point(119, 23);
            this.cbo_ds_hh.Name = "cbo_ds_hh";
            this.cbo_ds_hh.Size = new System.Drawing.Size(504, 21);
            this.cbo_ds_hh.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(23, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "SỐ LƯỢNG";
            // 
            // nbric_soluong
            // 
            this.nbric_soluong.Location = new System.Drawing.Point(119, 77);
            this.nbric_soluong.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nbric_soluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbric_soluong.Name = "nbric_soluong";
            this.nbric_soluong.Size = new System.Drawing.Size(320, 21);
            this.nbric_soluong.TabIndex = 2;
            this.nbric_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_them
            // 
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(446, 49);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(178, 50);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "&THÊM VÀO ĐƠN HÀNG";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(25, 335);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(244, 36);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "&XÓA MÓN ĐANG CHỌN";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // Frm_MAKE_DH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(830, 390);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.nbric_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_ds_hh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbo_ds_ban);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_chitietdh);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_tao_dh);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_MAKE_DH";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO ĐƠN HÀNG";
            this.Load += new System.EventHandler(this.Frm_MAKE_DH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_soluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tao_dh;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_chitietdh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ds_ban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_ds_hh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbric_soluong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
    }
}