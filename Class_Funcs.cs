using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml;

namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    public class Class_Funcs
    {
        public bool CHECK_CHARACTER(string CHARACTER_DATA, string LIST_CUSTOM_CHARACTERS = "", bool ACCEPT_NUMBER = false, bool ACCEPT_ALPHABET = false, bool ACCEPT_ALPHABET_VIETNAM = false)
        {
            string LIST_CHARACTER_FOR_NUMBER = "0123456789";
            string LIST_CHARACTER_FOR_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string LIST_CHARACTER_FOR_ALPHABET_VIETNAM = "ÀàÁáẢảÃãẠạĂăẰằẮắẲẳẴẵẶặÂâẦầẤấẨẩẪẫẬậĐđÈèÉéẺẻẼẽẸẹÊêỀềẾếỂểỄễỆệÌìÍíỈỉĨĩỊịÒòÓóỎỏÕõỌọÔôỒồỐốỔổỖỗỘộƠơỜờỚớỞởỠỡỢợÙùÚúỦủŨũỤụƯưỪừỨứỬửỮữỰựỲỳÝýỶỷỸỹỴỵ";

            string LIST_CHARACTER_FOR_CHECKER = "";

            if (LIST_CUSTOM_CHARACTERS != "") { LIST_CHARACTER_FOR_CHECKER += LIST_CUSTOM_CHARACTERS; }
            if (ACCEPT_NUMBER == true) { LIST_CHARACTER_FOR_CHECKER += LIST_CHARACTER_FOR_NUMBER; }
            if (ACCEPT_ALPHABET == true) { LIST_CHARACTER_FOR_CHECKER += LIST_CHARACTER_FOR_ALPHABET; }
            if (ACCEPT_ALPHABET_VIETNAM == true) { LIST_CHARACTER_FOR_CHECKER +=  LIST_CHARACTER_FOR_ALPHABET_VIETNAM; }

            for (int i = 0; i < CHARACTER_DATA.Length; i++)
            {
                if (!LIST_CHARACTER_FOR_CHECKER.Contains(CHARACTER_DATA[i])) { return false; }
            }

            return true;
        }

        public string GET_CURRENT_APP_PATH()
        {
            string CurrDir = AppDomain.CurrentDomain.BaseDirectory.ToString();
            if (CurrDir.Substring(CurrDir.Length - 1) != "\\") { CurrDir = CurrDir + "\\"; }
            return CurrDir;
        }
    }
}
