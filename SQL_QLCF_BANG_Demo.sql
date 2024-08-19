﻿CREATE DATABASE QL_CAFE ON PRIMARY
(
	NAME = DB_PRIMARY,
	FILENAME = 'E:\Bài tập\Kỳ 5\dotNet\CSDL CAFE\QL_QCAFE.mdf',
	SIZE = 3MB,
	MAXSIZE = 10MB,
	FILEGROWTH = 10%
)
LOG ON 
(
	NAME = DB_LOG,
	FILENAME = 'E:\Bài tập\Kỳ 5\dotNet\CSDL CAFE\QL_QCAFE.ldf',
	SIZE = 1MB,
	MAXSIZE = 5MB,
	FILEGROWTH = 15%
)
USE QL_CAFE
GO
CREATE TABLE NHANVIEN(
	MANV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENNV NVARCHAR(50) NOT NULL,
	GIOITINH NVARCHAR(5) CHECK (GIOITINH IN ('Nam',N'Nữ')),
	CHUCVU NVARCHAR(30) NOT NULL,
	NGAYVAOLAM DATE CHECK (NGAYVAOLAM <= GETDATE()),
	DIACHI NVARCHAR(100) NOT NULL,
	SDT INT UNIQUE,
)
CREATE TABLE LOGINNV
(
	MANV VARCHAR(10) NOT NULL,
	PASSNV VARCHAR(30),
	CONSTRAINT FK_LOGINNV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
CREATE TABLE LOAIKHACHHANG(
	MALKH VARCHAR(10) NOT NULL PRIMARY KEY,
	TENLKH NVARCHAR(50) NOT NULL,
	GIAMGIA INT CHECK (GIAMGIA >= 0),
)

CREATE TABLE KHACHHANG(
	MAKH VARCHAR(10) NOT NULL PRIMARY KEY,
	MALKH VARCHAR(10) NOT NULL,
	TENKH NVARCHAR(50),
	DIACHI NVARCHAR(50),
	SDT INT UNIQUE,
	DIEMTL INT CHECK (DIEMTL >= 0),
	CONSTRAINT FK_MALKH FOREIGN KEY (MALKH) REFERENCES LOAIKHACHHANG(MALKH),
)
CREATE TABLE LOGINKH
(
	MAKH VARCHAR(10) NOT NULL,
	PASSKH VARCHAR(30),
	CONSTRAINT FK_LOGINKH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH)
)
CREATE TABLE LOAISANPHAM(
	MALSP VARCHAR(10) NOT NULL PRIMARY KEY,
	TENLSP NVARCHAR(50) NOT NULL,
	MOTA NVARCHAR(150),
)
CREATE TABLE SANPHAM(
	MASP VARCHAR(10) NOT NULL PRIMARY KEY,
	TENSP NVARCHAR(50) NOT NULL,
	MALSP VARCHAR(10),
	GIASP INT NOT NULL CHECK(GIASP >= 0),
	CONSTRAINT FK_MALSP FOREIGN KEY (MALSP) REFERENCES LOAISANPHAM(MALSP),
	HINHANH NVARCHAR(MAX)
)

CREATE TABLE CALAMVIEC(
	MACLV VARCHAR(10) NOT NULL PRIMARY KEY,
	TENCLV NVARCHAR(50) NOT NULL,
	GIOBD TIME(2) NOT NULL,
	GIOKT TIME(2) NOT NULL,
	SOTIEN INT,
	CONSTRAINT chk_giolam CHECK(GIOBD < GIOKT),
)
CREATE TABLE HDBANHANG
(
	MAHDBH VARCHAR(10) NOT NULL PRIMARY KEY,
	MANV VARCHAR(10) NOT NULL,
	NGAYHDBH DATETIME CHECK (NGAYHDBH <= GETDATE()),
	TONGTIEN INT,
	GIAMGIA INT,
	MAKH VARCHAR(10) NOT NULL,
	IDBAN CHAR(5) NOT NULL,
	CONSTRAINT FK_MANV FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_MAKH FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_HDIDBAN FOREIGN KEY (IDBAN) REFERENCES TABLECOFFE(IDBAN),
)
CREATE TABLE CHITIETBANHANG
(
	MAHDBH VARCHAR(10) NOT NULL,
	MASP VARCHAR(10) NOT NULL,
	SOLUONG INT CHECK(SOLUONG >= 0),
	PRIMARY KEY(MAHDBH,MASP),
	CONSTRAINT FK_MAHDBH FOREIGN KEY (MAHDBH) REFERENCES HDBANHANG(MAHDBH),
	CONSTRAINT FK_MASP FOREIGN KEY (MASP) REFERENCES SANPHAM(MASP),
)
CREATE TABLE CHITIETLUONGNV
(
	MACLV VARCHAR(10) NOT NULL ,
	MANV VARCHAR(10) NOT NULL,
	TONGCALVTRONGTHANG INT,
	THANHTIEN INT,
	KYLUONG NVARCHAR(7),
	CONSTRAINT FK_MANV_LUONG FOREIGN KEY (MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_MACLV_LUONG FOREIGN KEY (MACLV) REFERENCES CALAMVIEC(MACLV),
)
CREATE TABLE TABLECOFFE
(
	IDBAN CHAR(5) NOT NULL PRIMARY KEY,
	TENBAN NVARCHAR(30),
	TRANGTHAI NVARCHAR(30) DEFAULT N'Trống'
)



SELECT* FROM NHANVIEN
SELECT* FROM KHACHHANG
SELECT* FROM LOAIKHACHHANG
SELECT* FROM SANPHAM
SELECT* FROM LOAISANPHAM
SELECT* FROM CALAMVIEC
SELECT* FROM HDBANHANG
SELECT* FROM CHITIETBANHANG
SELECT* FROM CHITIETLUONGNV
SELECT* FROM TABLECOFFE