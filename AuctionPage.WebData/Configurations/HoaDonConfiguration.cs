using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaHoaDon);
            builder.Property(p => p.MaHoaDon).HasMaxLength(50);
            builder.Property(p => p.NgayThanhToan).IsRequired()
                .HasColumnType("Date");
            builder.Property(p => p.GiaMua).IsRequired();
            builder.Property(p => p.TrangThai).IsRequired();
        }
    }
}
