using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaSanPham);
            builder.Property(p => p.MaSanPham).HasMaxLength(50);
            builder.Property(p => p.TenSanPham).IsRequired()
                .HasMaxLength(300)
                .IsUnicode();
            builder.Property(p => p.TinhTrang).IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.MoTa).IsUnicode();
            builder.Property(p => p.AnhDaiDien).IsRequired()
                .HasMaxLength(500);
            builder.Property(p => p.TonKho).IsRequired();
            builder.Property(p => p.TenVietTat).IsRequired();
        }
    }
}
