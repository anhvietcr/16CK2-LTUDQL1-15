USE [QuanLyVeXe]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTuyenXe]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[UpdateTuyenXe]
GO
/****** Object:  StoredProcedure [dbo].[updateChuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[updateChuyen]
GO
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoTen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[timKhachHangTheoTen]
GO
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoSDT]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[timKhachHangTheoSDT]
GO
/****** Object:  StoredProcedure [dbo].[taoKhachHang]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[taoKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[newTuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[newTuyen]
GO
/****** Object:  StoredProcedure [dbo].[newTram]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[newTram]
GO
/****** Object:  StoredProcedure [dbo].[listXe]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listXe]
GO
/****** Object:  StoredProcedure [dbo].[listTuyenXe]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listTuyenXe]
GO
/****** Object:  StoredProcedure [dbo].[ListTuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[ListTuyen]
GO
/****** Object:  StoredProcedure [dbo].[listTenTram]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listTenTram]
GO
/****** Object:  StoredProcedure [dbo].[listKhachHang]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[listChuyenSearch]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listChuyenSearch]
GO
/****** Object:  StoredProcedure [dbo].[listChuyenDK]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listChuyenDK]
GO
/****** Object:  StoredProcedure [dbo].[listChuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listChuyen]
GO
/****** Object:  StoredProcedure [dbo].[listChonGhe]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listChonGhe]
GO
/****** Object:  StoredProcedure [dbo].[listcbbTuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listcbbTuyen]
GO
/****** Object:  StoredProcedure [dbo].[listcbbLoai]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listcbbLoai]
GO
/****** Object:  StoredProcedure [dbo].[listcbbChuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[listcbbChuyen]
GO
/****** Object:  StoredProcedure [dbo].[insertChuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[insertChuyen]
GO
/****** Object:  StoredProcedure [dbo].[getXeById]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[getXeById]
GO
/****** Object:  StoredProcedure [dbo].[GetTuyenById]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[GetTuyenById]
GO
/****** Object:  StoredProcedure [dbo].[getTenTrambyTuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[getTenTrambyTuyen]
GO
/****** Object:  StoredProcedure [dbo].[getGheById]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[getGheById]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTuyenXe]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[DeleteTuyenXe]
GO
/****** Object:  StoredProcedure [dbo].[deleteChuyen]    Script Date: 01-Jan-19 05:30:33 ******/
DROP PROCEDURE [dbo].[deleteChuyen]
GO
ALTER TABLE [dbo].[Xe] DROP CONSTRAINT [Xe_LoaiXe_FK]
GO
ALTER TABLE [dbo].[Ve] DROP CONSTRAINT [Ve_KhachHang_FK]
GO
ALTER TABLE [dbo].[Ve] DROP CONSTRAINT [Ve_Ghe_FK]
GO
ALTER TABLE [dbo].[Ve] DROP CONSTRAINT [Ve_Chuyen_FK]
GO
ALTER TABLE [dbo].[Tuyen] DROP CONSTRAINT [Tuyen_Tram_FKv2]
GO
ALTER TABLE [dbo].[Tuyen] DROP CONSTRAINT [Tuyen_Tram_FK]
GO
ALTER TABLE [dbo].[Tram_trung_gian] DROP CONSTRAINT [Tram_trung_gian_Tuyen_FK]
GO
ALTER TABLE [dbo].[Tram_trung_gian] DROP CONSTRAINT [Tram_trung_gian_Tram_FK]
GO
ALTER TABLE [dbo].[Ghe] DROP CONSTRAINT [Ghe_Xe_FK]
GO
ALTER TABLE [dbo].[Chuyen] DROP CONSTRAINT [FK_Chuyen_Tuyen]
GO
ALTER TABLE [dbo].[Chuyen] DROP CONSTRAINT [Chuyen_Xe_FK]
GO
ALTER TABLE [dbo].[Chuyen] DROP CONSTRAINT [Chuyen_Tai_xe_FK]
GO
/****** Object:  Table [dbo].[Xe]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Xe]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Ve]
GO
/****** Object:  Table [dbo].[Tuyen]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Tuyen]
GO
/****** Object:  Table [dbo].[Tram_trung_gian]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Tram_trung_gian]
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Tram]
GO
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Tai_xe]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[LoaiXe]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Ghe]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 01-Jan-19 05:30:34 ******/
DROP TABLE [dbo].[Chuyen]
GO
USE [master]
GO
/****** Object:  Database [QuanLyVeXe]    Script Date: 01-Jan-19 05:30:34 ******/
DROP DATABASE [QuanLyVeXe]
GO
/****** Object:  Database [QuanLyVeXe]    Script Date: 01-Jan-19 05:30:34 ******/
CREATE DATABASE [QuanLyVeXe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyVeXe', FILENAME = N'D:\Software\SqlServer\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyVeXe.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyVeXe_log', FILENAME = N'D:\Software\SqlServer\MSSQL14.SQLEXPRESS\MSSQL\DATA\QuanLyVeXe_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
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
ALTER DATABASE [QuanLyVeXe] SET QUERY_STORE = OFF
GO
USE [QuanLyVeXe]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLyVeXe]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Ghe]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 01-Jan-19 05:30:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID_KhachHang] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Tram]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Tram_trung_gian]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Tuyen]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Ve]    Script Date: 01-Jan-19 05:30:34 ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 01-Jan-19 05:30:34 ******/
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
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (1, 1, CAST(N'2018-11-15T00:00:00.000' AS DateTime), N'1', 1, 1)
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (2, 1, CAST(N'2018-12-20T00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (3, 1, CAST(N'2018-11-14T00:00:00.000' AS DateTime), N'êm ái và nhẹ nhàng', 1, 1)
INSERT [dbo].[Chuyen] ([ID_Chuyen], [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES (4, 2, CAST(N'2018-10-10T00:00:00.000' AS DateTime), N'', 2, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (1, 1, 1, 1, 1, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (2, 1, 2, 1, 2, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (3, 1, 3, 1, 3, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (4, 1, 4, 1, 4, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (5, 1, 5, 1, 5, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (6, 1, 6, 1, 6, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (7, 1, 7, 1, 7, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (8, 1, 8, 1, 8, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (9, 1, 9, 1, 9, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (10, 2, 1, 1, 10, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (11, 2, 2, 1, 11, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (12, 2, 3, 1, 12, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (13, 2, 4, 1, 13, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (14, 2, 5, 1, 14, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (15, 2, 6, 1, 15, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (16, 2, 7, 1, 16, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (17, 2, 8, 1, 17, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (18, 2, 9, 1, 18, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (19, 3, 1, 1, 19, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (20, 4, 1, 1, 20, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (21, 4, 2, 1, 21, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (22, 4, 3, 1, 22, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (23, 4, 4, 1, 23, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (24, 4, 5, 1, 24, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (25, 4, 6, 1, 25, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (26, 4, 7, 1, 26, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (27, 4, 8, 1, 27, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (28, 4, 9, 1, 28, 1)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (29, 1, 1, 1, 1, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (30, 1, 2, 1, 2, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (31, 1, 3, 1, 3, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (32, 1, 4, 1, 4, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (33, 1, 5, 1, 5, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (34, 1, 6, 1, 6, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (35, 1, 7, 1, 7, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (36, 1, 8, 1, 8, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (37, 1, 9, 1, 9, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (38, 2, 1, 1, 10, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (39, 2, 2, 1, 11, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (40, 2, 3, 1, 12, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (41, 2, 4, 1, 13, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (42, 2, 5, 1, 14, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (43, 2, 6, 1, 15, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (44, 2, 7, 1, 16, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (45, 2, 8, 1, 17, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (46, 2, 9, 1, 18, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (47, 3, 1, 1, 19, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (48, 4, 1, 1, 20, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (49, 4, 2, 1, 21, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (50, 4, 3, 1, 22, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (51, 4, 4, 1, 23, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (52, 4, 5, 1, 24, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (53, 4, 6, 1, 25, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (54, 4, 7, 1, 26, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (55, 4, 8, 1, 27, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (56, 4, 9, 1, 28, 2)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (57, 1, 1, 1, 1, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (58, 1, 2, 1, 2, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (59, 1, 3, 1, 3, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (60, 1, 4, 1, 4, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (61, 1, 5, 1, 5, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (62, 1, 6, 1, 6, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (63, 1, 7, 1, 7, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (64, 1, 8, 1, 8, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (65, 1, 9, 1, 9, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (66, 1, 10, 1, 10, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (67, 1, 11, 1, 11, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (68, 2, 1, 1, 12, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (69, 2, 2, 1, 13, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (70, 2, 3, 1, 14, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (71, 2, 4, 1, 15, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (72, 2, 5, 1, 16, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (73, 2, 6, 1, 17, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (74, 2, 7, 1, 18, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (75, 2, 8, 1, 19, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (76, 2, 9, 1, 20, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (77, 2, 10, 1, 21, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (78, 2, 11, 1, 22, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (79, 3, 1, 1, 23, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (80, 4, 1, 1, 24, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (81, 4, 2, 1, 25, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (82, 4, 3, 1, 26, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (83, 4, 4, 1, 27, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (84, 4, 5, 1, 28, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (85, 4, 6, 1, 29, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (86, 4, 7, 1, 30, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (87, 4, 8, 1, 31, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (88, 4, 9, 1, 32, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (89, 4, 10, 1, 33, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (90, 4, 11, 1, 34, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (91, 5, 1, 1, 35, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (92, 5, 2, 1, 36, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (93, 5, 3, 1, 37, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (94, 5, 4, 1, 38, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (95, 5, 5, 1, 39, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (96, 5, 6, 1, 40, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (97, 5, 7, 1, 41, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (98, 5, 8, 1, 42, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (99, 5, 9, 1, 43, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (100, 5, 10, 1, 44, 3)
GO
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (101, 5, 11, 1, 45, 3)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (102, 1, 1, 1, 1, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (103, 1, 2, 1, 2, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (104, 1, 3, 1, 3, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (105, 1, 4, 1, 4, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (106, 1, 5, 1, 5, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (107, 1, 6, 1, 6, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (108, 1, 7, 1, 7, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (109, 2, 1, 1, 8, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (110, 3, 1, 1, 9, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (111, 3, 2, 1, 10, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (112, 3, 3, 1, 11, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (113, 3, 4, 1, 12, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (114, 3, 5, 1, 13, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (115, 3, 6, 1, 14, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (116, 3, 7, 1, 15, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (117, 4, 1, 1, 16, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (118, 5, 1, 1, 17, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (119, 5, 2, 1, 18, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (120, 5, 3, 1, 19, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (121, 5, 4, 1, 20, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (122, 5, 5, 1, 21, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (123, 5, 6, 1, 22, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (124, 5, 7, 1, 23, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (125, 1, 1, 2, 24, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (126, 1, 2, 2, 25, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (127, 1, 3, 2, 26, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (128, 1, 4, 2, 27, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (129, 1, 5, 2, 28, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (130, 1, 6, 2, 29, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (131, 1, 7, 2, 30, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (132, 2, 1, 2, 31, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (133, 3, 1, 2, 32, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (134, 3, 2, 2, 33, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (135, 3, 3, 2, 34, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (136, 3, 4, 2, 35, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (137, 3, 5, 2, 36, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (138, 3, 6, 2, 37, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (139, 3, 7, 2, 38, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (140, 4, 1, 2, 39, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (141, 5, 1, 2, 40, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (142, 5, 2, 2, 41, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (143, 5, 3, 2, 42, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (144, 5, 4, 2, 43, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (145, 5, 5, 2, 44, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (146, 5, 6, 2, 45, 4)
INSERT [dbo].[Ghe] ([ID_Ghe], [Dong], [Cot], [Tang], [So_ghe], [Xe_XeID]) VALUES (147, 5, 7, 2, 46, 4)
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (1, N'Khách hàng 1', N'0123456789', N'mail1@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (2, N'Khách hàng 2', N'0987654321', N'mail2@gmail.com', 1)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (3, N'Khách hàng 3', N'098765434', N'mail3@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (4, N'Khách hàng 4', N'098123123', N'mail4@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
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
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (1, 1, 1, 1, 400000, 1, CAST(N'2018-11-19T00:00:00.000' AS DateTime), N'Thanh toán muộn')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (2, 2, 1, 0, 400000, 2, CAST(N'2018-11-04T07:05:30.000' AS DateTime), N'Chua thanh toán')
INSERT [dbo].[Ve] ([ID_Ve], [Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (3, 3, 1, 1, 400000, 3, CAST(N'2018-11-20T00:00:00.000' AS DateTime), N'thanh toán nhanh')
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
/****** Object:  StoredProcedure [dbo].[deleteChuyen]    Script Date: 01-Jan-19 05:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteChuyen](@ID_Chuyen int)
as
delete from Chuyen where ID_Chuyen=@ID_Chuyen 

GO
/****** Object:  StoredProcedure [dbo].[DeleteTuyenXe]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[getGheById]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[getTenTrambyTuyen]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[GetTuyenById]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[getXeById]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[insertChuyen]    Script Date: 01-Jan-19 05:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
insert into Chuyen values(@ID_Chuyen,@Tuyen, @GKH, @Ghichu,@Xe ,@TaiXe)
GO
/****** Object:  StoredProcedure [dbo].[listcbbChuyen]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listcbbLoai]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listcbbTuyen]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listChonGhe]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listChuyen]    Script Date: 01-Jan-19 05:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[listChuyen]
AS
 select * from Chuyen
GO
/****** Object:  StoredProcedure [dbo].[listChuyenDK]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listChuyenSearch]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listKhachHang]    Script Date: 01-Jan-19 05:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listKhachHang]
as begin
	select * from KhachHang
end
GO
/****** Object:  StoredProcedure [dbo].[listTenTram]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[ListTuyen]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listTuyenXe]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[listXe]    Script Date: 01-Jan-19 05:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[listXe]
as
select * from Xe 
GO
/****** Object:  StoredProcedure [dbo].[newTram]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[newTuyen]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[taoKhachHang]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoSDT]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoTen]    Script Date: 01-Jan-19 05:30:35 ******/
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
/****** Object:  StoredProcedure [dbo].[updateChuyen]    Script Date: 01-Jan-19 05:30:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateChuyen](@ID_Chuyen int,@Tuyen int, @GKH datetime, @Ghichu nvarchar(4000),@Xe int,@TaiXe int)
as
update Chuyen set Tuyen_ID_Tuyen=@Tuyen, Gio_khoi_hanh=@GKH, Ghi_chu=@Ghichu,Xe_XeID=@Xe,Tai_xe_ID_TaiXe=@TaiXe where ID_Chuyen =1 

GO
/****** Object:  StoredProcedure [dbo].[UpdateTuyenXe]    Script Date: 01-Jan-19 05:30:35 ******/
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
USE [master]
GO
ALTER DATABASE [QuanLyVeXe] SET  READ_WRITE 
GO
