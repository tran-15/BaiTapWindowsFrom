namespace BaiTap3WindowsFrom
{
    partial class frmBai1
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
            this.lblMa = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblPhuCap = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtNgaySInh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtPhuCap = new System.Windows.Forms.TextBox();
            this.btnTongLuong = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHSLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHSPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHienThi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(55, 42);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(86, 16);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã nhân viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(55, 77);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(46, 16);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(55, 111);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(67, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
           

            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(55, 149);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(79, 16);
            this.lblLuong.TabIndex = 3;
            this.lblLuong.Text = "Hệ số lương";
            // 
            // lblPhuCap
            // 
            this.lblPhuCap.AutoSize = true;
            this.lblPhuCap.Location = new System.Drawing.Point(55, 189);
            this.lblPhuCap.Name = "lblPhuCap";
            this.lblPhuCap.Size = new System.Drawing.Size(94, 16);
            this.lblPhuCap.TabIndex = 4;
            this.lblPhuCap.Text = "Hệ số phụ cấp";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(213, 42);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(230, 22);
            this.txtMa.TabIndex = 6;
            // 
            // txtNgaySInh
            // 
            this.txtNgaySInh.Location = new System.Drawing.Point(213, 111);
            this.txtNgaySInh.Name = "txtNgaySInh";
            this.txtNgaySInh.Size = new System.Drawing.Size(230, 22);
            this.txtNgaySInh.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(213, 77);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(230, 22);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(213, 149);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(230, 22);
            this.txtLuong.TabIndex = 9;
            // 
            // txtPhuCap
            // 
            this.txtPhuCap.Location = new System.Drawing.Point(213, 189);
            this.txtPhuCap.Name = "txtPhuCap";
            this.txtPhuCap.Size = new System.Drawing.Size(230, 22);
            this.txtPhuCap.TabIndex = 10;
            // 
            // btnTongLuong
            // 
            this.btnTongLuong.Location = new System.Drawing.Point(151, 258);
            this.btnTongLuong.Name = "btnTongLuong";
            this.btnTongLuong.Size = new System.Drawing.Size(103, 31);
            this.btnTongLuong.TabIndex = 12;
            this.btnTongLuong.Text = "Tổng lương";
            this.btnTongLuong.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaN,
            this.colHoTen,
            this.colNgaySinh,
            this.colHSLuong,
            this.colHSPhuCap});
            this.dataGridView1.Location = new System.Drawing.Point(271, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 50);
            this.dataGridView1.TabIndex = 14;
            // 
            // colMaN
            // 
            this.colMaN.HeaderText = "Mã nhân viên";
            this.colMaN.MinimumWidth = 6;
            this.colMaN.Name = "colMaN";
            this.colMaN.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 125;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 125;
            // 
            // colHSLuong
            // 
            this.colHSLuong.HeaderText = "Hệ số lương";
            this.colHSLuong.MinimumWidth = 6;
            this.colHSLuong.Name = "colHSLuong";
            this.colHSLuong.Width = 125;
            // 
            // colHSPhuCap
            // 
            this.colHSPhuCap.HeaderText = "Hệ số phụ cấp";
            this.colHSPhuCap.MinimumWidth = 6;
            this.colHSPhuCap.Name = "colHSPhuCap";
            this.colHSPhuCap.Width = 125;
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(53, 391);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(77, 25);
            this.lblHienThi.TabIndex = 15;
            this.lblHienThi.Text = "Hiển thị";
          
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 486);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTongLuong);
            this.Controls.Add(this.txtPhuCap);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtNgaySInh);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblPhuCap);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblMa);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
     
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblPhuCap;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtNgaySInh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtPhuCap;
        private System.Windows.Forms.Button btnTongLuong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHSLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHSPhuCap;
        private System.Windows.Forms.Label lblHienThi;
    }
}