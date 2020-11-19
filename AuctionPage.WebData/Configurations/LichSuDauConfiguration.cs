using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class LichSuDauConfiguration : IEntityTypeConfiguration<LichSuDau>
    {
        public void Configure(EntityTypeBuilder<LichSuDau> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaLichSuDau);
            builder.Property(p => p.MaLichSuDau).HasMaxLength(50);
            builder.Property(p => p.GiaThoaThuan).IsRequired();
            builder.Property(p => p.ThoiGanDau).IsRequired();
        }
    }
}
