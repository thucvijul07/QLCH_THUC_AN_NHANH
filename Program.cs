using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QUAN_LY_CUA_HANG_THUC_AN_NHANH
{
    static class Program
    {
       [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_MAIN());
        }
    }
}
