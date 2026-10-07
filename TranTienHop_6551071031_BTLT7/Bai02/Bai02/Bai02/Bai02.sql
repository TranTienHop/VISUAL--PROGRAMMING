-- Tạo cơ sở dữ liệu
CREATE DATABASE FitZoneDB;
GO

USE FitZoneDB;
GO

-- Bảng HoiVien
CREATE TABLE HoiVien (
    MaHV INT IDENTITY(1,1) CONSTRAINT PK_HoiVien PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    GioiTinh BIT NOT NULL,                          -- 1 = Nam, 0 = Nữ
    NgaySinh DATE NOT NULL,
    SDT VARCHAR(15),
    Email VARCHAR(100),
    HangThanhVien NVARCHAR(20) NOT NULL,            -- 'Basic', 'VIP', 'Premium'
    NgayDangKy DATETIME NOT NULL DEFAULT GETDATE(),
    TrangThai BIT NOT NULL DEFAULT 1,               -- 1 = Đang hoạt động, 0 = Tạm ngưng
    CONSTRAINT CK_HoiVien_HangThanhVien CHECK (HangThanhVien IN (N'Basic', N'VIP', N'Premium'))
);
GO

-- Thêm dữ liệu mẫu cho Hội viên
INSERT INTO HoiVien (HoTen, GioiTinh, NgaySinh, SDT, Email, HangThanhVien, TrangThai) VALUES
(N'Họ tên Văn', 1, '1999-11-07', '07382735879', 'van@gmail.com', N'Basic', 1),
(N'Nguyễn Ninh', 1, '1999-11-10', '07382731034', 'ninh@gmail.com', N'Premium', 1),
(N'Nguyễn Bộ Dôn', 1, '1999-12-29', '07882773727', 'bodon@gmail.com', N'Basic', 1),
(N'Nguyễn Xim', 1, '1999-11-17', '07375856587', 'xim@gmail.com', N'VIP', 1),
(N'Nguyễn Tương', 0, '1999-01-22', '07887775931', 'tuong@gmail.com', N'Premium', 1);
GO
