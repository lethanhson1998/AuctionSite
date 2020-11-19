using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class LoaiSanPhamConfiguration : IEntityTypeConfiguration<LoaiSanPham>
    {
        public void Configure(EntityTypeBuilder<LoaiSanPham> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaLoaiSP);
            builder.Property(p => p.MaLoaiSP).HasMaxLength(50);
            builder.Property(p => p.TenLoaiSP).HasMaxLength(250)
                .IsRequired()
                .IsUnicode();
            builder.Property(p => p.TenVietTat).IsRequired();
            builder.Property(p => p.MoTa).IsUnicode();
        }
    }
}
