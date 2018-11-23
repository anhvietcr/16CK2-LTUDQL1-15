CREATE TABLE Ve (
	ID_Ve int Primary key not null,
	Ghe_ID_Ghe int,
	Chuyen_ID_Chuyen int,
	TinhTrang int,
	GiaTien real,
	KhachHang_ID_KhachHang int,
	NgayXuatVe date,
	GhiChu nvarchar(4000)
)

alter table Ve
   add constraint Ve_Ghe_FK foreign key (Ghe_ID_Ghe)
      references Ghe (ID_Ghe)
go

alter table Ve
   add constraint Ve_Chuyen_FK foreign key (Chuyen_ID_Chuyen)
      references Chuyen (ID_Chuyen)
go

alter table Ve
   add constraint Ve_KhachHang_FK foreign key (KhachHang_ID_KhachHang)
      references KhachHang (ID_KhachHang)
go