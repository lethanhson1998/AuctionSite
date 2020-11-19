using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class GiaoDichConfiguration : IEntityTypeConfiguration<GiaoDich>
    {
        public void Configure(EntityTypeBuilder<GiaoDich> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaGiaoDich);
            builder.Property(p => p.MaGiaoDich).HasMaxLength(50);
            builder.Property(p => p.ThoiGianGD).IsRequired();
            builder.Property(p => p.KieuGiaoDich).IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.SoTien).IsRequired();
        }
    }
}
