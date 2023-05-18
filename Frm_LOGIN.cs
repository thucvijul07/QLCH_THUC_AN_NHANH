using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    public partial class Frm_LOGIN : Form
    {
        Class_Funcs Funcs = new Class_Funcs();

        public Frm_MAIN FMain = null;
        public string SQL_CONNECTION_STRING = "";

        public Frm_LOGIN() { InitializeComponent(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // TIẾN HÀNH ĐĂNG NHẬP

            string tai_khoan = txt_tai_khoan.Text.Trim();
            string mat_khau = txt_mat_khau.Text.Trim();

            if (tai_khoan == "" || mat_khau == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐẦY ĐỦ DỮ LIỆU", "THÔNG BÁO");

                if (tai_khoan == "") { txt_tai_khoan.Focus(); return; }
                if (mat_khau == "") { txt_mat_khau.Focus(); return; }

                return;
            }

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT TAI_KHOAN, MAT_KHAU, HO_TEN, SDT, QUYEN_HAN FROM NHAN_VIEN WHERE TAI_KHOAN = @TAI_KHOAN AND (MAT_KHAU = @MAT_KHAU COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS)";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TAI_KHOAN", tai_khoan, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MAT_KHAU", mat_khau, SqlDbType.NVarChar);
            ArrayList KQ = vmk.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                Console.WriteLine(KQ[1].ToString());
                MessageBox.Show(KQ[1].ToString(),"THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("THÔNG TIN ĐĂNG NHẬP KHÔNG ĐÚNG", "THÔNG BÁO");
                return;
            }

            // NẾU ĐĂNG NHẬP THÀNH CÔNG, THÌ ĐÓNG FORM LOGIN VÀ SET CÁC BIẾN TRONG FORM MAIN

            string Quyen_Han_From_CSDL = DT.Rows[0]["QUYEN_HAN"].ToString().Trim();

            FMain.Logged = true;
            FMain.Acc_Logged = DT.Rows[0]["TAI_KHOAN"].ToString().Trim();

            if (Quyen_Han_From_CSDL == "1")
            {
                FMain.Quyen_Han = "QUAN_LY";
            }
            else
            {
                FMain.Quyen_Han = "NHAN_VIEN";
            }            
        
            MessageBox.Show("ĐĂNG NHẬP THÀNH CÔNG", "THÔNG BÁO");

            this.Close();
        }        
    }
}
