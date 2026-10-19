-- Tạo cơ sở dữ liệu Quản lý đặt tour
-- Lưu ý: dùng NCHAR(...) cho tiếng Việt để tránh lỗi encoding khi chạy sqlcmd (UTF-8).
IF DB_ID(N'QL_DatTour') IS NOT NULL
BEGIN
    ALTER DATABASE QL_DatTour SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QL_DatTour;
END
GO

CREATE DATABASE QL_DatTour;
GO

USE QL_DatTour;
GO

-- 1. Bảng Tour
CREATE TABLE Tour (
    MaTour INT IDENTITY(1,1) PRIMARY KEY,
    TenTour NVARCHAR(100) NOT NULL,
    DiemDen NVARCHAR(50) NOT NULL,
    NgoaiTe CHAR(3) NOT NULL, -- THB, KRW, JPY, USD
    GiaNgoaiTe DECIMAL(18,2) NOT NULL,
    NgayKhoiHanh DATE NOT NULL,
    SoChoToiDa INT NOT NULL
);
GO

-- 2. Bảng KhachHang
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15),
    Email NVARCHAR(100)
);
GO

-- 3. Bảng DatTour
CREATE TABLE DatTour (
    MaDat INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT NOT NULL,
    MaTour INT NOT NULL,
    SoNguoi INT NOT NULL,
    NgayDat DATETIME NOT NULL,
    TyGia DECIMAL(18,4) NOT NULL,
    TongTienVND DECIMAL(18,0) NOT NULL,
    CONSTRAINT FK_DatTour_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_DatTour_Tour FOREIGN KEY (MaTour) REFERENCES Tour(MaTour)
);
GO

-- Seed: ít nhất 5 tour (NCHAR tránh mojibake khi sqlcmd đọc file UTF-8)
-- Đ=272, á=225, à=224, ố=7889, ậ=7853, ả=7843, ể=7875, đ=273
INSERT INTO Tour (TenTour, DiemDen, NgoaiTe, GiaNgoaiTe, NgayKhoiHanh, SoChoToiDa) VALUES
(N'Bangkok - Pattaya 5N4' + NCHAR(272), N'Th' + NCHAR(225) + N'i Lan', 'THB', 9500.00, '2026-11-15', 40),
(N'Seoul - Nami 4N3' + NCHAR(272), N'H' + NCHAR(224) + N'n Qu' + NCHAR(7889) + N'c', 'KRW', 850000.00, '2026-12-01', 30),
(N'Tokyo - Fuji 5N4' + NCHAR(272), N'Nh' + NCHAR(7853) + N't B' + NCHAR(7843) + N'n', 'JPY', 120000.00, '2026-12-20', 25),
(N'Singapore - Sentosa 3N2' + NCHAR(272), N'Singapore', 'USD', 450.00, '2026-11-28', 35),
(N'Nha Trang - Bi' + NCHAR(7875) + N'n ' + NCHAR(273) + NCHAR(7843) + N'o 4N3' + NCHAR(272), N'Nha Trang', 'USD', 180.00, '2026-10-25', 50);
GO

-- Seed khách hàng: ê=234, ă=259, ầ=7847, ị=7883, ễ=7877, ạ=7841
INSERT INTO KhachHang (HoTen, SoDienThoai, Email) VALUES
(N'L' + NCHAR(234) + N' V' + NCHAR(259) + N'n An', '0901234567', N'lean@email.com'),
(N'Tr' + NCHAR(7847) + N'n Th' + NCHAR(7883) + N' Mai', '0987654321', N'tranmai@email.com'),
(N'Nguy' + NCHAR(7877) + N'n Ho' + NCHAR(224) + N'ng Nam', '0912345678', N'namnguyen@email.com'),
(N'Ph' + NCHAR(7841) + N'm Th' + NCHAR(7883) + N' Hoa', '0934567890', N'hoa.pham@email.com');
GO

INSERT INTO DatTour (MaKH, MaTour, SoNguoi, NgayDat, TyGia, TongTienVND) VALUES
(1, 5, 4, '2026-09-10 09:30:00', 25500.0000, 18360000),
(2, 1, 2, '2026-09-12 14:15:00', 778.0000, 14782000),
(3, 2, 3, '2026-09-15 10:00:00', 18.5000, 47175000);
GO
