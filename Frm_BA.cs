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
    public partial class Frm_BA : Form
    {
        public string SQL_CONNECTION_STRING = "";

        public Frm_BA() { InitializeComponent(); }

        private void Frm_BA_Load(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_reload_Click(object sender, EventArgs e) { RELOAD_DATA_FROM_SQL(); }

        private void btn_thoat_Click(object sender, EventArgs e) { this.Close(); }

        private void RELOAD_DATA_FROM_SQL()
        {
            // LẤY DỮ LIỆU TỪ CSDL

            DataAccess data = new DataAccess();
            data.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            data.MS_SQL_QUERY = "SELECT MA_BAN, TEN_BAN FROM BAN_AN ORDER BY MA_BAN ASC";
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

            if (DT.Rows.Count == 0) { dgv_ds_ba.DataSource = null; dgv_ds_ba.Columns.Clear(); return; }

            dgv_ds_ba.DataSource = DT;

            // CHỈNH SỬA TIÊU ĐỀ CÁC CỘT CHO ĐỐI TƯỢNG DATAGRIDVIEW

            dgv_ds_ba.Columns["MA_BAN"].HeaderText = "MÃ BÀN ĂN";
            dgv_ds_ba.Columns["TEN_BAN"].HeaderText = "TÊN BÀN ĂN";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_ds_ba.Rows.Count == 0 || dgv_ds_ba.SelectedRows.Count == 0) { return; }

            string ma_ban = dgv_ds_ba.SelectedRows[0].Cells["MA_BAN"].Value.ToString().Trim();

            if (ma_ban == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN XÓA", "THÔNG BÁO");
                return;
            }

            if (MessageBox.Show("BẠN MUỐN XÓA DỮ LIỆU ĐANG CHỌN ?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            DataAccess data = new DataAccess();
            data.MS_SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            data.MS_SQL_QUERY = "DELETE FROM BAN_AN WHERE MA_BAN = @MA_BAN";
            data.MS_SQL_PARAMETERS = data.CREATE_MS_SQL_PARAMETERS();
            data.MS_SQL_PARAMETERS.Clear();
            data.MS_SQL_PARAMETERS.Rows.Add("@MA_BAN", ma_ban, SqlDbType.VarChar);
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

            RELOAD_DATA_FROM_SQL();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.Hide();

            Frm_BA_CHI_TIET Frm = new Frm_BA_CHI_TIET();
            Frm.ID_DATA = "";
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();

            RELOAD_DATA_FROM_SQL();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dgv_ds_ba.Rows.Count == 0 || dgv_ds_ba.SelectedRows.Count == 0) { return; }

            string ma_ban = dgv_ds_ba.SelectedRows[0].Cells["MA_BAN"].Value.ToString().Trim();

            if (ma_ban == "")
            {
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU CẦN CHỈNH SỬA", "THÔNG BÁO");
                return;
            }

            this.Hide();

            Frm_BA_CHI_TIET Frm = new Frm_BA_CHI_TIET();
            Frm.ID_DATA = ma_ban;
            Frm.SQL_CONNECTION_STRING = SQL_CONNECTION_STRING;
            Frm.ShowDialog();

            this.Show();

            RELOAD_DATA_FROM_SQL();
        }
    }
}