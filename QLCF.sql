IF EXISTS (SELECT * FROM sys.databases WHERE name = 'QLCF')
    DROP DATABASE QLCF
GO

CREATE DATABASE QLCF
GO

USE QLCF
GO

-- ================= NHÂN VIÊN =================
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL
    DROP TABLE NhanVien;
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

(N'Lê Phan Quang Huy', 'huy', '2006-01-01',
'0786283728', N'Nam', N'HCM',
N'Quản lý', 11000000),

(N'Nguyễn Hoài Nam', 'nam', '2006-11-23',
'0867992284', N'Nam', N'HCM',
N'QUản lý', 11000000),

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
IF OBJECT_ID('TaiKhoan', 'U') IS NOT NULL
    DROP TABLE TaiKhoan;

CREATE TABLE TaiKhoan
(
    TenDangNhap NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(50),
    ChucVu NVARCHAR(20),
    Email NVARCHAR(100)
);

INSERT INTO TaiKhoan (TenDangNhap, MatKhau, ChucVu, Email)
VALUES
('quan', '123', 'User', 'quan@gmail.com'),
('huy', '123', 'Admin', 'huylevippro123456@gmail.com'),
('nam', '123', 'Admin', 'namnguyenvn2006@gmail.com'),
('bao', '123', 'User', 'bao@gmail.com'),
('khang', '123', 'User', 'khang@gmail.com'),
('vy', '123', 'User', 'vy@gmail.com'),
('han', '123', 'User', 'han@gmail.com'),
('nhi', '123', 'User', 'nhi@gmail.com'),
('ngan', '123', 'User', 'ngan@gmail.com'),
('thu', '123', 'User', 'thu@gmail.com');



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
Drop table Mon

CREATE TABLE Mon
(
    MaMon INT IDENTITY(1,1) PRIMARY KEY,
    TenMon NVARCHAR(100),
    Gia DECIMAL(18,0),
    Loai NVARCHAR(50),
    HinhAnh NVARCHAR(255)
)

INSERT INTO Mon
(TenMon, Gia, Loai, HinhAnh)
VALUES

-- ================= CAFE =================
(N'Cà phê đen', 18000, N'Cafe', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\capheden.jpg'),
(N'Cà phê sữa', 22000, N'Cafe', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\caphesua.jpg'),
(N'Bạc xỉu', 25000, N'Cafe', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\bacxiu.jpg'),
(N'Latte', 38000, N'Cafe', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\latte.jpg'),
(N'Cappuccino', 40000, N'Cafe', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\cappuccino.jpg'),

-- ================= TRÀ =================
(N'Trà đào cam sả', 32000, N'Trà', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\tradaocamsa.jpg'),
(N'Trà chanh', 20000, N'Trà', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\trachanh.jpg'),
(N'Trà vải', 30000, N'Trà', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\travai.jpg'),
(N'Trà dâu', 32000, N'Trà', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\tradau.jpg'),
(N'Trà sữa trân châu', 35000, N'Trà', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\trasuatranchau.jpg'),

-- ================= NƯỚC ÉP =================
(N'Nước ép cam', 35000, N'Nước ép', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\nuocepcam.jpg'),
(N'Nước ép dứa', 32000, N'Nước ép', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\nuocepdua.jpg'),
(N'Nước ép cà rốt', 30000, N'Nước ép', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\nuocepcarot.jpg'),

-- ================= SINH TỐ =================
(N'Sinh tố dâu', 38000, N'Sinh tố', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\sinhtodau.jpg'),
(N'Sinh tố xoài', 38000, N'Sinh tố', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\sinhtoxoai.jpg'),
(N'Sinh tố bơ', 42000, N'Sinh tố', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\sinhtobo.jpg'),

-- ================= NƯỚC NGỌT =================
(N'Coca Cola', 15000, N'Nước ngọt', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\cocacola.jpg'),
(N'Pepsi', 15000, N'Nước ngọt', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\pepsi.jpg'),
(N'7Up', 15000, N'Nước ngọt', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\7up.jpg'),
(N'Sting', 15000, N'Nước ngọt', 'C:\Users\Hoai Nam\Downloads\QuanLyQuanCafe\Images\sting.jpg')

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

Drop table CongThuc
CREATE TABLE CongThuc
(
    MaMon INT,
    MaNL NVARCHAR(20),
    SoLuong FLOAT,

    PRIMARY KEY (MaMon, MaNL),

    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon),
    FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL)
)

INSERT INTO CongThuc (MaMon, MaNL, SoLuong)
VALUES

-- ================= CÀ PHÊ =================
-- Cà phê đen
(1, 'NL01', 10),  -- cà phê hạt
(1, 'NL21', 5),   -- đường
(1, 'NL22', 50),  -- đá

-- Cà phê sữa
(2, 'NL01', 8),   -- cà phê hạt
(2, 'NL02', 10),  -- sữa đặc
(2, 'NL21', 5),   -- đường
(2, 'NL22', 50),  -- đá

-- Bạc xỉu
(3, 'NL01', 6),   -- cà phê hạt
(3, 'NL02', 15),  -- sữa đặc
(3, 'NL23', 10),  -- kem sữa

-- Latte
(4, 'NL03', 20),  -- sữa tươi
(4, 'NL21', 10),  -- đường

-- Cappuccino
(5, 'NL03', 15),  -- sữa tươi
(5, 'NL23', 15),  -- kem sữa


-- ================= TRÀ =================
-- Trà đào cam sả
(6, 'NL04', 1),   -- trà túi lọc
(6, 'NL05', 15),  -- đào ngâm
(6, 'NL21', 10),  -- đường
(6, 'NL22', 50),  -- đá

-- Trà chanh
(7, 'NL04', 1),   -- trà túi lọc
(7, 'NL08', 20),  -- chanh
(7, 'NL21', 10),  -- đường

-- Trà vải
(8, 'NL04', 1),   -- trà túi lọc
(8, 'NL09', 15),  -- vải
(8, 'NL21', 10),  -- đường

-- Trà dâu
(9, 'NL04', 1),   -- trà túi lọc
(9, 'NL10', 15),  -- dâu
(9, 'NL21', 10),  -- đường

-- Trà sữa trân châu
(10, 'NL04', 1),  -- trà túi lọc
(10, 'NL11', 20), -- trân châu
(10, 'NL03', 10), -- sữa tươi


-- ================= NƯỚC ÉP =================
-- Nước ép cam
(11, 'NL06', 2),  -- cam
(11, 'NL21', 10), -- đường

-- Nước ép dứa
(12, 'NL12', 2),  -- dứa
(12, 'NL21', 10),

-- Nước ép cà rốt
(13, 'NL13', 2),  -- cà rốt
(13, 'NL21', 10),


-- ================= SINH TỐ =================
-- Sinh tố dâu
(14, 'NL10', 2),  -- dâu
(14, 'NL23', 20), -- kem sữa

-- Sinh tố xoài
(15, 'NL14', 2),  -- xoài
(15, 'NL23', 20), -- kem sữa

-- Sinh tố bơ
(16, 'NL15', 2),  -- bơ
(16, 'NL23', 20), -- kem sữa


-- ================= NƯỚC NGỌT =================
-- Coca Cola
(17, 'NL17', 1),  -- coca lon
(17, 'NL22', 50), -- đá

-- Pepsi
(18, 'NL18', 1),  -- pepsi lon
(18, 'NL22', 50), -- đá

-- 7Up
(19, 'NL19', 1),  -- 7Up lon
(19, 'NL22', 50), -- đá

-- Sting
(20, 'NL20', 1),  -- sting lon
(20, 'NL22', 50)  -- đá


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
    MaCT INT IDENTITY(1,1) PRIMARY KEY,
    MaHD INT,
    MaMon INT,
    SoLuong INT,
    DonGia DECIMAL(18,0),
    ThanhTien AS (SoLuong * DonGia ),

    GhiChu NVARCHAR(255),


    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaMon) REFERENCES Mon(MaMon)
)

INSERT INTO ChiTietHoaDon 
(MaHD, MaMon, SoLuong, DonGia, GhiChu)
VALUES

-- ================= HÓA ĐƠN 1 =================
(1, 1, 1, 18000, N'ít đá'),
(1, 6, 1, 32000, N'bình thường'),
(1, 17, 1, 15000, N'lon'),

-- ================= HÓA ĐƠN 2 =================
(2, 2, 2, 22000, N'ít đường'),
(2, 7, 1, 20000, N'chanh nhiều'),
(2, 18, 1, 15000, N'lạnh'),

-- ================= HÓA ĐƠN 3 =================
(3, 3, 2, 25000, N'đậm'),
(3, 10, 2, 35000, N'thêm trân châu'),

-- ================= HÓA ĐƠN 4 =================
(4, 1, 1, 18000, N'không đường'),
(4, 11, 1, 35000, N'ít đá'),
(4, 19, 1, 15000, N'lon'),

-- ================= HÓA ĐƠN 5 =================
(5, 4, 2, 38000, N'size lớn'),
(5, 16, 2, 38000, N'bơ thêm kem');

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
SELECT * FROM CongThuc

SELECT * FROM HoaDon ORDER BY MaHD DESC
SELECT * FROM ChiTietHoaDon ORDER BY MaHD DESC

SELECT TenMon, HinhAnh FROM Mon