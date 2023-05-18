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
    public partial class Frm_NHAN_VIEN_CHI_TIET : Form
    {
        Class_Funcs CFuncs = new Class_Funcs();

        public string ID_DATA = "";
        public string MODE_CHANGE_DATA = "";
        public string SQL_CONNECTION_STRING = "";

        public Frm_NHAN_VIEN_CHI_TIET() { InitializeComponent(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void Make_Combobox_QuyenHan()
        {
            DataTable DTable = new DataTable();
            DTable.Columns.Add("MA_QH", typeof(int));
            DTable.Columns.Add("TEN_QH", typeof(string));

            DTable.Rows.Add(0, "NHÂN VIÊN");
            DTable.Rows.Add(1, "QUẢN LÝ");

            cbo_quyen_han.DataSource = DTable;
            cbo_quyen_han.DisplayMember = "TEN_QH";
            cbo_quyen_han.ValueMember = "MA_QH";
        }

        private void Frm_TAIKHOAN_CHI_TIET_Load(object sender, EventArgs e)
        {
            // TẠO CONTROL DANH SÁCH QUYỀN HẠN

            Make_Combobox_QuyenHan();

            // KIỂM TRA BIẾN ID_DATA ĐƯỢC TRUYỀN ĐẾN. NẾU RỖNG NGHĨA LÀ THÊM MỚI, NGƯỢC LẠI LÀ CẬP NHẬT

            if (ID_DATA.Trim() != "")
            {
                MODE_CHANGE_DATA = "CAP_NHAT";
                XEM_CSDL_THEO_ID(ID_DATA);
                btn_capnhat.Visible = true;
                btn_them.Visible = false;
                txt_tai_khoan.Enabled = false;
            }
            else
            {
                MODE_CHANGE_DATA = "THEM_MOI";
                btn_capnhat.Visible = false;
                btn_them.Visible = true;
            }
        }        

        private void XEM_CSDL_THEO_ID(string ID_DATA)
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT TAI_KHOAN, MAT_KHAU, HO_TEN, SDT, QUYEN_HAN FROM NHAN_VIEN WHERE (TAI_KHOAN = @TAI_KHOAN) ORDER BY TAI_KHOAN ASC";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TAI_KHOAN", ID_DATA, SqlDbType.VarChar);
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
                txt_tai_khoan.Text = DT.Rows[0]["TAI_KHOAN"].ToString().Trim();
                txt_mat_khau.Text = DT.Rows[0]["MAT_KHAU"].ToString().Trim();
                txt_ho_ten.Text = DT.Rows[0]["HO_TEN"].ToString().Trim();
                txt_sdt.Text = DT.Rows[0]["SDT"].ToString().Trim();
                cbo_quyen_han.SelectedValue = DT.Rows[0]["QUYEN_HAN"].ToString().Trim();
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (MODE_CHANGE_DATA != "THEM_MOI") { return; }

            // LẤY VÀ KIỂM TRA DỮ LIỆU TỪ FORM

            string tai_khoan = txt_tai_khoan.Text.Trim().ToUpper();
            string mat_khau = txt_mat_khau.Text.Trim();
            string ho_ten = txt_ho_ten.Text.Trim();
            string quyen_han = cbo_quyen_han.SelectedValue.ToString();
            string sdt = txt_sdt.Text.Trim();

            if (tai_khoan == "" || mat_khau == "" || ho_ten == "" || quyen_han == "" || sdt == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐẦY ĐỦ DỮ LIỆU", "THÔNG BÁO");

                if (tai_khoan == "") { txt_tai_khoan.Focus(); return; }
                if (mat_khau == "") { txt_mat_khau.Focus(); return; }
                if (ho_ten == "") { txt_ho_ten.Focus(); return; }
                if (quyen_han == "") { cbo_quyen_han.Focus(); return; }
                if (sdt == "") { txt_sdt.Focus(); return; }

                return;
            }

            if (tai_khoan != "" && CFuncs.CHECK_CHARACTER(tai_khoan, "_", true, true, false) == false)
            {
                MessageBox.Show("TÀI KHOẢN CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ho_ten != "" && CFuncs.CHECK_CHARACTER(ho_ten, " ", true, true, true) == false)
            {
                MessageBox.Show("HỌ TÊN CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (quyen_han != "" && CFuncs.CHECK_CHARACTER(quyen_han, "", true, false, false) == false)
            {
                MessageBox.Show("QUYỀN HẠN CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            if (sdt != "" && CFuncs.CHECK_CHARACTER(sdt, "", true, false, false) == false)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            // TIẾN HÀNH THÊM DỮ LIỆU VÀO CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "INSERT INTO NHAN_VIEN (TAI_KHOAN, MAT_KHAU, HO_TEN, SDT, QUYEN_HAN) VALUES (@TAI_KHOAN, @MAT_KHAU, @HO_TEN, @SDT, @QUYEN_HAN)";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TAI_KHOAN", tai_khoan, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MAT_KHAU", mat_khau, SqlDbType.NVarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@HO_TEN", ho_ten, SqlDbType.NVarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@SDT", sdt, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@QUYEN_HAN", quyen_han, SqlDbType.Int);
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

            string tai_khoan = ID_DATA.Trim();
            string mat_khau = txt_mat_khau.Text.Trim();
            string ho_ten = txt_ho_ten.Text.Trim();
            string quyen_han = cbo_quyen_han.SelectedValue.ToString();
            string sdt = txt_sdt.Text.Trim();

            if (tai_khoan == "" || mat_khau == "" || ho_ten == "" || quyen_han == "" || sdt == "")
            {
                MessageBox.Show("BẠN CHƯA NHẬP ĐẦY ĐỦ DỮ LIỆU", "THÔNG BÁO");

                if (mat_khau == "") { txt_mat_khau.Focus(); return; }
                if (ho_ten == "") { txt_ho_ten.Focus(); return; }
                if (quyen_han == "") { cbo_quyen_han.Focus(); return; }
                if (sdt == "") { txt_sdt.Focus(); return; }

                return;
            }

            if (tai_khoan != "" && CFuncs.CHECK_CHARACTER(tai_khoan, "_", true, true, false) == false)
            {
                MessageBox.Show("TÀI KHOẢN CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (ho_ten != "" && CFuncs.CHECK_CHARACTER(ho_ten, " ", true, true, true) == false)
            {
                MessageBox.Show("HỌ TÊN CÓ CHỨA NHỮNG KÝ TỰ KHÔNG HỢP LỆ", "THÔNG BÁO");
                return;
            }

            if (quyen_han != "" && CFuncs.CHECK_CHARACTER(quyen_han, "", true, false, false) == false)
            {
                MessageBox.Show("QUYỀN HẠN CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            if (sdt != "" && CFuncs.CHECK_CHARACTER(sdt, "", true, false, false) == false)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI CHỈ CHẤP NHẬN KÝ TỰ SỐ", "THÔNG BÁO");
                return;
            }

            // TIẾN HÀNH THÊM DỮ LIỆU VÀO CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "UPDATE NHAN_VIEN SET MAT_KHAU = @MAT_KHAU, HO_TEN = @HO_TEN, SDT = @SDT, QUYEN_HAN = @QUYEN_HAN WHERE TAI_KHOAN = @TAI_KHOAN";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TAI_KHOAN", tai_khoan, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MAT_KHAU", mat_khau, SqlDbType.NVarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@HO_TEN", ho_ten, SqlDbType.NVarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@SDT", sdt, SqlDbType.VarChar);
            vmk.MS_SQL_PARAMETERS.Rows.Add("@QUYEN_HAN", quyen_han, SqlDbType.Int);
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