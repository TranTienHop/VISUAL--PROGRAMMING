-- Tạo Cơ sở dữ liệu TiemTapHoa
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'TiemTapHoa')
BEGIN
    CREATE DATABASE TiemTapHoa;
END
GO

USE TiemTapHoa;
GO

-- Xóa bảng HangHoa nếu đã tồn tại trước đó để đảm bảo dữ liệu mới nhất
IF OBJECT_ID(N'dbo.HangHoa', N'U') IS NOT NULL
BEGIN
    DROP TABLE dbo.HangHoa;
END
GO

-- Tạo bảng HangHoa
CREATE TABLE dbo.HangHoa (
    MaHang INT IDENTITY(1,1) PRIMARY KEY,
    TenHang NVARCHAR(100) NOT NULL,
    LoaiHang NVARCHAR(50) NULL,
    DonVi NVARCHAR(20) NULL,
    GiaBan DECIMAL(18,0) NOT NULL CONSTRAINT CK_HangHoa_GiaBan CHECK (GiaBan > 0),
    SoLuongTon INT NOT NULL CONSTRAINT CK_HangHoa_SoLuongTon CHECK (SoLuongTon >= 0),
    NgayNhap DATETIME NOT NULL,
    ConKinhDoanh BIT NOT NULL CONSTRAINT DF_HangHoa_ConKinhDoanh DEFAULT (1)
);
GO

-- Chèn 6 dòng dữ liệu mẫu
INSERT INTO dbo.HangHoa (TenHang, LoaiHang, DonVi, GiaBan, SoLuongTon, NgayNhap, ConKinhDoanh)
VALUES
(N'Nước suối Aquafina 500ml', N'Đồ uống', N'Chai', 6000, 120, '2026-10-02 00:00:00', 1),
(N'Mì Hảo Hảo tôm chua cay', N'Thực phẩm khô', N'Gói', 4500, 200, '2026-10-02 00:00:00', 1),
(N'Dầu ăn Tường An 1L', N'Gia vị', N'Chai', 48000, 35, '2026-10-05 00:00:00', 1),
(N'Bột giặt OMO 800g', N'Đồ gia dụng', N'Túi', 52000, 40, '2026-10-05 00:00:00', 1),
(N'Sữa tươi Vinamilk 1L', N'Đồ uống', N'Hộp', 32000, 60, '2026-10-08 00:00:00', 1),
(N'Nước mắm Nam Ngư 500ml', N'Gia vị', N'Chai', 38000, 25, '2026-10-01 00:00:00', 0);
GO
