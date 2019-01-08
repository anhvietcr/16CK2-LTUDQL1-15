USE [QuanLyVeXe]
GO
DROP PROCEDURE [dbo].[getTuyenIDTuyenbyTuyen]
DROP PROCEDURE [dbo].[updateTramDen]
DROP PROCEDURE [dbo].[updateTuyen]
DROP PROCEDURE [dbo].[InsertTramTrungGian]
DROP PROCEDURE [dbo].[getIDTramIDTuyen]
DROP PROCEDURE [dbo].[listTram]
DROP PROCEDURE [dbo].[xoaTram]
DROP PROCEDURE [dbo].[suaTram]
DROP PROCEDURE [dbo].[kiemTraTenTramInTuyen]
DROP PROCEDURE [dbo].[checkExistsTenTramInTram]

/****** Object:  StoredProcedure [dbo].[timkhachhangtheotenhoacsdt]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[timkhachhangtheotenhoacsdt]
GO
/****** Object:  StoredProcedure [dbo].[listVe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listVe]
GO
/****** Object:  StoredProcedure [dbo].[deleteVe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[deleteVe]
GO
/****** Object:  StoredProcedure [dbo].[updateTinhtrangVe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[updateTinhtrangVe]
GO
/****** Object:  StoredProcedure [dbo].[xoakhachhang]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[xoakhachhang]
GO
/****** Object:  StoredProcedure [dbo].[UpdateTuyenXe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[UpdateTuyenXe]
GO
/****** Object:  StoredProcedure [dbo].[updateChuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[updateChuyen]
GO
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoTen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[timKhachHangTheoTen]
GO
/****** Object:  StoredProcedure [dbo].[timKhachHangTheoSDT]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[timKhachHangTheoSDT]
GO
/****** Object:  StoredProcedure [dbo].[themkhachhang]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[themkhachhang]
GO
/****** Object:  StoredProcedure [dbo].[taoKhachHang]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[taoKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[suakhachhang]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[suakhachhang]
GO
/****** Object:  StoredProcedure [dbo].[ReportVeNgay]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[ReportVeNgay]
GO
/****** Object:  StoredProcedure [dbo].[ReportVe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[ReportVe]
GO
/****** Object:  StoredProcedure [dbo].[ReportTuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[ReportTuyen]
GO
/****** Object:  StoredProcedure [dbo].[newVe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[newVe]
GO
/****** Object:  StoredProcedure [dbo].[newTuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[newTuyen]
GO
/****** Object:  StoredProcedure [dbo].[newTram]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[newTram]
GO
/****** Object:  StoredProcedure [dbo].[listXe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listXe]
GO
/****** Object:  StoredProcedure [dbo].[listTuyenXe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listTuyenXe]
GO
/****** Object:  StoredProcedure [dbo].[ListTuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[ListTuyen]
GO
/****** Object:  StoredProcedure [dbo].[listTenTram]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listTenTram]
GO
/****** Object:  StoredProcedure [dbo].[listKhachHang]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listKhachHang]
GO
/****** Object:  StoredProcedure [dbo].[listChuyenSearch]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listChuyenSearch]
GO
/****** Object:  StoredProcedure [dbo].[listChuyenDK]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listChuyenDK]
GO
/****** Object:  StoredProcedure [dbo].[listChuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listChuyen]
GO
/****** Object:  StoredProcedure [dbo].[listChonGhe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listChonGhe]
GO
/****** Object:  StoredProcedure [dbo].[listcbbTuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listcbbTuyen]
GO
/****** Object:  StoredProcedure [dbo].[listcbbLoai]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listcbbLoai]
GO
/****** Object:  StoredProcedure [dbo].[listcbbChuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[listcbbChuyen]
GO
/****** Object:  StoredProcedure [dbo].[insertChuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[insertChuyen]
GO
/****** Object:  StoredProcedure [dbo].[getXeById]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[getXeById]
GO
/****** Object:  StoredProcedure [dbo].[GetTuyenById]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[GetTuyenById]
GO
/****** Object:  StoredProcedure [dbo].[getTenTrambyTuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[getTenTrambyTuyen]
GO
/****** Object:  StoredProcedure [dbo].[getGheById]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[getGheById]
GO
/****** Object:  StoredProcedure [dbo].[getGheByChuyenAndXe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[getGheByChuyenAndXe]
GO
/****** Object:  StoredProcedure [dbo].[DeleteTuyenXe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP PROCEDURE [dbo].[DeleteTuyenXe]
GO
/****** Object:  StoredProcedure [dbo].[deleteChuyen]    Script Date: 04-Jan-19 01:39:05 ******/
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
/****** Object:  Table [dbo].[Xe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Xe]
GO
/****** Object:  Table [dbo].[Ve]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Ve]
GO
/****** Object:  Table [dbo].[Tuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Tuyen]
GO
/****** Object:  Table [dbo].[Tram_trung_gian]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Tram_trung_gian]
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Tram]
GO
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Tai_xe]
GO
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[LoaiXe]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[KhachHang]
GO
/****** Object:  Table [dbo].[Ghe]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Ghe]
GO
/****** Object:  Table [dbo].[Chuyen]    Script Date: 04-Jan-19 01:39:05 ******/
DROP TABLE [dbo].[Chuyen]
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
/****** Object:  Table [dbo].[Chuyen]    Script Date: 04-Jan-19 01:39:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chuyen](
	[ID_Chuyen] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Ghe]    Script Date: 04-Jan-19 01:39:06 ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 04-Jan-19 01:39:06 ******/
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
/****** Object:  Table [dbo].[LoaiXe]    Script Date: 04-Jan-19 01:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiXe](
	[ID_LoaiXe] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](4000) NULL,
 CONSTRAINT [PK_LoaiXe] PRIMARY KEY CLUSTERED 
(
	[ID_LoaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tai_xe]    Script Date: 04-Jan-19 01:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tai_xe](
	[ID_TaiXe] [int] IDENTITY(1,1) NOT NULL,
	[TenTaiXe] [nvarchar](4000) NULL,
	[BangLai] [nvarchar](4000) NULL,
 CONSTRAINT [PK_Tai_xe] PRIMARY KEY CLUSTERED 
(
	[ID_TaiXe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram]    Script Date: 04-Jan-19 01:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tram](
	[ID_Tram] [int] IDENTITY(1,1) NOT NULL,
	[TenTram] [nvarchar](4000) NULL,
	[Dia_diem] [nvarchar](4000) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Tram] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tram_trung_gian]    Script Date: 04-Jan-19 01:39:06 ******/
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
/****** Object:  Table [dbo].[Tuyen]    Script Date: 04-Jan-19 01:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tuyen](
	[ID_Tuyen] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Ve]    Script Date: 04-Jan-19 01:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ve](
	[ID_Ve] [int] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[Xe]    Script Date: 04-Jan-19 01:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Xe](
	[XeID] [int] IDENTITY(1,1) NOT NULL,
	[TenXe] [nvarchar](4000) NULL,
	[So_dang_ky] [nvarchar](4000) NULL,
	[LoaiXe_ID_LoaiXe] [int] NOT NULL,
 CONSTRAINT [PK_Xe] PRIMARY KEY CLUSTERED 
(
	[XeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2018-11-15T00:00:00.000' AS DateTime), N'1', 1, 1)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2018-12-20T00:00:00.000' AS DateTime), NULL, 1, 1)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2018-11-14T00:00:00.000' AS DateTime), N'êm ái và nhẹ nhàng', 1, 1)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 2, CAST(N'2018-10-10T00:00:00.000' AS DateTime), N'', 2, 2)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), NULL, 2, 1)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), NULL, 3, 2)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), NULL, 4, 1)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2019-01-02T00:00:00.000' AS DateTime), NULL, 4, 1)
INSERT [dbo].[Chuyen] ( [Tuyen_ID_Tuyen], [Gio_khoi_hanh], [Ghi_chu], [Xe_XeID], [Tai_xe_ID_TaiXe]) VALUES ( 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), NULL, 1, 2)
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
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (6, N'Nguyen van a', N'2384728', N'Nguyeenvana@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (9, N'Guest 1', N'3244345', N'sdsd@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (10, N'Guest 2', N'23435345', N'asdfasd@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (11, N'Guest 3', N'678679', N'asdfasd@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (12, N'Guest 4', N'098755371', N'rmail@gmail.com', 0)
INSERT [dbo].[KhachHang] ([ID_KhachHang], [HoTen], [DienThoai], [Email], [Loai]) VALUES (13, N'Guest null', N'09876541', N'434asdf@gmail.com', 1)
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
INSERT [dbo].[LoaiXe] ([TenLoai]) VALUES (N'28 chỗ')
INSERT [dbo].[LoaiXe] ([TenLoai]) VALUES (N'45 chỗ')
INSERT [dbo].[LoaiXe] ([TenLoai]) VALUES (N'46 chỗ')
INSERT [dbo].[Tai_xe] ([TenTaiXe], [BangLai]) VALUES (N'Tài xế 1', N'C')
INSERT [dbo].[Tai_xe] ([TenTaiXe], [BangLai]) VALUES (N'Tài xế 2', N'F')
INSERT [dbo].[Tai_xe] ([TenTaiXe], [BangLai]) VALUES (N'Tài xế 3', N'FC')
INSERT [dbo].[Tai_xe] ([TenTaiXe], [BangLai]) VALUES (N'Tài xế 4', N'B1')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'Cây xăng Comeco', N'Ngã 4 Hàng Xanh, Bình Thạnh, TP. Hồ Chí Minh')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'Ngã tư Thủ Đức', N'Thủ Đức, TP. Hồ Chí Minh')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'Nhà thương Biên Hòa', N'Quốc lộ 1K, Tân Phong, Biên Hòa')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'Bến xe Cam Ranh', N'Đại lộ Hùng Vương, Cam Ranh, Khánh Hòa')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'Ngã tư Thạch Trụ', N'Quốc lộ 1A, Quảng Ngãi')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'Bến xe Giáp Bát', N'Giải Phóng, Giáp Bát, Hoàng Mai, Hà Nội')
INSERT [dbo].[Tram] ([TenTram], [Dia_diem]) VALUES (N'', N'')
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
INSERT [dbo].[Tuyen] ([KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (1800, 48, 1, 6)
INSERT [dbo].[Tuyen] ([KhoangCach], [ThoiGianChay], [Tram_ID_Tram1], [Tram_ID_Tram]) VALUES (400, 8, 1, 4)
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (29, 5, 1, 400000, 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), N'Thanh toán muộn')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (30, 5, 0, 400000, 2, CAST(N'2019-01-01T07:05:30.000' AS DateTime), N'Chua thanh toán')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (31, 5, 1, 400000, 3, CAST(N'2018-11-20T00:00:00.000' AS DateTime), N'thanh toán nhanh')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (90, 6, 1, 130000, 1, CAST(N'2019-01-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (105, 7, 0, 1000000, 9, CAST(N'2019-01-04T01:25:02.560' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (37, 5, 1, 130000, 1, CAST(N'2019-01-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (41, 5, 0, 180000, 12, CAST(N'2019-01-01T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (53, 5, 0, 200000, 11, CAST(N'2019-01-01T00:00:00.000' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (73, 6, 0, 200000, 3, CAST(N'2019-01-04T01:27:35.843' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (38, 5, 0, 130000, 3, CAST(N'2019-01-04T01:27:51.270' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (39, 5, 0, 130000, 13, CAST(N'2019-01-04T01:29:51.947' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (18, 9, 1, 200000, 13, CAST(N'2019-01-04T01:35:44.757' AS DateTime), N'')
INSERT [dbo].[Ve] ([Ghe_ID_Ghe], [Chuyen_ID_Chuyen], [TinhTrang], [GiaTien], [KhachHang_ID_KhachHang], [NgayXuatVe], [GhiChu]) VALUES (105, 8, 0, 200000, 12, CAST(N'2019-01-04T01:37:28.610' AS DateTime), N'nhanh nhe')
INSERT [dbo].[Xe] ([TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'Giường nằm', N'DK-001', 1)
INSERT [dbo].[Xe] ([TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'Ghế cứng', N'DK-002', 1)
INSERT [dbo].[Xe] ([TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'Máy lạnh', N'DK-003', 2)
INSERT [dbo].[Xe] ([TenXe], [So_dang_ky], [LoaiXe_ID_LoaiXe]) VALUES (N'Giường nằm', N'DK-004', 3)
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

USE [master]
GO
ALTER DATABASE [QuanLyVeXe] SET  READ_WRITE 
GO
