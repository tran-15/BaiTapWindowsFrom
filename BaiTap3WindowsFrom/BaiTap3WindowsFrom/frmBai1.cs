using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3WindowsFrom
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            public partial class frmBai1 : Form
        {
            public NhanVien nhanVien;
            public frmBai1()
            {
                InitializeComponent();

                dgvHienThi.Columns.Add("MaNV", "Mã Nhân Viên");
                dgvHienThi.Columns.Add("HoTen", "Họ Tên");
                dgvHienThi.Columns.Add("NgaySinh", "Ngày Sinh");
                dgvHienThi.Columns.Add("HeSoLuong", "Hệ Số Lương");
                dgvHienThi.Columns.Add("HeSoPhuCap", "Hệ Số Phụ Cấp");
                dgvHienThi.Columns.Add("TongLuong", "Tổng Lương");
            }

            private void frmBai1_Load(object sender, EventArgs e)
            {


            }

            private void btnThem_Click(object sender, EventArgs e)
            {
                string maNV = txtMa.Text;
                string hoTen = txtHoTen.Text;
                DateTime ngaySinh = dtpNgaySinh.Value;
                float hesoluong = float.Parse(txtLuong.Text);
                float phucap = float.Parse(txtPhuCap.Text);

                nhanVien = new NhanVien(maNV, hoTen, ngaySinh, hesoluong, phucap);

                // Thêm dòng mới vào DataGridView dgvHienThi
                dgvHienThi.Rows.Add(nhanVien.MaNV, nhanVien.HoTen, nhanVien.NgaySinh.ToShortDateString(),
                                    nhanVien.HeSoLuong, nhanVien.HeSoPhuCap, nhanVien.TongLuong().ToString("0,0"));

                // Hiển thị thông tin nhân viên trong MessageBox
                string thongTin = nhanVien.HienThi();
                MessageBox.Show(thongTin, "Thông tin nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void txtPhuCap_TextChanged(object sender, EventArgs e)
            {

            }


        }  
    }
}







