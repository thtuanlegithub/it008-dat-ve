create table Ve
(
	MaKH varchar(20),
	TenKH nvarchar(100),
	DiaChi nvarchar(200),
	NgheNghiep nvarchar(100),
	SoLuongVe int,
	DonGia money,
	ThanhTien money,
	Thue money,
	GiamGia money,
	TongTien money,
	constraint PK_Ve primary key (MaKH)
)