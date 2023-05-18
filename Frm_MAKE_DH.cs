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
    public partial class Frm_MAKE_DH : Form
    {
        Class_Funcs CFuncs = new Class_Funcs();

        public string SQL_CONNECTION_STRING = "";

        DataTable DT_CHITIET;

        public Frm_MAKE_DH() { InitializeComponent(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void Make_Combobox_Ds_HH()
        {
            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT MA_HH, TEN_HH FROM HANG_HOA ORDER BY MA_HH ASC";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            ArrayList KQ = vmk.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            if (DT.Rows.Count == 0) { cbo_ds_hh.DataSource = null; return; }

            cbo_ds_hh.DataSource = DT;
            cbo_ds_hh.ValueMember = "MA_HH";
            cbo_ds_hh.DisplayMember = "TEN_HH";
        }

        private void Make_Combobox_Ds_BAN()
        {
            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT MA_BAN, TEN_BAN FROM BAN_AN ORDER BY MA_BAN ASC";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            ArrayList KQ = vmk.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            if (DT.Rows.Count == 0) { cbo_ds_ban.DataSource = null; return; }

            cbo_ds_ban.DataSource = DT;
            cbo_ds_ban.ValueMember = "MA_BAN";
            cbo_ds_ban.DisplayMember = "TEN_BAN";
        }

        private void Frm_MAKE_DH_Load(object sender, EventArgs e)
        {
            // TẠO CONTROL DANH SÁCH

            Make_Combobox_Ds_HH();
            Make_Combobox_Ds_BAN();

            // TẠO ĐỐI TƯỢNG DATATABLE CHI TIẾT HÓA ĐƠN

            DT_CHITIET = new DataTable();
            DT_CHITIET.Columns.Add("MA_BAN", typeof(string));
            DT_CHITIET.Columns.Add("TEN_BAN", typeof(string));
            DT_CHITIET.Columns.Add("MA_HH", typeof(string));
            DT_CHITIET.Columns.Add("TEN_HH", typeof(string));
            DT_CHITIET.Columns.Add("SO_LUONG", typeof(string));
            DT_CHITIET.Columns.Add("DON_GIA", typeof(string));
            DT_CHITIET.Columns.Add("THANH_TIEN", typeof(string));

            dgv_chitietdh.DataSource = DT_CHITIET;

            dgv_chitietdh.Columns["TEN_BAN"].HeaderText = "BÀN ĂN";
            dgv_chitietdh.Columns["TEN_HH"].HeaderText = "MÓN ĂN";
            dgv_chitietdh.Columns["SO_LUONG"].HeaderText = "SỐ LƯỢNG";
            dgv_chitietdh.Columns["DON_GIA"].HeaderText = "ĐƠN GIÁ";
            dgv_chitietdh.Columns["THANH_TIEN"].HeaderText = "THÀNH TIỀN";

            dgv_chitietdh.Columns["MA_BAN"].Visible = false;
            dgv_chitietdh.Columns["MA_HH"].Visible = false;
        }

        private int LAY_DON_GIA_THEO_MA_HH(string ma_hh = "")
        {
            int don_gia = 0;

            if (ma_hh.Trim() != "")
            {
                DataAccess vmk = new DataAccess();
                vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
                vmk.MS_SQL_QUERY = "SELECT DON_GIA FROM HANG_HOA WHERE MA_HH = @MA_HH";
                vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
                vmk.MS_SQL_PARAMETERS.Clear();
                vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ma_hh, SqlDbType.Int);
                ArrayList KQ = vmk.MS_SQL_SELECT();

                if (KQ[0].ToString() == "ERROR")
                {
                    MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                    return don_gia;
                }

                DataTable DT = (DataTable)KQ[2];

                if (DT.Rows.Count == 0) { return don_gia; }

                string don_gia_from_csdl = DT.Rows[0]["DON_GIA"].ToString();

                don_gia = int.Parse(don_gia_from_csdl);
            }

            return don_gia;
        }

        private int LAY_SO_LUONG_TON_THEO_MA_HH(string ma_hh)
        {
            int so_luong_ton = 0;

            if (ma_hh.Trim() != "")
            {
                DataAccess vmk = new DataAccess();
                vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
                vmk.MS_SQL_QUERY = "SELECT SO_LUONG FROM HANG_HOA WHERE MA_HH = @MA_HH";
                vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
                vmk.MS_SQL_PARAMETERS.Clear();
                vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ma_hh, SqlDbType.Int);
                ArrayList KQ = vmk.MS_SQL_SELECT();

                if (KQ[0].ToString() == "ERROR")
                {
                    MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                    return so_luong_ton;
                }

                DataTable DT = (DataTable)KQ[2];

                if (DT.Rows.Count == 0) { return so_luong_ton; }

                string so_luong_from_csdl = DT.Rows[0]["SO_LUONG"].ToString();

                so_luong_ton = int.Parse(so_luong_from_csdl);
            }

            return so_luong_ton;
        }

        private int LAY_SO_LUONG_TRONG_BANG_CHI_TIET_THEO_MA_HH(string ma_hh)
        {
            int so_luong = 0;

            for (int i = 0; i < DT_CHITIET.Rows.Count; i++)
            {
                if (DT_CHITIET.Rows[i]["MA_HH"].ToString().ToUpper() == ma_hh.ToString().ToUpper())
                {
                    so_luong += int.Parse(DT_CHITIET.Rows[i]["SO_LUONG"].ToString());
                }
            }

            return so_luong;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // LẤY VÀ KIỂM TRA DỮ LIỆU TỪ FORM

            string ma_hh = cbo_ds_hh.SelectedValue.ToString().Trim();
            string ten_hh = cbo_ds_hh.Text.Trim();
            string ma_ban = cbo_ds_ban.SelectedValue.ToString().Trim();
            string ten_ban = cbo_ds_ban.Text.Trim();
            string so_luong = nbric_soluong.Value.ToString().Trim();

            if (ma_hh == "" || ten_hh == "" || ma_ban == "" || ten_ban == "" || so_luong == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐẦY ĐỦ DỮ LIỆU", "THÔNG BÁO");

                if (ma_hh == "" || ten_hh == "") { cbo_ds_hh.Focus(); return; }
                if (ma_ban == "" || ten_ban == "") { cbo_ds_ban.Focus(); return; }
                if (so_luong == "") { nbric_soluong.Focus(); return; }

                return;
            }

            // LẤY ĐƠN GIÁ TỪ CSDL THEO MÃ HÀNG HÓA

            string don_gia = LAY_DON_GIA_THEO_MA_HH(ma_hh).ToString();

            // KIỂM TRA TÍNH HỢP LỆ CỦA DỮ LIỆU

            if (ma_hh != "" && CFuncs.CHECK_CHARACTER(ma_hh, "_", true, true, false) == false)
            {
                MessageBox.Show("MÃ HÀNG HÓA CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ma_ban != "" && CFuncs.CHECK_CHARACTER(ma_ban, "_", true, true, false) == false)
            {
                MessageBox.Show("MÃ BÀN ĂN CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (so_luong != "" && CFuncs.CHECK_CHARACTER(so_luong, "", true, false, false) == false)
            {
                MessageBox.Show("SỐ LƯỢNG CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            int don_gia_ok = int.Parse(don_gia);
            int so_luong_ok = int.Parse(so_luong);
            int thanh_tien = so_luong_ok * don_gia_ok;

            // THÊM VÀO BẢNG CHI TIẾT ĐƠN HÀNG
            // KIỂM TRA SỰ TỒN TẠI CỦA MÃ HÀNG HÓA CÙNG MÃ BÀN ĂN
            // NẾU CÓ RỒI THÌ CẬP NHẬT SỐ LƯỢNG
            // NGƯỢC LẠI THÌ THÊM

            int index_exists = -1;

            for (int i = 0; i < DT_CHITIET.Rows.Count; i++)
            {
                if (DT_CHITIET.Rows[i]["MA_HH"].ToString().ToUpper() == ma_hh.ToString().ToUpper()
                    && DT_CHITIET.Rows[i]["MA_BAN"].ToString().ToUpper() == ma_ban.ToString().ToUpper())
                {
                    index_exists = i;
                }
            }

            if (index_exists != -1)
            {
                string so_luong_old = DT_CHITIET.Rows[index_exists]["SO_LUONG"].ToString();
                string don_gia_old = DT_CHITIET.Rows[index_exists]["DON_GIA"].ToString();
                
                int so_luong_new = so_luong_ok + int.Parse(so_luong_old);
                int thanh_tien_new = so_luong_new * int.Parse(don_gia_old);

                // KIỂM TRA XEM SỐ LƯỢNG TỒN CÒN ĐỦ KHÔNG MỚI CHO PHÉP CẬP NHẬT

                if (LAY_SO_LUONG_TON_THEO_MA_HH(ma_hh) < LAY_SO_LUONG_TRONG_BANG_CHI_TIET_THEO_MA_HH(ma_hh) + so_luong_ok)
                {
                    MessageBox.Show("SỐ LƯỢNG BẠN YÊU CẦU VƯỢT SỐ LƯỢNG HIỆN CÓ TRONG KHO", "THÔNG BÁO");
                    return;
                }

                DT_CHITIET.Rows[index_exists]["SO_LUONG"] = so_luong_new.ToString();
                DT_CHITIET.Rows[index_exists]["THANH_TIEN"] = thanh_tien_new.ToString();
            }
            else
            {
                // KIỂM TRA XEM SỐ LƯỢNG TỒN CÒN ĐỦ KHÔNG MỚI CHO PHÉP THÊM

                if (LAY_SO_LUONG_TON_THEO_MA_HH(ma_hh) < LAY_SO_LUONG_TRONG_BANG_CHI_TIET_THEO_MA_HH(ma_hh) + so_luong_ok)
                {
                    MessageBox.Show("SỐ LƯỢNG BẠN YÊU CẦU VƯỢT SỐ LƯỢNG HIỆN CÓ TRONG KHO", "THÔNG BÁO");
                    return;
                }

                DT_CHITIET.Rows.Add(ma_ban, ten_ban, ma_hh, ten_hh, so_luong, don_gia, thanh_tien);             
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_chitietdh.Rows.Count == 0 || dgv_chitietdh.SelectedRows.Count == 0) { return; }

            string ma_ban = dgv_chitietdh.SelectedRows[0].Cells["MA_BAN"].Value.ToString().Trim();
            string ma_hh = dgv_chitietdh.SelectedRows[0].Cells["MA_HH"].Value.ToString().Trim();

            if (ma_ban == "" || ma_hh == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN XÓA", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN MUỐN XÓA DỮ LIỆU ĐANG CHỌN ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            // TIẾN HÀNH XÓA DỮ LIỆU CẦN XÓA RA KHỎI BẢNG CHI TIẾT ĐƠN HÀNG

            for (int i = 0; i < DT_CHITIET.Rows.Count; i++)
            {
                if (DT_CHITIET.Rows[i]["MA_HH"].ToString().ToUpper() == ma_hh.ToString().ToUpper()
                    && DT_CHITIET.Rows[i]["MA_BAN"].ToString().ToUpper() == ma_ban.ToString().ToUpper())
                {
                    DT_CHITIET.Rows.RemoveAt(i);
                    i = 0;
                }
            }
        }

        private void btn_tao_dh_Click(object sender, EventArgs e)
        {
            if (DT_CHITIET.Rows.Count == 0)
            {
                MessageBox.Show("ĐƠN HÀNG ĐANG RỖNG. XIN VUI LÒNG CHỌN MÓN ĂN", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN CÓ CHẮC MUỐN TẠO ĐƠN HÀNG KHÔNG ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            int ma_dh = TAO_MA_DON_HANG();

            if (ma_dh != 0)
            {
                bool status_run_query = true;
                for (int i = 0; i < DT_CHITIET.Rows.Count; i++)
                {
                    string ma_ban = DT_CHITIET.Rows[i]["MA_BAN"].ToString().Trim();
                    string ma_hh = DT_CHITIET.Rows[i]["MA_HH"].ToString().Trim();
                    string so_luong = DT_CHITIET.Rows[i]["SO_LUONG"].ToString().Trim();
                    string don_gia = DT_CHITIET.Rows[i]["DON_GIA"].ToString().Trim();

                    if (ma_ban == "" || ma_hh == "" || so_luong == "" || don_gia == "") { continue; }

                    DataAccess vmk = new DataAccess();
                    vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
                    vmk.MS_SQL_QUERY = "INSERT INTO DON_HANG_CHI_TIET (MA_DH, MA_BAN, MA_HH, SO_LUONG, DON_GIA) VALUES (@MA_DH, @MA_BAN, @MA_HH, @SO_LUONG, @DON_GIA)";
                    vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
                    vmk.MS_SQL_PARAMETERS.Clear();
                    vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_DH", ma_dh, SqlDbType.Int);
                    vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_BAN", ma_ban, SqlDbType.VarChar);
                    vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ma_hh, SqlDbType.Int);
                    vmk.MS_SQL_PARAMETERS.Rows.Add("@SO_LUONG", so_luong, SqlDbType.Int);
                    vmk.MS_SQL_PARAMETERS.Rows.Add("@DON_GIA", don_gia, SqlDbType.Int);
                    String[] KQ = vmk.MS_SQL_INSERT_DELETE_UPDATE();

                    if (KQ[0].ToString() == "ERROR")
                    {
                        status_run_query = false;
                        Console.WriteLine(KQ[1].ToString());
                        if (KQ[1].ToLower().Contains("the insert statement conflicted with the foreign key constraint"))
                        {
                            MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU LIÊN KẾT VỚI BẢNG KHÁC KHÔNG TỒN TẠI", "THÔNG BÁO");
                            break;
                        }
                        if (KQ[1].ToLower().Contains("the update statement conflicted with the foreign key constraint"))
                        {
                            MessageBox.Show("KHÔNG THỂ CẬP NHẬT. DỮ LIỆU LIÊN KẾT VỚI BẢNG KHÁC KHÔNG TỒN TẠI", "THÔNG BÁO");
                            break;
                        }
                        if (KQ[1].ToLower().Contains("cannot insert duplicate key in object"))
                        {
                            MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU ĐÃ CÓ RỒI", "THÔNG BÁO");
                            break;
                        }
                        if (KQ[1].ToLower().Contains("string or binary data would be truncated"))
                        {
                            MessageBox.Show("KHÔNG THỂ THÊM. DỮ LIỆU VƯỢT QUÁ QUY ĐỊNH", "THÔNG BÁO");
                            break;
                        }
                        MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");                        
                        break;
                    }

                    // NẾU THÊM HÀNG HÓA VÀO BẢNG ĐƠN HÀNG THÀNH CÔNG THÌ TIẾN HÀNH GIẢM SỐ LƯỢNG TRONG BẢNG HÀNG HÓA

                    CAP_NHAT_SO_LUONG_TRONG_BANG_HANG_HOA_THEO_MA_HH(ma_hh, so_luong);
                }

                CAP_NHAT_THANH_TIEN_TRONG_BANG_DON_HANG_THEO_MA_DH(ma_dh.ToString());

                if (status_run_query == true)
                {
                    MessageBox.Show("THÊM DỮ LIỆU MỚI THÀNH CÔNG", "THÔNG BÁO");
                }

                this.Close();
            }
        }

        private void CAP_NHAT_SO_LUONG_TRONG_BANG_HANG_HOA_THEO_MA_HH(string ma_hh, string so_luong_can_giam)
        {
            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "UPDATE HANG_HOA SET SO_LUONG = SO_LUONG - @SO_LUONG_CAN_GIAM WHERE MA_HH = @MA_HH";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ma_hh, SqlDbType.Int);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@SO_LUONG_CAN_GIAM", so_luong_can_giam, SqlDbType.Int);
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
        }

        private void CAP_NHAT_THANH_TIEN_TRONG_BANG_DON_HANG_THEO_MA_DH(string ma_dh)
        {
            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "UPDATE DON_HANG SET THANH_TIEN = (SELECT SUM(THANH_TIEN) FROM DON_HANG_CHI_TIET WHERE MA_DH = @MA_DH) WHERE MA_DH = @MA_DH";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_DH", ma_dh, SqlDbType.Int);
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
        }

        private int TAO_MA_DON_HANG()
        {
            int ma_dh = 0;

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "INSERT INTO DON_HANG (THANH_TIEN) OUTPUT INSERTED.MA_DH VALUES (@THANH_TIEN)";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@THANH_TIEN", "0", SqlDbType.Int);

            String[] KQ = vmk.MS_SQL_INSERT_RETURN_OUTPUT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return ma_dh;
            }

            ma_dh = int.Parse(KQ[1].ToString());

            return ma_dh;
        }
    }
}