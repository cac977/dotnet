
-- Create db
CREATE DATABASE ThanhToan;
GO

USE ThanhToan;
GO

-- Create table Phong
CREATE TABLE Phong (
    MaPhong INT PRIMARY KEY,
    TenPhong NVARCHAR(100) NOT NULL
);
GO

-- Create table KhachHang
CREATE TABLE KhachHang (
    SoHD INT PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    SoCMND NVARCHAR(20) NOT NULL,
    SoTien DECIMAL(18, 2) NOT NULL,
    NgayTT DATETIME NOT NULL,
    Phong INT NOT NULL,
    CONSTRAINT FK_KhachHang_Phong FOREIGN KEY (Phong) REFERENCES Phong(MaPhong)
);
GO

-- Create login & user
IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = 'mylogin')
BEGIN
    CREATE LOGIN mylogin WITH PASSWORD = 'mylogin';
END
GO

IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = 'mylogin')
BEGIN
    CREATE USER mylogin FOR LOGIN mylogin;
    EXEC sp_addrolemember 'db_owner', 'mylogin';
END
GO
--them du lieu mau (debugging only)
INSERT INTO Phong (MaPhong, TenPhong) VALUES (101, 'Phong A');
INSERT INTO KhachHang (SoHD, TenKH, SoCMND, SoTien, NgayTT, Phong) VALUES (1, 'Nguyen Van A', '123456789', 500000.00, GETDATE(), 101);
