USE [QuanLyVeXe]
GO
/****** Object:  StoredProcedure [dbo].[listTram]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listTram]
as
begin
	select * from Tram
end
GO
/****** Object:  StoredProcedure [dbo].[listTenTram]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listTenTram]
as
begin
	select TenTram, ID_Tram from Tram
end
GO
/****** Object:  StoredProcedure [dbo].[listKhachHang]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listKhachHang]
as begin
	select * from KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[checkExistsTenTramInTram]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[checkExistsTenTramInTram]
@tenTram nvarchar(50),
@diaDiem nvarchar(100)
as
begin
	select * from Tram t
	where TenTram=@tenTram and Dia_diem=@diaDiem
end
GO
/****** Object:  StoredProcedure [dbo].[timkhachhangtheotenhoacsdt]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timkhachhangtheotenhoacsdt]
@ma nvarchar(50)
as begin
	select * from KhachHang where HoTen like '%'+@ma+'%' or DienThoai like '%'+@ma+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoTen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timKhachHangTheoTen]
@ten nvarchar(4000)
as begin
	select * from KhachHang where HoTen=@ten
end
GO
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoSDT]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timKhachHangTheoSDT]
@sdt nchar(4000)
as begin
	select * from KhachHang where DienThoai=@sdt
end
GO
/****** Object:  StoredProcedure [dbo].[themkhachhang]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[themkhachhang]
@tenkh nvarchar(30),@sdt varchar(20),@email nvarchar(50),@loai int
as begin
	insert into KhachHang values(@tenkh,@sdt,@email,@loai);
	SELECT SCOPE_IDENTITY()
end
GO
/****** Object:  StoredProcedure [dbo].[taoKhachHang]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[taoKhachHang]
@ten nvarchar(4000), @sdt varchar(4000), @email nvarchar(4000), @loai int
as begin
	insert into KhachHang values(@ten, @sdt, @email, @loai)
end
GO
/****** Object:  StoredProcedure [dbo].[xoaTram]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoaTram]
@id_Tram int
as
begin
	delete from Tram where ID_Tram=@id_Tram
end
GO
/****** Object:  StoredProcedure [dbo].[xoakhachhang]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoakhachhang]
@makh int
as begin
	delete from KhachHang where ID_KhachHang=@makh
end
GO
/****** Object:  StoredProcedure [dbo].[listcbbLoai]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listcbbLoai]
AS
begin
	select TenLoai from LoaiXe
end
GO
/****** Object:  StoredProcedure [dbo].[suaTram]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[suaTram]
@id_Tram int,
@ten_Tram nvarchar(50),
@dia_Diem nvarchar(100)
as
begin
	update Tram set 
					TenTram=@ten_Tram,
					Dia_diem=@dia_Diem
	where ID_Tram=@id_Tram
end
GO
/****** Object:  StoredProcedure [dbo].[suakhachhang]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[suakhachhang]
@makh int, @tenkh nvarchar(30),@sdt varchar(20),@email nvarchar(50),@loai int
as begin
	update KhachHang set HoTen=@tenkh, DienThoai=@sdt, Email = @email, Loai = @loai where ID_KhachHang=@makh
end
GO
/****** Object:  StoredProcedure [dbo].[newTram]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[newTram]
@tenTram nvarchar(4000),
@diaDiem nvarchar(4000)
as
begin
	insert into Tram values(@tenTram,@diaDiem)	
end
GO
/****** Object:  StoredProcedure [dbo].[updateTramDen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTramDen]
@id_Tuyen int,
@id_TramDen int
as
begin
	update Tuyen set Tram_ID_Tram=@id_TramDen
	where @id_Tuyen=ID_Tuyen
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateTuyenXe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateTuyenXe]
@idTuyen int out,
@khoangCach real,
@thoiGianChay int,
@tram_id_Tram1 int,
@tram_id_Tram2 int
as
begin
update Tuyen set KhoangCach=@khoangCach,
				 ThoiGianChay=@thoiGianChay,
				 Tram_ID_Tram1=@tram_id_Tram1,
				 Tram_ID_Tram=@tram_id_Tram2
where ID_Tuyen=@idTuyen
end
GO
/****** Object:  StoredProcedure [dbo].[listcbbTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listcbbTuyen]
AS
begin
	select ID_Tuyen from Tuyen
end
GO
/****** Object:  StoredProcedure [dbo].[newTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[newTuyen] 
@khoangCach real,
@thoiGianChay int,
@tram_id_Tram1 int,
@tram_id_Tram2 int
as
begin
	insert into Tuyen values(@khoangCach, @thoiGianChay, @tram_id_Tram1, @tram_id_Tram2)
end
GO
/****** Object:  StoredProcedure [dbo].[listXe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listXe]
as
select * from Xe
GO
/****** Object:  StoredProcedure [dbo].[listTuyenXe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[listTuyenXe]
as
begin
	select * from Tuyen 
end
GO
/****** Object:  StoredProcedure [dbo].[ListTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ListTuyen]
as
	begin
		select * from Tuyen
	end
GO
/****** Object:  StoredProcedure [dbo].[getXeById]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getXeById]
	@id int
as begin
	select * from Xe where XeID = @id
end
GO
/****** Object:  StoredProcedure [dbo].[getTuyenIDTuyenbyTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getTuyenIDTuyenbyTuyen]
as
begin
	select t.ID_Tuyen
	from  Tuyen t 
end
GO
/****** Object:  StoredProcedure [dbo].[GetTuyenById]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetTuyenById]
@idTuyen int
as
begin
select distinct(t.ID_Tuyen), tram_bat_dau.TenTram as TramBatDau, tram_ket_thuc.TenTram as TramKetThuc, tram_bat_dau.ID_Tram as IDTramBatDau, tram_ket_thuc.ID_Tram as IDTramKetThuc
from Tuyen t,
	(select * from Tram tr) as tram_bat_dau,
	 (select * from Tram tr) as tram_ket_thuc
where t.Tram_ID_Tram1 = tram_bat_dau.ID_Tram
and t.Tram_ID_Tram = tram_ket_thuc.ID_Tram
and t.ID_Tuyen = @idTuyen
end
GO
/****** Object:  StoredProcedure [dbo].[getTenTrambyTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getTenTrambyTuyen]
as 
begin
select distinct(t.ID_Tuyen), tram_bat_dau.TenTram as TramBatDau, tram_ket_thuc.TenTram as TramKetThuc, tram_bat_dau.ID_Tram as IDTramBatDau, tram_ket_thuc.ID_Tram as IDTramKetThuc
from Tuyen t,
	(select * from Tram tr) as tram_bat_dau,
	 (select * from Tram tr) as tram_ket_thuc
where t.Tram_ID_Tram1 = tram_bat_dau.ID_Tram
and t.Tram_ID_Tram = tram_ket_thuc.ID_Tram
end
GO
/****** Object:  StoredProcedure [dbo].[kiemTraTenTramInTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[kiemTraTenTramInTuyen]
@id_TramDi int,
@id_TramDen int
as
begin
	Select * from Tuyen
	where Tram_ID_Tram1=@id_TramDi and Tram_ID_Tram=@id_TramDen
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteTuyenXe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteTuyenXe]
@idTuyen int out
as
begin
	delete from Tuyen where ID_Tuyen=@idTuyen
end
GO
/****** Object:  StoredProcedure [dbo].[listChuyenSearch]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listChuyenSearch](@Tu nvarchar(50),@Den nvarchar(50))
as
begin
		if @Tu!='%%' and @Den = '%%'
		begin 
			select distinct c.*
			from Chuyen c join Tuyen t
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen
							join Tram_trung_gian ttg
							on ttg.Tuyen_ID_Tuyen=t.ID_Tuyen
			where t.Tram_ID_Tram1 in (select ID_Tram from Tram where Dia_diem like @Tu)	
		end 
		else
		if @Den !='%%' and @Tu = '%%'
		begin
			select distinct c.*
			from Chuyen c join Tuyen t
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen	
							join Tram_trung_gian ttg
							on ttg.Tuyen_ID_Tuyen=t.ID_Tuyen						
			where t.Tram_ID_Tram in (select ID_Tram from Tram where Dia_diem like @Den) or ttg.Tram_ID_Tram in(select ID_Tram from Tram where Dia_diem like @Den)
		end
		else
		begin
			select distinct c.*
			from Chuyen c join Tuyen t
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen	
							join Tram_trung_gian ttg
							on ttg.Tuyen_ID_Tuyen=t.ID_Tuyen						
			where t.Tram_ID_Tram1 in (select ID_Tram from Tram where Dia_diem like @Tu) and t.Tram_ID_Tram in (select ID_Tram from Tram where Dia_diem like @Den) or ttg.Tram_ID_Tram in(select ID_Tram from Tram where Dia_diem like @Den)
			
		end
end
GO
/****** Object:  StoredProcedure [dbo].[listChuyenDK]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listChuyenDK](@Tuyen int,
								@Chuyen int,
								@Loai nvarchar(4000))

AS
begin
--Trường hợp @Chuyen not null
	if  @Chuyen != -1
	begin
	select *
	from Chuyen c
	where c.ID_Chuyen=@Chuyen
	end
--trường hợp @tuyen,@Loai not null 
	if  @Tuyen != -1 and @Loai!='All'
	begin
		select c.*
		from Chuyen c join Tuyen t 
						on c.Tuyen_ID_Tuyen=t.ID_Tuyen
						join Xe x
						on x.XeID=c.Xe_XeID
						join LoaiXe l
						on l.ID_LoaiXe=x.LoaiXe_ID_LoaiXe
						
		where t.ID_Tuyen=@Tuyen and l.TenLoai=@Loai
	end
--Trường hợp @ tuyen not null, con lại null
if @Tuyen is not null and @Tuyen != -1
	begin
		select c.*
		from Chuyen c join Tuyen t 
						on c.Tuyen_ID_Tuyen=t.ID_Tuyen
		where t.ID_Tuyen=@Tuyen
	end


 --Trường @Loai not null, con lại null
 if @Loai !='All'
	begin
		select c.*
		from Chuyen c join Xe x
						on c.Xe_XeID= x.XeID
						join LoaiXe l
						on l.ID_LoaiXe=x.LoaiXe_ID_LoaiXe
		where l.TenLoai=@Loai
	end
 end
GO
/****** Object:  StoredProcedure [dbo].[listChuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listChuyen]
AS
 select * from Chuyen
GO
/****** Object:  StoredProcedure [dbo].[listChonGhe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listChonGhe]
	@idTuyen int,
	@ngayKH datetime
as
	select c.ID_Chuyen,x.XeID,x.TenXe,lx.ID_LoaiXe,lx.TenLoai from Chuyen c join xe x 
							on c.Xe_XeID=x.XeID
							join LoaiXe lx
							on lx.ID_LoaiXe=x.LoaiXe_ID_LoaiXe
			where  c.Tuyen_ID_Tuyen=@idTuyen and c.Gio_khoi_hanh=@ngayKH
GO
/****** Object:  StoredProcedure [dbo].[deleteChuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteChuyen](@ID_Chuyen int)
as
delete from Chuyen where ID_Chuyen=@ID_Chuyen
GO
/****** Object:  StoredProcedure [dbo].[InsertTramTrungGian]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertTramTrungGian]
@id_Tuyen int,
@id_Tram int
as
begin
	declare @stt int
	select @stt=COUNT(Thu_tu) from Tram_trung_gian ttg
	where @id_Tuyen=ttg.Tuyen_ID_Tuyen
	set @stt+=1
	insert into Tram_trung_gian values(@id_Tuyen,@id_Tram,@stt)
end
GO
/****** Object:  StoredProcedure [dbo].[insertChuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertChuyen](@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
insert into Chuyen(Tuyen_ID_Tuyen,Gio_khoi_hanh,Ghi_chu,Xe_XeID,Tai_xe_ID_TaiXe) values(@Tuyen, @GKH, @Ghichu,@Xe ,@TaiXe)
GO
/****** Object:  StoredProcedure [dbo].[getIDTramIDTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getIDTramIDTuyen]
as
begin
	select distinct(tr_tg.Tuyen_ID_Tuyen),tr_tg.Tram_ID_Tram
	from Tram_trung_gian tr_tg join Tram tr on tr_tg.Tram_ID_Tram=tr.ID_Tram
								join Tuyen t on tr_tg.Tuyen_ID_Tuyen=t.ID_Tuyen
end
GO
/****** Object:  StoredProcedure [dbo].[getGheById]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getGheById]
	@id int
as begin
	select * from Ghe where ID_Ghe = @id
end
GO
/****** Object:  StoredProcedure [dbo].[listcbbChuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listcbbChuyen]
AS
begin
	select ID_Chuyen from Chuyen
end
GO
/****** Object:  StoredProcedure [dbo].[updateChuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
update Chuyen set Tuyen_ID_Tuyen=@Tuyen, Gio_khoi_hanh=@GKH, Ghi_chu=@Ghichu,Xe_XeID=@Xe,Tai_xe_ID_TaiXe=@TaiXe where ID_Chuyen=@ID_Chuyen
GO
/****** Object:  StoredProcedure [dbo].[updateTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTuyen]
@id_Tuyen int
--@id_TramDen int
as
begin
	select top 1 Tram_ID_Tram
	from Tram_trung_gian 
	where @id_Tuyen=Tuyen_ID_Tuyen 
	order by Thu_tu desc
end
GO
/****** Object:  StoredProcedure [dbo].[updateTinhtrangVe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTinhtrangVe]
	@id int,
	@tinhTrang int
as begin
	Update Ve set TinhTrang = @tinhTrang where ID_Ve = @id 
end
GO
/****** Object:  StoredProcedure [dbo].[ReportVeNgay]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReportVeNgay]	
	@Ngay date
as		
		select ve.NgayXuatVe,ve.ID_Ve,ve.TinhTrang,ve.GiaTien,kh.HoTen ,kh.ID_KhachHang,ve.Chuyen_ID_Chuyen
		from Ve join KhachHang kh
				on ve.KhachHang_ID_KhachHang=kh.ID_KhachHang 
		where ve.NgayXuatVe=@Ngay
GO
/****** Object:  StoredProcedure [dbo].[ReportVe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReportVe]
as
		select ve.NgayXuatVe,ve.ID_Ve,ve.TinhTrang,ve.GiaTien,kh.HoTen
		from Ve join KhachHang kh
				on ve.KhachHang_ID_KhachHang=kh.ID_KhachHang
GO
/****** Object:  StoredProcedure [dbo].[ReportTuyen]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ReportTuyen]
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
GO
/****** Object:  StoredProcedure [dbo].[newVe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[newVe]
	@id_ghe int,
	@id_chuyen int,
	@tinhTrang int,
	@giaTien real,
	@id_KhachHang int,
	@ngayXuatVe date,
	@ghiChu nvarchar(4000)
as begin
	insert into Ve(Ghe_ID_Ghe, Chuyen_ID_Chuyen, TinhTrang, GiaTien, KhachHang_ID_KhachHang, NgayXuatVe, GhiChu)
	values (@id_ghe, @id_chuyen, @tinhTrang, @giaTien, @id_KhachHang, GETDATE(), @ghiChu);
end
GO
/****** Object:  StoredProcedure [dbo].[listVe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listVe]
as begin

	select * from Ve
end
GO
/****** Object:  StoredProcedure [dbo].[getGheByChuyenAndXe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getGheByChuyenAndXe]
	@id_chuyen int,
	@id_xe int
as begin
	select g.ID_Ghe 
	from Ghe as g
		, Chuyen as c
		, Ve as v
	where c.ID_Chuyen = v.Chuyen_ID_Chuyen
	and g.ID_Ghe = v.Ghe_ID_Ghe
	and c.ID_Chuyen = @id_chuyen
	and c.Xe_XeID = @id_xe
end
GO
/****** Object:  StoredProcedure [dbo].[deleteVe]    Script Date: 01/08/2019 02:09:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteVe]
	@id int
as begin

	DELETE Ve where ID_Ve = @id

end
GO
