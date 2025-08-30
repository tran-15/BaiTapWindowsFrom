using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap2WindowsFrom
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            dgvHienThi.Columns.Add("MaThietBi", "Mã thiết bị");
            dgvHienThi.Columns.Add("TenThietBi", "Tên thiết bị");
            dgvHienThi.Columns.Add("NuocSanXuat", "Nước sản xuất");
            dgvHienThi.Columns.Add("DonGia", "Đơn giá");
            dgvHienThi.Columns.Add("SoLuong", "Số lượng");
            dgvHienThi.Columns.Add("ThanhTien", "Thành tiền");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maThietBi = txtMa.Text;
            string tenThietBi = txtThietBi.Text;
            string nuocSanXuat = txtNuoc.Text;
            double donGia = double.Parse(txtGia.Text);
            int soLuong = int.Parse(txtSoLuong.Text);

            ThietBi thietBi = new ThietBi(maThietBi, tenThietBi, nuocSanXuat, donGia, soLuong);


            dgvHienThi.Rows.Add(thietBi.MaThietBi, thietBi.TenThietBi, thietBi.NuocSanXuat, thietBi.DonGia,
                                thietBi.SoLuong, thietBi.ThanhTien());

            string thongTin = thietBi.HienThi();
            MessageBox.Show(thongTin, "Thông tin thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
