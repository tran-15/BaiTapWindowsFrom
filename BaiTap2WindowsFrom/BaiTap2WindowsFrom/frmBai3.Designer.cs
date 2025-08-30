namespace BaiTap2WindowsFrom
{
    partial class frmBai3
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
            this.lblHo = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btnNoiChuoi = new System.Windows.Forms.Button();
            this.btnGiaiThua = new System.Windows.Forms.Button();
            this.txtTenHT = new System.Windows.Forms.TextBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHo
            // 
            this.lblHo.AutoSize = true;
            this.lblHo.Location = new System.Drawing.Point(73, 50);
            this.lblHo.Name = "lblHo";
            this.lblHo.Size = new System.Drawing.Size(25, 16);
            this.lblHo.TabIndex = 0;
            this.lblHo.Text = "Họ";
            this.lblHo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(135, 50);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(220, 22);
            this.txtHo.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(67, 86);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(31, 16);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(135, 98);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(220, 22);
            this.txtTen.TabIndex = 3;
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(49, 257);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(120, 25);
            this.lblHienThi.TabIndex = 4;
            this.lblHienThi.Text = "Tên hiển thị:";
            // 
            // btnNoiChuoi
            // 
            this.btnNoiChuoi.Location = new System.Drawing.Point(222, 165);
            this.btnNoiChuoi.Name = "btnNoiChuoi";
            this.btnNoiChuoi.Size = new System.Drawing.Size(91, 39);
            this.btnNoiChuoi.TabIndex = 5;
            this.btnNoiChuoi.Text = "Nối chuỗi";
            this.btnNoiChuoi.UseVisualStyleBackColor = true;
            // 
            // btnGiaiThua
            // 
            this.btnGiaiThua.Location = new System.Drawing.Point(474, 165);
            this.btnGiaiThua.Name = "btnGiaiThua";
            this.btnGiaiThua.Size = new System.Drawing.Size(91, 39);
            this.btnGiaiThua.TabIndex = 6;
            this.btnGiaiThua.Text = "Giai Thừa";
            this.btnGiaiThua.UseVisualStyleBackColor = true;
            // 
            // txtTenHT
            // 
            this.txtTenHT.Location = new System.Drawing.Point(195, 261);
            this.txtTenHT.Name = "txtTenHT";
            this.txtTenHT.Size = new System.Drawing.Size(220, 22);
            this.txtTenHT.TabIndex = 7;
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(195, 319);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(220, 22);
            this.txtSo.TabIndex = 8;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(49, 315);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(86, 25);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.txtTenHT);
            this.Controls.Add(this.btnGiaiThua);
            this.Controls.Add(this.btnNoiChuoi);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.lblHo);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHo;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnNoiChuoi;
        private System.Windows.Forms.Button btnGiaiThua;
        private System.Windows.Forms.TextBox txtTenHT;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label lblKetQua;
    }
}