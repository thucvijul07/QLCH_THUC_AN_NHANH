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
    public partial class Frm_HH : Form
    {
        public string SQL_CONNECTION_STRING = "";

        public Frm_HH() { InitializeComponent(); }

        private void Frm_HH_Load(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_reload_Click(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void RELOAD_DATA_FROM_SQL()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT MA_HH, TEN_HH, (SELECT TEN_LH FROM LOAI_HANG WHERE MA_LH = HANG_HOA.MA_LH) AS TEN_LH, (SELECT TEN_DVT FROM DON_VI_TINH WHERE MA_DVT = HANG_HOA.MA_DVT) AS TEN_DVT, SO_LUONG, DON_GIA FROM HANG_HOA ORDER BY MA_HH ASC";
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

            if (DT.Rows.Count == 0) { dgv_ds_hh.DataSource = null; dgv_ds_hh.Columns.Clear(); return; }

            dgv_ds_hh.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_ds_hh.Columns["MA_HH"].HeaderText = "MÃ HÀNG HÓA";
            dgv_ds_hh.Columns["TEN_HH"].HeaderText = "TÊN HÀNG HÓA";
            dgv_ds_hh.Columns["TEN_LH"].HeaderText = "LOẠI HÀNG";
            dgv_ds_hh.Columns["TEN_DVT"].HeaderText = "ĐƠN VỊ TÍNH";            
            dgv_ds_hh.Columns["SO_LUONG"].HeaderText = "SỐ LƯỢNG";
            dgv_ds_hh.Columns["DON_GIA"].HeaderText = "ĐƠN GIÁ";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_ds_hh.Rows.Count == 0 || dgv_ds_hh.SelectedRows.Count == 0) { return; }

            string ma_hh = dgv_ds_hh.SelectedRows[0].Cells["MA_HH"].Value.ToString().Trim();

            if (ma_hh == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN XÓA", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN MUỐN XÓA DỮ LIỆU ĐANG CHỌN ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "DELETE FROM HANG_HOA WHERE MA_HH = @MA_HH";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_HH", ma_hh, SqlDbType.Int);
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

            Frm_HH_CHI_TIET Frm = new Frm_HH_CHI_TIET();
            Frm.ID_DATA = "";
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();

            RELOAD_DATA_FROM_SQL();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_ds_hh.Rows.Count == 0 || dgv_ds_hh.SelectedRows.Count == 0) { return; }

            string ma_hh = dgv_ds_hh.SelectedRows[0].Cells["MA_HH"].Value.ToString().Trim();

            if (ma_hh == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN CHỈNH SỬA", "THÔNG BÁO");
                return;
            }

            this.Hide();

            Frm_HH_CHI_TIET Frm = new Frm_HH_CHI_TIET();
            Frm.ID_DATA = ma_hh;
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();

            RELOAD_DATA_FROM_SQL();
        }
    }
}