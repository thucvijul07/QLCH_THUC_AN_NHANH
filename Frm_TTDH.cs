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
    public partial class Frm_TTDH : Form
    {
        public string SQL_CONNECTION_STRING = "";

        public Frm_TTDH() { InitializeComponent(); }

        private void Frm_TTDH_Load(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_reload_Click(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void RELOAD_DATA_FROM_SQL()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "SELECT * FROM DON_HANG WHERE (THOI_GIAN_THANH_TOAN IS NULL) ORDER BY THOI_GIAN_TAO_DH DESC";
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

            if (DT.Rows.Count == 0) { dgv_ds_dh_chua_thanh_toan.DataSource = null; dgv_ds_dh_chua_thanh_toan.Columns.Clear(); return; }

            dgv_ds_dh_chua_thanh_toan.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_ds_dh_chua_thanh_toan.Columns["MA_DH"].HeaderText = "MÃ ĐƠN HÀNG";
            dgv_ds_dh_chua_thanh_toan.Columns["THANH_TIEN"].HeaderText = "THÀNH TIỀN";
            dgv_ds_dh_chua_thanh_toan.Columns["THOI_GIAN_TAO_DH"].HeaderText = "THỜI GIAN TẠO ĐƠN HÀNG";

            dgv_ds_dh_chua_thanh_toan.Columns["THOI_GIAN_THANH_TOAN"].Visible = false;       
        }

        private void btn_capnhat_thanhtoan_Click(object sender, EventArgs e)
        {
            if (dgv_ds_dh_chua_thanh_toan.Rows.Count == 0 || dgv_ds_dh_chua_thanh_toan.SelectedRows.Count == 0) { return; }

            string ma_dh = dgv_ds_dh_chua_thanh_toan.SelectedRows[0].Cells["MA_DH"].Value.ToString().Trim();

            if (ma_dh == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN ĐƠN HÀNG CẦN CẬP NHẬT TRẠNG THÁI", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN MUỐN CẬP NHẬT TRẠNG THÁI THANH TOÁN" + "\r\n\r\n" + "CHO ĐƠN HÀNG ĐANG CHỌN ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            DataAccess vmk = new DataAccess();
            vmk.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            vmk.MS_SQL_QUERY = "UPDATE DON_HANG SET THOI_GIAN_THANH_TOAN = GETDATE() WHERE MA_DH = @MA_DH";
            vmk.MS_SQL_PARAMETERS = vmk.CREATE_MS_SQL_PARAMETERS();
            vmk.MS_SQL_PARAMETERS.Clear();
            vmk.MS_SQL_PARAMETERS.Rows.Add("@MA_DH", ma_dh, SqlDbType.VarChar);
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

            MessageBox.Show("CẬP NHẬT TRẠNG THÁI CHO ĐƠN HÀNG ĐANG CHỌN THÀNH CÔNG", "THÔNG BÁO");

            RELOAD_DATA_FROM_SQL();
        }
    }
}