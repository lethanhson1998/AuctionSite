using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Configurations
{
    class DanhGiaConfiguration : IEntityTypeConfiguration<DanhGia>
    {
        public void Configure(EntityTypeBuilder<DanhGia> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(k => new { k.MaSanPham, k.TenDangNhap });
            builder.Property(p => p.Diem).IsRequired();
        }
    }
}
