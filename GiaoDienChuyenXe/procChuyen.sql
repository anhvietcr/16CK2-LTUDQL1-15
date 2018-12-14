USE [QuanLyVeXe]
GO
/****** Object:  StoredProcedure [dbo].[deleteChuyen]    Script Date: 12/14/2018 11:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteChuyen](@ID_Chuyen int)
as
delete from Chuyen where ID_Chuyen=@ID_Chuyen 

GO
/****** Object:  StoredProcedure [dbo].[insertChuyen]    Script Date: 12/14/2018 11:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
insert into Chuyen values(@ID_Chuyen,@Tuyen, @GKH, @Ghichu,@Xe ,@TaiXe)
GO
/****** Object:  StoredProcedure [dbo].[listcbbChuyen]    Script Date: 12/14/2018 11:02:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[listcbbLoai]    Script Date: 12/14/2018 11:02:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[listcbbTuyen]    Script Date: 12/14/2018 11:02:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[listChonGhe]    Script Date: 12/14/2018 11:02:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[listChuyen]    Script Date: 12/14/2018 11:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listChuyen]
AS
 select * from Chuyen
GO
/****** Object:  StoredProcedure [dbo].[listChuyenDK]    Script Date: 12/14/2018 11:02:26 AM ******/
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
/****** Object:  StoredProcedure [dbo].[listChuyenSearch]    Script Date: 12/14/2018 11:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listChuyenSearch](@Tu nvarchar(50),@Den nvarchar(50))
as
begin
		if @Tu is not null and @Den = null
		begin 
			select c.*
			from Chuyen c join Tuyen t
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen							
			where t.Tram_ID_Tram in (select ID_Tram from Tram where Dia_diem like @Tu)
		end 
		else
		if @Den is not null and @Tu = null
		begin
					select c.*
			from Chuyen c join Tuyen t
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen							
			where t.Tram_ID_Tram in (select ID_Tram from Tram where Dia_diem like @Den)
		end
		else
		begin
		select * from (			select c.*
			from Chuyen c join Tuyen t
							on t.ID_Tuyen=c.Tuyen_ID_Tuyen							
			where t.Tram_ID_Tram in (select ID_Tram from Tram where Dia_diem like @Tu)) t
			
		end
end
GO
/****** Object:  StoredProcedure [dbo].[listXe]    Script Date: 12/14/2018 11:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listXe]
as
select * from Xe 
GO
/****** Object:  StoredProcedure [dbo].[updateChuyen]    Script Date: 12/14/2018 11:02:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
update Chuyen set Tuyen_ID_Tuyen=@Tuyen, Gio_khoi_hanh=@GKH, Ghi_chu=@Ghichu,Xe_XeID=@Xe,Tai_xe_ID_TaiXe=@TaiXe where ID_Chuyen =1 

GO
