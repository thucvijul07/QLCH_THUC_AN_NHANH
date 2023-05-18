using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    public class DataAccess
    {
        public string MS_SQL_QUERY = "";
        public DataTable MS_SQL_PARAMETERS;
        public string MS_SQL_CONNECTION_STRING = "";

        public DataTable CREATE_MS_SQL_PARAMETERS()
        {
            DataTable MS_SQL_PARAMETERS = new DataTable();
            MS_SQL_PARAMETERS.Columns.Add("KEY", typeof(string));
            MS_SQL_PARAMETERS.Columns.Add("VALUE", typeof(string));
            MS_SQL_PARAMETERS.Columns.Add("TYPE_OF_DATA", typeof(int));
            return MS_SQL_PARAMETERS;
        }

        public ArrayList MS_SQL_SELECT()
        {
            ArrayList DATA_RETURN = new ArrayList(3);
            DataTable DATA_TABLE_RETURN = new DataTable();
            try
            {
                // MỞ KẾT NỐI CSDL

                SqlConnection MS_SQL_CONNECTION = new SqlConnection(MS_SQL_CONNECTION_STRING);
                MS_SQL_CONNECTION.Open();

                // THỰC HIỆN TRUY VẤN CSDL

                SqlCommand MS_SQL_COMMAND = new SqlCommand(MS_SQL_QUERY, MS_SQL_CONNECTION);
                MS_SQL_COMMAND.Parameters.Clear();

                for (int i = 0; i < MS_SQL_PARAMETERS.Rows.Count; i++)
                {
                    MS_SQL_COMMAND.Parameters.Add(new SqlParameter(MS_SQL_PARAMETERS.Rows[i][0].ToString(), MS_SQL_PARAMETERS.Rows[i][2]));
                    MS_SQL_COMMAND.Parameters[MS_SQL_PARAMETERS.Rows[i][0].ToString()].Value = MS_SQL_PARAMETERS.Rows[i][1];
                }

                SqlDataReader MS_SQL_DATA_READER = MS_SQL_COMMAND.ExecuteReader();

                // LẤY DỮ LIỆU CÓ ĐƯỢC TỪ TRUY VẤN ĐƯA VÀO ĐỐI TƯỢNG DATA TABLE

                DATA_TABLE_RETURN.Load(MS_SQL_DATA_READER);

                // ĐÓNG KẾT NỐI CSDL

                MS_SQL_CONNECTION.Close();

                DATA_RETURN.Clear();
                DATA_RETURN.Add("OK");
                DATA_RETURN.Add("");
                DATA_RETURN.Add(DATA_TABLE_RETURN);
            }
            catch (Exception ex)
            {
                DATA_RETURN.Clear();
                DATA_RETURN.Add("ERROR");
                DATA_RETURN.Add(ex.ToString());
                DATA_RETURN.Add(DATA_TABLE_RETURN);
            }

            return DATA_RETURN;
        }

        public string[] MS_SQL_INSERT_DELETE_UPDATE()
        {
            string[] DATA_RETURN = { "", "" };
            try
            {
                // MỞ KẾT NỐI CSDL

                SqlConnection MS_SQL_CONNECTION = new SqlConnection(MS_SQL_CONNECTION_STRING);
                MS_SQL_CONNECTION.Open();

                // THỰC HIỆN TRUY VẤN CSDL

                SqlCommand MS_SQL_COMMAND = new SqlCommand(MS_SQL_QUERY, MS_SQL_CONNECTION);
                MS_SQL_COMMAND.Parameters.Clear();

                for (int i = 0; i < MS_SQL_PARAMETERS.Rows.Count; i++)
                {
                    MS_SQL_COMMAND.Parameters.Add(new SqlParameter(MS_SQL_PARAMETERS.Rows[i][0].ToString(), MS_SQL_PARAMETERS.Rows[i][2]));
                    MS_SQL_COMMAND.Parameters[MS_SQL_PARAMETERS.Rows[i][0].ToString()].Value = MS_SQL_PARAMETERS.Rows[i][1];
                }

                int MS_SQL_COMMAND_RESULT = MS_SQL_COMMAND.ExecuteNonQuery();

                // ĐÓNG KẾT NỐI CSDL

                MS_SQL_CONNECTION.Close();

                DATA_RETURN[0] = "OK";
                DATA_RETURN[1] = MS_SQL_COMMAND_RESULT.ToString();
            }
            catch (Exception ex)
            {
                DATA_RETURN[0] = "ERROR";
                DATA_RETURN[1] = ex.ToString();
            }

            return DATA_RETURN;
        }

        public string[] MS_SQL_INSERT_RETURN_OUTPUT()
        {
            string[] DATA_RETURN = { "", "" };
            try
            {
                // MỞ KẾT NỐI CSDL

                SqlConnection MS_SQL_CONNECTION = new SqlConnection(MS_SQL_CONNECTION_STRING);
                MS_SQL_CONNECTION.Open();

                // THỰC HIỆN TRUY VẤN CSDL

                SqlCommand MS_SQL_COMMAND = new SqlCommand(MS_SQL_QUERY, MS_SQL_CONNECTION);
                MS_SQL_COMMAND.Parameters.Clear();

                for (int i = 0; i < MS_SQL_PARAMETERS.Rows.Count; i++)
                {
                    MS_SQL_COMMAND.Parameters.Add(new SqlParameter(MS_SQL_PARAMETERS.Rows[i][0].ToString(), MS_SQL_PARAMETERS.Rows[i][2]));
                    MS_SQL_COMMAND.Parameters[MS_SQL_PARAMETERS.Rows[i][0].ToString()].Value = MS_SQL_PARAMETERS.Rows[i][1];
                }

                string MS_SQL_COMMAND_RESULT = Convert.ToString(MS_SQL_COMMAND.ExecuteScalar());

                // ĐÓNG KẾT NỐI CSDL

                MS_SQL_CONNECTION.Close();

                DATA_RETURN[0] = "OK";
                DATA_RETURN[1] = MS_SQL_COMMAND_RESULT.ToString();


            }
            catch (Exception ex)
            {
                DATA_RETURN[0] = "ERROR";
                DATA_RETURN[1] = ex.ToString();
            }

            return DATA_RETURN;
        }
    }
}