-- 0. kiểm tra phiên bản SQL Server hiện tại
SELECT @@VERSION;
-- 1. Tạo CSDL QLCB
CREATE DATABASE QLCB;
-- 2. Chọn sử dụng CSDL vừa tạo
USE QLCB;
GO
-- 3. Tạo bảng ChucVu trước (Bảng cha), mỗi chức vụ có khóa chính maCV int và tên chức vụ nchar
-- Phải tạo bảng này trước để bảng CanBo có chỗ tham chiếu tới
CREATE TABLE ChucVu (
    MaCV INT PRIMARY KEY,          -- Khóa chính
    TenCV NVARCHAR(50) NOT NULL    -- Tên chức vụ (dùng nvarchar để gõ tiếng Việt)
);
-- 4. Tạo bảng CanBo (Bảng con) với các cột MaCB int (khóa chính), TenCB nchar, ChucVuCB int (khóa ngoại tham chiếu tới MaCV của bảng ChucVu), SoGioGiang int, DonGia money
GO
CREATE TABLE CanBo (
    MaCB INT PRIMARY KEY,          -- Khóa chính
    TenCB NVARCHAR(100) NOT NULL,  -- Tên cán bộ
    MaCV INT,                  -- Cột này sẽ liên kết với MaCV bên trên
    SoGioGiang INT,                -- Số giờ giảng
    DonGia MONEY,                  -- Đơn giá

    -- Thiết lập Khóa ngoại (Foreign Key)
    -- Nghĩa là: Giá trị trong cột ChucVuCB bắt buộc phải tồn tại trong cột MaCV của bảng ChucVu
    CONSTRAINT FK_CanBo_ChucVu FOREIGN KEY (MaCV) REFERENCES ChucVu(MaCV)
);
-- 5. tạo dữ liệu ảo cho bảng ChucVu, bao gồm các chức vụ như: Giảng viên, giảng viên chính, thỉnh giảng
INSERT INTO ChucVu (MaCV, TenCV) VALUES
(1, N'Giảng viên'),
(2, N'Giảng viên chính'),
(3, N'Thỉnh giảng');
--6. tạo dữ liệu ảo cho cán bộ
INSERT INTO CanBo (MaCB, TenCB, MaCV, SoGioGiang, DonGia) VALUES
(101, N'Nguyễn Văn A', 1, 120, 200000),
(102, N'Trần Thị B', 2, 150, 250000),
(103, N'Lê Văn C', 3, 80, 300000),
(104, N'Phạm Thị D', 1, 100, 220000);
