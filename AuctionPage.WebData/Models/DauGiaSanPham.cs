using AuctionPage.WebData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class DauGiaSanPham
    {
        public string MaDauGiaSP { get; set; }
        public string TieuDe { get; set; }
        public double GiaKhoiDiem { get; set; }
        public double GiaHienTai { get; set; }
        public double GiaBanNgay { get; set; }
        public TrangThaiDauGiaSPEnum TrangThai { get; set; }

        public string MaSanPham { get; set; }
        public string MaPhienDau { get; set; }
        public virtual PhienDau PhienDau { get; set; }
        public virtual SanPham SanPham { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ICollection<LichSuDau> LichSuDaus { get; set; }
    }
}
