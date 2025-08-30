namespace BaiTap2WindowsFrom
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
            this.lblSo1 = new System.Windows.Forms.Label();
            this.lblSo2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdChia = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSo1
            // 
            this.lblSo1.AutoSize = true;
            this.lblSo1.Location = new System.Drawing.Point(134, 41);
            this.lblSo1.Name = "lblSo1";
            this.lblSo1.Size = new System.Drawing.Size(72, 16);
            this.lblSo1.TabIndex = 0;
            this.lblSo1.Text = "Số thứ nhất";
            // 
            // lblSo2
            // 
            this.lblSo2.AutoSize = true;
            this.lblSo2.Location = new System.Drawing.Point(134, 85);
            this.lblSo2.Name = "lblSo2";
            this.lblSo2.Size = new System.Drawing.Size(65, 16);
            this.lblSo2.TabIndex = 1;
            this.lblSo2.Text = "Số thứ hai";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(278, 35);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(112, 22);
            this.txtSo1.TabIndex = 2;
            this.txtSo1.Text = "50";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(278, 85);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(112, 22);
            this.txtSo2.TabIndex = 3;
            this.txtSo2.Text = "30";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChia);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(278, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Location = new System.Drawing.Point(9, 40);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(60, 20);
            this.rdCong.TabIndex = 0;
            this.rdCong.Text = "Cộng";
            this.rdCong.UseVisualStyleBackColor = true;
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Checked = true;
            this.rdTru.Location = new System.Drawing.Point(9, 76);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(48, 20);
            this.rdTru.TabIndex = 1;
            this.rdTru.TabStop = true;
            this.rdTru.Text = "Trừ";
            this.rdTru.UseVisualStyleBackColor = true;
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(9, 111);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(60, 20);
            this.rdNhan.TabIndex = 2;
            this.rdNhan.Text = "Nhân";
            this.rdNhan.UseVisualStyleBackColor = true;
            // 
            // rdChia
            // 
            this.rdChia.AutoSize = true;
            this.rdChia.Location = new System.Drawing.Point(9, 151);
            this.rdChia.Name = "rdChia";
            this.rdChia.Size = new System.Drawing.Size(55, 20);
            this.rdChia.TabIndex = 3;
            this.rdChia.Text = "Chia";
            this.rdChia.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(403, 336);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(111, 23);
            this.btnKetQua.TabIndex = 5;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(206, 400);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(89, 20);
            this.lblKetQua.TabIndex = 6;
            this.lblKetQua.Text = "Kết quả là:";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.lblSo2);
            this.Controls.Add(this.lblSo1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdChia;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lblKetQua;
    }
}