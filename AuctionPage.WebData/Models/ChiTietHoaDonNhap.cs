using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class ChiTietHoaDonNhap
    {
        public string MaSanPham { get; set; }
        public string MaHoaDonNhap { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public double ThanhTien { get; set; }

        public virtual HoaDonNhap HoaDonNhap { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
