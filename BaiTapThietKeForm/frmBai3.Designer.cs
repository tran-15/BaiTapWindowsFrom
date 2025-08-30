namespace BaiTapThietKeForm
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
            this.lblTuMoi = new System.Windows.Forms.Label();
            this.lblNghia = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.bntThemTuMoi = new System.Windows.Forms.Button();
            this.lblDSTuMoi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNghia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTuMoi
            // 
            this.lblTuMoi.AutoSize = true;
            this.lblTuMoi.Location = new System.Drawing.Point(45, 30);
            this.lblTuMoi.Name = "lblTuMoi";
            this.lblTuMoi.Size = new System.Drawing.Size(48, 16);
            this.lblTuMoi.TabIndex = 0;
            this.lblTuMoi.Text = "Từ mới";
            // 
            // lblNghia
            // 
            this.lblNghia.AutoSize = true;
            this.lblNghia.Location = new System.Drawing.Point(45, 86);
            this.lblNghia.Name = "lblNghia";
            this.lblNghia.Size = new System.Drawing.Size(83, 16);
            this.lblNghia.TabIndex = 1;
            this.lblNghia.Text = "Nghĩa của từ";
            
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuMoi.Location = new System.Drawing.Point(170, 30);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(264, 27);
            this.txtTuMoi.TabIndex = 2;
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(170, 80);
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(264, 27);
            this.txtNghiaCuaTu.TabIndex = 3;
            // 
            // bntThemTuMoi
            // 
            this.bntThemTuMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntThemTuMoi.Location = new System.Drawing.Point(238, 134);
            this.bntThemTuMoi.Name = "bntThemTuMoi";
            this.bntThemTuMoi.Size = new System.Drawing.Size(120, 28);
            this.bntThemTuMoi.TabIndex = 4;
            this.bntThemTuMoi.Text = "Thêm từ mới";
            this.bntThemTuMoi.UseVisualStyleBackColor = true;
            // 
            // lblDSTuMoi
            // 
            this.lblDSTuMoi.AutoSize = true;
            this.lblDSTuMoi.Location = new System.Drawing.Point(56, 184);
            this.lblDSTuMoi.Name = "lblDSTuMoi";
            this.lblDSTuMoi.Size = new System.Drawing.Size(135, 16);
            this.lblDSTuMoi.TabIndex = 5;
            this.lblDSTuMoi.Text = "DANH SÁCH TỪ MỚI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "NGHĨA CỦA TỪ";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(59, 215);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(275, 212);
            this.listBox1.TabIndex = 7;
            // 
            // txtNghia
            // 
            this.txtNghia.Location = new System.Drawing.Point(479, 215);
            this.txtNghia.Multiline = true;
            this.txtNghia.Name = "txtNghia";
            this.txtNghia.Size = new System.Drawing.Size(267, 212);
            this.txtNghia.TabIndex = 8;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNghia);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDSTuMoi);
            this.Controls.Add(this.bntThemTuMoi);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lblNghia);
            this.Controls.Add(this.lblTuMoi);
            this.Name = "frmBai3";
            this.Text = "frmBai3";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuMoi;
        private System.Windows.Forms.Label lblNghia;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
        private System.Windows.Forms.Button bntThemTuMoi;
        private System.Windows.Forms.Label lblDSTuMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtNghia;
    }
}