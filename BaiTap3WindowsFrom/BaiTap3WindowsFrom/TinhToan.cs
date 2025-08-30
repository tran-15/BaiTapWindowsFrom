using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3WindowsFrom
{
    internal class TinhToan
    {
        public static void TinhTongN(int n, out int tong)
        {
            tong = 0;
            for (int i = 1; i <= n; i++)
            {
                tong += i;
            }
        }

        public static void TinhGiaiThuaN(int n, out int giaiThua)
        {
            giaiThua = 1;
            for (int i = 2; i <= n; i++)
            {
                giaiThua *= i;
            }
        }


        public static void TachChuoi(string hoten, out string s1, out string s2)
        {
            s1 = "";
            s2 = "";

            string[] parts = hoten.Trim().Split(' ');

            if (parts.Length == 1)
            {
                s2 = parts[0];
            }
            else
            {
                s1 = string.Join(" ", parts, 0, parts.Length - 1);

                s2 = parts[parts.Length - 1];
            }
        }

        public static bool ThuTu(int n1, int n2)
        {
            return n2 == n1 + 1;
        }
    }

}
    

