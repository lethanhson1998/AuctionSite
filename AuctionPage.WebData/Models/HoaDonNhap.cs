using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class HoaDonNhap
    {
        public string MaHoaDonNhap { get; set; }
        public DateTime NgayLap { get; set; }
        public double TongTien { get; set; }

        public string MaNhaCungCap { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual ICollection<ChiTietHoaDonNhap> ChiTietHoaDonNhaps { get; set; }
    }
}
