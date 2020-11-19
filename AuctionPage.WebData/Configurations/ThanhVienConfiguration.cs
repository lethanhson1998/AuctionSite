using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class ThanhVienConfiguration : IEntityTypeConfiguration<ThanhVien>
    {
        public void Configure(EntityTypeBuilder<ThanhVien> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.TenDangNhap);
            builder.Property(p => p.TenDangNhap).HasMaxLength(50);
            builder.Property(p => p.AnhDaiDien).HasMaxLength(300);
            builder.Property(p => p.MatKhau).HasMaxLength(300)
                .IsRequired();
            builder.Property(p => p.Email).HasMaxLength(300)
                .IsRequired();
            builder.Property(p => p.TenDayDu).HasMaxLength(50)
                .IsUnicode();
            builder.Property(p => p.SoCMT).HasMaxLength(15);
            builder.Property(p => p.NgaySinh).HasColumnType("Date");
            builder.Property(p => p.SoDienThoai).HasMaxLength(12);
            builder.Property(p => p.DiaChi).HasMaxLength(300)
                .IsUnicode();
            builder.Property(p => p.SoDuTaiKhoan).IsRequired();
            builder.Property(p => p.TrangThai).IsRequired()
                .HasMaxLength(30);
        }
    }
}
