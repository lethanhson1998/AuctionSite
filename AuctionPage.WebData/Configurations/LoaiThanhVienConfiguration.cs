using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class LoaiThanhVienConfiguration : IEntityTypeConfiguration<LoaiThanhVien>
    {
        public void Configure(EntityTypeBuilder<LoaiThanhVien> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaLoaiThanhVien);
            builder.Property(p => p.MaLoaiThanhVien).HasMaxLength(50);
            builder.Property(p => p.TenLoaiThanhVien).IsRequired()
                .HasMaxLength(50);
        }
    }
}
