using System;
using System.Collections.Generic;
using System.Text;
using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionPage.WebData.Configurations
{
    class HoaDonNhapConfiguration : IEntityTypeConfiguration<HoaDonNhap>
    {
        public void Configure(EntityTypeBuilder<HoaDonNhap> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaHoaDonNhap);
            builder.Property(k => k.MaHoaDonNhap).HasMaxLength(50);
            builder.Property(k => k.NgayLap).IsRequired()
                .HasColumnType("Date");
            builder.Property(k => k.TongTien).IsRequired();
        }
    }
}
