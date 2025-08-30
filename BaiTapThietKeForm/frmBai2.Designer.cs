namespace BaiTapThietKeForm
{
    partial class frmBai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSotien = new System.Windows.Forms.Label();
            this.bntTinhTien = new System.Windows.Forms.Button();
            this.bntBoHang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USP Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(19, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 196);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hàng hoá";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 365);
            this.panel1.TabIndex = 2;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(248, 116);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(98, 32);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblSotien);
            this.panel2.Controls.Add(this.bntTinhTien);
            this.panel2.Controls.Add(this.bntBoHang);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(423, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 365);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(243, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = ".";
            // 
            // lblSotien
            // 
            this.lblSotien.AutoSize = true;
            this.lblSotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSotien.Location = new System.Drawing.Point(3, 327);
            this.lblSotien.Name = "lblSotien";
            this.lblSotien.Size = new System.Drawing.Size(191, 25);
            this.lblSotien.TabIndex = 4;
            this.lblSotien.Text = "Tổng tiền thanh toán";
            // 
            // bntTinhTien
            // 
            this.bntTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTinhTien.Location = new System.Drawing.Point(200, 274);
            this.bntTinhTien.Name = "bntTinhTien";
            this.bntTinhTien.Size = new System.Drawing.Size(82, 29);
            this.bntTinhTien.TabIndex = 3;
            this.bntTinhTien.Text = "Tính tiền";
            this.bntTinhTien.UseVisualStyleBackColor = true;
            // 
            // bntBoHang
            // 
            this.bntBoHang.Location = new System.Drawing.Point(17, 116);
            this.bntBoHang.Name = "bntBoHang";
            this.bntBoHang.Size = new System.Drawing.Size(98, 32);
            this.bntBoHang.TabIndex = 2;
            this.bntBoHang.Text = "Bỏ hàng >";
            this.bntBoHang.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(155, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(196, 180);
            this.listBox2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Các mặt hàng khách đã mua";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntBoHang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSotien;
        private System.Windows.Forms.Button bntTinhTien;
    }
}