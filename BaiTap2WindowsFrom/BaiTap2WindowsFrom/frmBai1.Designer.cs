namespace BaiTap2WindowsFrom
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
            this.lblThietBi = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtThietBi = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnSoTien = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblNuoc = new System.Windows.Forms.Label();
            this.txtNuoc = new System.Windows.Forms.TextBox();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.dgvHienThi = new System.Windows.Forms.DataGridView();
            this.colMaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNuocSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThietBi
            // 
            this.lblThietBi.AutoSize = true;
            this.lblThietBi.Location = new System.Drawing.Point(17, 61);
            this.lblThietBi.Name = "lblThietBi";
            this.lblThietBi.Size = new System.Drawing.Size(72, 16);
            this.lblThietBi.TabIndex = 0;
            this.lblThietBi.Text = "Tên thiết bị";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(22, 167);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(53, 16);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Đơn giá";
            // 
            // txtThietBi
            // 
            this.txtThietBi.Location = new System.Drawing.Point(119, 55);
            this.txtThietBi.Name = "txtThietBi";
            this.txtThietBi.Size = new System.Drawing.Size(381, 22);
            this.txtThietBi.TabIndex = 2;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(119, 167);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(310, 22);
            this.txtGia.TabIndex = 3;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(22, 211);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 4;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(119, 211);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(226, 22);
            this.txtSoLuong.TabIndex = 5;
            // 
            // btnSoTien
            // 
            this.btnSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoTien.Location = new System.Drawing.Point(234, 263);
            this.btnSoTien.Name = "btnSoTien";
            this.btnSoTien.Size = new System.Drawing.Size(143, 36);
            this.btnSoTien.TabIndex = 6;
            this.btnSoTien.Text = "Tính tiền";
            this.btnSoTien.UseVisualStyleBackColor = true;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(22, 22);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(67, 16);
            this.lblMa.TabIndex = 9;
            this.lblMa.Text = "Mã thiết bị";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(119, 16);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(269, 22);
            this.txtMa.TabIndex = 10;
            // 
            // lblNuoc
            // 
            this.lblNuoc.AutoSize = true;
            this.lblNuoc.Location = new System.Drawing.Point(12, 118);
            this.lblNuoc.Name = "lblNuoc";
            this.lblNuoc.Size = new System.Drawing.Size(91, 16);
            this.lblNuoc.TabIndex = 11;
            this.lblNuoc.Text = "Nước sản xuất";
            // 
            // txtNuoc
            // 
            this.txtNuoc.Location = new System.Drawing.Point(119, 112);
            this.txtNuoc.Name = "txtNuoc";
            this.txtNuoc.Size = new System.Drawing.Size(310, 22);
            this.txtNuoc.TabIndex = 12;
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Location = new System.Drawing.Point(20, 374);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(83, 25);
            this.lblThanhTien.TabIndex = 13;
            this.lblThanhTien.Text = "Hiển thị:";
            // 
            // dgvHienThi
            // 
            this.dgvHienThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHienThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHienThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTB,
            this.colTenTB,
            this.colNuocSX,
            this.colDonGia,
            this.colSoLuong});
            this.dgvHienThi.Location = new System.Drawing.Point(164, 353);
            this.dgvHienThi.Name = "dgvHienThi";
            this.dgvHienThi.ReadOnly = true;
            this.dgvHienThi.RowHeadersWidth = 51;
            this.dgvHienThi.RowTemplate.Height = 24;
            this.dgvHienThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHienThi.Size = new System.Drawing.Size(574, 65);
            this.dgvHienThi.TabIndex = 14;
            // 
            // colMaTB
            // 
            this.colMaTB.HeaderText = "Mã thiết bị";
            this.colMaTB.MinimumWidth = 6;
            this.colMaTB.Name = "colMaTB";
            this.colMaTB.ReadOnly = true;
            // 
            // colTenTB
            // 
            this.colTenTB.HeaderText = "Tên thiết bị";
            this.colTenTB.MinimumWidth = 6;
            this.colTenTB.Name = "colTenTB";
            this.colTenTB.ReadOnly = true;
            // 
            // colNuocSX
            // 
            this.colNuocSX.HeaderText = "Nước sản xuất";
            this.colNuocSX.MinimumWidth = 6;
            this.colNuocSX.Name = "colNuocSX";
            this.colNuocSX.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHienThi);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.txtNuoc);
            this.Controls.Add(this.lblNuoc);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.btnSoTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtThietBi);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblThietBi);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHienThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThietBi;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtThietBi;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnSoTien;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblNuoc;
        private System.Windows.Forms.TextBox txtNuoc;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.DataGridView dgvHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNuocSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
    }
}