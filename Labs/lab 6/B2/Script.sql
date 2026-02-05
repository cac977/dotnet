--0. tao csdl qlcb
CREATE DATABASE QLCB;
--1.CanBo(MaCB, TenCB, ChucVuCB, SoGioGiang, DonGia): mỗi cán bộ có mã cán bộ (int) là khóa chính, tên cán bộ (nvarchar), chức vụ cán bộ (int; là khóa ngoại, khóa chính là MaCV của bảng ChucVu), số giờ giảng trong năm (int), đơn giá 1 giờ (money).
create Table CanBo(
    MaCB int Primary Key,
    TenCB nvarchar(100) Not Null,
    MaCV int Not Null,
    SoGioGiang int Not Null,
    DonGia money Not Null,
    Foreign Key (MaCV) References ChucVu(MaCV)
);
--2.ChucVu(MaCV, TenCV): mỗi chức vụ có mã chức vụ (int) là khóa chính, tên chức vụ (nvarchar).
create Table ChucVu(
    MaCV int Primary Key,
    TenCV nvarchar(100) Not Null
);
