create proc ReportTruyen
		@NgayBD datetime,
		@NgayKT datetime
as
	select t.ID_Tuyen,c.ID_Chuyen,x.So_dang_ky,COUNT(v.ID_Ve) as SLV,v.GiaTien ,Sum(v.GiaTien) as total
	from Tuyen t join Chuyen c
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen
							join Xe x 
							on x.XeID=c.Xe_XeID
							join Ve v
							on v.Chuyen_ID_Chuyen=c.ID_Chuyen
					where c.Gio_khoi_hanh>=@NgayBD and c.Gio_khoi_hanh<@NgayKT and
						v.Chuyen_ID_Chuyen=c.ID_Chuyen 
	group by v.Chuyen_ID_Chuyen,t.ID_Tuyen,x.So_dang_ky,v.GiaTien,c.ID_Chuyen

go
create proc ReportVe
as
		select ve.NgayXuatVe,ve.ID_Ve,ve.TinhTrang,ve.GiaTien,kh.HoTen
		from Ve join KhachHang kh
				on ve.KhachHang_ID_KhachHang=kh.ID_KhachHang 
go

create proc ReportVeNgay	@Ngay date
as		
		select ve.NgayXuatVe,ve.ID_Ve,ve.TinhTrang,ve.GiaTien,kh.HoTen ,kh.ID_KhachHang,ve.Chuyen_ID_Chuyen
		from Ve join KhachHang kh
				on ve.KhachHang_ID_KhachHang=kh.ID_KhachHang 
		where ve.NgayXuatVe=@Ngay

