using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2WindowsFrom
{
    internal class TinhToan
    {
        public static void NoiChuoi(string ho, string ten, out string s)
        {
            s = ho + " " + ten;
        }

        public static long GiaThua(int n)
        {
            if (n <= 1)
                return 1;

            long ketQua = 1;
            for (int i = 2; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }
    }
}
    

