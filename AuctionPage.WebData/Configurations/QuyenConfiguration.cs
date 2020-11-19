using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class QuyenConfiguration : IEntityTypeConfiguration<Quyen>
    {
        public void Configure(EntityTypeBuilder<Quyen> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => k.MaQuyen);
            builder.Property(p => p.MaQuyen).HasMaxLength(50);
            builder.Property(p => p.TenQuyen).IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.GhiChu).HasMaxLength(500)
                .IsUnicode();
        }
    }
}
