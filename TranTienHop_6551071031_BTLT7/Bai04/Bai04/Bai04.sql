-- Tạo cơ sở dữ liệu
CREATE DATABASE AnKhangClinicDB;
GO

USE AnKhangClinicDB;
GO

-- 1. Bảng BacSi
CREATE TABLE BacSi (
    MaBS INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    ChuyenKhoa NVARCHAR(100),
    SDT VARCHAR(15)
);
GO

-- 2. Bảng LichKham
CREATE TABLE LichKham (
    MaLich INT IDENTITY(1,1) PRIMARY KEY,
    TenBenhNhan NVARCHAR(100) NOT NULL,
    SDT VARCHAR(15),
    NgayKham DATE NOT NULL,
    GioKham TIME NOT NULL, -- Hoặc NVARCHAR(10)
    MaBS INT NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL, -- 'Chờ khám', 'Đã khám', 'Đã hủy'
    CONSTRAINT FK_LichKham_BacSi FOREIGN KEY (MaBS) REFERENCES BacSi(MaBS) ON DELETE CASCADE
);
GO

-- Thêm dữ liệu mẫu cho Bác sĩ
INSERT INTO BacSi (HoTen, ChuyenKhoa, SDT) VALUES
(N'BS. Nguyễn Văn A', N'Nội tổng quát', '0901234567'),
(N'BS. Nguyễn Văn B', N'Nội tổng quát', '0902345678'),
(N'BS. Nguyễn Văn C', N'Nội tổng quát', '0903456789'),
(N'BS. Nguyễn Văn D', N'Nội tổng quát', '0904567890');
GO

-- Thêm dữ liệu mẫu cho Lịch khám
INSERT INTO LichKham (TenBenhNhan, SDT, NgayKham, GioKham, MaBS, TrangThai) VALUES
(N'Tên bệnh nhân', '09725667894', '2022-07-13', '09:00:00', 1, N'Chờ khám'),
(N'Nguyễn Xinh', '09725667897', '2022-12-29', '13:00:00', 1, N'Đã khám'),
(N'Nguyễn Hạm', '09725667899', '2022-12-23', '16:00:00', 1, N'Đã hủy'),
(N'Nguyễn Tinh', '09725667830', '2022-12-23', '16:00:00', 1, N'Đã hủy'),
(N'Nguyễn Hoan anh', '09725667899', '2022-12-29', '18:00:00', 1, N'Đã hủy');
GO