-- 0. Kiểm tra phiên bản SQL Server hiện tại
SELECT @@VERSION;
-- 1. Tạo CSDL QLCB
CREATE DATABASE QLCB;
-- 2. Chọn sử dụng CSDL vừa tạo
USE QLCB;
GO
-- 3. Tạo bảng ChucVu trước (Bảng cha)
-- Phải tạo bảng này trước để bảng CanBo có chỗ tham chiếu tới
CREATE TABLE ChucVu (
    MaCV INT PRIMARY KEY,          -- Khóa chính
    TenCV NVARCHAR(50) NOT NULL    -- Tên chức vụ (dùng nvarchar để gõ tiếng Việt)
);
GO

-- 4. Tạo bảng CanBo (Bảng con)
CREATE TABLE CanBo (
    MaCB INT PRIMARY KEY,          -- Khóa chính
    TenCB NVARCHAR(100) NOT NULL,  -- Tên cán bộ
    ChucVuCB INT,                  -- Cột này sẽ liên kết với MaCV bên trên
    SoGioGiang INT,                -- Số giờ giảng
    DonGia MONEY,                  -- Đơn giá

    -- Thiết lập Khóa ngoại (Foreign Key)
    -- Nghĩa là: Giá trị trong cột ChucVuCB bắt buộc phải tồn tại trong cột MaCV của bảng ChucVu
    CONSTRAINT FK_CanBo_ChucVu FOREIGN KEY (ChucVuCB) REFERENCES ChucVu(MaCV)
);
GO

-- =============================================
-- PHẦN DƯỚI NÀY LÀ MẪU ĐỂ BẠN NHẬP DỮ LIỆU THỬ (OPTION)
-- =============================================

-- Nhập dữ liệu mẫu cho bảng ChucVu
INSERT INTO ChucVu (MaCV, TenCV) VALUES (1, N'Giảng viên');
INSERT INTO ChucVu (MaCV, TenCV) VALUES (2, N'Trưởng bộ môn');
INSERT INTO ChucVu (MaCV, TenCV) VALUES (3, N'Phó khoa');

-- Nhập dữ liệu mẫu cho bảng CanBo
-- Lưu ý: ChucVuCB phải điền số 1, 2 hoặc 3 (tương ứng với MaCV ở trên)
INSERT INTO CanBo (MaCB, TenCB, ChucVuCB, SoGioGiang, DonGia) 
VALUES (101, N'Nguyễn Văn An', 1, 100, 150000);

INSERT INTO CanBo (MaCB, TenCB, ChucVuCB, SoGioGiang, DonGia) 
VALUES (102, N'Trần Thị Bích', 2, 200, 200000);