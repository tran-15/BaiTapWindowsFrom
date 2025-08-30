using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4WindowsFrom
{
    internal class TinhToan
    {
        public static void ChaoHoi(string hoten, bool gioitinh)
        {
            if (gioitinh)
            {
                MessageBox.Show("Chào Ông " + hoten);

            }
            else
            {
                MessageBox.Show("Chào Bà " + hoten);
            }
        }

        public static int TimUSCLN(int m, int n)
        {

            if (m == 0)
                return n;
            if (n == 0)
                return m;


            while (n != 0)
            {
                int temp = n;
                n = m % n;
                m = temp;

            }
            return m;
        }
    }
}
    

