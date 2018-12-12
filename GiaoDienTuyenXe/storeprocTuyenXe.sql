USE [QuanLyVeXe]
GO
/****** Object:  StoredProcedure [dbo].[listTenTram]    Script Date: 12/12/2018 20:13:17 ******/
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
/****** Object:  StoredProcedure [dbo].[newTram]    Script Date: 12/12/2018 20:13:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[newTram]
@tenTram nvarchar(4000),
@diaDiem nvarchar(4000)
as
begin
	declare @idTram int
	select @idTram=COUNT(*) from Tram
	set @idTram+=1
	insert into Tram values(@idTram,@tenTram,@diaDiem)	
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateTuyenXe]    Script Date: 12/12/2018 20:13:17 ******/
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
/****** Object:  StoredProcedure [dbo].[listTuyenXe]    Script Date: 12/12/2018 20:13:17 ******/
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
/****** Object:  StoredProcedure [dbo].[ListTuyen]    Script Date: 12/12/2018 20:13:17 ******/
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
/****** Object:  StoredProcedure [dbo].[newTuyen]    Script Date: 12/12/2018 20:13:17 ******/
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
	declare @idTuyen int
	select @idTuyen=COUNT(*) from Tuyen
	set @idTuyen+=1
	insert into Tuyen values(@idTuyen, @khoangCach, @thoiGianChay, @tram_id_Tram1, @tram_id_Tram2)
end
GO
/****** Object:  StoredProcedure [dbo].[GetTuyenById]    Script Date: 12/12/2018 20:13:17 ******/
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
/****** Object:  StoredProcedure [dbo].[getTenTrambyTuyen]    Script Date: 12/12/2018 20:13:17 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteTuyenXe]    Script Date: 12/12/2018 20:13:17 ******/
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
