namespace BaiTapThietKeForm
{
    partial class frmBai4
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
            this.lblSoCanTim = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.bntTimSo = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(46, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 276);
            this.listBox1.TabIndex = 0;
    
            // 
            // lblSoCanTim
            // 
            this.lblSoCanTim.AutoSize = true;
            this.lblSoCanTim.Location = new System.Drawing.Point(390, 108);
            this.lblSoCanTim.Name = "lblSoCanTim";
            this.lblSoCanTim.Size = new System.Drawing.Size(106, 16);
            this.lblSoCanTim.TabIndex = 1;
            this.lblSoCanTim.Text = "Nhập số cần tìm:";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(512, 102);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(159, 22);
            this.txtSo.TabIndex = 2;
            // 
            // bntTimSo
            // 
            this.bntTimSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntTimSo.Location = new System.Drawing.Point(550, 149);
            this.bntTimSo.Name = "bntTimSo";
            this.bntTimSo.Size = new System.Drawing.Size(84, 30);
            this.bntTimSo.TabIndex = 3;
            this.bntTimSo.Text = "Tìm số";
            this.bntTimSo.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblKetQua.Location = new System.Drawing.Point(390, 221);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(86, 25);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết quả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(545, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.bntTimSo);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblSoCanTim);
            this.Controls.Add(this.listBox1);
            this.Name = "frmBai4";
            this.Text = "frmBai4";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblSoCanTim;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button bntTimSo;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
    }
}