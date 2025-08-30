namespace BaiTap3WindowsFrom
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
            this.lblSoN = new System.Windows.Forms.Label();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhTong = new System.Windows.Forms.RadioButton();
            this.rdGiaiThua = new System.Windows.Forms.RadioButton();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoN
            // 
            this.lblSoN.AutoSize = true;
            this.lblSoN.Location = new System.Drawing.Point(248, 25);
            this.lblSoN.Name = "lblSoN";
            this.lblSoN.Size = new System.Drawing.Size(184, 16);
            this.lblSoN.TabIndex = 0;
            this.lblSoN.Text = "Nhập một số nguyên dương N";
       
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(453, 19);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(100, 22);
            this.txtSoN.TabIndex = 1;
            this.txtSoN.Text = "4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGiaiThua);
            this.groupBox1.Controls.Add(this.rdTinhTong);
            this.groupBox1.Location = new System.Drawing.Point(393, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn công việc:";
            // 
            // rdTinhTong
            // 
            this.rdTinhTong.AutoSize = true;
            this.rdTinhTong.Checked = true;
            this.rdTinhTong.Location = new System.Drawing.Point(22, 31);
            this.rdTinhTong.Name = "rdTinhTong";
            this.rdTinhTong.Size = new System.Drawing.Size(140, 20);
            this.rdTinhTong.TabIndex = 0;
            this.rdTinhTong.TabStop = true;
            this.rdTinhTong.Text = "Tính tổng 1+2+...+N";
            this.rdTinhTong.UseVisualStyleBackColor = true;
            // 
            // rdGiaiThua
            // 
            this.rdGiaiThua.AutoSize = true;
            this.rdGiaiThua.Location = new System.Drawing.Point(22, 84);
            this.rdGiaiThua.Name = "rdGiaiThua";
            this.rdGiaiThua.Size = new System.Drawing.Size(141, 20);
            this.rdGiaiThua.TabIndex = 1;
            this.rdGiaiThua.Text = "Tính N giai thừa(N!)";
            this.rdGiaiThua.UseVisualStyleBackColor = true;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(393, 245);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(133, 34);
            this.btnKetQua.TabIndex = 3;
            this.btnKetQua.Text = "Xem kết quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(288, 329);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(106, 25);
            this.lblKetQua.TabIndex = 4;
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
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.lblSoN);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGiaiThua;
        private System.Windows.Forms.RadioButton rdTinhTong;
        private System.Windows.Forms.Button btnKetQua;
        private System.Windows.Forms.Label lblKetQua;
    }
}