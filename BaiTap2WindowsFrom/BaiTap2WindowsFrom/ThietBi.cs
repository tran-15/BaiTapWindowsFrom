using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2WindowsFrom
{
    internal class ThietBi
    {
        public string MaThietBi { get; set; }
        public string TenThietBi { get; set; }
        public string NuocSanXuat { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }

        public ThietBi()
        {

        }

        public ThietBi(string maThietBi, string tenThietBi, string nuocSanXuat, double donGia, int soLuong)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            NuocSanXuat = nuocSanXuat;
            DonGia = donGia;
            SoLuong = soLuong;
        }

        public double ThanhTien()
        {
            return DonGia * SoLuong;
        }

        public string HienThi()
        {
            return $"Mã thiết bị: {MaThietBi}\nTên thiết bị: {TenThietBi}\nNước sản xuất: {NuocSanXuat}\n" +
                   $"Đơn giá: {DonGia:C}\nSố lượng: {SoLuong}\nThành tiền: {ThanhTien():C}";
        }
    }
}
