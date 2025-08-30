namespace BaiTap4WindowsFrom
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
            this.lblLT = new System.Windows.Forms.Label();
            this.txtLyThuyet = new System.Windows.Forms.TextBox();
            this.btnXepLoai = new System.Windows.Forms.Button();
            this.lblTH = new System.Windows.Forms.Label();
            this.txtTH = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLT
            // 
            this.lblLT.AutoSize = true;
            this.lblLT.Location = new System.Drawing.Point(205, 21);
            this.lblLT.Name = "lblLT";
            this.lblLT.Size = new System.Drawing.Size(130, 16);
            this.lblLT.TabIndex = 0;
            this.lblLT.Text = "Nhập điểm lý thuyết :";
            // 
            // txtLyThuyet
            // 
            this.txtLyThuyet.Location = new System.Drawing.Point(372, 12);
            this.txtLyThuyet.Name = "txtLyThuyet";
            this.txtLyThuyet.Size = new System.Drawing.Size(180, 22);
            this.txtLyThuyet.TabIndex = 1;
            this.txtLyThuyet.Text = "5";
            // 
            // btnXepLoai
            // 
            this.btnXepLoai.Location = new System.Drawing.Point(425, 129);
            this.btnXepLoai.Name = "btnXepLoai";
            this.btnXepLoai.Size = new System.Drawing.Size(104, 46);
            this.btnXepLoai.TabIndex = 2;
            this.btnXepLoai.Text = "Xếp loại";
            this.btnXepLoai.UseVisualStyleBackColor = true;
            // 
            // lblTH
            // 
            this.lblTH.AutoSize = true;
            this.lblTH.Location = new System.Drawing.Point(205, 67);
            this.lblTH.Name = "lblTH";
            this.lblTH.Size = new System.Drawing.Size(135, 16);
            this.lblTH.TabIndex = 3;
            this.lblTH.Text = "Nhập điểm thực hành:";
            // 
            // txtTH
            // 
            this.txtTH.Location = new System.Drawing.Point(372, 64);
            this.txtTH.Name = "txtTH";
            this.txtTH.Size = new System.Drawing.Size(180, 22);
            this.txtTH.TabIndex = 4;
            this.txtTH.Text = "7";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(214, 254);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(106, 25);
            this.lblKetQua.TabIndex = 5;
            this.lblKetQua.Text = "Kết quả là:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(367, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "...";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtTH);
            this.Controls.Add(this.lblTH);
            this.Controls.Add(this.btnXepLoai);
            this.Controls.Add(this.txtLyThuyet);
            this.Controls.Add(this.lblLT);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLT;
        private System.Windows.Forms.TextBox txtLyThuyet;
        private System.Windows.Forms.Button btnXepLoai;
        private System.Windows.Forms.Label lblTH;
        private System.Windows.Forms.TextBox txtTH;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
    }
}