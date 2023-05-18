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
    public partial class Frm_HH_CHI_TIET : Form
    {
        Class_Funcs CFuncs = new Class_Funcs();

        public string ID_DATA = "";
        public string MODE_CHANGE_DATA = "";
        public string SQL_CONNECTION_STRING = "";

        public Frm_HH_CHI_TIET() { InitializeComponent(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void Make_Combobox_DS_DVT()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT MA_DVT, TEN_DVT FROM DON_VI_TINH ORDER BY MA_DVT ASC";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            ArrayList KQ = vmk.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            // SAU ĐÓ NẠP VÀO DATAGRIDVIEW

            if (DT.Rows.Count == 0) { cbo_ma_dvt.DataSource = null; return; }

            cbo_ma_dvt.DataSource = DT;
            cbo_ma_dvt.ValueMember = "MA_DVT";
            cbo_ma_dvt.DisplayMember = "TEN_DVT";
        }

        private void Make_Combobox_DS_LH()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT MA_LH, TEN_LH FROM LOAI_HANG ORDER BY MA_LH ASC";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            ArrayList KQ = vmk.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            // SAU ĐÓ NẠP VÀO DATAGRIDVIEW

            if (DT.Rows.Count == 0) { cbo_loai_hang.DataSource = null; return; }

            cbo_loai_hang.DataSource = DT;
            cbo_loai_hang.ValueMember = "MA_LH";
            cbo_loai_hang.DisplayMember = "TEN_LH";
        }

        private void Frm_HH_CHI_TIET_Load(object sender, EventArgs e)
        {
            // TẠO CÁC CONTROL COMBOBOX CẦN

            Make_Combobox_DS_DVT();
            Make_Combobox_DS_LH();

            // KIỂM TRA BIẾN ID_DATA ĐƯỢC TRUYỀN ĐẾN. NẾU RỖNG NGHĨA LÀ THÊM MỚI, NGƯỢC LẠI LÀ CẬP NHẬT

            if (ID_DATA.Trim() != "")
            {
                MODE_CHANGE_DATA = "CAP_NHAT";
                XEM_CSDL_THEO_ID(ID_DATA);
                btn_capnhat.Visible = true;
                btn_them.Visible = false;
                txt_ma_hh.Enabled = false;
            }
            else
            {
                MODE_CHANGE_DATA = "THEM_MOI";
                btn_capnhat.Visible = false;
                btn_them.Visible = true;
                txt_ma_hh.Enabled = false;
            }
        }        

        private void XEM_CSDL_THEO_ID(string ID_DATA)
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT MA_HH, TEN_HH, MA_LH, MA_DVT, SO_LUONG, DON_GIA FROM HANG_HOA WHERE (MA_HH = @MA_HH) ORDER BY MA_HH ASC";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ID_DATA, SqlDbType.VarChar);
            ArrayList KQ = vmk.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            // SAU ĐÓ NẠP VÀO CÁC CONTROL

            if (DT.Rows.Count != 0)
            {
                txt_ma_hh.Text = DT.Rows[0]["MA_HH"].ToString().Trim();
                txt_ten_hh.Text = DT.Rows[0]["TEN_HH"].ToString().Trim();
                cbo_loai_hang.SelectedValue = DT.Rows[0]["MA_LH"].ToString().Trim();
                cbo_ma_dvt.SelectedValue = DT.Rows[0]["MA_DVT"].ToString().Trim();
                nbric_soluong.Value = int.Parse(DT.Rows[0]["SO_LUONG"].ToString().Trim());
                nbric_dongia.Value = int.Parse(DT.Rows[0]["DON_GIA"].ToString().Trim());
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (MODE_CHANGE_DATA != "THEM_MOI") { return; }

            // LẤY VÀ KIỂM TRA DỮ LIỆU TỪ FORM

            string ten_hh = txt_ten_hh.Text.Trim();
            string ma_lh = cbo_loai_hang.SelectedValue.ToString().Trim();
            string ma_dvt = cbo_ma_dvt.SelectedValue.ToString().Trim();
            string soluong = nbric_soluong.Value.ToString();
            string dongia = nbric_dongia.Value.ToString();

            if (ten_hh == "" || ma_lh == "" || ma_dvt == "" || soluong == "" || dongia == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐẦY ĐỦ DỮ LIỆU", "THÔNG BÁO");

                if (ten_hh == "") { txt_ten_hh.Focus(); return; }
                if (ma_lh == "") { cbo_loai_hang.Focus(); return; }
                if (ma_dvt == "") { cbo_ma_dvt.Focus(); return; }
                if (soluong == "") { nbric_soluong.Focus(); return; }
                if (dongia == "") { nbric_dongia.Focus(); return; }

                return;
            }

            if (ten_hh != "" && CFuncs.CHECK_CHARACTER(ten_hh, " ", true, true, true) == false)
            {
                MessageBox.Show("TÊN HÀNG HÓA CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ma_lh != "" && CFuncs.CHECK_CHARACTER(ma_lh, "_", true, true, false) == false)
            {
                MessageBox.Show("MÃ LOẠI HÀNG CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ma_dvt != "" && CFuncs.CHECK_CHARACTER(ma_dvt, "_", true, true, false) == false)
            {
                MessageBox.Show("MÃ ĐƠN VỊ TÍNH CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (soluong != "" && CFuncs.CHECK_CHARACTER(soluong, "", true, false, false) == false)
            {
                MessageBox.Show("SỐ LƯỢNG CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            if (dongia != "" && CFuncs.CHECK_CHARACTER(dongia, "", true, false, false) == false)
            {
                MessageBox.Show("ĐƠN GIÁ CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            // TIẾN HÀNH THÊM DỮ LIỆU VÀO CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "INSERT INTO HANG_HOA (TEN_HH, MA_LH, MA_DVT, SO_LUONG, DON_GIA) VALUES (@TEN_HH, @MA_LH, @MA_DVT, @SO_LUONG, @DON_GIA)";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TEN_HH", ten_hh, SqlDbType.NVarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_LH", ma_lh, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_DVT", ma_dvt, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@SO_LUONG", soluong, SqlDbType.Int);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@DON_GIA", dongia, SqlDbType.Int);
            String[] KQ = vmk.MS_SQL_INSERT_DELETE_UPDATE();

            if (KQ[0].ToString() == "ERROR")
            {
                Console.WriteLine(KQ[1].ToString());
                if (KQ[1].ToLower().Contains("the insert statement conflicted with the foreign key constraint"))
                {
                    MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU LIÊN KẾT VỚI BẢNG KHÁC KHÔNG TỒN TẠI", "THÔNG BÁO");
                    return;
                }
                if (KQ[1].ToLower().Contains("the update statement conflicted with the foreign key constraint"))
                {
                    MessageBox.Show("KHÔNG THỂ CẬP NHẬT. DỮ LIỆU LIÊN KẾT VỚI BẢNG KHÁC KHÔNG TỒN TẠI", "THÔNG BÁO");
                    return;
                }
                if (KQ[1].ToLower().Contains("cannot insert duplicate key in object"))
                {
                    MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU ĐÃ CÓ RỒI", "THÔNG BÁO");
                    return;
                }
                if (KQ[1].ToLower().Contains("string or binary data would be truncated"))
                {
                    MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU VƯỢT QUÁ QUY ĐỊNH", "THÔNG BÁO");
                    return;
                }
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            MessageBox.Show("THÊM DỮ LIỆU MỚI THÀNH CÔNG", "THÔNG BÁO");

            this.Close();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (MODE_CHANGE_DATA != "CAP_NHAT") { return; }

            // LẤY VÀ KIỂM TRA DỮ LIỆU TỪ FORM

            string ma_hh = ID_DATA.Trim();
            string ten_hh = txt_ten_hh.Text.Trim();
            string ma_lh = cbo_loai_hang.SelectedValue.ToString().Trim();
            string ma_dvt = cbo_ma_dvt.SelectedValue.ToString().Trim();
            string soluong = nbric_soluong.Value.ToString();
            string dongia = nbric_dongia.Value.ToString();

            if (ten_hh == "" || ma_lh == "" || ma_dvt == "" || soluong == "" || dongia == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐẦY ĐỦ DỮ LIỆU", "THÔNG BÁO");

                if (ten_hh == "") { txt_ten_hh.Focus(); return; }
                if (ma_lh == "") { cbo_loai_hang.Focus(); return; }
                if (ma_dvt == "") { cbo_ma_dvt.Focus(); return; }
                if (soluong == "") { nbric_soluong.Focus(); return; }
                if (dongia == "") { nbric_dongia.Focus(); return; }

                return;
            }

            if (ten_hh != "" && CFuncs.CHECK_CHARACTER(ten_hh, " ", true, true, true) == false)
            {
                MessageBox.Show("TÊN HÀNG HÓA CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ma_lh != "" && CFuncs.CHECK_CHARACTER(ma_lh, "_", true, true, false) == false)
            {
                MessageBox.Show("MÃ LOẠI HÀNG CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ma_dvt != "" && CFuncs.CHECK_CHARACTER(ma_dvt, "_", true, true, false) == false)
            {
                MessageBox.Show("MÃ ĐƠN VỊ TÍNH CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (soluong != "" && CFuncs.CHECK_CHARACTER(soluong, "", true, false, false) == false)
            {
                MessageBox.Show("SỐ LƯỢNG CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            if (dongia != "" && CFuncs.CHECK_CHARACTER(dongia, "", true, false, false) == false)
            {
                MessageBox.Show("ĐƠN GIÁ CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            // TIẾN HÀNH THÊM DỮ LIỆU VÀO CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "UPDATE HANG_HOA SET TEN_HH = @TEN_HH, MA_LH = @MA_LH, MA_DVT = @MA_DVT, SO_LUONG = @SO_LUONG, DON_GIA = @DON_GIA WHERE MA_HH = @MA_HH";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ma_hh, SqlDbType.Int);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TEN_HH", ten_hh, SqlDbType.NVarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_LH", ma_lh, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_DVT", ma_dvt, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@SO_LUONG", soluong, SqlDbType.Int);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@DON_GIA", dongia, SqlDbType.Int);
            String[] KQ = vmk.MS_SQL_INSERT_DELETE_UPDATE();

            if (KQ[0].ToString() == "ERROR")
            {
                Console.WriteLine(KQ[1].ToString());
                if (KQ[1].ToLower().Contains("the insert statement conflicted with the foreign key constraint"))
                {
                    MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU LIÊN KẾT VỚI BẢNG KHÁC KHÔNG TỒN TẠI", "THÔNG BÁO");
                    return;
                }
                if (KQ[1].ToLower().Contains("the update statement conflicted with the foreign key constraint"))
                {
                    MessageBox.Show("KHÔNG THỂ CẬP NHẬT. DỮ LIỆU LIÊN KẾT VỚI BẢNG KHÁC KHÔNG TỒN TẠI", "THÔNG BÁO");
                    return;
                }
                if (KQ[1].ToLower().Contains("cannot insert duplicate key in object"))
                {
                    MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU ĐÃ CÓ RỒI", "THÔNG BÁO");
                    return;
                }
                if (KQ[1].ToLower().Contains("string or binary data would be truncated"))
                {
                    MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU VƯỢT QUÁ QUY ĐỊNH", "THÔNG BÁO");
                    return;
                }
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            MessageBox.Show("CẬP NHẬT DỮ LIỆU THÀNH CÔNG", "THÔNG BÁO");

            this.Close();
        }
    }
}