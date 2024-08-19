
USE QL_CAFE

INSERT INTO NHANVIEN (MANV, TENNV, GIOITINH, CHUCVU, NGAYVAOLAM, DIACHI, SDT)
VALUES
    ('AD001', N'Nguyễn Công Dũng', 'Nam', N'Quản lí', '2021-07-15', N'22 Đoàn giỏi', 0983537271),
    ('AD002', N'Ngô Thị Thanh Tuyền', N'Nữ', N'Quản lí', '2021-12-09', N'21 Trần Văn Ơn', 0733251637),
    ('AD003', N'Nguyễn Hữu Sang', 'Nam', N'Quản lí', '2022-02-28', N'Lũy Bán Bích', 0378738737),
    ('NV004', N'Nguyễn Thị Vân', N'Nữ', N'Nhân viên', '2023-09-05', N'Âu Cơ', 0263761638),
    ('NV005', N'Võ Yến Nhi', N'Nữ', N'Nhân viên', '2022-04-20', N'Gò Vấp', 0126376123),
    ('NV006', N'Đoàn Quang Bé', 'Nam', N'Nhân viên', '2023-04-12', N'Phú Nhuận', 0263136191),
    ('NV007', N'Lê Thị Tú', N'Nữ', N'Nhân viên', '2022-06-07', N'Hòa Bình', 0128361913),
    ('NV008', N'Nguyễn Văn An', 'Nam', N'Nhân viên', '2023-05-18', N'Nguyễn Văn Sáng', 0336126328),
    ('NV009', N'Trần Bích Ngân', N'Nữ', N'Nhân viên', '2023-01-03', N'Kinh Dương Vương', 0263673611);


INSERT INTO LOGINNV(MANV,PASSNV)
VALUES
	('AD001','3537'),
	('AD002','2516'),
	('AD003','8738'),
	('NV004','7616'),
	('NV005','6376'),
	('NV006','3136'),
	('NV007','3619'),
	('NV008','1263'),     
	('NV009','6367');
INSERT INTO LOAIKHACHHANG (MALKH, TENLKH, GIAMGIA)
VALUES
    ('LKH002', N'Khách hàng thường', 5),
    ('LKH003', N'Khách hàng tiềm năng', 7),
    ('LKH004', N'Khách hàng trung thành', 8),
    ('LKH001', N'Khách hàng mới', 2);

	-- 0: KH mới; 1-200: KH thường; 200-500:KH Tiềm năng; 500 trở lên: KH trung thành
INSERT INTO KHACHHANG (MAKH, MALKH, TENKH, DIACHI, SDT, DIEMTL)
VALUES
	('KH000', 'LKH001', null , null, null, 0),
    ('KH001', 'LKH001', N'Trần Văn An', N'Nguyễn Huệ', 0987657374, 0),
    ('KH002', 'LKH003', N'Nguyễn Văn Bảo', N'Võ Văn Tần', 0987436136, 220),
    ('KH003', 'LKH002', N'Lê Thị Chi', N'Lê Lai', 0845753958, 150),
    ('KH004', 'LKH001', N'Đinh Văn Lẹ', N'Trần Hưng Đạo', 0769123683, 0),
    ('KH005', 'LKH002', N'Phan Văn Em', N'Điện Biên Phủ', 0364568271, 22),
    ('KH006', 'LKH002', N'Trần Văn Phúc', N'Hàm Nghi', 0918728956, 35),
    ('KH007', 'LKH004', N'Nguyễn Văn Giang', N'Nguyễn Thị Minh Khai', 0773288538, 532),
    ('KH008', 'LKH002', N'Lê Thị Hoài', N'Pasteur', 0856368841, 13),
    ('KH009', 'LKH003', N'Đinh Văn Tín', N'Lý Tự Trọng', 0934649963, 463),
    ('KH010', 'LKH004', N'Phan Văn Khánh', N'Nam Kỳ Khởi Nghĩa', 0887572342, 1523),
    ('KH011', 'LKH004', N'Nguyễn Thị Hương', N'Nguyễn Đình Chiểu', 0796264789, 521),
    ('KH012', 'LKH001', N'Trần Văn Long', N'Hai Bà Trưng', 0975581269, 0),
    ('KH013', 'LKH002', N'Lê Thị Mai Anh', N'Tôn Đức Thắng', 0863638952, 31),
    ('KH014', 'LKH002', N'Phạm Minh Tuấn', N'Bà Huyện Thanh Quan', 0905742789, 160),
    ('KH015', 'LKH002', N'Võ Thanh Hải', N'Hoàng Sa', 0894421178, 32),
    ('KH016', 'LKH004', N'Hoàng Minh Sơn', N'Trường Sa', 0707358821, 942),
    ('KH017', 'LKH003', N'Ngô Ngọc Trâm', N'Đề Thám', 0339472280, 213),
    ('KH018', 'LKH002', N'Lý Quang Huy', N'Lê Duẩn', 0943482276, 56),
    ('KH019', 'LKH003', N'Đặng Thị Thu Hà', N'Nguyễn Văn Cừ', 0872326886, 435),
    ('KH020', 'LKH002', N'Bùi Hữu Đức', N'Cách Mạng Tháng Tám', 0956152225, 152);
INSERT INTO LOGINKH(MAKH,PASSKH)
VALUES
	('KH001','3722'),
	('KH002','7298'),
	('KH003','7647'),
	('KH004','0122'),
	('KH005','2767'),
	('KH006','9836'),
	('KH007','1409'),
	('KH008','2205'),
	('KH009','0405'),
	('KH011','6186'),
	('KH012','7467'),
	('KH013','6836'),
	('KH014','3692'),
	('KH015','7362'),
	('KH016','7812'),
	('KH017','3682'),
	('KH018','3769'),
	('KH019','7619'),
	('KH020','5218');
INSERT INTO LOAISANPHAM (MALSP, TENLSP, MOTA)
VALUES
    ('CF001', N'Cà phê', N'Hương vị đậm đà từ hạt cà phê rang xay.'),
    ('TUD002', N'Thức uống đá', N'Mát lạnh với đá và thêm đường hoặc sữa.'),
    ('TRA003', N'Trà', N'Thức uống từ lá trà, có nhiều loại và hương vị đa dạng.'),
    ('NTC004', N'Nước trái cây', N'Nước ép hoặc pha từ trái cây tươi, tươi mát và ngọt ngào.'),
	('BN005', N'Bánh ngọt', N'Món tráng miệng ngon, hình dạng đẹp, hương vị đa dạng.');
INSERT INTO SANPHAM (MASP, MALSP, TENSP, GIASP,HINHANH)		
VALUES
    ('SP001', 'CF001', N'Cà phê đen', 35000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\1.png'),
    ('SP002', 'CF001', N'Cà phê sữa', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\2.png'),
    ('SP003', 'CF001', N'Cà phê Latte', 50000, N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\3.png'),
    ('SP004', 'CF001', N'Cappuccino', 55000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\4.png'),
    ('SP005', 'CF001', N'Mocha', 55000, N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\5.png'),
    ('SP006', 'CF001', N'Caramel Macchiato', 60000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\6.png'),
    ('SP007', 'TUD002', N'Cà phê đá', 35000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\7.png'),
    ('SP008', 'TUD002', N'Cà phê sữa đá', 40000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\8.png'),
    ('SP009', 'TUD002', N'Frappuccino', 80000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\9.png'),
    ('SP010', 'TUD002', N'Matcha Latte', 60000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\10.png'),
    ('SP011', 'TRA003', N'Trà đen', 30000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\11.png'),
    ('SP012', 'TRA003', N'Trà xanh', 35000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\12.png'),
    ('SP013', 'TRA003', N'Trà bưởi', 40000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\13.png'),
    ('SP014', 'TUD002', N'Soda chanh', 55000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\14.png'),
    ('SP015', 'NTC004', N'Nước ép trái cây', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\15.png'),
	('SP016', 'BN005', N'Bánh Chocolate ganache', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\16.png'),
	('SP017', 'BN005', N'Bánh Red Velvet', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\17.png'),
	('SP018', 'BN005', N'Bánh Carrot cake', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\18.png'),
	('SP019', 'BN005', N'Bánh Matcha Roll', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\19.png'),
	('SP020', 'BN005', N'Bánh Lemon Tart', 45000,N'E:\Bài tập\Kỳ 5\dotNet\QuanLyCafe_FormNew\QuanLyCafe_FormNew\img\20.png');

INSERT INTO CALAMVIEC (MACLV, TENCLV, GIOBD, GIOKT, SOTIEN)
VALUES
    ('CS001', N'Ca sáng', '06:00:00', '12:00:00', 175000),
    ('CC002', N'Ca chiều', '12:00:00', '18:00:00', 1500000),
    ('CT003', N'Ca tối', '18:00:00', '23:00:00', 125000);

INSERT INTO HDBANHANG (MAHDBH, MANV, NGAYHDBH, TONGTIEN, GIAMGIA, MAKH,IDBAN)
VALUES
    ('HDBH01', 'NV004', '2023-09-15', 210000, null, 'KH001','B001'), 
    ('HDBH02', 'NV005', '2023-09-19', 225000, null, 'KH002','B034'),
    ('HDBH03', 'NV006', '2023-08-22', 105000, null, 'KH003','B023'), 
    ('HDBH04', 'NV007', '2023-09-16', 140000, null,'KH004','B004'),
    ('HDBH05', 'NV008', '2023-09-17', 180000, null, 'KH005','B042'),
    ('HDBH06', 'NV009', '2023-09-15', 32000, null, 'KH006','B011'),
    ('HDBH07', 'NV006', '2023-09-16', 45000, null,  'KH007','B005'),
    ('HDBH08', 'NV007', '2023-09-17', 80000, null, 'KH008','B014'),
    ('HDBH09', 'NV008', '2023-09-18', 160000, null ,'KH009','B025'),
    ('HDBH10', 'NV005', '2023-09-19', 90000, null, 'KH010','B007'),
    ('HDBH11', 'NV006', '2023-09-18', 105000, null, 'KH011','B024'),
    ('HDBH12', 'NV007', '2023-09-16', 140000, null,  'KH012','B045'),
    ('HDBH13', 'NV008', '2023-08-22', 180000,  null,  'KH013','B020'),
    ('HDBH14', 'NV009', '2023-09-15', 32000, null, 'KH014','B009'),
    ('HDBH15', 'NV006', '2023-09-16', 210000, null,  'KH015','B010'),
    ('HDBH16', 'NV007', '2023-09-15', 225000, null, 'KH016','B028'),
    ('HDBH17', 'NV008', '2023-09-18', 32000, null, 'KH017','B037'),
    ('HDBH18', 'NV007', '2023-08-22', 45000, null, 'KH018','B041'),
    ('HDBH19', 'NV008', '2023-09-16', 80000, null, 'KH019','B035'),
    ('HDBH20', 'NV005', '2023-08-22', 160000, null, 'KH020','B016'),
    ('HDBH21', 'NV006', '2023-09-19', 650000, null, 'KH008', 'B039'),
    ('HDBH22', 'NV004', '2023-09-19', 200000, null, 'KH012', 'B012'),
    ('HDBH23', 'NV007', '2023-09-19', 150000, null, 'KH003', 'B011'),
    ('HDBH24', 'NV005', '2023-09-19', 250000, null, 'KH016', 'B013'), 
    ('HDBH25', 'NV008', '2023-09-19', 350000, null, 'KH019', 'B015'),
    ('HDBH26', 'NV005', '2023-09-19', 100000, null, 'KH004', 'B018');

INSERT INTO CHITIETBANHANG (MAHDBH, MASP, SOLUONG)
VALUES
    ('HDBH01', 'SP001', 4),
    ('HDBH02', 'SP013', 1),
    ('HDBH03', 'SP007', 9),
    ('HDBH04', 'SP011', 1),
    ('HDBH05', 'SP005', 3),
    ('HDBH06', 'SP006', 3),
    ('HDBH07', 'SP015', 5),
    ('HDBH08', 'SP008', 3),
    ('HDBH09', 'SP012', 1),
    ('HDBH10', 'SP010', 6),
    ('HDBH11', 'SP002', 8),
    ('HDBH12', 'SP014', 1),
    ('HDBH13', 'SP003', 5),
    ('HDBH14', 'SP014', 8),
    ('HDBH15', 'SP008', 3),
    ('HDBH16', 'SP004', 2),
    ('HDBH17', 'SP004', 8),
    ('HDBH18', 'SP009', 3),
    ('HDBH19', 'SP008', 2),
    ('HDBH20', 'SP006', 5);

INSERT INTO CHITIETLUONGNV (MACLV, MANV, TONGCALVTRONGTHANG, THANHTIEN, KYLUONG)
VALUES
    ('CS001', 'AD001', 14, null, 1),
    ('CS001', 'AD002', 14, null, 1),
    ('CS001', 'AD003', 14, null, 1),
    ('CC002', 'NV004', 14, null, 1),
    ('CC002', 'NV005', 14, null, 1),
    ('CC002', 'NV006', 14,null , 1),
    ('CT003', 'NV007', 14, null, 1),
    ('CT003', 'NV008', 14, null, 1),
    ('CT003', 'NV009', 14, null, 1),
	('CS001', 'NV007', 7, null, 1),
    ('CS001', 'NV008', 7, null, 1),
    ('CS001', 'NV009', 7, null, 1),
    ('CC002', 'AD001', 7, null, 1),
    ('CC002', 'AD002', 7, null, 1),
    ('CC002', 'AD003', 7,null , 1),
    ('CT003', 'NV004', 7, null, 1),
    ('CT003', 'NV005', 7, null, 1),
    ('CT003', 'NV006', 7, null, 1),
	('CS001', 'NV004', 7, null, 1),
    ('CS001', 'NV005', 7, null, 1),
    ('CS001', 'NV006', 7, null, 1),
    ('CC002', 'NV007', 7, null, 1),
    ('CC002', 'NV008', 7, null, 1), 
    ('CC002', 'NV009', 7,null , 1),
    ('CT003', 'AD001', 7, null, 1),
    ('CT003', 'AD002', 7, null, 1),
    ('CT003', 'AD003', 7, null, 1);
 
GO
CREATE PROC USP_GetAccoutByUserNameNV
@userName char(10)
AS
BEGIN 
	SELECT* FROM dbo.LOGINNV WHERE MANV = @userName
END
GO



CREATE PROC USP_GettAccoutByUserNameKH
@userName char(10)
AS
BEGIN 
	SELECT* FROM dbo.LOGINKH WHERE MAKH = @userName
END
GO



CREATE PROC USP_GettAccoutByUserNameHD
@userName char(10)
AS
BEGIN 
	SELECT MAHDBH as N'Mã hóa đơn', KHACHHANG.TENKH AS N'Tên khách hàng' , NGAYHDBH as N'Ngày xuất hóa đơn', TONGTIEN as N'Tổng tiền', GIAMGIA as N'Giảm giá', NHANVIEN.TENNV as N'Nhân viên' 
	FROM dbo.HDBANHANG,dbo.NHANVIEN, dbo.KHACHHANG WHERE MAHDBH = @userName and NHANVIEN.MANV = HDBANHANG.MANV AND KHACHHANG.MAKH = HDBANHANG.MAKH
END
GO



GO

CREATE PROC USP_GettAccoutByUserNameMenu
@userName char(10)
AS
BEGIN 
	SELECT MASP AS 'Mã sản phẩm', TENSP as N'Tên nước', TENLSP as N'Loại nước', GIASP as N'Giá'
	FROM dbo.SANPHAM,dbo.LOAISANPHAM WHERE MASP = @userName and LOAISANPHAM.MALSP = SANPHAM.MALSP
END
GO


GO

CREATE PROC USP_GettAccoutByUserNameDSKH
@userName char(10)
AS
BEGIN 
	SELECT MAKH as N'Mã khách hàng', TENKH as N'Tên khách hàng', DIACHI as N'Địa chỉ', SDT as 'Số điện thoại', TENLKH as N'Loại Khách', DIEMTL as N'Điểm tích lũy'
	FROM dbo.KHACHHANG,dbo.LOAIKHACHHANG WHERE MAKH = @userName and KHACHHANG.MALKH = LOAIKHACHHANG.MALKH
END
GO


GO

CREATE PROC USP_GettAccoutByUserNameDSNV
@userName char(10)
AS
BEGIN 
	SELECT MANV as N'Mã nhân viên', TENNV as N'Tên nhân viên', GIOITINH as N'Giới tính', CHUCVU as N'Chức vụ', NGAYVAOLAM as N'Ngày vào làm', DIACHI as N'Địa chỉ', SDT as N'Số điện thoại'
	FROM dbo.NHANVIEN WHERE MANV = @userName
END
GO


GO

CREATE PROC USP_Login
@userName char(20), @passWord char(20)
as
begin
	select * from dbo.LOGINNV where MANV = @userName and PASSNV = @passWord
end 
go

CREATE PROC USP_LoginKH
@userName char(20), @passWord char(20)
as
begin
	select * from dbo.LOGINKH where MAKH = @userName and PASSKH = @passWord
end 
go




DECLARE @i INT = 10
WHILE @i <= 45
BEGIN
	UPDATE dbo.TABLECOFFE SET TENBAN = (N'Bàn ' + CAST(@i AS nvarchar(10))) WHERE IDBAN = ('B0' + CAST(@i AS char(5)))
	SET @i = @i + 1
END

SELECT* FROM TABLECOFFE
Go

CREATE PROC USP_GetTableList
AS SELECT* FROM dbo.TABLECOFFE
Go

CREATE PROC USP_GetMenuList
AS SELECT* FROM dbo.SANPHAM  
Go

DECLARE @i INT = 1
WHILE @i <= 9
BEGIN
	UPDATE TABLECOFFE SET IDBAN = (N'B00' + CAST(@i AS nvarchar(10))) WHERE TENBAN = (N'Bàn ' + CAST(@i AS nvarchar(10)))
	SET @i = @i + 1
END
GO


UPDATE TABLECOFFE
SET TRANGTHAI = N'Có người'
FROM TABLECOFFE
JOIN HDBANHANG ON TABLECOFFE.IDBAN = HDBANHANG.IDBAN
WHERE HDBANHANG.NGAYHDBH = '2023-09-19';

UPDATE TABLECOFFE
SET TRANGTHAI = N'Trống'
FROM TABLECOFFE
WHERE IDBAN = 'B018'


--FORM THANH TOÁN 
CREATE FUNCTION dbo.TTThanhToan (@MAKH VARCHAR(10))
RETURNS TABLE
AS
RETURN
(
    SELECT KH.TENKH, LKH.TENLKH, KH.DIEMTL, LKH.GIAMGIA
    FROM KHACHHANG KH
    JOIN LOAIKHACHHANG LKH ON KH.MALKH = LKH.MALKH
    WHERE KH.MAKH = @MAKH
);

SELECT * FROM dbo.TTThanhToan('KH001')

SELECT* FROM dbo.CHITIETBANHANG 

SELECT NHANVIEN.TENNV AS N'Tên nhân viên', TABLECOFFE.IDBAN AS N'Bàn', SANPHAM.TENSP AS N'Tên sản phẩm', SANPHAM.GIASP AS N'Giá sản phẩm', CHITIETBANHANG.SOLUONG AS N'Số lượng', HDBANHANG.GIAMGIA AS N'Giảm giá',HDBANHANG.TONGTIEN AS N'Tổng tiền'
FROM dbo.NHANVIEN,dbo.SANPHAM,dbo.HDBANHANG,dbo.CHITIETBANHANG,dbo.TABLECOFFE
WHERE CHITIETBANHANG.MAHDBH = HDBANHANG.MAHDBH AND HDBANHANG.MANV = NHANVIEN.MANV AND HDBANHANG.IDBAN = TABLECOFFE.IDBAN AND CHITIETBANHANG.MASP = SANPHAM.MASP

DELETE FROM CHITIETBANHANG
INSERT INTO CHITIETBANHANG (MAHDBH, MASP, SOLUONG)
VALUES
    ('HDBH01', 'SP001', 4),
    ('HDBH02', 'SP013', 1),
    ('HDBH03', 'SP007', 9),
    ('HDBH04', 'SP011', 1),
    ('HDBH05', 'SP005', 3),
    ('HDBH06', 'SP006', 3),
    ('HDBH07', 'SP015', 5),
    ('HDBH08', 'SP008', 3),
    ('HDBH09', 'SP012', 1),
    ('HDBH10', 'SP010', 6),
    ('HDBH11', 'SP002', 8),
    ('HDBH12', 'SP014', 1),
    ('HDBH13', 'SP003', 5),
    ('HDBH14', 'SP014', 8),
    ('HDBH15', 'SP008', 3),
    ('HDBH16', 'SP004', 2),
    ('HDBH17', 'SP004', 8),
    ('HDBH18', 'SP009', 3),
    ('HDBH19', 'SP008', 2),
    ('HDBH20', 'SP006', 5),
	('HDBH21', 'SP016', 3),
    ('HDBH22', 'SP020', 2),
    ('HDBH23', 'SP018', 8),
    ('HDBH24', 'SP019', 3),
    ('HDBH25', 'SP017', 2);


	-- UPDATE BẢNG 

UPDATE HDBANHANG
SET GIAMGIA = 5
WHERE MAKH IN (
    SELECT MAKH FROM KHACHHANG WHERE MALKH = 'LKH002'
);

UPDATE HDBANHANG
SET GIAMGIA = 7
WHERE MAKH IN (
    SELECT MAKH FROM KHACHHANG WHERE MALKH = 'LKH003'
);

UPDATE HDBANHANG
SET GIAMGIA = 8
WHERE MAKH IN (
    SELECT MAKH FROM KHACHHANG WHERE MALKH = 'LKH004'
);

UPDATE HDBANHANG
SET GIAMGIA = 2
WHERE MAKH IN (
    SELECT MAKH FROM KHACHHANG WHERE MALKH = 'LKH001'
);
-- UPDATE TÔNG TIỀN 
UPDATE HDBANHANG
SET TONGTIEN = (
    SELECT SUM(SANPHAM.GIASP * CHITIETBANHANG.SOLUONG) - (SUM(SANPHAM.GIASP * CHITIETBANHANG.SOLUONG) * HDBANHANG.GIAMGIA / 100)
    FROM CHITIETBANHANG
    INNER JOIN SANPHAM ON CHITIETBANHANG.MASP = SANPHAM.MASP
    WHERE CHITIETBANHANG.MAHDBH = HDBANHANG.MAHDBH
)
--TIỀN LƯƠNG NHÂN VIÊN 
select * from CHITIETLUONGNV
UPDATE CHITIETLUONGNV
SET THANHTIEN = CHITIETLUONGNV.TONGCALVTRONGTHANG *CALAMVIEC.SOTIEN
FROM CHITIETLUONGNV 
JOIN CALAMVIEC ON CHITIETLUONGNV.MACLV = CALAMVIEC.MACLV


CREATE FUNCTION dbo.GetSalesData(@id CHAR(5))
RETURNS TABLE
AS
RETURN
(
    SELECT 
        NV.TENNV,
        TC.TENBAN,
        SP.TENSP,
        SP.GIASP,
        CTBH.SOLUONG,
        BH.GIAMGIA,
        BH.TONGTIEN,
		BH.NGAYHDBH
    FROM 
        dbo.NHANVIEN NV
        JOIN dbo.HDBANHANG BH ON BH.MANV = NV.MANV
        JOIN dbo.CHITIETBANHANG CTBH ON CTBH.MAHDBH = BH.MAHDBH
        JOIN dbo.TABLECOFFE TC ON TC.IDBAN = BH.IDBAN
        JOIN dbo.SANPHAM SP ON SP.MASP = CTBH.MASP
    WHERE
        TC.IDBAN = @id
)
SELECT * FROM dbo.GetSalesData('B001');

DELETE FROM HDBANHANG
WHERE IDBAN = 'B018';

Select TENNV,TENBAN,TENSP from NHANVIEN,HDBANHANG,TABLECOFFE,SANPHAM,CHITIETBANHANG WHERE NHANVIEN.MANV = HDBANHANG.MANV AND HDBANHANG.IDBAN = TABLECOFFE.IDBAN AND CHITIETBANHANG.MAHDBH = HDBANHANG.MAHDBH AND CHITIETBANHANG.MASP = SANPHAM.MASP AND HDBANHANG.IDBAN = 'B001'
Go

CREATE FUNCTION dbo.GetSalesDataTable(@id CHAR(5))
RETURNS TABLE
AS
RETURN
(
    SELECT 
        SP.TENSP,
        CTBH.SOLUONG,
        SP.GIASP,
        BH.TONGTIEN,
		BH.NGAYHDBH
    FROM 
        dbo.NHANVIEN NV
        JOIN dbo.HDBANHANG BH ON BH.MANV = NV.MANV
        JOIN dbo.CHITIETBANHANG CTBH ON CTBH.MAHDBH = BH.MAHDBH
        JOIN dbo.TABLECOFFE TC ON TC.IDBAN = BH.IDBAN
        JOIN dbo.SANPHAM SP ON SP.MASP = CTBH.MASP
    WHERE
        TC.IDBAN = @id
)

SELECT * FROM dbo.GetSalesData('B001');

select TENSP,GIASP from dbo.SANPHAM  
go

CREATE PROCEDURE USP_InsertBil
    @idTable char(5),
    @tongtien int
AS
BEGIN
    DECLARE @currentNo int
    DECLARE @nextNo int
    DECLARE @nextMAHDBH varchar(10)
    DECLARE @randomEmployeeId char(5)

    -- Lấy giá trị cuối cùng của MAHDBH trong bảng HDBANHANG
    SELECT @currentNo = SUBSTRING(MAX(MAHDBH), 5, 2)
    FROM dbo.HDBANHANG

    -- Tăng giá trị hiện tại lên 1
    SET @nextNo = @currentNo + 1

    -- Tạo giá trị MAHDBH mới
    SET @nextMAHDBH = 'HDBH' + RIGHT('00' + CAST(@nextNo AS varchar), 2)

    -- Lấy mã nhân viên ngẫu nhiên từ bảng NHANVIEN
    SELECT TOP 1 @randomEmployeeId = MANV
    FROM dbo.NHANVIEN
    ORDER BY NEWID()

    -- Chèn dữ liệu vào bảng HDBANHANG với MAHDBH mới và mã nhân viên ngẫu nhiên
    INSERT INTO dbo.HDBANHANG (MAHDBH, MANV, NGAYHDBH, TONGTIEN, GIAMGIA, MAKH, IDBAN)
    VALUES (@nextMAHDBH, @randomEmployeeId, '2023-09-19' , @tongtien, NULL , 'KH000', @idTable)
END
go

EXEC USP_InsertBil @idTable = 'B003', @tongtien = 400000;

go
CREATE PROC USP_InsertBillInfo
@idBill varchar(10) , @idFood char(5) , @count int
as
begin

	declare @isExitsBillinfo varchar(10);
	declare @foodCount int = 1
	select @isExitsBillinfo = MAHDBH, @foodCount = SOLUONG from dbo.CHITIETBANHANG where MAHDBH = @idBill and MASP = @idFood
	if(@isExitsBillinfo is not null)
	begin
		declare @newCount int = @foodCount + @count
		if(@newCount > 0)
			update dbo.CHITIETBANHANG set SOLUONG = @newCount where MAHDBH = @idBill and MASP = @idFood
		else
			delete dbo.CHITIETBANHANG where MAHDBH = @idBill and MASP = @idFood
			DELETE FROM dbo.HDBANHANG
			WHERE MAHDBH = @idBill
	end
	else
	begin
		INSERT INTO dbo.CHITIETBANHANG (MAHDBH , MASP , SOLUONG)
		VALUES (@idBill , @idFood , @count)
	end

end
go

exec USP_InsertBillInfo @idBill = 'HDBH26', @idFood = 'SP003', @count = -5;

INSERT INTO dbo.CHITIETBANHANG (MAHDBH , MASP , SOLUONG)
VALUES ('HDBH26' , 'SP003' , 4)

Select MAX(MAHDBH) from dbo.HDBANHANG

SELECT* FROM NHANVIEN
SELECT* FROM dbo.LOGINNV
SELECT* FROM dbo.LOGINKH
SELECT* FROM KHACHHANG
SELECT* FROM LOAIKHACHHANG
SELECT* FROM SANPHAM
SELECT* FROM LOAISANPHAM
SELECT* FROM CALAMVIEC
SELECT* FROM HDBANHANG 
SELECT* FROM CHITIETBANHANG
SELECT* FROM CHITIETLUONGNV
SELECT* FROM TABLECOFFE

--Tắt khóa ngoại tạm thời
ALTER TABLE CHITIETBANHANG
NOCHECK CONSTRAINT FK_MASP

ALTER TABLE CHITIETBANHANG
NOCHECK CONSTRAINT FK_MAHDBH

--Bật lại khóa ngoại
ALTER TABLE CHITIETBANHANG
WITH CHECK CHECK CONSTRAINT FK_MASP;

ALTER TABLE CHITIETBANHANG
WITH CHECK CHECK CONSTRAINT FK_MAHDBH;

SELECT* FROM dbo.HDBANHANG WHERE NGAYHDBH = '2023-09-19'

CREATE PROCEDURE dbo.UpdateTableStatusByCoffee
    @idBan INT,
    @ngayHDBH DATE
AS
BEGIN
    DECLARE @trangThai NVARCHAR(50);

    UPDATE TABLECOFFE 
    SET @trangThai = 
        CASE 
            WHEN HDBANHANG.IDBAN IS NULL THEN N'Trống'
            ELSE N'Có người'
        END
    FROM TABLECOFFE 
    LEFT JOIN HDBANHANG ON TABLECOFFE.IDBAN = HDBANHANG.IDBAN 
    WHERE TABLECOFFE.IDBAN = @idBan
          AND CONVERT(DATE, ISNULL(HDBANHANG.NGAYHDBH, GETDATE())) = @ngayHDBH;

END;

EXEC dbo.UpdateTableStatusByCoffee()
EXEC sp_helpconstraint 'CHITIETBANHANG';

ALTER TABLE CHITIETBANHANG
DROP CONSTRAINT PK__CHITIETB__2C72D016E21BA0D5

DELETE FROM CHITIETBANHANG
WHERE MAHDBH = 'HDBH28';
Go
CREATE TRIGGER UpdateTableStatusTrigger
ON HDBANHANG
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật TRANGTHAI trong TABLECOFFE khi có HDBANHANG được thêm vào
    UPDATE tc
    SET TRANGTHAI = CASE
                        WHEN i.IDBAN IS NOT NULL THEN N'Có người'
                        ELSE N'Trống'
                    END
    FROM TABLECOFFE tc
    LEFT JOIN inserted i ON tc.IDBAN = i.IDBAN;

END;
go

CREATE PROCEDURE UpdateTableStatusProcedure
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật TRANGTHAI trong TABLECOFFE dựa trên có hoặc không có HDBANHANG
    UPDATE tc
    SET TRANGTHAI = CASE
                        WHEN hb.IDBAN IS NOT NULL THEN N'Có người'
                        ELSE N'Trống'
                    END
    FROM TABLECOFFE tc
    LEFT JOIN HDBANHANG hb ON tc.IDBAN = hb.IDBAN;
END;

EXEC UpdateTableStatusProcedure;
go

CREATE PROCEDURE UpdateTableStatusProcedures
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật TRANGTHAI trong TABLECOFFE dựa trên có hoặc không có HDBANHANG vào ngày cụ thể
    UPDATE tc
    SET TRANGTHAI = CASE
                        WHEN hb.IDBAN IS NOT NULL THEN N'Có người'
                        ELSE N'Trống'
                    END
    FROM TABLECOFFE tc
    LEFT JOIN HDBANHANG hb ON tc.IDBAN = hb.IDBAN
                          AND CONVERT(DATE, ISNULL(hb.NGAYHDBH, GETDATE())) = '2023-09-19';
END;

EXEC UpdateTableStatusProcedures;