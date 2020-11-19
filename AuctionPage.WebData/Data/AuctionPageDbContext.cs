using AuctionPage.WebData.Configurations;
using DatabaseProvider.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuctionPage.WebData.Data
{
    public class AuctionPageDbContext : DbContext
    {
        public AuctionPageDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PhienDauConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new NhaCungCapConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonNhapConfiguration());
            modelBuilder.ApplyConfiguration(new ChiTietHoaDonNhapConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new DauGiaSanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            modelBuilder.ApplyConfiguration(new LichSuDauConfiguration());
            modelBuilder.ApplyConfiguration(new DanhGiaConfiguration());
            modelBuilder.ApplyConfiguration(new QuyenConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiThanhVien_QuyenConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiThanhVienConfiguration());
            modelBuilder.ApplyConfiguration(new ThanhVienConfiguration());
            modelBuilder.ApplyConfiguration(new GiaoDichConfiguration());

            modelBuilder.Entity<PhienDau>()
                .HasMany(p => p.DauGiaSanPhams)
                .WithOne(p => p.PhienDau)
                .HasForeignKey(p => p.MaPhienDau)
                .IsRequired();

            modelBuilder.Entity<LoaiSanPham>()
                .HasMany(p => p.SanPhams)
                .WithOne(p => p.LoaiSanPham)
                .HasForeignKey(p => p.MaLoaiSanPham)
                .IsRequired();

            modelBuilder.Entity<NhaCungCap>()
                .HasMany(p => p.HoaDonNhaps)
                .WithOne(p => p.NhaCungCap)
                .HasForeignKey(p => p.MaNhaCungCap)
                .IsRequired();

            modelBuilder.Entity<ChiTietHoaDonNhap>()
                .HasOne(p => p.HoaDonNhap)
                .WithMany(p => p.ChiTietHoaDonNhaps)
                .HasForeignKey(p => p.MaHoaDonNhap).IsRequired();
            modelBuilder.Entity<ChiTietHoaDonNhap>()
                .HasOne(p => p.SanPham)
                .WithMany(p => p.ChiTietHoaDonNhaps)
                .HasForeignKey(p => p.MaSanPham).IsRequired();

            modelBuilder.Entity<DauGiaSanPham>()
                .HasOne(p => p.SanPham)
                .WithMany(p => p.DauGiaSanPhams)
                .HasForeignKey(p => p.MaSanPham).IsRequired();

            modelBuilder.Entity<DauGiaSanPham>()
                .HasOne(p => p.HoaDon)
                .WithOne(p => p.DauGiaSanPham)
                .HasForeignKey<DauGiaSanPham>(p => p.MaDauGiaSP).IsRequired();

            modelBuilder.Entity<LichSuDau>()
                .HasOne(p => p.DauGiaSanPham)
                .WithMany(p => p.LichSuDaus)
                .HasForeignKey(p => p.MaDauGiaSP)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<LichSuDau>()
                .HasOne(p => p.ThanhVien)
                .WithMany(p => p.LichSuDaus)
                .HasForeignKey(p => p.TenDangNhap)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DanhGia>()
                .HasOne(p => p.SanPham)
                .WithMany(p => p.DanhGias)
                .HasForeignKey(p => p.MaSanPham).IsRequired();
            modelBuilder.Entity<DanhGia>()
                .HasOne(p => p.ThanhVien)
                .WithMany(p => p.DanhGias)
                .HasForeignKey(p => p.TenDangNhap).IsRequired();

            modelBuilder.Entity<LoaiThanhVien_Quyen>()
                .HasOne(p => p.Quyen)
                .WithMany(p => p.LoaiThanhVien_Quyens)
                .HasForeignKey(p => p.MaQuyen).IsRequired();
            modelBuilder.Entity<LoaiThanhVien_Quyen>()
                .HasOne(p => p.LoaiThanhVien)
                .WithMany(p => p.LoaiThanhVien_Quyens)
                .HasForeignKey(p => p.MaLoaiThanhVien).IsRequired();

            modelBuilder.Entity<LoaiThanhVien>()
                .HasMany(p => p.ThanhViens)
                .WithOne(p => p.LoaiThanhVien)
                .HasForeignKey(p => p.MaLoaiThanhVien)
                .IsRequired();

            modelBuilder.Entity<ThanhVien>()
                .HasMany(p => p.GiaoDiches)
                .WithOne(p => p.ThanhVien)
                .HasForeignKey(p => p.TenDangNhap)
                .IsRequired();

            modelBuilder.Entity<ThanhVien>()
                .HasMany(p => p.HoaDons)
                .WithOne(p => p.ThanhVien)
                .HasForeignKey(p => p.TenDangNhap)
                .IsRequired();
        }
    }
}
