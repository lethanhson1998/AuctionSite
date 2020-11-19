using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class PhienDauConfiguration : IEntityTypeConfiguration<PhienDau>
    {
        public void Configure(EntityTypeBuilder<PhienDau> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaPhienDau);
            builder.Property(p => p.MaPhienDau).HasMaxLength(50);
            builder.Property(p => p.ThoiGianBatDau).IsRequired()
                .HasColumnType("Date");
            builder.Property(p => p.ThoiGianKetThuc).IsRequired()
                .HasColumnType("Date");
            builder.Property(p => p.GhiChu).IsUnicode();
        }
    }
}
