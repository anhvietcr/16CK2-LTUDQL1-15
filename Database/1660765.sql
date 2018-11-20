CREATE TABLE Ve (
	ID_Ve int Primary key not null,
	Ghe_ID_Ghe int,
	Chuyen_ID_Chuyen int,
	TinhTrang int,
	GiaTien real,
	KhachHang_ID_KhachHang int,
	NgayXuatVe date,
	GhiChu varchar(4000)
)