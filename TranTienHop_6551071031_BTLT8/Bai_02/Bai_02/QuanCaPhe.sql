-- Tạo CSDL QuanCaPhe (NCHAR tránh lỗi font khi sqlcmd UTF-8)
IF DB_ID(N'QuanCaPhe') IS NOT NULL
BEGIN
    ALTER DATABASE QuanCaPhe SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QuanCaPhe;
END
GO

CREATE DATABASE QuanCaPhe;
GO

USE QuanCaPhe;
GO

CREATE TABLE dbo.Mon (
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100) NOT NULL,
    NhomMon NVARCHAR(30) NOT NULL,
    DonGia DECIMAL(18,0) NOT NULL CONSTRAINT CK_Mon_DonGia CHECK (DonGia >= 0)
);
GO

CREATE TABLE dbo.HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME NOT NULL,
    SoBan INT NOT NULL CONSTRAINT CK_HoaDon_SoBan CHECK (SoBan BETWEEN 1 AND 10),
    HinhThucTT NVARCHAR(20) NOT NULL,
    GhiChu NVARCHAR(200) NULL
);
GO

CREATE TABLE dbo.ChiTietHoaDon (
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT NOT NULL,
    MaMon INT NOT NULL,
    SoLuong INT NOT NULL CONSTRAINT CK_ChiTietHoaDon_SoLuong CHECK (SoLuong > 0),
    DonGia DECIMAL(18,0) NOT NULL,
    CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (MaHD) REFERENCES dbo.HoaDon(MaHD),
    CONSTRAINT FK_ChiTietHoaDon_Mon FOREIGN KEY (MaMon) REFERENCES dbo.Mon(MaMon)
);
GO

-- à=224 ê=234 ữ=7919 đ=273 á=225 ạ=7841 ỉ=7881 ả=7843 ư=432 ớ=7899 ố=7889 ó=243 ề=7873 ặ=7863 ể=7875
DECLARE @CaPhe NVARCHAR(30) = N'C' + NCHAR(224) + N' ph' + NCHAR(234);
DECLARE @NuocDongChai NVARCHAR(30) = N'N' + NCHAR(432) + NCHAR(7899) + N'c ' + NCHAR(273) + NCHAR(243) + N'ng chai';
DECLARE @Tra NVARCHAR(30) = N'Tr' + NCHAR(224);
DECLARE @Banh NVARCHAR(30) = N'B' + NCHAR(225) + N'nh';

INSERT INTO dbo.Mon (TenMon, NhomMon, DonGia) VALUES
(
    N'C' + NCHAR(224) + N' ph' + NCHAR(234) + N' s' + NCHAR(7919) + N'a ' + NCHAR(273) + NCHAR(225),
    @CaPhe, 29000
),
(
    N'B' + NCHAR(7841) + N'c x' + NCHAR(7881) + N'u',
    @CaPhe, 32000
),
(
    N'Tr' + NCHAR(224) + N' ' + NCHAR(273) + NCHAR(224) + N'o cam s' + NCHAR(7843),
    @Tra, 45000
),
(
    N'B' + NCHAR(225) + N'nh tiramisu',
    @Banh, 39000
),
(
    N'N' + NCHAR(432) + NCHAR(7899) + N'c su' + NCHAR(7889) + N'i',
    @NuocDongChai, 12000
);
GO

INSERT INTO dbo.HoaDon (NgayLap, SoBan, HinhThucTT, GhiChu) VALUES
('2026-10-09 08:15:00', 3, N'Ti' + NCHAR(7873) + N'n m' + NCHAR(7863) + N't', NULL),
('2026-10-09 09:40:00', 5, N'Chuy' + NCHAR(7875) + N'n kho' + NCHAR(7843) + N'n', NULL);
GO

INSERT INTO dbo.ChiTietHoaDon (MaHD, MaMon, SoLuong, DonGia) VALUES
(1, 1, 2, 29000),
(1, 3, 1, 45000),
(1, 4, 1, 39000),
(2, 2, 1, 32000),
(2, 5, 2, 12000);
GO
