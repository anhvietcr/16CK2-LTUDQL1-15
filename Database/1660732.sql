if db_id('QuanLyVeXe') is not null
	drop database QuanLyVeXe
go
create database QuanLyVeXe
go
use QuanLyVeXe
go
CREATE TABLE [dbo].[Chuyen](
	[ID_Chuyen] [int] NOT NULL,
	[Tuyen_ID_Truyen] [int] NOT NULL,
	[Gio_khoi_hanh] [date] NOT NULL,
	[Ghi_chu] [nvarchar](4000) NULL,
	[Xe_XeID] [int] NOT NULL,
	[Tai_xe_ID_TaiXe] [int] NOT NULL,
 CONSTRAINT [PK_Chuyen] PRIMARY KEY CLUSTERED 
(
	[ID_Chuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE KhachHang(
	ID_KhachHang int primary key not null,
	HoTen nvarchar(4000),
	DienThoai varchar(4000),
	Email nvarchar(4000),
	Loai int
)
go
CREATE TABLE [dbo].[Ghe](
	[ID_Ghe] [int] NOT NULL,
	[Dong] [int] NOT NULL,
	[Cot] [int] NOT NULL,
	[Tang] [int] NULL,
	[So_ghe] [int] NULL,
	[Xe_XeID] [int] NOT NULL,
 CONSTRAINT [PK_Ghe] PRIMARY KEY CLUSTERED 
(
	[ID_Ghe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 11/21/2018 9:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[ID_LoaiXe] [int] NOT NULL,
	[TenLoai] [nvarchar](4000) NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[ID_LoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 11/21/2018 9:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tai_xe](
	[ID_TaiXe] [int] NOT NULL,
	[TenTaiXe] [nvarchar](4000) NULL,
	[BangLai] [nvarchar](4000) NULL,
 CONSTRAINT [PK_Tai_xe] PRIMARY KEY CLUSTERED 
(
	[ID_TaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Xe]    Script Date: 11/21/2018 9:17:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[XeID] [int] NOT NULL,
	[TenXe] [nvarchar](4000) NULL,
	[So_dang_ky] [nvarchar](4000) NULL,
	[LoaiXe_ID_LoaiXe] [int] NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[XeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
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
Create table Tram (
ID_Tram int primary key not null,
TenTram nvarchar(4000),
Dia_diem nvarchar(4000)
)
Create table Tuyen(
ID_Tuyen int primary key not null,
KhoangCach real,
ThoiGianChay int,
Tram_ID_Tram1 int,
Tram_ID_Tram int
)
Create table Tram_trung_gian(
Tuyen_ID_Tuyen int not null,
Tram_ID_Tram int not null,
Primary key(Tuyen_ID_Tuyen,Tram_ID_Tram)
)

Alter table Tuyen 
add constraint Tuyen_Tram_FK 
foreign key (Tram_ID_Tram)
references Tram(ID_Tram)
go

Alter table Tuyen 
add constraint Tuyen_Tram_FKv2 
foreign key (Tram_ID_Tram1)
references Tram(ID_Tram)
go

Alter table Tram_trung_gian
add constraint Tram_trung_gian_Tuyen_FK 
foreign key (Tuyen_ID_Tuyen)
references Tuyen(ID_Tuyen)
go

Alter table Tram_trung_gian
add constraint Tram_trung_gian_Tram_FK 
foreign key (Tram_ID_Tram)
references Tram(ID_Tram)
go
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
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [Chuyen_Tai_xe_FK] FOREIGN KEY([Tai_xe_ID_TaiXe])
REFERENCES [dbo].[Tai_xe] ([ID_TaiXe])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [Chuyen_Tai_xe_FK]
GO
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [Chuyen_Xe_FK] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [Chuyen_Xe_FK]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [Ghe_Xe_FK] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [Ghe_Xe_FK]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [Xe_LoaiXe_FK] FOREIGN KEY([LoaiXe_ID_LoaiXe])
REFERENCES [dbo].[LoaiXe] ([ID_LoaiXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [Xe_LoaiXe_FK]
GO