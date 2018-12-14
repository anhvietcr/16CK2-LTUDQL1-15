USE [master]
GO
/****** Object:  Database [QuanLyVeXe]    Script Date: 12/14/2018 12:12:23 PM ******/
CREATE DATABASE [QuanLyVeXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyVeXe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyVeXe.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyVeXe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyVeXe_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyVeXe] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyVeXe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyVeXe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyVeXe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyVeXe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyVeXe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyVeXe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyVeXe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyVeXe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyVeXe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyVeXe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyVeXe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyVeXe] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyVeXe]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chuyen](
	[ID_Chuyen] [int] NOT NULL,
	[Tuyen_ID_Tuyen] [int] NOT NULL,
	[Gio_khoi_hanh] [datetime] NOT NULL,
	[Ghi_chu] [nvarchar](4000) NULL,
	[Xe_XeID] [int] NOT NULL,
	[Tai_xe_ID_TaiXe] [int] NOT NULL,
 CONSTRAINT [PK_Chuyen] PRIMARY KEY CLUSTERED 
(
	[ID_Chuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KhachHang] [int] identity NOT NULL,
	[HoTen] [nvarchar](4000) NULL,
	[DienThoai] [varchar](4000) NULL,
	[Email] [nvarchar](4000) NULL,
	[Loai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_KhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 12/14/2018 12:12:24 PM ******/
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
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 12/14/2018 12:12:24 PM ******/
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
/****** Object:  Table [dbo].[Tram]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram](
	[ID_Tram] [int] NOT NULL,
	[TenTram] [nvarchar](4000) NULL,
	[Dia_diem] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tram_trung_gian]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram_trung_gian](
	[Tuyen_ID_Tuyen] [int] NOT NULL,
	[Tram_ID_Tram] [int] NOT NULL,
	[Thu_tu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Tuyen_ID_Tuyen] ASC,
	[Tram_ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tuyen]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tuyen](
	[ID_Tuyen] [int] NOT NULL,
	[KhoangCach] [real] NULL,
	[ThoiGianChay] [int] NULL,
	[Tram_ID_Tram1] [int] NULL,
	[Tram_ID_Tram] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ve]    Script Date: 12/14/2018 12:12:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[ID_Ve] [int] NOT NULL,
	[Ghe_ID_Ghe] [int] NULL,
	[Chuyen_ID_Chuyen] [int] NULL,
	[TinhTrang] [int] NULL,
	[GiaTien] [real] NULL,
	[KhachHang_ID_KhachHang] [int] NULL,
	[NgayXuatVe] [datetime] NULL,
	[GhiChu] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Ve] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Xe]    Script Date: 12/14/2018 12:12:24 PM ******/
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
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (1, 1, CAST(N'2018-11-15 00:00:00.000' AS DateTime), N'1', 1, 1)
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (2, 1, CAST(N'2018-12-20 00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (3, 1, CAST(N'2018-11-14 00:00:00.000' AS DateTime), N'êm ái và nhẹ nhàng', 1, 1)
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (4, 2, CAST(N'2018-10-10 00:00:00.000' AS DateTime), N'', 2, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (1, 0, 0, 1, 1, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (2, 0, 1, 1, 2, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (3, 1, 0, 1, 3, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (4, 1, 1, 1, 4, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (5, 2, 0, 1, 5, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (6, 2, 1, 1, 6, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (7, 3, 0, 1, 7, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (8, 3, 1, 1, 8, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (9, 4, 0, 1, 9, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (10, 4, 1, 1, 10, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (11, 5, 0, 1, 11, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (12, 5, 1, 1, 12, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (13, 6, 0, 1, 13, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (14, 6, 1, 1, 14, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (15, 7, 0, 1, 15, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (16, 7, 1, 1, 16, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (17, 0, 0, 1, 1, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (18, 0, 1, 1, 2, 2)
INSERT [dbo].[KhachHang] ([HoTen], [DienThoai], [Email], [Loai]) VALUES (N'Khách hàng 1', N'0123456789', N'mail1@gmail.com', 0)
INSERT [dbo].[KhachHang] ([HoTen], [DienThoai], [Email], [Loai]) VALUES (N'Khách hàng 2', N'0987654321', N'mail2@gmail.com', 1)
INSERT [dbo].[KhachHang] ([HoTen], [DienThoai], [Email], [Loai]) VALUES (N'Khách hàng 3', N'098765434', N'mail3@gmail.com', 0)
INSERT [dbo].[KhachHang] ([HoTen], [DienThoai], [Email], [Loai]) VALUES (N'Khách hàng 4', N'098123123', N'mail4@gmail.com', 0)
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (1, N'28 chỗ')
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (2, N'45 chỗ')
INSERT [dbo].[LoaiXe] ([ID_LoaiXe], [TenLoai]) VALUES (3, N'46 chỗ')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (1, N'Tài xế 1', N'C')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (2, N'Tài xế 2', N'F')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (3, N'Tài xế 3', N'FC')
INSERT [dbo].[Tai_xe] ([ID_TaiXe], [TenTaiXe], [BangLai]) VALUES (4, N'Tài xế 4', N'B1')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_diem]) VALUES (1, N'Cây xăng Comeco', N'Ngã 4 Hàng Xanh, Bình Thạnh, TP. Hồ Chí Minh')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_diem]) VALUES (2, N'Ngã tư Thủ Đức', N'Thủ Đức, TP. Hồ Chí Minh')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_diem]) VALUES (3, N'Nhà thương Biên Hòa', N'Quốc lộ 1K, Tân Phong, Biên Hòa')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_diem]) VALUES (4, N'Bến xe Cam Ranh', N'Đại lộ Hùng Vương, Cam Ranh, Khánh Hòa')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_diem]) VALUES (5, N'Ngã tư Thạch Trụ', N'Quốc lộ 1A, Quảng Ngãi')
INSERT [dbo].[Tram] ([ID_Tram], [TenTram], [Dia_diem]) VALUES (6, N'Bến xe Giáp Bát', N'Giải Phóng, Giáp Bát, Hoàng Mai, Hà Nội')
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (1, 1, 1)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (1, 2, 2)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (1, 3, 3)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (1, 4, 4)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (1, 5, 5)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (1, 6, 6)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (2, 1, 1)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (2, 2, 2)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (2, 3, 3)
INSERT [dbo].[Tram_trung_gian] ([Tuyen_ID_Tuyen], [Tram_ID_Tram], [Thu_tu]) VALUES (2, 4, 4)
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (1, 1800, 48, 1, 6)
INSERT [dbo].[Tuyen] ([ID_Tuyen], [KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (2, 400, 8, 1, 4)
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (1, 1, 1, 1, 400000, 1, CAST(N'2018-11-19 00:00:00.000' AS DateTime), N'Thanh toán muộn')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (2, 2, 1, 0, 400000, 2, CAST(N'2018-11-04 07:05:30.000' AS DateTime), N'Chua thanh toán')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (3, 3, 1, 1, 400000, 3, CAST(N'2018-11-20 00:00:00.000' AS DateTime), N'thanh toán nhanh')
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (1, N'Giường nằm', N'DK-001', 1)
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (2, N'Ghế cứng', N'DK-002', 1)
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (3, N'Máy lạnh', N'DK-003', 2)
INSERT [dbo].[Xe] ([XeID], [TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (4, N'Giường nằm', N'DK-004', 3)
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
ALTER TABLE [dbo].[Chuyen]  WITH CHECK ADD  CONSTRAINT [FK_Chuyen_Tuyen] FOREIGN KEY([Tuyen_ID_Tuyen])
REFERENCES [dbo].[Tuyen] ([ID_Tuyen])
GO
ALTER TABLE [dbo].[Chuyen] CHECK CONSTRAINT [FK_Chuyen_Tuyen]
GO
ALTER TABLE [dbo].[Ghe]  WITH CHECK ADD  CONSTRAINT [Ghe_Xe_FK] FOREIGN KEY([Xe_XeID])
REFERENCES [dbo].[Xe] ([XeID])
GO
ALTER TABLE [dbo].[Ghe] CHECK CONSTRAINT [Ghe_Xe_FK]
GO
ALTER TABLE [dbo].[Tram_trung_gian]  WITH CHECK ADD  CONSTRAINT [Tram_trung_gian_Tram_FK] FOREIGN KEY([Tram_ID_Tram])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tram_trung_gian] CHECK CONSTRAINT [Tram_trung_gian_Tram_FK]
GO
ALTER TABLE [dbo].[Tram_trung_gian]  WITH CHECK ADD  CONSTRAINT [Tram_trung_gian_Tuyen_FK] FOREIGN KEY([Tuyen_ID_Tuyen])
REFERENCES [dbo].[Tuyen] ([ID_Tuyen])
GO
ALTER TABLE [dbo].[Tram_trung_gian] CHECK CONSTRAINT [Tram_trung_gian_Tuyen_FK]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [Tuyen_Tram_FK] FOREIGN KEY([Tram_ID_Tram])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [Tuyen_Tram_FK]
GO
ALTER TABLE [dbo].[Tuyen]  WITH CHECK ADD  CONSTRAINT [Tuyen_Tram_FKv2] FOREIGN KEY([Tram_ID_Tram1])
REFERENCES [dbo].[Tram] ([ID_Tram])
GO
ALTER TABLE [dbo].[Tuyen] CHECK CONSTRAINT [Tuyen_Tram_FKv2]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [Ve_Chuyen_FK] FOREIGN KEY([Chuyen_ID_Chuyen])
REFERENCES [dbo].[Chuyen] ([ID_Chuyen])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [Ve_Chuyen_FK]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [Ve_Ghe_FK] FOREIGN KEY([Ghe_ID_Ghe])
REFERENCES [dbo].[Ghe] ([ID_Ghe])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [Ve_Ghe_FK]
GO
ALTER TABLE [dbo].[Ve]  WITH CHECK ADD  CONSTRAINT [Ve_KhachHang_FK] FOREIGN KEY([KhachHang_ID_KhachHang])
REFERENCES [dbo].[KhachHang] ([ID_KhachHang])
GO
ALTER TABLE [dbo].[Ve] CHECK CONSTRAINT [Ve_KhachHang_FK]
GO
ALTER TABLE [dbo].[Xe]  WITH CHECK ADD  CONSTRAINT [Xe_LoaiXe_FK] FOREIGN KEY([LoaiXe_ID_LoaiXe])
REFERENCES [dbo].[LoaiXe] ([ID_LoaiXe])
GO
ALTER TABLE [dbo].[Xe] CHECK CONSTRAINT [Xe_LoaiXe_FK]
GO
/****** Object:  StoredProcedure [dbo].[deleteChuyen]    Script Date: 12/14/2018 12:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteChuyen](@ID_Chuyen int)
as
delete from Chuyen where ID_Chuyen=@ID_Chuyen 

GO
/****** Object:  StoredProcedure [dbo].[insertChuyen]    Script Date: 12/14/2018 12:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
insert into Chuyen values(@ID_Chuyen,@Tuyen, @GKH, @Ghichu,@Xe ,@TaiXe)
GO
/****** Object:  StoredProcedure [dbo].[listcbbChuyen]    Script Date: 12/14/2018 12:12:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[listcbbLoai]    Script Date: 12/14/2018 12:12:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[listcbbTuyen]    Script Date: 12/14/2018 12:12:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[listChonGhe]    Script Date: 12/14/2018 12:12:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[listChuyen]    Script Date: 12/14/2018 12:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listChuyen]
AS
 select * from Chuyen
GO
/****** Object:  StoredProcedure [dbo].[listChuyenDK]    Script Date: 12/14/2018 12:12:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[listChuyenSearch]    Script Date: 12/14/2018 12:12:25 PM ******/
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
/****** Object:  StoredProcedure [dbo].[listXe]    Script Date: 12/14/2018 12:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listXe]
as
select * from Xe 
GO
/****** Object:  StoredProcedure [dbo].[updateChuyen]    Script Date: 12/14/2018 12:12:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
update Chuyen set Tuyen_ID_Tuyen=@Tuyen, Gio_khoi_hanh=@GKH, Ghi_chu=@Ghichu,Xe_XeID=@Xe,Tai_xe_ID_TaiXe=@TaiXe where ID_Chuyen =1 

GO
USE [master]
GO
ALTER DATABASE [QuanLyVeXe] SET  READ_WRITE 
GO
