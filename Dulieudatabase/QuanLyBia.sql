USE [QuanLyBia]
GO
/****** Object:  Table [dbo].[BanChoi]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanChoi](
	[MaBan] [nvarchar](10) NOT NULL,
	[LoaiBan] [nvarchar](10) NOT NULL,
	[GiaThue] [float] NOT NULL,
	[TrangThai] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaBan] [nvarchar](10) NOT NULL,
	[MaDichVu] [nvarchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[Gia] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[MaBan] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[MaDichVu] [nvarchar](10) NOT NULL,
	[TenDichVu] [nvarchar](50) NOT NULL,
	[GiaDichVu] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[MaKhachHang] [nvarchar](10) NULL,
	[NgayLap] [datetime] NOT NULL,
	[TongTien] [float] NOT NULL,
	[TienDaTT] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [nvarchar](10) NOT NULL,
	[TenKhachHang] [nvarchar](10) NOT NULL,
	[DiaChi] [nvarchar](10) NULL,
	[DienThoai] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[DiemTichLuy] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBan]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBan](
	[MaLoaiBan] [nvarchar](10) NOT NULL,
	[TenLoaiBan] [nvarchar](50) NOT NULL,
	[GiaThue] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [nvarchar](10) NOT NULL,
	[TenNhaCungCap] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[manv] [nchar](10) NOT NULL,
	[tennv] [nvarchar](50) NOT NULL,
	[namsinh] [int] NOT NULL,
	[luong] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuDungBan]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuDungBan](
	[MaSuDung] [int] IDENTITY(1,1) NOT NULL,
	[MaBan] [nvarchar](10) NOT NULL,
	[MaKhachHang] [nvarchar](10) NOT NULL,
	[ThoiGianBat] [datetime] NOT NULL,
	[ThoiGianTat] [datetime] NULL,
	[ChiPhi] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSuDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 12/20/2024 4:35:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[MaHoaDon] [nvarchar](10) NOT NULL,
	[TienDaTT] [float] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC,
	[TienDaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B01', N'PREDATOR', 150000, N'Còn Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B02', N'predato', 120000, N'Còn Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B03', N'MIT', 2500, N'Hết Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B06', N'PREDATOR', 25000, N'Còn Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B07', N'MITcui', 2500, N'Còn Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B10', N'APLUs', 16000, N'Hết Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B109', N'predato', 120000, N'Còn Bàn')
INSERT [dbo].[BanChoi] ([MaBan], [LoaiBan], [GiaThue], [TrangThai]) VALUES (N'B11', N'APLISS', 11100, N'Còn Bàn')
GO
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (N'DV1', N'VIPPOR', 12000)
INSERT [dbo].[DichVu] ([MaDichVu], [TenDichVu], [GiaDichVu]) VALUES (N'DV3', N'DAWWww', 11111)
GO
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [NgayLap], [TongTien], [TienDaTT]) VALUES (N'HD11', N'AA03', CAST(N'2024-12-20T09:30:49.193' AS DateTime), 262.40706666666665, 262.40706666666665)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [NgayLap], [TongTien], [TienDaTT]) VALUES (N'HDA1', N'AA02', CAST(N'2024-12-20T16:13:33.603' AS DateTime), 16.581436736111112, 16.581436736111112)
INSERT [dbo].[HoaDon] ([MaHoaDon], [MaKhachHang], [NgayLap], [TongTien], [TienDaTT]) VALUES (N'HDV1', N'AA03', CAST(N'2024-12-19T22:12:01.273' AS DateTime), 19.252415972222224, 19.252415972222224)
GO
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [Email], [DiemTichLuy]) VALUES (N'AA01', N'LEVIP', N'HN', 29283921, N'FWEFWE', 11221)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [Email], [DiemTichLuy]) VALUES (N'AA02', N'LEVIPVD', N'HN', 292839, N'FWEFfs3', 11221)
INSERT [dbo].[KhachHang] ([MaKhachHang], [TenKhachHang], [DiaChi], [DienThoai], [Email], [DiemTichLuy]) VALUES (N'AA03', N'FSEFSENK', N'HN', 2928, N'FWEFWE', 11221)
GO
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan], [GiaThue]) VALUES (N'BZ01', N'PREDATOR', 100000)
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan], [GiaThue]) VALUES (N'BZ02', N'MIT', 100000)
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan], [GiaThue]) VALUES (N'bz04', N'adw', 11111)
INSERT [dbo].[LoaiBan] ([MaLoaiBan], [TenLoaiBan], [GiaThue]) VALUES (N'bz05', N'adwas', 11111)
GO
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC1', N'CUETEC', N'USA', 998288, N'CUETEC@MAIL')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC3', N'NGOCMY', N'VN', 267892, N'NMCUE@MAIL')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC4', N'ADAM', N'SING', 434342, N'AD@MAIL')
INSERT [dbo].[NhaCungCap] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [DienThoai], [Email]) VALUES (N'NCC5', N'QLCUE', N'CHINAwda', 4343332, N'QL@MAIL11')
GO
INSERT [dbo].[NhanVien] ([manv], [tennv], [namsinh], [luong]) VALUES (N'nv01      ', N'le duc t', 2004, 12000)
GO
SET IDENTITY_INSERT [dbo].[SuDungBan] ON 

INSERT [dbo].[SuDungBan] ([MaSuDung], [MaBan], [MaKhachHang], [ThoiGianBat], [ThoiGianTat], [ChiPhi]) VALUES (1, N'B06', N'AA02', CAST(N'2024-12-19T21:28:43.100' AS DateTime), CAST(N'2024-12-19T21:28:47.203' AS DateTime), 28.492092361111112)
INSERT [dbo].[SuDungBan] ([MaSuDung], [MaBan], [MaKhachHang], [ThoiGianBat], [ThoiGianTat], [ChiPhi]) VALUES (2, N'B06', N'AA02', CAST(N'2024-12-19T21:28:57.993' AS DateTime), CAST(N'2024-12-19T21:29:02.087' AS DateTime), 28.436471527777776)
INSERT [dbo].[SuDungBan] ([MaSuDung], [MaBan], [MaKhachHang], [ThoiGianBat], [ThoiGianTat], [ChiPhi]) VALUES (3, N'B06', N'AA03', CAST(N'2024-12-19T21:32:20.100' AS DateTime), CAST(N'2024-12-19T21:32:22.873' AS DateTime), 19.252415972222224)
INSERT [dbo].[SuDungBan] ([MaSuDung], [MaBan], [MaKhachHang], [ThoiGianBat], [ThoiGianTat], [ChiPhi]) VALUES (4, N'B02', N'AA03', CAST(N'2024-12-20T09:30:32.863' AS DateTime), CAST(N'2024-12-20T09:30:40.737' AS DateTime), 262.40706666666665)
INSERT [dbo].[SuDungBan] ([MaSuDung], [MaBan], [MaKhachHang], [ThoiGianBat], [ThoiGianTat], [ChiPhi]) VALUES (5, N'B07', N'AA02', CAST(N'2024-12-20T16:13:03.997' AS DateTime), CAST(N'2024-12-20T16:13:27.873' AS DateTime), 16.581436736111112)
SET IDENTITY_INSERT [dbo].[SuDungBan] OFF
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ((0)) FOR [DiemTichLuy]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanChoi] ([MaBan])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DichVu] ([MaDichVu])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[SuDungBan]  WITH CHECK ADD  CONSTRAINT [FK_SuDungBan_BanChoi] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BanChoi] ([MaBan])
GO
ALTER TABLE [dbo].[SuDungBan] CHECK CONSTRAINT [FK_SuDungBan_BanChoi]
GO
ALTER TABLE [dbo].[SuDungBan]  WITH CHECK ADD  CONSTRAINT [FK_SuDungBan_KhachHang] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[SuDungBan] CHECK CONSTRAINT [FK_SuDungBan_KhachHang]
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
