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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }
        private void tsmBai1_Click_1(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void bàiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void tsmBai2_Click_3(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }
    }
}

