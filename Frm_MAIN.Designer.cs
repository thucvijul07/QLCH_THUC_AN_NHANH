namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    partial class Frm_MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MAIN));
            this.Menu_Main = new System.Windows.Forms.MenuStrip();
            this.Menu_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_HT_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_HT_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_HT_QLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_HT_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DM_BanAn = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DM_DVT = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DM_LHH = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DM_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DonHang = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DH_TaoDH = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DH_TTDH = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_DH_DSDH = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.thongKeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Main
            // 
            this.Menu_Main.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.Menu_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_HeThong,
            this.Menu_DanhMuc,
            this.Menu_DonHang,
            this.thongKeToolStripMenuItem,
            this.Menu_ThongTin});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(815, 33);
            this.Menu_Main.TabIndex = 0;
            // 
            // Menu_HeThong
            // 
            this.Menu_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_HT_DangNhap,
            this.Menu_HT_DangXuat,
            this.Menu_HT_QLNV,
            this.Menu_HT_Thoat});
            this.Menu_HeThong.Name = "Menu_HeThong";
            this.Menu_HeThong.Size = new System.Drawing.Size(116, 29);
            this.Menu_HeThong.Text = "&HỆ THỐNG";
            // 
            // Menu_HT_DangNhap
            // 
            this.Menu_HT_DangNhap.Name = "Menu_HT_DangNhap";
            this.Menu_HT_DangNhap.Size = new System.Drawing.Size(313, 34);
            this.Menu_HT_DangNhap.Text = "&1 - ĐĂNG NHẬP";
            this.Menu_HT_DangNhap.Click += new System.EventHandler(this.Menu_HT_DangNhap_Click);
            // 
            // Menu_HT_DangXuat
            // 
            this.Menu_HT_DangXuat.Name = "Menu_HT_DangXuat";
            this.Menu_HT_DangXuat.Size = new System.Drawing.Size(313, 34);
            this.Menu_HT_DangXuat.Text = "&1 - ĐĂNG XUẤT";
            this.Menu_HT_DangXuat.Click += new System.EventHandler(this.Menu_HT_DangXuat_Click);
            // 
            // Menu_HT_QLNV
            // 
            this.Menu_HT_QLNV.Name = "Menu_HT_QLNV";
            this.Menu_HT_QLNV.Size = new System.Drawing.Size(313, 34);
            this.Menu_HT_QLNV.Text = "&2 - QUẢN LÝ NHÂN VIÊN";
            this.Menu_HT_QLNV.Click += new System.EventHandler(this.Menu_HT_QLNV_Click);
            // 
            // Menu_HT_Thoat
            // 
            this.Menu_HT_Thoat.Name = "Menu_HT_Thoat";
            this.Menu_HT_Thoat.Size = new System.Drawing.Size(313, 34);
            this.Menu_HT_Thoat.Text = "&3 - THOÁT";
            this.Menu_HT_Thoat.Click += new System.EventHandler(this.Menu_HT_Thoat_Click);
            // 
            // Menu_DanhMuc
            // 
            this.Menu_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_DM_BanAn,
            this.Menu_DM_DVT,
            this.Menu_DM_LHH,
            this.Menu_DM_HangHoa});
            this.Menu_DanhMuc.Name = "Menu_DanhMuc";
            this.Menu_DanhMuc.Size = new System.Drawing.Size(123, 29);
            this.Menu_DanhMuc.Text = "&DANH MỤC";
            // 
            // Menu_DM_BanAn
            // 
            this.Menu_DM_BanAn.Name = "Menu_DM_BanAn";
            this.Menu_DM_BanAn.Size = new System.Drawing.Size(278, 34);
            this.Menu_DM_BanAn.Text = "&1 - BÀN ĂN";
            this.Menu_DM_BanAn.Click += new System.EventHandler(this.Menu_DM_BanAn_Click);
            // 
            // Menu_DM_DVT
            // 
            this.Menu_DM_DVT.Name = "Menu_DM_DVT";
            this.Menu_DM_DVT.Size = new System.Drawing.Size(278, 34);
            this.Menu_DM_DVT.Text = "&2 - ĐƠN VỊ TÍNH";
            this.Menu_DM_DVT.Click += new System.EventHandler(this.Menu_DM_DVT_Click);
            // 
            // Menu_DM_LHH
            // 
            this.Menu_DM_LHH.Name = "Menu_DM_LHH";
            this.Menu_DM_LHH.Size = new System.Drawing.Size(278, 34);
            this.Menu_DM_LHH.Text = "&3 - LOẠI HÀNG HÓA";
            this.Menu_DM_LHH.Click += new System.EventHandler(this.Menu_DM_LHH_Click);
            // 
            // Menu_DM_HangHoa
            // 
            this.Menu_DM_HangHoa.Name = "Menu_DM_HangHoa";
            this.Menu_DM_HangHoa.Size = new System.Drawing.Size(278, 34);
            this.Menu_DM_HangHoa.Text = "&4 - HÀNG HÓA";
            this.Menu_DM_HangHoa.Click += new System.EventHandler(this.Menu_DM_HangHoa_Click);
            // 
            // Menu_DonHang
            // 
            this.Menu_DonHang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_DH_TaoDH,
            this.Menu_DH_TTDH,
            this.Menu_DH_DSDH});
            this.Menu_DonHang.Name = "Menu_DonHang";
            this.Menu_DonHang.Size = new System.Drawing.Size(123, 29);
            this.Menu_DonHang.Text = "ĐƠN &HÀNG";
            // 
            // Menu_DH_TaoDH
            // 
            this.Menu_DH_TaoDH.Name = "Menu_DH_TaoDH";
            this.Menu_DH_TaoDH.Size = new System.Drawing.Size(353, 34);
            this.Menu_DH_TaoDH.Text = "&1 - TẠO ĐƠN HÀNG";
            this.Menu_DH_TaoDH.Click += new System.EventHandler(this.Menu_DH_TaoDH_Click);
            // 
            // Menu_DH_TTDH
            // 
            this.Menu_DH_TTDH.Name = "Menu_DH_TTDH";
            this.Menu_DH_TTDH.Size = new System.Drawing.Size(353, 34);
            this.Menu_DH_TTDH.Text = "&2 - THANH TOÁN ĐƠN HÀNG";
            this.Menu_DH_TTDH.Click += new System.EventHandler(this.Menu_DH_TTDH_Click);
            // 
            // Menu_DH_DSDH
            // 
            this.Menu_DH_DSDH.Name = "Menu_DH_DSDH";
            this.Menu_DH_DSDH.Size = new System.Drawing.Size(353, 34);
            this.Menu_DH_DSDH.Text = "&3 - DANH SÁCH ĐƠN HÀNG";
            this.Menu_DH_DSDH.Click += new System.EventHandler(this.Menu_DH_DSDH_Click);
            // 
            // Menu_ThongTin
            // 
            this.Menu_ThongTin.Name = "Menu_ThongTin";
            this.Menu_ThongTin.Size = new System.Drawing.Size(121, 29);
            this.Menu_ThongTin.Text = "&THÔNG TIN";
            this.Menu_ThongTin.Click += new System.EventHandler(this.Menu_ThongTin_Click);
            // 
            // thongKeToolStripMenuItem
            // 
            this.thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            this.thongKeToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.thongKeToolStripMenuItem.Text = "Thong ke";
            // 
            // Frm_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 489);
            this.Controls.Add(this.Menu_Main);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_Main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ CỬA HÀNG THỨC ĂN NHANH";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Menu_Main.ResumeLayout(false);
            this.Menu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_Main;
        private System.Windows.Forms.ToolStripMenuItem Menu_HeThong;
        private System.Windows.Forms.ToolStripMenuItem Menu_HT_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem Menu_HT_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem Menu_HT_Thoat;
        private System.Windows.Forms.ToolStripMenuItem Menu_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem Menu_ThongTin;
        private System.Windows.Forms.ToolStripMenuItem Menu_HT_QLNV;
        private System.Windows.Forms.ToolStripMenuItem Menu_DM_BanAn;
        private System.Windows.Forms.ToolStripMenuItem Menu_DM_DVT;
        private System.Windows.Forms.ToolStripMenuItem Menu_DM_LHH;
        private System.Windows.Forms.ToolStripMenuItem Menu_DM_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem Menu_DonHang;
        private System.Windows.Forms.ToolStripMenuItem Menu_DH_TaoDH;
        private System.Windows.Forms.ToolStripMenuItem Menu_DH_TTDH;
        private System.Windows.Forms.ToolStripMenuItem Menu_DH_DSDH;
        private System.Windows.Forms.ToolStripMenuItem thongKeToolStripMenuItem;
    }
}

