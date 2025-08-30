using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap4WindowsFrom
{
    internal class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPham { get; set; }
        public DateTime NgaySanXuat { get; set; }

        public SanPham() { }

        public void SetSanPham(string maSanPham, string tenSanPham, string loaiSanPham, DateTime ngaySanXuat)
        {
            MaSanPham = maSanPham;
            TenSanPham = tenSanPham;
            LoaiSanPham = loaiSanPham;
            NgaySanXuat = ngaySanXuat;
        }

        public int NamHetHan()
        {
            return NgaySanXuat.AddYears(3).Year;
        }

        public string HienThi()
        {
            return $"Mã sản phẩm: {MaSanPham}\nTên sản phẩm: {TenSanPham}\nLoại sản phẩm: {LoaiSanPham}\nNgày sản xuất: {NgaySanXuat.ToShortDateString()}\nNăm hết hạn: {NamHetHan()}";
        }
    }
}
    

