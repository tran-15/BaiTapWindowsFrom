namespace BaiTap4WindowsFrom
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
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.lblNgaySX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntNamHetHan = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.dtNgay = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(48, 32);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(88, 16);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã sản phẩm";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(48, 69);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(93, 16);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Location = new System.Drawing.Point(48, 112);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(95, 16);
            this.lblLoaiSP.TabIndex = 2;
            this.lblLoaiSP.Text = "Loại sản phẩm";
            // 
            // lblNgaySX
            // 
            this.lblNgaySX.AutoSize = true;
            this.lblNgaySX.Location = new System.Drawing.Point(48, 147);
            this.lblNgaySX.Name = "lblNgaySX";
            this.lblNgaySX.Size = new System.Drawing.Size(92, 16);
            this.lblNgaySX.TabIndex = 3;
            this.lblNgaySX.Text = "Ngày sản xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // bntNamHetHan
            // 
            this.bntNamHetHan.Location = new System.Drawing.Point(80, 196);
            this.bntNamHetHan.Name = "bntNamHetHan";
            this.bntNamHetHan.Size = new System.Drawing.Size(199, 42);
            this.bntNamHetHan.TabIndex = 5;
            this.bntNamHetHan.Text = "Năm hết hạn";
            this.bntNamHetHan.UseVisualStyleBackColor = true;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(187, 26);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(200, 22);
            this.txtMaSP.TabIndex = 6;
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(187, 112);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(200, 22);
            this.txtLoaiSP.TabIndex = 7;
            // 
            // dtNgay
            // 
            this.dtNgay.Location = new System.Drawing.Point(187, 147);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 22);
            this.dtNgay.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(187, 66);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 22);
            this.txtTenSP.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hiển thị:";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colLoaiSP,
            this.colNgaySX});
            this.dataGridView1.Location = new System.Drawing.Point(228, 319);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(550, 68);
            this.dataGridView1.TabIndex = 11;
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã sản phẩm";
            this.colMaSP.MinimumWidth = 6;
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.Width = 125;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 125;
            // 
            // colLoaiSP
            // 
            this.colLoaiSP.HeaderText = "Loại sản phẩm";
            this.colLoaiSP.MinimumWidth = 6;
            this.colLoaiSP.Name = "colLoaiSP";
            this.colLoaiSP.Width = 125;
            // 
            // colNgaySX
            // 
            this.colNgaySX.HeaderText = "Ngày sản xuất";
            this.colNgaySX.MinimumWidth = 6;
            this.colNgaySX.Name = "colNgaySX";
            this.colNgaySX.Width = 125;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.bntNamHetHan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNgaySX);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblMaSP);
            this.Name = "frmBai1";
            this.Text = "Bài 1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.Label lblNgaySX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntNamHetHan;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox dtNgay;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySX;
    }
}