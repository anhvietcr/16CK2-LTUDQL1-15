USE [QuanLyVeXe]
GO
/****** Object:  StoredProcedure [dbo].[newTram]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[listTenTram]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[newTuyen]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[getTuyenIDTuyenbyTuyen]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[GetTuyenById]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[getTenTrambyTuyen]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteTuyenXe]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[updateTramDen]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[listTuyenXe]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[ListTuyen]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateTuyenXe]    Script Date: 01/07/2019 21:44:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[UpdateTuyenXe]
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
/****** Object:  StoredProcedure [dbo].[updateTuyen]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertTramTrungGian]    Script Date: 01/07/2019 21:44:57 ******/
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
/****** Object:  StoredProcedure [dbo].[checkExistsTenTramInTuyen]    Script Date: 01/07/2019 21:44:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[checkExistsTenTramInTuyen]
@id_Tram int,
@id_Tuyen int
as
begin
	select * from Tram_trung_gian t
	where @id_Tram=t.Tram_ID_Tram and t.Tuyen_ID_Tuyen=@id_Tuyen
end
GO
/****** Object:  StoredProcedure [dbo].[getIDTramIDTuyen]    Script Date: 01/07/2019 21:44:57 ******/
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
