-- Tạo CSDL Quản lý nhà trọ
-- Tiếng Việt dùng NCHAR để tránh lỗi font khi chạy sqlcmd với file UTF-8
IF DB_ID(N'QL_NhaTro') IS NOT NULL
BEGIN
    ALTER DATABASE QL_NhaTro SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QL_NhaTro;
END
GO

CREATE DATABASE QL_NhaTro;
GO

USE QL_NhaTro;
GO

CREATE TABLE PhongTro (
    MaPhong INT IDENTITY(1,1) PRIMARY KEY,
    TenPhong NVARCHAR(20) NOT NULL,
    GiaThue DECIMAL(18,0) NOT NULL,
    TinhTrang NVARCHAR(20) NOT NULL
);
GO

CREATE TABLE KhachThue (
    MaKhach INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh NVARCHAR(5) NOT NULL,
    NgaySinh DATE NOT NULL,
    SoDienThoai VARCHAR(15),
    MaTinh INT NULL,
    TenTinh NVARCHAR(100) NULL,
    MaPhuongXa INT NULL,
    TenPhuongXa NVARCHAR(100) NULL,
    DaDangKyTamTru BIT NOT NULL DEFAULT 0,
    MaPhong INT NOT NULL,
    CONSTRAINT FK_KhachThue_PhongTro FOREIGN KEY (MaPhong) REFERENCES PhongTro(MaPhong)
);
GO

DECLARE @Trong NVARCHAR(20) = N'Tr' + NCHAR(7889) + N'ng';           -- Trống
DECLARE @DangThue NVARCHAR(20) = NCHAR(272) + N'ang thu' + NCHAR(234); -- Đang thuê

INSERT INTO PhongTro (TenPhong, GiaThue, TinhTrang) VALUES
(N'P01', 1500000, @Trong),
(N'P02', 1600000, @Trong),
(N'P03', 1800000, @Trong),
(N'P04', 2000000, @Trong),
(N'P05', 2200000, @Trong),
(N'P06', 2500000, @Trong);
GO

DECLARE @Trong NVARCHAR(20) = N'Tr' + NCHAR(7889) + N'ng';
DECLARE @DangThue NVARCHAR(20) = NCHAR(272) + N'ang thu' + NCHAR(234);
DECLARE @Nu NVARCHAR(5) = N'N' + NCHAR(7919); -- Nữ

-- Nguyễn Văn An | Trần Thị Bình | Lê Minh Cường
INSERT INTO KhachThue (HoTen, GioiTinh, NgaySinh, SoDienThoai, MaTinh, TenTinh, MaPhuongXa, TenPhuongXa, DaDangKyTamTru, MaPhong) VALUES
(
    N'Nguy' + NCHAR(7877) + N'n V' + NCHAR(259) + N'n An',
    N'Nam', '2004-05-12', '0912345678',
    1,
    N'Th' + NCHAR(224) + N'nh ph' + NCHAR(7889) + N' H' + NCHAR(224) + N' N' + NCHAR(7897) + N'i',
    1,
    N'Ph' + NCHAR(432) + NCHAR(7901) + N'ng Ba ' + NCHAR(272) + NCHAR(236) + N'nh',
    1, 3
),
(
    N'Tr' + NCHAR(7847) + N'n Th' + NCHAR(7883) + N' B' + NCHAR(236) + N'nh',
    @Nu, '2002-08-20', '0987654321',
    79,
    N'Th' + NCHAR(224) + N'nh ph' + NCHAR(7889) + N' H' + NCHAR(7891) + N' Ch' + NCHAR(237) + N' Minh',
    760,
    N'Ph' + NCHAR(432) + NCHAR(7901) + N'ng B' + NCHAR(7871) + N'n Ngh' + NCHAR(233),
    0, 1
),
(
    N'L' + NCHAR(234) + N' Minh C' + NCHAR(432) + NCHAR(7901) + N'ng',
    N'Nam', '2000-01-15', '0901112233',
    48,
    N'Th' + NCHAR(224) + N'nh ph' + NCHAR(7889) + N' ' + NCHAR(272) + NCHAR(224) + N' N' + NCHAR(7855) + N'ng',
    201,
    N'Ph' + NCHAR(432) + NCHAR(7901) + N'ng H' + NCHAR(7843) + N'i Ch' + NCHAR(226) + N'u',
    1, 1
);
GO

UPDATE PhongTro
SET TinhTrang = NCHAR(272) + N'ang thu' + NCHAR(234)
WHERE MaPhong IN (1, 3);
GO
