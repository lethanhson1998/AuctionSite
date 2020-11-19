using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class LoaiSanPham
    {
        public string MaLoaiSP { get; set; }
        public string TenLoaiSP { get; set; }
        public string MoTa { get; set; }
        public string TenVietTat { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
