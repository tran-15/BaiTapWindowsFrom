using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3WindowsFrom
{
    internal class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public float HeSoLuong { get; set; }
        public float HeSoPhuCap { get; set; }

        public NhanVien() { }

        public NhanVien(string maNV, string hoten, DateTime ngaySinh, float heSoLuong, float heSoPhuCap)
        {
            MaNV = maNV;
            HoTen = hoten;
            NgaySinh = ngaySinh;
            HeSoLuong = heSoLuong;
            HeSoPhuCap = heSoPhuCap;
        }

        public double TongLuong()
        {
            return (HeSoLuong + HeSoPhuCap) * 1150000;
        }

        public string HienThi()
        {
            return $"Mã nhân viên: {MaNV}\nHọ tên: {HoTen}\nNgày sinh: {NgaySinh.ToShortDateString()}\n" +
                   $"Hệ số lương: {HeSoLuong}\nHệ số phụ cấp: {HeSoPhuCap}\nTổng lương: {TongLuong():0,0} VND";
        }

    }
}
    

