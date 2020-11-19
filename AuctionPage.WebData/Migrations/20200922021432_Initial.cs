using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuctionPage.WebData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    MaLoaiSP = table.Column<string>(maxLength: 50, nullable: false),
                    TenLoaiSP = table.Column<string>(maxLength: 250, nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    TenVietTat = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.MaLoaiSP);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThanhVien",
                columns: table => new
                {
                    MaLoaiThanhVien = table.Column<string>(maxLength: 50, nullable: false),
                    TenLoaiThanhVien = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThanhVien", x => x.MaLoaiThanhVien);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNhaCungCap = table.Column<string>(maxLength: 50, nullable: false),
                    TenNhaCungCap = table.Column<string>(maxLength: 350, nullable: false),
                    DiaChi = table.Column<string>(maxLength: 500, nullable: false),
                    SDT = table.Column<string>(maxLength: 12, nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNhaCungCap);
                });

            migrationBuilder.CreateTable(
                name: "PhienDau",
                columns: table => new
                {
                    MaPhienDau = table.Column<string>(maxLength: 50, nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "Date", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "Date", nullable: false),
                    GhiChu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhienDau", x => x.MaPhienDau);
                });

            migrationBuilder.CreateTable(
                name: "Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<string>(maxLength: 50, nullable: false),
                    TenQuyen = table.Column<string>(maxLength: 50, nullable: false),
                    GhiChu = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quyen", x => x.MaQuyen);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(maxLength: 50, nullable: false),
                    TenSanPham = table.Column<string>(maxLength: 300, nullable: false),
                    TinhTrang = table.Column<string>(maxLength: 50, nullable: false),
                    MoTa = table.Column<string>(nullable: true),
                    GhiChu = table.Column<string>(nullable: true),
                    TonKho = table.Column<int>(nullable: false),
                    TenVietTat = table.Column<string>(nullable: false),
                    AnhDaiDien = table.Column<string>(maxLength: 500, nullable: false),
                    AnhChiTiet1 = table.Column<string>(nullable: true),
                    AnhChiTiet2 = table.Column<string>(nullable: true),
                    AnhChiTiet3 = table.Column<string>(nullable: true),
                    MaLoaiSanPham = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_MaLoaiSanPham",
                        column: x => x.MaLoaiSanPham,
                        principalTable: "LoaiSanPham",
                        principalColumn: "MaLoaiSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThanhVien",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(maxLength: 300, nullable: false),
                    AnhDaiDien = table.Column<string>(maxLength: 300, nullable: true),
                    Email = table.Column<string>(maxLength: 300, nullable: false),
                    TenDayDu = table.Column<string>(maxLength: 50, nullable: true),
                    SoCMT = table.Column<string>(maxLength: 15, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "Date", nullable: false),
                    SoDienThoai = table.Column<string>(maxLength: 12, nullable: true),
                    GioiTinh = table.Column<bool>(nullable: false),
                    DiaChi = table.Column<string>(maxLength: 300, nullable: true),
                    SoDuTaiKhoan = table.Column<double>(nullable: false),
                    ActivateCode = table.Column<string>(nullable: true),
                    ResetPassCode = table.Column<string>(nullable: true),
                    TrangThai = table.Column<int>(maxLength: 30, nullable: false),
                    MaLoaiThanhVien = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhVien", x => x.TenDangNhap);
                    table.ForeignKey(
                        name: "FK_ThanhVien_LoaiThanhVien_MaLoaiThanhVien",
                        column: x => x.MaLoaiThanhVien,
                        principalTable: "LoaiThanhVien",
                        principalColumn: "MaLoaiThanhVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonNhap",
                columns: table => new
                {
                    MaHoaDonNhap = table.Column<string>(maxLength: 50, nullable: false),
                    NgayLap = table.Column<DateTime>(type: "Date", nullable: false),
                    TongTien = table.Column<double>(nullable: false),
                    MaNhaCungCap = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonNhap", x => x.MaHoaDonNhap);
                    table.ForeignKey(
                        name: "FK_HoaDonNhap_NhaCungCap_MaNhaCungCap",
                        column: x => x.MaNhaCungCap,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNhaCungCap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThanhVien_Quyen",
                columns: table => new
                {
                    MaQuyen = table.Column<string>(nullable: false),
                    MaLoaiThanhVien = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThanhVien_Quyen", x => new { x.MaLoaiThanhVien, x.MaQuyen });
                    table.ForeignKey(
                        name: "FK_LoaiThanhVien_Quyen_LoaiThanhVien_MaLoaiThanhVien",
                        column: x => x.MaLoaiThanhVien,
                        principalTable: "LoaiThanhVien",
                        principalColumn: "MaLoaiThanhVien",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoaiThanhVien_Quyen_Quyen_MaQuyen",
                        column: x => x.MaQuyen,
                        principalTable: "Quyen",
                        principalColumn: "MaQuyen",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DanhGia",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(nullable: false),
                    TenDangNhap = table.Column<string>(nullable: false),
                    Diem = table.Column<int>(nullable: false),
                    BinhLuan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhGia", x => new { x.MaSanPham, x.TenDangNhap });
                    table.ForeignKey(
                        name: "FK_DanhGia_SanPham_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhGia_ThanhVien_TenDangNhap",
                        column: x => x.TenDangNhap,
                        principalTable: "ThanhVien",
                        principalColumn: "TenDangNhap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiaoDich",
                columns: table => new
                {
                    MaGiaoDich = table.Column<string>(maxLength: 50, nullable: false),
                    ThoiGianGD = table.Column<DateTime>(nullable: false),
                    KieuGiaoDich = table.Column<int>(maxLength: 50, nullable: false),
                    SoTien = table.Column<double>(nullable: false),
                    TenDangNhap = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoDich", x => x.MaGiaoDich);
                    table.ForeignKey(
                        name: "FK_GiaoDich_ThanhVien_TenDangNhap",
                        column: x => x.TenDangNhap,
                        principalTable: "ThanhVien",
                        principalColumn: "TenDangNhap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHoaDon = table.Column<string>(maxLength: 50, nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "Date", nullable: false),
                    GiaMua = table.Column<double>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    TenDangNhap = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_ThanhVien_TenDangNhap",
                        column: x => x.TenDangNhap,
                        principalTable: "ThanhVien",
                        principalColumn: "TenDangNhap",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonNhap",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(nullable: false),
                    MaHoaDonNhap = table.Column<string>(nullable: false),
                    SoLuong = table.Column<int>(nullable: false),
                    DonGia = table.Column<double>(nullable: false),
                    NgaySanXuat = table.Column<DateTime>(type: "Date", nullable: false),
                    ThanhTien = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonNhap", x => new { x.MaSanPham, x.MaHoaDonNhap });
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_HoaDonNhap_MaHoaDonNhap",
                        column: x => x.MaHoaDonNhap,
                        principalTable: "HoaDonNhap",
                        principalColumn: "MaHoaDonNhap",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonNhap_SanPham_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DauGiaSanPham",
                columns: table => new
                {
                    MaDauGiaSP = table.Column<string>(maxLength: 50, nullable: false),
                    TieuDe = table.Column<string>(maxLength: 300, nullable: false),
                    GiaKhoiDiem = table.Column<double>(nullable: false),
                    GiaHienTai = table.Column<double>(nullable: false),
                    GiaBanNgay = table.Column<double>(nullable: false),
                    TrangThai = table.Column<int>(nullable: false),
                    MaSanPham = table.Column<string>(nullable: false),
                    MaPhienDau = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DauGiaSanPham", x => x.MaDauGiaSP);
                    table.ForeignKey(
                        name: "FK_DauGiaSanPham_HoaDon_MaDauGiaSP",
                        column: x => x.MaDauGiaSP,
                        principalTable: "HoaDon",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DauGiaSanPham_PhienDau_MaPhienDau",
                        column: x => x.MaPhienDau,
                        principalTable: "PhienDau",
                        principalColumn: "MaPhienDau",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DauGiaSanPham_SanPham_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SanPham",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuDau",
                columns: table => new
                {
                    MaLichSuDau = table.Column<string>(maxLength: 50, nullable: false),
                    TenDangNhap = table.Column<string>(nullable: false),
                    MaDauGiaSP = table.Column<string>(nullable: false),
                    GiaThoaThuan = table.Column<double>(nullable: false),
                    ThoiGanDau = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuDau", x => x.MaLichSuDau);
                    table.ForeignKey(
                        name: "FK_LichSuDau_DauGiaSanPham_MaDauGiaSP",
                        column: x => x.MaDauGiaSP,
                        principalTable: "DauGiaSanPham",
                        principalColumn: "MaDauGiaSP");
                    table.ForeignKey(
                        name: "FK_LichSuDau_ThanhVien_TenDangNhap",
                        column: x => x.TenDangNhap,
                        principalTable: "ThanhVien",
                        principalColumn: "TenDangNhap");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonNhap_MaHoaDonNhap",
                table: "ChiTietHoaDonNhap",
                column: "MaHoaDonNhap");

            migrationBuilder.CreateIndex(
                name: "IX_DanhGia_TenDangNhap",
                table: "DanhGia",
                column: "TenDangNhap");

            migrationBuilder.CreateIndex(
                name: "IX_DauGiaSanPham_MaPhienDau",
                table: "DauGiaSanPham",
                column: "MaPhienDau");

            migrationBuilder.CreateIndex(
                name: "IX_DauGiaSanPham_MaSanPham",
                table: "DauGiaSanPham",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_GiaoDich_TenDangNhap",
                table: "GiaoDich",
                column: "TenDangNhap");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_TenDangNhap",
                table: "HoaDon",
                column: "TenDangNhap");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonNhap_MaNhaCungCap",
                table: "HoaDonNhap",
                column: "MaNhaCungCap");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDau_MaDauGiaSP",
                table: "LichSuDau",
                column: "MaDauGiaSP");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuDau_TenDangNhap",
                table: "LichSuDau",
                column: "TenDangNhap");

            migrationBuilder.CreateIndex(
                name: "IX_LoaiThanhVien_Quyen_MaQuyen",
                table: "LoaiThanhVien_Quyen",
                column: "MaQuyen");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_MaLoaiSanPham",
                table: "SanPham",
                column: "MaLoaiSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhVien_MaLoaiThanhVien",
                table: "ThanhVien",
                column: "MaLoaiThanhVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDonNhap");

            migrationBuilder.DropTable(
                name: "DanhGia");

            migrationBuilder.DropTable(
                name: "GiaoDich");

            migrationBuilder.DropTable(
                name: "LichSuDau");

            migrationBuilder.DropTable(
                name: "LoaiThanhVien_Quyen");

            migrationBuilder.DropTable(
                name: "HoaDonNhap");

            migrationBuilder.DropTable(
                name: "DauGiaSanPham");

            migrationBuilder.DropTable(
                name: "Quyen");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "PhienDau");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ThanhVien");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");

            migrationBuilder.DropTable(
                name: "LoaiThanhVien");
        }
    }
}
