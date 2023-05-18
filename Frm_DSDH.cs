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
    public partial class Frm_DSDH : Form
    {
        public string SQL_CONNECTION_STRING = "";

        public string QUYEN_HAN = "";

        public Frm_DSDH() { InitializeComponent(); }

        private void Frm_DSDH_Load(object sender, EventArgs e)
        {
            RELOAD_DATA_FROM_SQL();
            if (TabC1.SelectedTab == TabP1)
            {
                btn_huydh.Visible = true;
            }
            else
            {
                btn_huydh.Visible = false;
            }
        }

        private void btn_reload_Click(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void LAY_DS_DH_CHUA_THANH_TOAN()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess data = new DataAccess();
            data.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            data.MS_SQL_QUERY = "SELECT * FROM DON_HANG WHERE THOI_GIAN_THANH_TOAN IS NULL ORDER BY MA_DH ASC";
            data.MS_SQL_PARAMETERS = data.CREATE_MS_SQL_PARAMETERS();
            data.MS_SQL_PARAMETERS.Clear();
            ArrayList KQ = data.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            // SAU ĐÓ NẠP VÀO DATAGRIDVIEW

            if (DT.Rows.Count == 0) { dgv_ds_dh_chua_pay.DataSource = null; dgv_ds_dh_chua_pay.Columns.Clear(); return; }

            dgv_ds_dh_chua_pay.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_ds_dh_chua_pay.Columns["MA_DH"].HeaderText = "MÃ ĐƠN HÀNG";
            dgv_ds_dh_chua_pay.Columns["THANH_TIEN"].HeaderText = "THÀNH TIỀN";
            dgv_ds_dh_chua_pay.Columns["THOI_GIAN_TAO_DH"].HeaderText = "THỜI GIAN TẠO ĐƠN HÀNG";

            dgv_ds_dh_chua_pay.Columns["THOI_GIAN_THANH_TOAN"].Visible = false;
        }

        private void LAY_DS_DH_DA_THANH_TOAN()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess data = new DataAccess();
            data.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            data.MS_SQL_QUERY = "SELECT * FROM DON_HANG WHERE THOI_GIAN_THANH_TOAN IS NOT NULL ORDER BY MA_DH ASC";
            data.MS_SQL_PARAMETERS = data.CREATE_MS_SQL_PARAMETERS();
            data.MS_SQL_PARAMETERS.Clear();
            ArrayList KQ = data.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            // SAU ĐÓ NẠP VÀO DATAGRIDVIEW

            if (DT.Rows.Count == 0) { dgv_ds_dh_da_pay.DataSource = null; dgv_ds_dh_da_pay.Columns.Clear(); return; }

            dgv_ds_dh_da_pay.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_ds_dh_da_pay.Columns["MA_DH"].HeaderText = "MÃ ĐƠN HÀNG";
            dgv_ds_dh_da_pay.Columns["THANH_TIEN"].HeaderText = "THÀNH TIỀN";
            dgv_ds_dh_da_pay.Columns["THOI_GIAN_TAO_DH"].HeaderText = "THỜI GIAN TẠO ĐƠN HÀNG";
            dgv_ds_dh_da_pay.Columns["THOI_GIAN_THANH_TOAN"].HeaderText = "THỜI GIAN THANH TOÁN";
        }

        private void RELOAD_DATA_FROM_SQL()
        {
            LAY_DS_DH_CHUA_THANH_TOAN();
            LAY_DS_DH_DA_THANH_TOAN();
            dgv_dh_chitiet.DataSource = null;
        }

        private void LAY_DS_CHI_TIET_DON_HANG_THEO_MA_DH(string ma_dh)
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess data = new DataAccess();
            data.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            data.MS_SQL_QUERY = "SELECT (SELECT TEN_BAN FROM BAN_AN WHERE MA_BAN = DON_HANG_CHI_TIET.MA_BAN) AS TEN_BAN, (SELECT TEN_HH FROM HANG_HOA WHERE MA_HH = DON_HANG_CHI_TIET.MA_HH) AS TEN_HH, SO_LUONG, DON_GIA, THANH_TIEN FROM DON_HANG_CHI_TIET WHERE MA_DH = @MA_DH";
            data.MS_SQL_PARAMETERS = data.CREATE_MS_SQL_PARAMETERS();
            data.MS_SQL_PARAMETERS.Clear();
            data.MS_SQL_PARAMETERS.Rows.Add("@MA_DH", ma_dh, SqlDbType.Int);
            ArrayList KQ = data.MS_SQL_SELECT();

            if (KQ[0].ToString() == "ERROR")
            {
                MessageBox.Show(KQ[1].ToString(), "THÔNG BÁO");
                return;
            }

            DataTable DT = (DataTable)KQ[2];

            // SAU ĐÓ NẠP VÀO DATAGRIDVIEW

            if (DT.Rows.Count == 0) { dgv_dh_chitiet.DataSource = null; dgv_dh_chitiet.Columns.Clear(); return; }

            dgv_dh_chitiet.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_dh_chitiet.Columns["TEN_BAN"].HeaderText = "BÀN ĂN";
            dgv_dh_chitiet.Columns["TEN_HH"].HeaderText = "MÓN ĂN";
            dgv_dh_chitiet.Columns["SO_LUONG"].HeaderText = "SỐ LƯỢNG";
            dgv_dh_chitiet.Columns["DON_GIA"].HeaderText = "ĐƠN GIÁ";
            dgv_dh_chitiet.Columns["THANH_TIEN"].HeaderText = "THÀNH TIỀN";
        }

        private void btn_huydh_Click(object sender, EventArgs e)
        {
            if (dgv_ds_dh_chua_pay.Rows.Count == 0 || dgv_ds_dh_chua_pay.SelectedRows.Count == 0) { return; }

            string ma_dh = dgv_ds_dh_chua_pay.SelectedRows[0].Cells["MA_DH"].Value.ToString().Trim();

            if (ma_dh == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN ĐƠN HÀNG CẦN HỦY", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN MUỐN XÓA DỮ LIỆU ĐANG CHỌN ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            // TIẾN HÀNH HỦY ĐƠN HÀNG

            DataAccess data = new DataAccess();
            data.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            data.MS_SQL_QUERY = "DELETE FROM DON_HANG_CHI_TIET WHERE MA_DH = @MA_DH; DELETE FROM DON_HANG WHERE MA_DH = @MA_DH";
            data.MS_SQL_PARAMETERS = data.CREATE_MS_SQL_PARAMETERS();
            data.MS_SQL_PARAMETERS.Clear();
            data.MS_SQL_PARAMETERS.Rows.Add("@MA_DH", ma_dh, SqlDbType.Int);
            String[] KQ = data.MS_SQL_INSERT_DELETE_UPDATE();

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

            MessageBox.Show("HỦY ĐƠN HÀNG THÀNH CÔNG", "THÔNG BÁO");

            RELOAD_DATA_FROM_SQL();
        }

        private void TabC1_Click(object sender, EventArgs e)
        {
            RELOAD_DATA_FROM_SQL();

            if (TabC1.SelectedTab == TabP1)
            {
                btn_huydh.Visible = true;
            }
            else
            {
                btn_huydh.Visible = false;
            }
        }

        private void dgv_ds_dh_da_pay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ds_dh_da_pay.Rows.Count != 0 && e.RowIndex > -1)
            {
                string ma_dh = dgv_ds_dh_da_pay.Rows[e.RowIndex].Cells["MA_DH"].Value.ToString();
                if (ma_dh != "")
                {
                    LAY_DS_CHI_TIET_DON_HANG_THEO_MA_DH(ma_dh);
                }
            }
        }

        private void dgv_ds_dh_chua_pay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ds_dh_chua_pay.Rows.Count != 0 && e.RowIndex > -1)
            {
                string ma_dh = dgv_ds_dh_chua_pay.Rows[e.RowIndex].Cells["MA_DH"].Value.ToString();
                if (ma_dh != "")
                {
                    LAY_DS_CHI_TIET_DON_HANG_THEO_MA_DH(ma_dh);
                }
            }
        }
    }
}