using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4WindowsFrom
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXepLoai_Click(object sender, EventArgs e)
        {
            int diemlt = int.Parse(txtLT.Text);
            int diemth = int.Parse(txtTH.Text);

            string xepLoai;
            if (diemlt < 5 || diemth < 5)
            {
                xepLoai = "Yếu";
            }
            else
            {
                double diemTB = (diemlt + diemth) / 2;
                if (diemTB < 7)
                    xepLoai = "Trung bình";
                else if (diemTB < 8)
                    xepLoai = "Khá";
                else if (diemTB < 9)
                    xepLoai = "Giỏi";
                else
                    xepLoai = "Xuất sắc";
            }
            btnXepLoai.Text = xepLoai;
        }
    }
}
    

