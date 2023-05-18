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
    public partial class Frm_NHAN_VIEN : Form
    {
        public string Acc_Logged = "";
        public string SQL_CONNECTION_STRING = "";

        public Frm_NHAN_VIEN() { InitializeComponent(); }

        private void Frm_NHAN_VIEN_Load(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_reload_Click(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void RELOAD_DATA_FROM_SQL()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT TAI_KHOAN, HO_TEN, SDT, (CASE QUYEN_HAN WHEN 1 THEN N'QUẢN LÝ' ELSE N'NHÂN VIÊN' END) AS QUYEN_HAN FROM NHAN_VIEN ORDER BY TAI_KHOAN ASC";
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

            if (DT.Rows.Count == 0) { dgv_ds_nv.DataSource = null; dgv_ds_nv.Columns.Clear(); return; }

            dgv_ds_nv.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_ds_nv.Columns["TAI_KHOAN"].HeaderText = "TÀI KHOẢN";
            dgv_ds_nv.Columns["HO_TEN"].HeaderText = "HỌ TÊN";
            dgv_ds_nv.Columns["SDT"].HeaderText = "SĐT";
            dgv_ds_nv.Columns["QUYEN_HAN"].HeaderText = "QUYỀN HẠN";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_ds_nv.Rows.Count == 0 || dgv_ds_nv.SelectedRows.Count == 0) { return; }

            string tai_khoan = dgv_ds_nv.SelectedRows[0].Cells["TAI_KHOAN"].Value.ToString().Trim();

            if (tai_khoan == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN XÓA", "THÔNG BÁO");
                return;
            }

            if (tai_khoan.ToLower() == Acc_Logged.ToLower())
            {
                MessageBox.Show("KHÔNG THỂ XÓA. TÀI KHOẢN ĐANG ĐƯỢC SỬ DỤNG", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN MUỐN XÓA DỮ LIỆU ĐANG CHỌN ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "DELETE FROM NHAN_VIEN WHERE TAI_KHOAN = @TAI_KHOAN";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@TAI_KHOAN", tai_khoan, SqlDbType.VarChar);
            String[] KQ = vmk.MS_SQL_INSERT_DELETE_UPDATE();

            if (KQ[0].ToString() == "ERROR")
            {
                Console.WriteLine(KQ[1].ToString());
                if (KQ[1].ToLower().Contains("the delete statement conflicted with the reference constraint"))
                {
                    MessageBox.Show("KHÔNG THỂ XÓA. DỮ LIỆU ĐANG ĐƯỢC SỬ DỤNG Ở BẢNG KHÁC", "THÔNG BÁO");
                    return;
                }
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            // NẾU XÓA THÀNH CÔNG THÌ CẬP NHẬT LẠI DỮ LIỆU

            RELOAD_DATA_FROM_SQL();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_NHAN_VIEN_CHI_TIET Frm = new Frm_NHAN_VIEN_CHI_TIET();
            Frm.ID_DATA = "";
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();

            RELOAD_DATA_FROM_SQL();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_ds_nv.Rows.Count == 0 || dgv_ds_nv.SelectedRows.Count == 0) { return; }

            string tai_khoan = dgv_ds_nv.SelectedRows[0].Cells["TAI_KHOAN"].Value.ToString().Trim();

            if (tai_khoan == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN CHỈNH SỬA", "THÔNG BÁO");
                return;
            }

            this.Hide();

            Frm_NHAN_VIEN_CHI_TIET Frm = new Frm_NHAN_VIEN_CHI_TIET();
            Frm.ID_DATA = tai_khoan;
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();

            RELOAD_DATA_FROM_SQL();
        }
    }
}