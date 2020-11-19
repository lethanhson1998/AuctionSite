using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class LoaiThanhVien_QuyenConfiguration : IEntityTypeConfiguration<LoaiThanhVien_Quyen>
    {
        public void Configure(EntityTypeBuilder<LoaiThanhVien_Quyen> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => new { k.MaLoaiThanhVien, k.MaQuyen });
        }
    }
}
