﻿using BaiTapWindowsFrom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmChinh_Load(object sender, EventArgs e)
        {

        }
        private void tsbBai1_Click(object sender, EventArgs e)
        {
            var from = new frmBai1();
            from.ShowDialog();
        }
        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var from = new frmBai2();
            from.ShowDialog();
        }
        private void tsbBai3_Click(object sender, EventArgs e)
        {
            var from = new frmBai3();
            from.ShowDialog();
        }
    }
}
