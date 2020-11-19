using AuctionPage.WebData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public double GiaMua { get; set; }
        public TrangThaiHoaDonEnum TrangThai { get; set; }



        public string TenDangNhap { get; set; }
        public virtual DauGiaSanPham DauGiaSanPham { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
