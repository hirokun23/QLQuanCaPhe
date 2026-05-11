IF EXISTS (SELECT * FROM sys.databases WHERE name = 'QLCF')
    DROP DATABASE QLCF
GO

CREATE DATABASE QLCF
GO

USE QLCF
GO

-- ================= NHÂN VIÊN =================
DROP TABLE NhanVien
CREATE TABLE NhanVien
(
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100),
    TenDangNhap NVARCHAR(50),
    NgaySinh DATE,
    SDT NVARCHAR(20),
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(200),
    ChucVu NVARCHAR(50),
    Luong DECIMAL(18,0)
)

INSERT INTO NhanVien
(TenNV, TenDangNhap, NgaySinh, SDT,
 GioiTinh, DiaChi, ChucVu, Luong)
VALUES
(N'Nguyễn Minh Quân', 'quan', '2003-01-15',
'0901234561', N'Nam', N'Bình Dương',
N'Nhân viên', 5500000),

(N'Trần Gia Huy', 'huy', '2002-03-20',
'0901234562', N'Nam', N'HCM',
N'Pha chế', 6500000),

(N'Lê Hoàng Nam', 'nam', '2004-05-10',
'0901234563', N'Nam', N'Đồng Nai',
N'Nhân viên', 5200000),

(N'Phạm Quốc Bảo', 'bao', '2001-07-08',
'0901234564', N'Nam', N'Bình Phước',
N'Thu ngân', 6200000),

(N'Võ Minh Khang', 'khang', '2000-09-12',
'0901234565', N'Nam', N'HCM',
N'Quản lý', 11000000),

(N'Nguyễn Khánh Vy', 'vy', '2003-04-17',
'0901234571', N'Nữ', N'Bình Dương',
N'Nhân viên', 5400000),

(N'Trần Ngọc Hân', 'han', '2002-06-11',
'0901234572', N'Nữ', N'HCM',
N'Pha chế', 6700000),

(N'Lê Thảo Nhi', 'nhi', '2004-09-09',
'0901234573', N'Nữ', N'Đồng Nai',
N'Nhân viên', 5100000),

(N'Phạm Kim Ngân', 'ngan', '2001-01-28',
'0901234574', N'Nữ', N'Bình Phước',
N'Thu ngân', 6100000),

(N'Hoàng Minh Thư', 'thu', '2000-02-16',
'0901234580', N'Nữ', N'HCM',
N'Quản lý', 11800000)

-- ================= TÀI KHOẢN =================
DROP TABLE TaiKhoan
CREATE TABLE TaiKhoan
(
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50)
)

INSERT INTO TaiKhoan
(TenDangNhap, MatKhau)
VALUES
('admin', '123'),
('quan', '123'),
('huy', '123'),
('nam', '123'),
('bao', '123'),
('khang', '123'),
('vy', '123'),
('han', '123'),
('nhi', '123'),
('ngan', '123'),
('thu', '123')


-- ================= BÀN =================
CREATE TABLE Ban
(
    MaBan INT IDENTITY(1,1) PRIMARY KEY,
    TenBan NVARCHAR(100),
    TrangThai NVARCHAR(50) DEFAULT N'Trống'
)

INSERT INTO Ban VALUES
(N'Bàn 1', N'Trống'),
(N'Bàn 2', N'Trống'),
(N'Bàn 3', N'Trống'),
(N'Bàn 4', N'Trống'),
(N'Bàn 5', N'Trống'),
(N'Bàn 6', N'Trống'),
(N'Bàn 7', N'Trống'),
(N'Bàn 8', N'Trống'),
(N'Bàn 9', N'Trống'),
(N'Bàn 10', N'Trống'),
(N'Bàn 11', N'Trống'),
(N'Bàn 12', N'Trống'),
(N'Bàn 13', N'Trống'),
(N'Bàn 14', N'Trống'),
(N'Bàn 15', N'Trống'),
(N'Bàn 16', N'Trống'),
(N'Bàn 17', N'Trống'),
(N'Bàn 18', N'Trống'),
(N'Bàn 19', N'Trống'),
(N'Bàn 20', N'Trống'),
(N'Bàn 21', N'Trống'),
(N'Bàn 22', N'Trống'),
(N'Bàn 23', N'Trống'),
(N'Bàn 24', N'Trống'),
(N'Bàn 25', N'Trống'),
(N'Bàn 26', N'Trống'),
(N'Bàn 27', N'Trống'),
(N'Bàn 28', N'Trống'),
(N'Bàn 29', N'Trống'),
(N'Bàn 30', N'Trống'),
(N'Bàn 31', N'Trống'),
(N'Bàn 32', N'Trống'),
(N'Bàn 33', N'Trống'),
(N'Bàn 34', N'Trống'),
(N'Bàn 35', N'Trống'),
(N'Bàn 36', N'Trống'),
(N'Bàn 37', N'Trống'),
(N'Bàn 38', N'Trống'),
(N'Bàn 39', N'Trống'),
(N'Bàn 40', N'Trống'),
(N'Bàn 41', N'Trống'),
(N'Bàn 42', N'Trống'),
(N'Bàn 43', N'Trống'),
(N'Bàn 44', N'Trống'),
(N'Bàn 45', N'Trống'),
(N'Bàn 46', N'Trống'),
(N'Bàn 47', N'Trống'),
(N'Bàn 48', N'Trống'),
(N'Bàn 49', N'Trống'),
(N'Bàn 50', N'Trống')

-- ================= MÓN =================
CREATE TABLE Mon
(
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100),
    Gia DECIMAL(18,0),
    Loai NVARCHAR(50)
)

INSERT INTO Mon VALUES
(N'Cà phê đen', 18000, N'Cafe'),
(N'Cà phê sữa', 22000, N'Cafe'),
(N'Bạc xỉu', 25000, N'Cafe'),
(N'Latte', 38000, N'Cafe'),
(N'Cappuccino', 40000, N'Cafe'),

(N'Trà đào cam sả', 32000, N'Trà'),
(N'Trà chanh', 20000, N'Trà'),
(N'Trà vải', 30000, N'Trà'),
(N'Trà dâu', 32000, N'Trà'),
(N'Trà sữa trân châu', 35000, N'Trà'),

(N'Nước ép cam', 35000, N'Nước ép'),
(N'Nước ép dứa', 32000, N'Nước ép'),
(N'Nước ép cà rốt', 30000, N'Nước ép'),

(N'Sinh tố dâu', 38000, N'Sinh tố'),
(N'Sinh tố xoài', 38000, N'Sinh tố'),
(N'Sinh tố bơ', 42000, N'Sinh tố'),

(N'Coca Cola', 15000, N'Nước ngọt'),
(N'Pepsi', 15000, N'Nước ngọt'),
(N'7Up', 15000, N'Nước ngọt'),
(N'Sting', 15000, N'Nước ngọt')

-- ================= NGUYÊN LIỆU =================
CREATE TABLE NguyenLieu
(
    MaNL NVARCHAR(20) PRIMARY KEY,
    TenNL NVARCHAR(100),
    SoLuong INT
)

INSERT INTO NguyenLieu VALUES
('NL01', N'Cà phê hạt', 50),
('NL02', N'Sữa đặc', 40),
('NL03', N'Sữa tươi', 35),
('NL04', N'Trà túi lọc', 60),
('NL05', N'Đào ngâm', 25),
('NL06', N'Cam', 30),
('NL07', N'Sả', 20),
('NL08', N'Chanh', 35),
('NL09', N'Vải', 20),
('NL10', N'Dâu', 25),
('NL11', N'Trân châu', 40),
('NL12', N'Dứa', 18),
('NL13', N'Cà rốt', 22),
('NL14', N'Xoài', 20),
('NL15', N'Bơ', 15),
('NL16', N'Sữa chua', 25),
('NL17', N'Coca Cola lon', 50),
('NL18', N'Pepsi lon', 50),
('NL19', N'7Up lon', 50),
('NL20', N'Sting lon', 50),
('NL21', N'Đường', 100),
('NL22', N'Đá viên', 200),
('NL23', N'Kem sữa', 20),
('NL24', N'Ống hút', 500),
('NL25', N'Ly nhựa', 300)

-- ================= HÓA ĐƠN =================
Drop TABLE HoaDon

CREATE TABLE HoaDon
(
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    MaBan INT,
    MaNV INT,
    NgayLap DATETIME DEFAULT GETDATE(),
    TongTien DECIMAL(18,0),

    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
)

ALTER TABLE HoaDon
ADD GiamGia DECIMAL(18,0) DEFAULT 0,
    PhuThu DECIMAL(18,0) DEFAULT 0

INSERT INTO HoaDon (MaBan, MaNV, NgayLap, TongTien)
VALUES
(1, 1, '2026-05-01 08:30:00', 65000),
(2, 2, '2026-05-01 09:15:00', 90000),
(3, 3, '2026-05-01 10:00:00', 120000),
(4, 4, '2026-05-01 11:20:00', 75000),
(5, 5, '2026-05-01 13:45:00', 150000),
(6, 1, '2026-05-02 08:10:00', 85000),
(7, 2, '2026-05-02 09:40:00', 110000),
(8, 3, '2026-05-02 10:30:00', 95000),
(9, 4, '2026-05-02 14:00:00', 180000),
(10, 5, '2026-05-02 16:20:00', 70000)

-- ================= CHI TIẾT HÓA ĐƠN =================
Drop TABLE ChiTietHoaDon
CREATE TABLE ChiTietHoaDon
(
    MaHD INT,
    MaMon INT,
    SoLuong INT,
    DonGia DECIMAL(18,0),

    PRIMARY KEY (MaHD, MaMon),

    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon)
)

INSERT INTO ChiTietHoaDon (MaHD, MaMon, SoLuong, DonGia)
VALUES
(1, 1, 1, 18000),
(1, 6, 1, 32000),
(1, 17, 1, 15000),

(2, 2, 2, 22000),
(2, 7, 1, 20000),
(2, 18, 1, 15000),

(3, 3, 2, 25000),
(3, 10, 2, 35000),

(4, 1, 1, 18000),
(4, 11, 1, 35000),
(4, 19, 1, 15000),

(5, 4, 2, 38000),
(5, 16, 2, 38000),

(6, 5, 1, 40000),
(6, 6, 1, 32000),
(6, 20, 1, 15000),

(7, 8, 2, 35000),
(7, 12, 1, 32000),

(8, 9, 1, 30000),
(8, 13, 1, 30000),
(8, 17, 1, 15000),

(9, 4, 2, 38000),
(9, 5, 1, 40000),
(9, 15, 2, 15000),

(10, 2, 1, 22000),
(10, 18, 2, 15000),
(10, 11, 1, 35000)



ALTER TABLE HoaDon
ADD TrangThai NVARCHAR(20) DEFAULT N'ChuaThanhToan';

UPDATE HoaDon
SET TrangThai = N'DaThanhToan'
WHERE TongTien > 0;


-- ================= TEST =================
SELECT * FROM NhanVien
SELECT * FROM TaiKhoan
SELECT * FROM Ban
SELECT * FROM Mon
SELECT * FROM NguyenLieu
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon


SELECT * FROM HoaDon ORDER BY MaHD DESC
SELECT * FROM ChiTietHoaDon ORDER BY MaHD DESC