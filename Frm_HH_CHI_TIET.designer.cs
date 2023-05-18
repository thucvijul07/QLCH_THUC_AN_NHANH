namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_HH_CHI_TIET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HH_CHI_TIET));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ma_hh = new System.Windows.Forms.TextBox();
            this.txt_ten_hh = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_loai_hang = new System.Windows.Forms.ComboBox();
            this.cbo_ma_dvt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nbric_soluong = new System.Windows.Forms.NumericUpDown();
            this.nbric_dongia = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_dongia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MÃ HÀNG HÓA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TÊN HÀNG HÓA";
            // 
            // txt_ma_hh
            // 
            this.txt_ma_hh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma_hh.Location = new System.Drawing.Point(166, 47);
            this.txt_ma_hh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ma_hh.Name = "txt_ma_hh";
            this.txt_ma_hh.Size = new System.Drawing.Size(329, 28);
            this.txt_ma_hh.TabIndex = 0;
            // 
            // txt_ten_hh
            // 
            this.txt_ten_hh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten_hh.Location = new System.Drawing.Point(166, 87);
            this.txt_ten_hh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ten_hh.Name = "txt_ten_hh";
            this.txt_ten_hh.Size = new System.Drawing.Size(329, 28);
            this.txt_ten_hh.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(166, 339);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(189, 38);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "&THÊM MỚI";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(375, 306);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(120, 38);
            this.btn_thoat.TabIndex = 7;
            this.btn_thoat.Text = "&HỦY";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capnhat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(166, 275);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(189, 38);
            this.btn_capnhat.TabIndex = 6;
            this.btn_capnhat.Text = "&CẬP NHẬT";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "LOẠI HÀNG";
            // 
            // cbo_loai_hang
            // 
            this.cbo_loai_hang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loai_hang.FormattingEnabled = true;
            this.cbo_loai_hang.Location = new System.Drawing.Point(166, 209);
            this.cbo_loai_hang.Name = "cbo_loai_hang";
            this.cbo_loai_hang.Size = new System.Drawing.Size(329, 28);
            this.cbo_loai_hang.TabIndex = 5;
            // 
            // cbo_ma_dvt
            // 
            this.cbo_ma_dvt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_ma_dvt.FormattingEnabled = true;
            this.cbo_ma_dvt.Location = new System.Drawing.Point(166, 169);
            this.cbo_ma_dvt.Name = "cbo_ma_dvt";
            this.cbo_ma_dvt.Size = new System.Drawing.Size(329, 28);
            this.cbo_ma_dvt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(16, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ĐƠN VỊ TÍNH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(16, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SỐ LƯỢNG";
            // 
            // nbric_soluong
            // 
            this.nbric_soluong.Location = new System.Drawing.Point(166, 128);
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
            this.nbric_soluong.Size = new System.Drawing.Size(103, 28);
            this.nbric_soluong.TabIndex = 2;
            this.nbric_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nbric_dongia
            // 
            this.nbric_dongia.Location = new System.Drawing.Point(401, 128);
            this.nbric_dongia.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nbric_dongia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbric_dongia.Name = "nbric_dongia";
            this.nbric_dongia.Size = new System.Drawing.Size(94, 28);
            this.nbric_dongia.TabIndex = 3;
            this.nbric_dongia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(297, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ĐƠN GIÁ";
            // 
            // Frm_HH_CHI_TIET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(625, 435);
            this.Controls.Add(this.nbric_dongia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbric_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbo_ma_dvt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_loai_hang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_ten_hh);
            this.Controls.Add(this.txt_ma_hh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_HH_CHI_TIET";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ - HÀNG HÓA - CHI TIẾT";
            this.Load += new System.EventHandler(this.Frm_HH_CHI_TIET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbric_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbric_dongia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ma_hh;
        private System.Windows.Forms.TextBox txt_ten_hh;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_loai_hang;
        private System.Windows.Forms.ComboBox cbo_ma_dvt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nbric_soluong;
        private System.Windows.Forms.NumericUpDown nbric_dongia;
        private System.Windows.Forms.Label label6;
    }
}