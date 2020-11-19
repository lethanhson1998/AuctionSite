using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class PhienDau
    {
        public string MaPhienDau { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<DauGiaSanPham> DauGiaSanPhams { get; set; }
    }
}
