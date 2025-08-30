using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
    {
        public partial class frmBai1 : Form
        {
            public frmBai1()
            {
                InitializeComponent();
            }

            private void radXanh_CheckedChanged(object sender, EventArgs e)
            {
                if (radXanh.Checked)
                    txtDonGia.Text = "22000";
            }

            private void radDo_CheckedChanged(object sender, EventArgs e)
            {
                if (radDo.Checked)
                    txtDonGia.Text = "21000";
            }

            private void radTrang_CheckedChanged(object sender, EventArgs e)
            {
                if (radTrang.Checked)
                    txtDonGia.Text = "20000";
            }

            private void btnTinhTien_Click(object sender, EventArgs e)
            {
                try
                {
                    int donGia = int.Parse(txtDonGia.Text);
                    int soLuong = int.Parse(txtSoLuong.Text);
                    int tongTien = donGia * soLuong;

                    lblSoTien.Text = "Tổng tiền thanh toán: " + tongTien.ToString("N0") + " $";
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ và đúng dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radTrang = new System.Windows.Forms.RadioButton();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radTrang);
            this.groupBox1.Controls.Add(this.radDo);
            this.groupBox1.Controls.Add(this.radXanh);
            this.groupBox1.Location = new System.Drawing.Point(483, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 169);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu xe";
            // 
            // radTrang
            // 
            this.radTrang.AutoSize = true;
            this.radTrang.Location = new System.Drawing.Point(19, 110);
            this.radTrang.Name = "radTrang";
            this.radTrang.Size = new System.Drawing.Size(64, 20);
            this.radTrang.TabIndex = 2;
            this.radTrang.Text = "Trắng";
            this.radTrang.UseVisualStyleBackColor = true;
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.Location = new System.Drawing.Point(19, 70);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(45, 20);
            this.radDo.TabIndex = 1;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.Checked = true;
            this.radXanh.Location = new System.Drawing.Point(19, 26);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(58, 20);
            this.radXanh.TabIndex = 0;
            this.radXanh.TabStop = true;
            this.radXanh.Text = "Xanh";
            this.radXanh.UseVisualStyleBackColor = true;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(445, 234);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(71, 20);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(445, 277);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(74, 20);
            this.lblSoLuong.TabIndex = 3;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(331, 358);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(166, 20);
            this.lblSoTien.TabIndex = 5;
            this.lblSoTien.Text = "Tổng tiền thanh toán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(662, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "$";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(537, 232);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(130, 27);
            this.txtDonGia.TabIndex = 8;
            this.txtDonGia.Text = "22000";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(537, 275);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(130, 27);
            this.txtSoLuong.TabIndex = 9;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(422, 318);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(109, 25);
            this.btnTinhTien.TabIndex = 10;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            // 
            // frmBai1
            // 
            this.ClientSize = new System.Drawing.Size(858, 404);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBai1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton radTrang;
        private RadioButton radDo;
        private RadioButton radXanh;
        private Label lblDonGia;
        private Label lblSoLuong;
        private Label label3;
        private Label lblSoTien;
        private Label label5;
        private Label label6;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Button btnTinhTien;

        private void frmBai1_Load(object sender, EventArgs e)
        {

        }
    }
}
