using System;
using System.Collections.Generic;
using System.Text;
using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionPage.WebData.Configurations
{
    class ChiTietHoaDonNhapConfiguration : IEntityTypeConfiguration<ChiTietHoaDonNhap>
    {
        public void Configure(EntityTypeBuilder<ChiTietHoaDonNhap> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => new { k.MaSanPham, k.MaHoaDonNhap });
            builder.Property(p => p.SoLuong).IsRequired();
            builder.Property(p => p.DonGia).IsRequired();
            builder.Property(p => p.NgaySanXuat).HasColumnType("Date");
            builder.Property(p => p.ThanhTien).IsRequired();
        }
    }
}
