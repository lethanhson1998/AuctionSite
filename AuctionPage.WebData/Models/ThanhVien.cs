using AuctionPage.WebData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class ThanhVien
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string AnhDaiDien { get; set; }
        public string Email { get; set; }
        public string TenDayDu { get; set; }
        public string SoCMT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public double SoDuTaiKhoan { get; set; }
        public string ActivateCode { get; set; }
        public string ResetPassCode { get; set; }
        public TrangThaiTaiKhoanEnum TrangThai { get; set; }

        public string MaLoaiThanhVien { get; set; }
        public virtual LoaiThanhVien LoaiThanhVien { get; set; }
        public virtual ICollection<DanhGia> DanhGias { get; set; }
        public virtual ICollection<LichSuDau> LichSuDaus { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }
    }
}
