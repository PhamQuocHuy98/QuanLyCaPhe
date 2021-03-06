USE [master]
GO
/****** Object:  Database [QuanLyNuoc]    Script Date: 21/12/2018 12:39:08 PM ******/
CREATE DATABASE [QuanLyNuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyNuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyNuoc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyNuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\QuanLyNuoc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyNuoc] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyNuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyNuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyNuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyNuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyNuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyNuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyNuoc] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyNuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyNuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyNuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyNuoc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyNuoc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyNuoc', N'ON'
GO
ALTER DATABASE [QuanLyNuoc] SET QUERY_STORE = OFF
GO
USE [QuanLyNuoc]
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
USE [QuanLyNuoc]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 21/12/2018 12:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[IdBan] [varchar](5) NOT NULL,
	[TenBan] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 21/12/2018 12:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[IdHoaDon] [varchar](10) NULL,
	[IdThucDon] [varchar](10) NULL,
	[Soluong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GoiMon]    Script Date: 21/12/2018 12:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GoiMon](
	[IdBan] [varchar](5) NULL,
	[IdThucDon] [varchar](10) NULL,
	[TenThucDon] [nvarchar](100) NULL,
	[DonGia] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
	[ThoiGian] [datetime] NULL,
	[ThanhTien] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 21/12/2018 12:39:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IdHoaDon] [varchar](10) NOT NULL,
	[IdBan] [varchar](5) NULL,
	[GioDen] [datetime] NULL,
	[TongTien] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[IdLoai] [varchar](10) NOT NULL,
	[TenLoaiThucDon] [nvarchar](100) NULL,
	[TrangThai] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IdNhanVien] [varchar](10) NOT NULL,
	[TenNhanVien] [nvarchar](30) NULL,
	[Ngaysinh] [datetime] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[Luong] [decimal](18, 0) NULL,
	[Dienthoai] [varchar](12) NULL,
	[Gmail] [varchar](30) NULL,
	[ChucVu] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[Username] [varchar](30) NOT NULL,
	[Pass] [varchar](12) NULL,
	[quyen] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[IdThucDon] [varchar](10) NOT NULL,
	[TenThucDon] [nvarchar](100) NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[TrangThai] [nvarchar](30) NULL,
	[DonGia] [decimal](18, 0) NULL,
	[TenLoaiThucDon] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B01', N'Bàn 01', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B02', N'Bàn 02', N'Có Người')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B04', N'Bàn 04', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B05', N'Bàn 05', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B06', N'Bàn 06', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B07', N'Bàn 07', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B08', N'Bàn 08', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B09', N'Bàn 09', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B10', N'Bàn 10', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B11', N'Bàn 11', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B12', N'Bàn 12', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B13', N'Bàn 13', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B14', N'Bàn 14', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B15', N'Bàn 15', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B17', N'Bàn 17', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B18', N'Bàn 18', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B19', N'Bàn 19', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B20', N'Bàn 20', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B21', N'Bàn 21', N'Còn Trống')
INSERT [dbo].[Ban] ([IdBan], [TenBan], [TrangThai]) VALUES (N'B22', N'Bàn 22', N'Còn Trống')
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000032', N'TD01', 3, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000024', N'TD06', 8, CAST(28000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000033', N'TD01', 8, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000009', N'TD04', 2, CAST(25000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000009', N'TD10', 5, CAST(28000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000025', N'TD17', 2, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000021', N'TD08', 2, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000008', N'TD15', 3, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000008', N'TD14', 2, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000008', N'TD19', 1, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000022', N'TD25', 3, CAST(15000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000012', N'TD04', 5, CAST(25000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000022', N'TD02', 1, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000027', N'TD12', 5, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000034', N'TD05', 3, CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000028', N'TD12', 5, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000015', N'TD12', 2, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000029', N'TD12', 5, CAST(27000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000030', N'TD22', 3, CAST(25000 AS Decimal(18, 0)))
INSERT [dbo].[ChiTietHoaDon] ([IdHoaDon], [IdThucDon], [Soluong], [DonGia]) VALUES (N'HD0000030', N'TD08', 1, CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[GoiMon] ([IdBan], [IdThucDon], [TenThucDon], [DonGia], [SoLuong], [ThoiGian], [ThanhTien]) VALUES (N'B02', N'TD05', N'Sinh Tố Cam', CAST(20000 AS Decimal(18, 0)), 5, CAST(N'2018-12-19T00:00:00.000' AS DateTime), CAST(100000 AS Decimal(18, 0)))
INSERT [dbo].[GoiMon] ([IdBan], [IdThucDon], [TenThucDon], [DonGia], [SoLuong], [ThoiGian], [ThanhTien]) VALUES (N'B02', N'TD01', N'Sinh Tố Dâu', CAST(27000 AS Decimal(18, 0)), 8, CAST(N'2018-12-18T00:00:00.000' AS DateTime), CAST(216000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000003', N'B05', CAST(N'2018-10-07T00:00:00.000' AS DateTime), CAST(940000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000004', N'B04', CAST(N'2018-10-08T00:00:00.000' AS DateTime), CAST(50000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000005', N'B01', CAST(N'2018-12-11T15:33:34.000' AS DateTime), CAST(555000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000006', N'B02', CAST(N'2018-10-05T00:00:00.000' AS DateTime), CAST(325000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000007', N'B06', CAST(N'2018-10-08T00:00:00.000' AS DateTime), CAST(325000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000008', N'B01', CAST(N'2018-12-12T09:13:33.000' AS DateTime), CAST(318000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000009', N'B02', CAST(N'2018-12-13T10:38:27.000' AS DateTime), CAST(280000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000010', N'B01', CAST(N'2018-12-14T08:31:25.000' AS DateTime), CAST(180000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000011', N'B12', CAST(N'2018-12-14T08:35:03.000' AS DateTime), CAST(480000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000012', N'B01', CAST(N'2018-12-14T08:36:15.000' AS DateTime), CAST(245000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000013', N'B01', CAST(N'2018-12-14T08:44:31.000' AS DateTime), CAST(330000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000014', N'B07', CAST(N'2018-12-14T08:45:14.000' AS DateTime), CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000015', N'B10', CAST(N'2018-12-14T08:45:54.000' AS DateTime), CAST(138000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000016', N'B02', CAST(N'2018-12-14T09:58:30.000' AS DateTime), CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000017', N'B14', CAST(N'2018-12-14T10:00:26.000' AS DateTime), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000018', N'B18', CAST(N'2018-12-14T10:00:32.000' AS DateTime), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000019', N'B05', CAST(N'2018-12-14T12:41:14.000' AS DateTime), CAST(120000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000020', N'B11', CAST(N'2018-12-15T11:30:18.000' AS DateTime), CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000021', N'B02', CAST(N'2018-12-15T12:09:33.000' AS DateTime), CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000022', N'B08', CAST(N'2018-12-16T13:14:07.000' AS DateTime), CAST(75000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000023', N'B02', CAST(N'2018-12-17T13:10:13.000' AS DateTime), CAST(60000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000024', N'B06', CAST(N'2018-12-17T14:50:40.000' AS DateTime), CAST(224000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000025', N'B04', CAST(N'2018-12-17T16:29:23.000' AS DateTime), CAST(234000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000026', N'B02', CAST(N'2018-12-17T22:55:14.000' AS DateTime), CAST(30000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000027', N'B18', CAST(N'2018-12-18T09:49:16.000' AS DateTime), CAST(825000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000028', N'B18', CAST(N'2018-12-18T09:51:17.000' AS DateTime), CAST(825000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000029', N'B18', CAST(N'2018-12-18T09:52:44.000' AS DateTime), CAST(825000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000030', N'B05', CAST(N'2018-12-18T10:43:32.000' AS DateTime), CAST(105000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000031', N'B12', CAST(N'2018-12-18T10:44:46.000' AS DateTime), CAST(60000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000032', N'B01', CAST(N'2018-12-18T13:08:25.030' AS DateTime), CAST(81000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000033', N'B02', CAST(N'2018-12-19T15:09:28.933' AS DateTime), CAST(216000 AS Decimal(18, 0)))
INSERT [dbo].[HoaDon] ([IdHoaDon], [IdBan], [GioDen], [TongTien]) VALUES (N'HD0000034', N'B04', CAST(N'2018-12-21T10:44:44.700' AS DateTime), CAST(60000 AS Decimal(18, 0)))
INSERT [dbo].[Loai] ([IdLoai], [TenLoaiThucDon], [TrangThai]) VALUES (N'NDC', N'Nước Đóng Chai', N'Còn Hàng')
INSERT [dbo].[Loai] ([IdLoai], [TenLoaiThucDon], [TrangThai]) VALUES (N'NDL', N'Nước Đóng Lon', N'Còn Hàng')
INSERT [dbo].[Loai] ([IdLoai], [TenLoaiThucDon], [TrangThai]) VALUES (N'NGK', N'Nước Giải Khát', N'Còn Hàng')
INSERT [dbo].[Loai] ([IdLoai], [TenLoaiThucDon], [TrangThai]) VALUES (N'ST', N'Sinh Tố', N'Còn Hàng')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV01', N'Phạm Quốc Huy', CAST(N'1998-11-26T00:00:00.000' AS DateTime), N'Nam', CAST(6000000 AS Decimal(18, 0)), N'01225654423', N'Quochuy@gmail.com', N'Phuc Vụ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV02', N'Đình Trọng', CAST(N'2018-11-26T00:00:00.000' AS DateTime), N'Nam', CAST(7000000 AS Decimal(18, 0)), N'012992120', N'trongdinh@gmail.com', N'Phục Vụ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV03', N'Vũ Minh Hiếu', CAST(N'1992-11-27T00:00:00.000' AS DateTime), N'Nam', CAST(5000000 AS Decimal(18, 0)), N'039092303', N'hieu@gmail.com', N'Bảo Vệ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV04', N'Bùi Phú Khuyên', CAST(N'1992-11-27T00:00:00.000' AS DateTime), N'Nam', CAST(5000000 AS Decimal(18, 0)), N'0129092303', N'khuyen@gmail.com', N'Bảo Vệ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV05', N'Hùng Dũng', CAST(N'1992-11-27T00:00:00.000' AS DateTime), N'Nam', CAST(5000000 AS Decimal(18, 0)), N'089723932', N'dunghung@gmail.com', N'Phục Vụ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV06', N'Võ Nhị Anh', CAST(N'1993-02-27T00:00:00.000' AS DateTime), N'Khác', CAST(7000000 AS Decimal(18, 0)), N'0778273823', N'nhianh@gmail.com', N'Pha Chế')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV07', N'Quốc Sơn', CAST(N'1995-02-12T00:00:00.000' AS DateTime), N'Nam', CAST(8000000 AS Decimal(18, 0)), N'0878273823', N'nhi@gmail.com', N'Pha Chế')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV08', N'Quang Hải', CAST(N'1997-08-15T00:00:00.000' AS DateTime), N'Nam', CAST(8000000 AS Decimal(18, 0)), N'090989281', N'hainguye@gmail.com', N'Bảo Vệ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV09', N'Duy Mạnh', CAST(N'1997-12-17T00:00:00.000' AS DateTime), N'Khác', CAST(7000000 AS Decimal(18, 0)), N'090934902', N'duymanh@gmail.com', N'Bảo Vệ')
INSERT [dbo].[NhanVien] ([IdNhanVien], [TenNhanVien], [Ngaysinh], [GioiTinh], [Luong], [Dienthoai], [Gmail], [ChucVu]) VALUES (N'NV10', N'Xuân Trường', CAST(N'1993-12-17T00:00:00.000' AS DateTime), N'Nam', CAST(7000000 AS Decimal(18, 0)), N'090923032', N'xtruong@gmail.com', N'Phục Vụ')
INSERT [dbo].[TaiKhoan] ([Username], [Pass], [quyen]) VALUES (N'admin', N'admin', 1)
INSERT [dbo].[TaiKhoan] ([Username], [Pass], [quyen]) VALUES (N'NV1', N'1', 0)
INSERT [dbo].[TaiKhoan] ([Username], [Pass], [quyen]) VALUES (N'NV2', N'1', 2)
INSERT [dbo].[TaiKhoan] ([Username], [Pass], [quyen]) VALUES (N'NV3', N'3', 0)
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD01', N'Sinh Tố Dâu', N'Ly', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD02', N'Sinh Tố Bơ', N'Ly', N'Còn Hàng', CAST(30000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD03', N'Sinh Tố Bưởi', N'Ly', N'Còn Hàng', CAST(15000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD04', N'Sinh Tố Mãn Cầu', N'Ly', N'Còn Hàng', CAST(25000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD05', N'Sinh Tố Cam', N'Ly', N'Còn Hàng', CAST(20000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD06', N'Sinh Tố Mít', N'Ly', N'Còn Hàng', CAST(28000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD07', N'Sinh Tố Chuối', N'Ly', N'Còn Hàng', CAST(30000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD08', N'Sinh Tố Dưa lê', N'Ly', N'Còn Hàng', CAST(30000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD09', N'Sinh Tố Kiwi', N'Ly', N'Còn Hàng', CAST(31000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD10', N'Sinh tố Đu Đủ', N'Ly', N'Còn Hàng', CAST(28000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD11', N'Sinh Tố Dứa', N'Ly', N'Còn Hàng', CAST(25000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD12', N'Sinh Tố Nha Đam', N'Ly', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD13', N'Sinh Tố Cần Tây', N'Ly', N'Còn Hàng', CAST(30000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD14', N'Sinh Tố Rau Má', N'Ly', N'Còn Hàng', CAST(30000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD15', N'Sinh Tố Hoàng Kim', N'Ly', N'Còn Hàng', CAST(15000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD16', N'Sinh Tố Mâm Xôi', N'Ly', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD17', N'Sinh Tố Bí Ngô', N'Ly', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Sinh Tố')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD18', N'CoCa', N'Chai', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Nước đóng chai')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD19', N'Pepsi', N'Lon', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Nước đóng lon')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD20', N'Sting', N'Lon', N'Còn Hàng', CAST(20000 AS Decimal(18, 0)), N'Nước đóng lon')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD21', N'Bò húp', N'Lon', N'Còn Hàng', CAST(25000 AS Decimal(18, 0)), N'Nước đóng lon')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD22', N'Nước suối', N'Chai', N'Còn Hàng', CAST(25000 AS Decimal(18, 0)), N'Nước đóng chai')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD23', N'7Up', N'Chai', N'Còn Hàng', CAST(20000 AS Decimal(18, 0)), N'Nước đóng chai')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD24', N'C2', N'Chai', N'Còn Hàng', CAST(20000 AS Decimal(18, 0)), N'Nước đóng chai')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD25', N'NesCafe', N'Lon', N'Còn Hàng', CAST(15000 AS Decimal(18, 0)), N'Nước đóng lon')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD26', N'Fanta', N'Lon', N'Còn Hàng', CAST(15000 AS Decimal(18, 0)), N'Nước đóng lon')
INSERT [dbo].[ThucDon] ([IdThucDon], [TenThucDon], [DonViTinh], [TrangThai], [DonGia], [TenLoaiThucDon]) VALUES (N'TD27', N'Chanh Đá', N'Ly', N'Còn Hàng', CAST(27000 AS Decimal(18, 0)), N'Nước Giải Khát')
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Ban__31C246CAF3438B04]    Script Date: 21/12/2018 12:39:10 PM ******/
ALTER TABLE [dbo].[Ban] ADD UNIQUE NONCLUSTERED 
(
	[TenBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Loai__6FDE7A590B5381AA]    Script Date: 21/12/2018 12:39:10 PM ******/
ALTER TABLE [dbo].[Loai] ADD UNIQUE NONCLUSTERED 
(
	[TenLoaiThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ThucDon__C2718D2DD9C5B4FB]    Script Date: 21/12/2018 12:39:10 PM ******/
ALTER TABLE [dbo].[ThucDon] ADD UNIQUE NONCLUSTERED 
(
	[TenThucDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDon] ([IdHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([IdThucDon])
REFERENCES [dbo].[ThucDon] ([IdThucDon])
GO
ALTER TABLE [dbo].[GoiMon]  WITH CHECK ADD FOREIGN KEY([IdBan])
REFERENCES [dbo].[Ban] ([IdBan])
GO
ALTER TABLE [dbo].[GoiMon]  WITH CHECK ADD FOREIGN KEY([IdThucDon])
REFERENCES [dbo].[ThucDon] ([IdThucDon])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IdBan])
REFERENCES [dbo].[Ban] ([IdBan])
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD FOREIGN KEY([TenLoaiThucDon])
REFERENCES [dbo].[Loai] ([TenLoaiThucDon])
GO
/****** Object:  StoredProcedure [dbo].[Pro_DanhSachGoiMonLenLV]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_DanhSachGoiMonLenLV]
@id nvarchar(30)
as
begin
	select * from GoiMon where IdBan=@id
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_DoiMatKhau]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pro_DoiMatKhau]
@username nvarchar(30) , @pass nvarchar(30)
as
begin
	update TaiKhoan set Pass=@pass where Username=@username
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_Login]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_Login]
@user varchar(30) , @pass varchar(30)
as
begin
	select *from TaiKhoan where Username=@user and Pass=@pass
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_SuaBan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[Pro_SuaBan]
@Idban nvarchar(30) , @Tenban nvarchar(100) ,@Trangthai nvarchar(100)
as
begin
	Update Ban set TenBan=@Tenban,TrangThai=@Trangthai where IdBan=@Idban
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_SuaGoiMon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_SuaGoiMon]
@Idban nvarchar(30), @Idthucdon nvarchar(30), @tenthucdon nvarchar(100) ,@dongia decimal ,@soluong int,@thoigian datetime,@thanhtien decimal
as
begin
	UPDATE  GoiMon SET SoLuong=@soluong,ThanhTien=@thanhtien,TenThucDon=@tenthucdon,DonGia=@dongia,ThoiGian=@thoigian where IdBan=@Idban and IdThucDon=@Idthucdon
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_SuaNv]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_SuaNv]
@Id nvarchar(30) , @Ten nvarchar(30) ,@ngaysinh datetime,@gioitinh nvarchar(4),@luong decimal,@dienthoai varchar(12),@gmail nvarchar(30),@chucvu nvarchar(30)
as
begin
	UPDATE NhanVien SET TenNhanVien=@Ten,Ngaysinh=@ngaysinh,GioiTinh=@gioitinh,Luong=@luong,Dienthoai=@dienthoai,Gmail=@gmail,ChucVu=@chucvu where IdNhanVien=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_SuaTaiKhoan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_SuaTaiKhoan]
@taikhoan nvarchar(30) , @matkhau nvarchar(30) , @quyen int
as
begin
	UPDATE  TaiKhoan Set Pass=@matkhau,quyen =@quyen where Username=@taikhoan
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_SuaThucDon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_SuaThucDon]
@Id nvarchar(30) , @Ten nvarchar(30) ,@donvitinh nvarchar(30),@trangthai nvarchar(30),@dongia decimal,@tenloai nvarchar(30)
as
begin
	UPDATE ThucDon SET TenThucDon=@Ten , DonViTinh=@donvitinh, TrangThai=@trangthai, DonGia=@dongia , TenLoaiThucDon=@tenloai where IdThucDon=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemBan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemBan]
@Idban nvarchar(30) , @Tenban nvarchar(100) ,@Trangthai nvarchar(100)
as
begin
	insert into Ban(IdBan,TenBan,TrangThai) Values(@Idban,@Tenban,@Trangthai)
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemCTHD]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemCTHD]
@Idhoadon nvarchar(30), @Idthucdon nvarchar(30), @soluong int , @dongia decimal
as
begin
	insert into ChiTietHoaDon(IdHoaDon,IdThucDon,Soluong,DonGia) Values(@Idhoadon,@Idthucdon,@soluong,@dongia)
	
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemGoiMon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemGoiMon]
@Idban nvarchar(30), @Idthucdon nvarchar(30), @tenthucdon nvarchar(100) ,@dongia decimal ,@soluong int,@thoigian datetime,@thanhtien decimal
as
begin
	INSERT into GoiMon (IdBan,IdThucDon,TenThucDon,DonGia,SoLuong,ThoiGian,ThanhTien)VALUES(@Idban,@Idthucdon,@tenthucdon,@dongia,@soluong,@thoigian,@thanhtien)
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemHoaDon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemHoaDon]
@Idhoadon nvarchar(30), @Idban nvarchar(30) ,@ngaylap datetime, @sotien decimal
as
begin
	INSERT into HoaDon (IdHoaDon,IdBan,GioDen,TongTien)VALUES(@Idhoadon,@Idban,@ngaylap,@sotien)

end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemNhanVien]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemNhanVien]
@Id nvarchar(30) , @Ten nvarchar(30) ,@ngaysinh datetime,@gioitinh nvarchar(4),@luong decimal,@dienthoai varchar(12),@gmail nvarchar(30),@chucvu nvarchar(30)
as
begin
	INSERT into NhanVien(IdNhanVien,TenNhanVien,Ngaysinh,GioiTinh,Luong,Dienthoai,Gmail,ChucVu)VALUES(@Id,@Ten,@ngaysinh,@gioitinh,@luong,@dienthoai,@gmail,@chucvu)
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemTaiKhoan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemTaiKhoan]
@taikhoan nvarchar(30) , @matkhau nvarchar(30) , @quyen int
as
begin
	INSERT into TaiKhoan(Username,Pass,quyen) Values(@taikhoan,@matkhau,@quyen)
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_ThemThucDon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_ThemThucDon]
@Id nvarchar(30) , @Ten nvarchar(30) ,@donvitinh nvarchar(30),@trangthai nvarchar(30),@dongia decimal,@tenloai nvarchar(30)
as
begin
	INSERT into ThucDon(IdThucDon,TenThucDon,DonViTinh,TrangThai,DonGia,TenLoaiThucDon)VALUES(@Id,@Ten,@donvitinh,@trangthai,@dongia,@tenloai)
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_TimKiemNv]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_TimKiemNv]
@find nvarchar(100)
as
begin
	Select * From NhanVien Where CONCAT (TenNhanVien,IdNhanVien,ChucVu) like N'%'+@find+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_TimKiemTD]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_TimKiemTD]
@find nvarchar(100)
as
begin
	Select * From ThucDon Where CONCAT (TenThucDon,IdThucDon,TrangThai,TenLoaiThucDon) like N'%'+@find+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_XoaBan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_XoaBan]
@Idban nvarchar(30)
as
begin
	DELETE Ban where IdBan=@Idban
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_XoaCTHD]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_XoaCTHD]
@Idthucdon nvarchar(30)
as
begin
	Delete ChiTietHoaDon where IdThucDon=@Idthucdon
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_XoaGoiMon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pro_XoaGoiMon]
@Idban nvarchar(30) , @Idthucdon nvarchar(30)
as
begin
	DELETE GoiMon where IdBan = @Idban and IdThucDon=@Idthucdon
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_XoaNhanVien]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_XoaNhanVien]
@Id nvarchar(30)
as
begin
	Delete NhanVien where IdNhanVien=@Id
end
GO
/****** Object:  StoredProcedure [dbo].[PRO_XoaTaiKhoan]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[PRO_XoaTaiKhoan]
@taikhoan nvarchar(30)
as
begin
	DELETE TaiKhoan where Username=@taikhoan
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_XoaTatCatGoiMon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Pro_XoaTatCatGoiMon]
@IdBan nvarchar(30)
as
begin
	Delete GoiMon where IdBan=@Idban
end
GO
/****** Object:  StoredProcedure [dbo].[Pro_XoaThucDon]    Script Date: 21/12/2018 12:39:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Pro_XoaThucDon]
@id nvarchar(30)
as
begin
	Delete ThucDon where IdThucDon=@id
end
GO
USE [master]
GO
ALTER DATABASE [QuanLyNuoc] SET  READ_WRITE 
GO
