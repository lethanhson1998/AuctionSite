using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseProvider.Models
{
    public class LoaiThanhVien_Quyen
    {
        public string MaQuyen { get; set; }
        public string MaLoaiThanhVien { get; set; }

        public virtual Quyen Quyen { get; set; }
        public virtual LoaiThanhVien LoaiThanhVien { get; set; }
    }
}
