using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2WindowsFrom
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }
        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            double soThuNhat = double.Parse(lblSo1.Text);
            double soThuHai = double.Parse(lblSo2.Text);
            double ketqua = 0;

            if (rdCong.Checked)
                ketqua = soThuNhat + soThuHai;
            else if (rdTru.Checked)
                ketqua = soThuNhat - soThuHai;
            else if (rdNhan.Checked)
                ketqua = soThuNhat * soThuHai;
            else
                ketqua = soThuNhat / soThuHai;

            lblKetQua.Text = ketqua.ToString();

        }
    }
}
    

