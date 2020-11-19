using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class LoaiThanhVien
    {
        public string MaLoaiThanhVien { get; set; }
        public string TenLoaiThanhVien { get; set; }

        public virtual ICollection<LoaiThanhVien_Quyen> LoaiThanhVien_Quyens { get; set; }
        public virtual ICollection<ThanhVien> ThanhViens { get; set; }
    }
}
