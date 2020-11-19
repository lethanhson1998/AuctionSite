using AuctionPage.WebData.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class GiaoDich
    {
        public string MaGiaoDich { get; set; }
        public DateTime ThoiGianGD { get; set; }
        public KieuGiaoDichEnum KieuGiaoDich { get; set; }
        public double SoTien { get; set; }

        public string TenDangNhap { get; set; }
        public virtual  ThanhVien ThanhVien { get; set; }
    }
}
