namespace WindowsFormsApp1
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
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoN = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.rdTongN = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(39, 45);
            this.lblSoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(54, 20);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số a -";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(39, 82);
            this.lblSoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(54, 20);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "Số b -";
            // 
            // lblSoN
            // 
            this.lblSoN.AutoSize = true;
            this.lblSoN.Location = new System.Drawing.Point(39, 121);
            this.lblSoN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoN.Name = "lblSoN";
            this.lblSoN.Size = new System.Drawing.Size(54, 20);
            this.lblSoN.TabIndex = 2;
            this.lblSoN.Text = "Số n -";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(116, 38);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(196, 27);
            this.txtSoA.TabIndex = 3;
            this.txtSoA.Text = "0";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(116, 121);
            this.txtSoN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(196, 27);
            this.txtSoN.TabIndex = 4;
            this.txtSoN.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(116, 82);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(196, 27);
            this.txtSoB.TabIndex = 5;
            this.txtSoB.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongN);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Location = new System.Drawing.Point(59, 189);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(282, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Checked = true;
            this.rdTongAB.Location = new System.Drawing.Point(8, 64);
            this.rdTongAB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(158, 24);
            this.rdTongAB.TabIndex = 7;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng của a,b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            // 
            // rdTongN
            // 
            this.rdTongN.AutoSize = true;
            this.rdTongN.Location = new System.Drawing.Point(8, 125);
            this.rdTongN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdTongN.Name = "rdTongN";
            this.rdTongN.Size = new System.Drawing.Size(178, 24);
            this.rdTongN.TabIndex = 8;
            this.rdTongN.Text = "Tính tổng từ 1 đến n";
            this.rdTongN.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xem kết quả";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(55, 480);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(89, 20);
            this.lblKetQua.TabIndex = 8;
            this.lblKetQua.Text = "Kết quả là:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 480);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = ".";
     
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblSoN);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoN;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongN;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label label1;
    }
}