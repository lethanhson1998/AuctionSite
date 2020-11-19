using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class SanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string TinhTrang { get; set; }
        public string MoTa { get; set; }
        public string GhiChu { get; set; }
        public int TonKho { get; set; }
        public string TenVietTat { get; set; }
        public string AnhDaiDien { get; set; }
        public string AnhChiTiet1 { get; set; }
        public string AnhChiTiet2 { get; set; }
        public string AnhChiTiet3 { get; set; }

        public string MaLoaiSanPham { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual ICollection <ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
        public virtual ICollection<DauGiaSanPham> DauGiaSanPhams { get; set; }
        public virtual ICollection<DanhGia> DanhGias { get; set; }
    }
}
