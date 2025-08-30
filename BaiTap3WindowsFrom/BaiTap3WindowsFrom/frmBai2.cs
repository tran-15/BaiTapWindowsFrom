using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3WindowsFrom
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int so = int.Parse(lblSoN.Text);
            int ketqua;
            if (rdTinhTong.Checked)
            {

                TinhToan.TinhTongN(so, out ketqua);
                lblKetQua.Text = ketqua.ToString();
            }
            else
            {
                TinhToan.TinhGiaiThuaN(so, out ketqua);
                lblKetQua.Text = ketqua.ToString();
            }


        }
    }
}
    

