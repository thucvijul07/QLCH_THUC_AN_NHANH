using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    public partial class Frm_MAIN : Form
    {
        public bool Logged = false;
        public string Quyen_Han = "";
        public string Acc_Logged = "";

        string SQL_CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLCH_THUC_AN_NHANH;Integrated Security=True";

        public Frm_MAIN() { InitializeComponent(); }

        private void Disable_Menu()
        {
            Menu_HT_DangNhap.Visible = true;
            Menu_HT_DangXuat.Visible = false;

            Menu_DanhMuc.Enabled = false;
            Menu_DonHang.Enabled = false;
            Menu_HT_QLNV.Enabled = false;
        }

        private void Enable_Menu_QuanLy()
        {
            Menu_HT_DangNhap.Visible = false;
            Menu_HT_DangXuat.Visible = true;

            Menu_DanhMuc.Enabled = true;
            Menu_DonHang.Enabled = true;
            Menu_HT_QLNV.Enabled = true;
        }

        private void Enable_Menu_NhanVien()
        {
            Menu_HT_DangNhap.Visible = false;
            Menu_HT_DangXuat.Visible = true;

            Menu_DanhMuc.Enabled = false;
            Menu_DonHang.Enabled = true;
            Menu_HT_QLNV.Enabled = false;
        }

        private void Check_Logged()
        {
            if (Logged == false || Acc_Logged == "" || Quyen_Han == "")
            {
                Disable_Menu();
            }
            else
            {
                if (Quyen_Han == "QUAN_LY")
                {
                    Enable_Menu_QuanLy();
                }
                else if (Quyen_Han == "NHAN_VIEN")
                {
                    Enable_Menu_NhanVien();
                }
                else
                {
                    Disable_Menu();
                }
            }
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            Check_Logged();
        }

        private void Menu_HT_Thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void Menu_ThongTin_Click(object sender, EventArgs e)
        {
            Frm_THONG_TIN Frm = new Frm_THONG_TIN();
            Frm.ShowDialog();
        }

        private void Menu_HT_DangNhap_Click(object sender, EventArgs e)
        {
            Frm_LOGIN Frm = new Frm_LOGIN();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.FMain = this;
            Frm.ShowDialog();

            Check_Logged();
        }

        private void Menu_HT_DangXuat_Click(object sender, EventArgs e)
        {
            Logged = false;
            Acc_Logged = "";
            Quyen_Han = "";

            Check_Logged();
        }

        private void Menu_HT_QLNV_Click(object sender, EventArgs e)
        {
            Frm_NHAN_VIEN Frm = new Frm_NHAN_VIEN();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.Acc_Logged = Acc_Logged;
            Frm.ShowDialog();
        }

        private void Menu_DM_DVT_Click(object sender, EventArgs e)
        {
            Frm_DVT Frm = new Frm_DVT();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();
        }

        private void Menu_DM_LHH_Click(object sender, EventArgs e)
        {
            Frm_LHH Frm = new Frm_LHH();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();
        }

        private void Menu_DM_BanAn_Click(object sender, EventArgs e)
        {
            Frm_BA Frm = new Frm_BA();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();
        }

        private void Menu_DM_HangHoa_Click(object sender, EventArgs e)
        {
            Frm_HH Frm = new Frm_HH();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();
        }

        private void Menu_DH_TaoDH_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_MAKE_DH Frm = new Frm_MAKE_DH();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();
        }

        private void Menu_DH_TTDH_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_TTDH Frm = new Frm_TTDH();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();
        }

        private void Menu_DH_DSDH_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_DSDH Frm = new Frm_DSDH();
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.QUYEN_HAN = Quyen_Han;
            Frm.ShowDialog();

            this.Show();
        }        
    }
}
