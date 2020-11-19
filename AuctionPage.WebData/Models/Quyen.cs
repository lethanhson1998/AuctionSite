using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class Quyen
    {
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public string GhiChu { get; set; }

        public virtual ICollection<LoaiThanhVien_Quyen> LoaiThanhVien_Quyens { get; set; }
    }
}
