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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }
        private void lbHienThi_TextChanged(object sender, EventArgs e)
        {
            //string ten = tbTen.Text;
            //string ho = tbHo.Text;
            //string s;
            //HamXuLy.NoiChuoi(ho, ten, out s);
            //lbHienThi.Text = "Họ và tên: " + s;
        }

        private void lblHienThi_Click(object sender, EventArgs e)
        {
            string ten = lblTen.Text;
            string ho = lblHo.Text;
            string s;
            TinhToan.NoiChuoi(ho, ten, out s);
            lblHienThi.Text = "Họ và tên: " + s;
        }


        private void btnKetQua_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtSo.Text);

            long kq = TinhToan.GiaThua(n);
            lblKetQua.Text = kq.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

