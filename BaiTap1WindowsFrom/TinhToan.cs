using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class TinhToan
    {
        public static void CongHaiSo(double a, double b, out double s)
        {
            s = a + b;
        }

        public static int TongDaySo(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n; i++)
                tong += i;
            return tong;
        }
    }
}
