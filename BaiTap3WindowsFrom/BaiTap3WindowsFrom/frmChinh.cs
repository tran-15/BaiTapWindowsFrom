﻿using System;
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
  

        public partial class frmChinh : Form
        {
            public frmChinh()
            {
                InitializeComponent();
            }

            private void btnBai1_Click(object sender, EventArgs e)
            {
                var form = new frmBai1();
                form.ShowDialog();
            }

            private void btnBai2_Click(object sender, EventArgs e)
            {
                var frm = new frmBai2();
                frm.ShowDialog();
            }

            private void btnBai3_Click(object sender, EventArgs e)
            {
                var form = new frmBai3();
                form.ShowDialog();
            }
        }
    }

