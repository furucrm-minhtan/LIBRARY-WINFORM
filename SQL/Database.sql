USE [QLTV]
GO

/* DROP PROC */

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetLastestAdultReaderCode')
	DROP PROCEDURE GetLastestAdultReaderCode
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetLastestChildReaderCode')
	DROP PROCEDURE GetLastestChildReaderCode
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetReaders')
	DROP PROCEDURE GetReaders
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetAdultReaders')
	DROP PROCEDURE GetAdultReaders
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'CreateAdultReader')
	DROP PROCEDURE CreateAdultReader
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateAdultReader')
	DROP PROCEDURE UpdateAdultReader
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'CreateChildReader')
	DROP PROCEDURE CreateChildReader
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateChildReader')
	DROP PROCEDURE UpdateChildReader
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'CheckUserExist')
	DROP PROCEDURE CheckUserExist
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DeleteReader')
	DROP PROCEDURE DeleteReader
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetBooks')
	DROP PROCEDURE GetBooks
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'CreateBook')
	DROP PROCEDURE CreateBook
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'UpdateBook')
	DROP PROCEDURE UpdateBook
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'DeleteBook')
	DROP PROCEDURE DeleteBook
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'FindWithBookName')
	DROP PROCEDURE FindWithBookName
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'FindWithAuthorName')
	DROP PROCEDURE FindWithAuthorName
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'FindWithPublishDate')
	DROP PROCEDURE FindWithPublishDate
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'FindWithBookTag')
	DROP PROCEDURE FindWithBookTag
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'GetTags')
	DROP PROCEDURE GetTags
GO

/* DROP TABLE */

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'CTPhieuMuon')  
   DROP TABLE [dbo].[CTPhieuMuon];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'PhieuMuon')  
   DROP TABLE [dbo].[PhieuMuon];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'PhieuTra')  
   DROP TABLE [dbo].[PhieuTra];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'SuKien')  
   DROP TABLE [dbo].[SuKien];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'ThongBao')  
   DROP TABLE [dbo].[ThongBao];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Sach')  
   DROP TABLE [dbo].[Sach];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'NhanVien')  
   DROP TABLE [dbo].[NhanVien];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'ThuVien')  
   DROP TABLE [dbo].[ThuVien];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Muc')  
   DROP TABLE [dbo].[Muc];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'DocGia')  
   DROP TABLE [dbo].[DocGia];  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'Muc')  
   DROP TABLE [dbo].[Muc];  
GO

/****** Object:  Table [dbo].[CTPhieuMuon]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuMuon](
	[MaPhieuMuon] [int] NOT NULL,
	[MaSach] [nchar](9) NOT NULL,
	[MaThuVien] [nchar](5) NOT NULL,
	[NgayHetHan] [datetime] NOT NULL,
	[SoNgayTreHan] [int] NULL,
	[MaPhieuTra] [int] NULL,
 CONSTRAINT [PK_CTPhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC,
	[MaSach] ASC,
	[MaThuVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [nchar](8) NOT NULL,
	[MatKhau] [nchar](30) NOT NULL,
	[TenDocGia] [nchar](20) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nchar](3) CHECK (GioiTinh IN('Nam', 'Nữ')),
	[DanToc] [nchar](10) NULL,
	[QuocTich] [nchar](10) NULL,
	[Email] [nchar](100) NULL,
	[SDTDocGia] [nchar](15) NULL,
	[AnhDaiDien] [text] NULL,
	[CMND] [nchar](20) NULL,
	[NoiCap] [nchar](10) NULL,
	[NgheNghiep] [nchar](10) NULL,
	[TrinhDo] [nchar](10) NULL,
	[TruongHoc] [nchar](30) NULL,
	[LopHoc] [nchar](5) NULL,
	[MaNguoiGiamHo] [nchar](8) NULL,
	[NgayTao] [datetime] NOT NULL,
	[loai] [varchar](10) DEFAULT('Adult') CHECK (loai IN ('Adult', 'Child')),

	
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Muc]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Muc](
	[MaMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenMuc] [nchar](30) NULL,
 CONSTRAINT [PK_Muc] PRIMARY KEY CLUSTERED 
(
	[MaMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Username] [nchar](30) NOT NULL,
	[Password] [nchar](30) NULL,
	[AnhNhanVien] [image] NULL,
	[TenNhanVien] [nchar](20) NULL,
	[MailNhanVien] [nchar](20) NULL,
	[DienThoaiLienLac] [nchar](15) NULL,
	[QuocGia] [nchar](10) NULL,
	[ChucVu] [nchar](15) NULL,
	[DiaChiNhanVien] [nchar](50) NULL,
	[MaThuVien] [nchar](5) NULL
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPhieuMuon] [int] IDENTITY(1,1) NOT NULL,
	[NgayMuon] [datetime] NOT NULL,
	[MaDocGia] [nchar](8) NOT NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuTra]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuTra](
	[MaPhieuTra] [int] IDENTITY(1,1) NOT NULL,
	[NgayTra] [datetime] NOT NULL,
	[NVTiepNhan] [nchar](30) NOT NULL,
 CONSTRAINT [PK_PhieuTra] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sach]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](9) NOT NULL,
	[MaThuVien] [nchar](5) NOT NULL,
	[TenSach] [nchar](30) NULL,
	[TacGia] [nchar](20) NULL,
	[SoLuongTonKho] [int] NULL,
	[MoTa] [nchar](50) NULL,
	[TrangBia] [image] NULL,
	[NgayXuatBan] [date] NULL,
	[ISBN] [nchar](15) NULL,
	[ViTri] [nchar](5) NULL,
	[TheLoai] [nchar](2) NULL,
	[MaMuc] [int] NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC,
	[MaThuVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SuKien]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuKien](
	[MaSuKien] [int] IDENTITY(1,1) NOT NULL,
	[TieuDeSuKien] [nchar](30) NULL,
	[NoiDungSuKien] [nchar](100) NULL,
	[ThoiGianToChuc] [datetime] NULL,
	[DiaDiemToChuc] [nchar](30) NULL,
	[NVPhuTrach] [nchar](30) NOT NULL,
 CONSTRAINT [PK_SuKien] PRIMARY KEY CLUSTERED 
(
	[MaSuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongBao]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongBao](
	[MaThongBao] [int] IDENTITY(1,1) NOT NULL,
	[TieuDeThongBao] [nchar](30) NULL,
	[NoiDungThongBao] [nchar](100) NULL,
	[ThoiGianThongBao] [datetime] NULL,
	[NVTaoThongBao] [nchar](30) NOT NULL,
 CONSTRAINT [PK_ThongBao] PRIMARY KEY CLUSTERED 
(
	[MaThongBao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuVien]    Script Date: 1/5/2022 3:00:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuVien](
	[MaThuVien] [nchar](5) NOT NULL,
	[TenThuVien] [nchar](20) NOT NULL,
	[SDT] [nchar](12) NULL,
	[DiaChiThuVien] [nchar](30) NULL,
 CONSTRAINT [PK_ThuVien] PRIMARY KEY CLUSTERED 
(
	[MaThuVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuMuon_PhieuMuon] FOREIGN KEY([MaPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([MaPhieuMuon])
GO
ALTER TABLE [dbo].[CTPhieuMuon] CHECK CONSTRAINT [FK_CTPhieuMuon_PhieuMuon]
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuMuon_PhieuTra] FOREIGN KEY([MaPhieuTra])
REFERENCES [dbo].[PhieuTra] ([MaPhieuTra])
GO
ALTER TABLE [dbo].[CTPhieuMuon] CHECK CONSTRAINT [FK_CTPhieuMuon_PhieuTra]
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_CTPhieuMuon_Sach] FOREIGN KEY([MaSach], [MaThuVien])
REFERENCES [dbo].[Sach] ([MaSach], [MaThuVien])
GO
ALTER TABLE [dbo].[CTPhieuMuon] CHECK CONSTRAINT [FK_CTPhieuMuon_Sach]
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_DocGia_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_DocGia_DocGia]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ThuVien] FOREIGN KEY([MaThuVien])
REFERENCES [dbo].[ThuVien] ([MaThuVien])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ThuVien]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_DocGia] FOREIGN KEY([MaDocGia])
REFERENCES [dbo].[DocGia] ([MaDocGia])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_DocGia]
GO
ALTER TABLE [dbo].[PhieuTra]  WITH CHECK ADD  CONSTRAINT [FK_PhieuTra_NhanVien] FOREIGN KEY([NVTiepNhan])
REFERENCES [dbo].[NhanVien] ([Username])
GO
ALTER TABLE [dbo].[PhieuTra] CHECK CONSTRAINT [FK_PhieuTra_NhanVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_Muc] FOREIGN KEY([MaMuc])
REFERENCES [dbo].[Muc] ([MaMuc])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_Muc]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_ThuVien] FOREIGN KEY([MaThuVien])
REFERENCES [dbo].[ThuVien] ([MaThuVien])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_ThuVien]
GO
ALTER TABLE [dbo].[SuKien]  WITH CHECK ADD  CONSTRAINT [FK_SuKien_NhanVien] FOREIGN KEY([NVPhuTrach])
REFERENCES [dbo].[NhanVien] ([Username])
GO
ALTER TABLE [dbo].[SuKien] CHECK CONSTRAINT [FK_SuKien_NhanVien]
GO
ALTER TABLE [dbo].[ThongBao]  WITH CHECK ADD  CONSTRAINT [FK_ThongBao_NhanVien] FOREIGN KEY([NVTaoThongBao])
REFERENCES [dbo].[NhanVien] ([Username])
GO
ALTER TABLE [dbo].[ThongBao] CHECK CONSTRAINT [FK_ThongBao_NhanVien]
GO

/*==============Reader===============*/

GO

CREATE PROC GetLastestAdultReaderCode
AS
	SELECT TOP 1 SUBSTRING(MaDocGia, 3, 7) AS code FROM DocGia WHERE MaDocGia LIKE 'NL%' ORDER BY NgayTao DESC;
GO

CREATE PROC GetLastestChildReaderCode
AS
	SELECT TOP 1 SUBSTRING(MaDocGia, 3, 7) AS code FROM DocGia WHERE MaDocGia LIKE 'TE%' ORDER BY NgayTao DESC;
GO

CREATE PROC GetReaders
AS
	SELECT * FROM DocGia;
GO

CREATE PROC GetAdultReaders
AS
	SELECT * FROM DocGia WHERE MaDocGia LIKE 'NL%';
GO

CREATE PROC CreateAdultReader 
@MADG CHAR(8),
@PhoneNumber NCHAR(15),
@Avatar TEXT,
@DisplayName NCHAR(20),
@Password NCHAR(30),
@Birth DATE,
@Email NCHAR(100),
@Nation NCHAR(10),
@Nationality NCHAR(10),
@Sex NCHAR(3), 
@Id NCHAR(20),
@IssuedPlace NCHAR(10),
@Job NCHAR(10),
@Degree NCHAR(10),
@CreatedDate DateTime
AS
	INSERT INTO DocGia(MaDocGia, SDTDocGia, TenDocGia, MatKhau, NgaySinh, DanToc, QuocTich, Email, GioiTinh, CMND, NoiCap, NgheNghiep, TrinhDo, AnhDaiDien, NgayTao, Loai) 
	VALUES (@MADG, @PhoneNumber, @DisplayName, @Password, @Birth, @Nation, @Nationality, @Email, @Sex, @Id, @IssuedPlace, @Job, @Degree, @Avatar, @CreatedDate, 'Adult')
GO

CREATE PROC CreateChildReader 
@MADG CHAR(8),
@PhoneNumber CHAR(15),
@Avatar TEXT,
@DisplayName NCHAR(20), 
@Password NCHAR(30), 
@Birth DATE,
@Nation NCHAR(10),
@Nationality NCHAR(20),
@Email NCHAR(100),
@Sex NCHAR(3),
@School NCHAR(50),
@Class NCHAR(10),
@Protector NCHAR(8),
@CreatedDate DateTime
AS
	INSERT INTO DocGia(MaDocGia, SDTDocGia, TenDocGia, MatKhau, NgaySinh, DanToc, QuocTich, Email, GioiTinh, TruongHoc, LopHoc, MaNguoiGiamHo, AnhDaiDien, NgayTao, Loai) 
	VALUES (@MADG, @PhoneNumber, @DisplayName, @Password, @Birth, @Nation, @Nationality, @Email, @Sex, @School, @Class, @Protector, @Avatar, @CreatedDate, 'Child')
GO

CREATE PROC CheckUserExist @UserName CHAR(8)
AS
	SELECT * FROM DocGia WHERE MaDocGia=@UserName;
GO

CREATE PROC DeleteReader @MADG CHAR(10)
AS
	DELETE FROM DocGia WHERE MaDocGia=@MADG;
GO


/*============== Book ===============*/

CREATE PROC GetBooks
AS
	SELECT * FROM Sach;
GO

CREATE PROC DeleteBook @Id INT
AS
	DELETE Sach WHERE MaSach=@Id;
GO

CREATE PROC FindWithBookName @Name NVARCHAR(255)
AS
	SELECT * FROM Sach WHERE TenSach LIKE @Name + '%';
GO

CREATE PROC FindWithAuthorName @Name NVARCHAR(255)
AS
	SELECT * FROM Sach WHERE TacGia LIKE @Name + '%';
GO

CREATE PROC FindWithPublishDate @Publish DATE
AS
	SELECT * FROM Sach WHERE NgayXuatBan = @Publish;
GO

CREATE PROC FindWithBookTag @TagId INT
AS
	SELECT * FROM Sach WHERE TheLoai = @TagId;
GO

/*============== Tag ===============*/
CREATE PROC GetTags
AS
	SELECT * FROM Muc;
GO