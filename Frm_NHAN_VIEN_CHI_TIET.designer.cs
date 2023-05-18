namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_NHAN_VIEN_CHI_TIET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NHAN_VIEN_CHI_TIET));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_quyen_han = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ho_ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU";
            // 
            // txt_tai_khoan
            // 
            this.txt_tai_khoan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tai_khoan.Location = new System.Drawing.Point(115, 17);
            this.txt_tai_khoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tai_khoan.Name = "txt_tai_khoan";
            this.txt_tai_khoan.Size = new System.Drawing.Size(345, 21);
            this.txt_tai_khoan.TabIndex = 0;
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mat_khau.Location = new System.Drawing.Point(115, 42);
            this.txt_mat_khau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.Size = new System.Drawing.Size(345, 21);
            this.txt_mat_khau.TabIndex = 1;
            // 
            // btn_them
            // 
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(114, 163);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(221, 38);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "&THÊM MỚI";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(341, 163);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(120, 38);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "&HỦY";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(23, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "QUYỀN HẠN";
            // 
            // cbo_quyen_han
            // 
            this.cbo_quyen_han.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_quyen_han.FormattingEnabled = true;
            this.cbo_quyen_han.Location = new System.Drawing.Point(115, 118);
            this.cbo_quyen_han.Name = "cbo_quyen_han";
            this.cbo_quyen_han.Size = new System.Drawing.Size(345, 21);
            this.cbo_quyen_han.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(23, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "HỌ TÊN";
            // 
            // txt_ho_ten
            // 
            this.txt_ho_ten.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ho_ten.Location = new System.Drawing.Point(115, 67);
            this.txt_ho_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ho_ten.Name = "txt_ho_ten";
            this.txt_ho_ten.Size = new System.Drawing.Size(345, 21);
            this.txt_ho_ten.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(23, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "SĐT";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capnhat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.Location = new System.Drawing.Point(114, 163);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(221, 38);
            this.btn_capnhat.TabIndex = 5;
            this.btn_capnhat.Text = "&CẬP NHẬT";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(115, 92);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(345, 21);
            this.txt_sdt.TabIndex = 3;
            // 
            // Frm_NHAN_VIEN_CHI_TIET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(484, 223);
            this.Controls.Add(this.cbo_quyen_han);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.txt_ho_ten);
            this.Controls.Add(this.txt_mat_khau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tai_khoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_NHAN_VIEN_CHI_TIET";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ - NHÂN VIÊN - CHI TIẾT";
            this.Load += new System.EventHandler(this.Frm_TAIKHOAN_CHI_TIET_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tai_khoan;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_quyen_han;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ho_ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.TextBox txt_sdt;
    }
}