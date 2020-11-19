using System;
using System.Collections.Generic;
using System.Text;
using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionPage.WebData.Configurations
{
    class NhaCungCapConfiguration : IEntityTypeConfiguration<NhaCungCap>
    {
        public void Configure(EntityTypeBuilder<NhaCungCap> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaNhaCungCap);
            builder.Property(p => p.MaNhaCungCap).HasMaxLength(50);
            builder.Property(p => p.TenNhaCungCap).IsRequired()
                .IsUnicode()
                .HasMaxLength(350);
            builder.Property(p => p.DiaChi).IsRequired()
                .IsUnicode()
                .HasMaxLength(500);
            builder.Property(p => p.SDT).IsRequired()
                .HasMaxLength(12);
            builder.Property(p => p.GhiChu).IsUnicode();
        }
    }
}
