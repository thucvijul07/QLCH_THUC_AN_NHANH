namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_LOGIN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tai_khoan = new System.Windows.Forms.TextBox();
            this.txt_mat_khau = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MẬT KHẨU";
            // 
            // txt_tai_khoan
            // 
            this.txt_tai_khoan.Location = new System.Drawing.Point(119, 26);
            this.txt_tai_khoan.Name = "txt_tai_khoan";
            this.txt_tai_khoan.Size = new System.Drawing.Size(265, 23);
            this.txt_tai_khoan.TabIndex = 0;
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Location = new System.Drawing.Point(119, 55);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.PasswordChar = '▪';
            this.txt_mat_khau.Size = new System.Drawing.Size(265, 23);
            this.txt_mat_khau.TabIndex = 1;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(119, 97);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(265, 38);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "ĐĂNG &NHẬP";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_thoat.Location = new System.Drawing.Point(540, 111);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(97, 38);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.TabStop = false;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "* LƯU Ý - MẬT KHẨU CÓ PHÂN BIỆT KÝ TỰ HOA THƯỜNG";
            // 
            // Frm_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_thoat;
            this.ClientSize = new System.Drawing.Size(421, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_mat_khau);
            this.Controls.Add(this.txt_tai_khoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Frm_LOGIN";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tai_khoan;
        private System.Windows.Forms.TextBox txt_mat_khau;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label3;
    }
}