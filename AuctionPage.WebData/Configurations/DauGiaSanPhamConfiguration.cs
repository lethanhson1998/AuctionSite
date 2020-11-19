using System;
using System.Collections.Generic;
using System.Text;
using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AuctionPage.WebData.Configurations
{
    class DauGiaSanPhamConfiguration : IEntityTypeConfiguration<DauGiaSanPham>
    {
        public void Configure(EntityTypeBuilder<DauGiaSanPham> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaDauGiaSP);
            builder.Property(p => p.MaDauGiaSP).HasMaxLength(50);
            builder.Property(p => p.TieuDe).IsRequired()
                .HasMaxLength(300)
                .IsUnicode();
            builder.Property(p => p.GiaKhoiDiem).IsRequired();
            builder.Property(p => p.GiaHienTai).IsRequired();
            builder.Property(p => p.GiaBanNgay).IsRequired();
            builder.Property(p => p.TrangThai).IsRequired();
        }
    }
}
