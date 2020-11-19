using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class DanhGia
    {
        public string MaSanPham { get; set; }
        public string TenDangNhap { get; set; }
        public int Diem { get; set; }
        public string BinhLuan { get; set; }

        public virtual SanPham SanPham { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
