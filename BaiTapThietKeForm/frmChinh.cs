using BaiTapThietKeForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    public partial class frmChinh : Form
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem nguyễnBíchTrânToolStripMenuItem;
        private ToolStripMenuItem tsmiBai1;
        private ToolStripMenuItem tsmiBai2;
        private ToolStripMenuItem tsmiBai4;
        private ToolStripMenuItem tsmiBai3;

        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsbBai1_Click(object sender, EventArgs e)
        {
            var form = new frmBai1();
            form.ShowDialog();
        }

        private void tsbBai2_Click(object sender, EventArgs e)
        {
            var form = new frmBai2();
            form.ShowDialog();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nguyễnBíchTrânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBai4 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyễnBíchTrânToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nguyễnBíchTrânToolStripMenuItem
            // 
            this.nguyễnBíchTrânToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBai1,
            this.tsmiBai2,
            this.tsmiBai3,
            this.tsmiBai4});
            this.nguyễnBíchTrânToolStripMenuItem.Name = "nguyễnBíchTrânToolStripMenuItem";
            this.nguyễnBíchTrânToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.nguyễnBíchTrânToolStripMenuItem.Text = "Nguyễn Bích Trân";
            // 
            // tsmiBai1
            // 
            this.tsmiBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai1.Image")));
            this.tsmiBai1.Name = "tsmiBai1";
            this.tsmiBai1.Size = new System.Drawing.Size(224, 26);
            this.tsmiBai1.Text = "Bài 1";
            // 
            // tsmiBai2
            // 
            this.tsmiBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai2.Image")));
            this.tsmiBai2.Name = "tsmiBai2";
            this.tsmiBai2.Size = new System.Drawing.Size(224, 26);
            this.tsmiBai2.Text = "Bài 2";
            // 
            // tsmiBai3
            // 
            this.tsmiBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai3.Image")));
            this.tsmiBai3.Name = "tsmiBai3";
            this.tsmiBai3.Size = new System.Drawing.Size(224, 26);
            this.tsmiBai3.Text = "Bài 3";
            this.tsmiBai3.Click += new System.EventHandler(this.tsmiBai3_Click);
            // 
            // tsmiBai4
            // 
            this.tsmiBai4.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBai4.Image")));
            this.tsmiBai4.Name = "tsmiBai4";
            this.tsmiBai4.Size = new System.Drawing.Size(224, 26);
            this.tsmiBai4.Text = "Bài 4";
            this.tsmiBai4.Click += new System.EventHandler(this.tsmiBai4_Click);
            // 
            // frmChinh
            // 
            this.ClientSize = new System.Drawing.Size(495, 389);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
        }

        private void tsmiBai3_Click(object sender, EventArgs e)
        {
            var form = new frmBai3();
            form.ShowDialog();
        }

        private void tsmiBai4_Click(object sender, EventArgs e)
        {
            var form = new frmBai4();
            form.ShowDialog();
        }
    }
}