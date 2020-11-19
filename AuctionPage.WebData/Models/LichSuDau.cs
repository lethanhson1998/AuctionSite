using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class LichSuDau
    {
        public string MaLichSuDau { get; set; }
        public string TenDangNhap { get; set; }
        public string MaDauGiaSP { get; set; }
        public double GiaThoaThuan { get; set; }
        public DateTime ThoiGanDau { get; set; }

        public virtual DauGiaSanPham DauGiaSanPham { get; set; }
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
