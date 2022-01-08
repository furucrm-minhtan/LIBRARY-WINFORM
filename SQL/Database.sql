USE QLTV;
GO

/* FROP PROC */

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

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'readers')  
   DROP TABLE [dbo].readers;  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'books')  
   DROP TABLE [dbo].books;  
GO

IF EXISTS(SELECT * FROM sys.tables WHERE SCHEMA_NAME(schema_id) LIKE 'dbo' AND name like 'tags')  
   DROP TABLE [dbo].tags;  
GO

CREATE TABLE readers (
	ma_doc_gia CHAR(8) PRIMARY KEY,
	ho_ten VARCHAR(255),
	mat_khau VARCHAR(255),
	ngay_sinh DATE,
	dan_toc VARCHAR(10),
	quoc_tinh VARCHAR(20),
	so_dien_thoai CHAR(11),
	email VARCHAR(100),
	cmnd VARCHAR(15),
	noi_cap VARCHAR(20),
	nghe_nghiep VARCHAR(20),
	bang_cap VARCHAR(10),
	truong VARCHAR(50),
	lop VARCHAR(10),
	nguoi_giam_ho CHAR(8),
	anh_dai_dien TEXT,
	loai VARCHAR(10) DEFAULT('Adult') CHECK (loai IN ('Adult', 'Child')),
	ngay_tao DATETIME,
	gioi_tinh NCHAR(6) NOT NULL

	CHECK (gioi_tinh IN('Nam', 'Nữ'))
	FOREIGN KEY (nguoi_giam_ho) REFERENCES readers(ma_doc_gia)
)

CREATE TABLE tags(
	ma_muc INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ten_muc VARCHAR(20) UNIQUE,
)

CREATE TABLE books (
	ma_sach CHAR(9) PRIMARY KEY,
	ten_sach VARCHAR(255),
	ten_tac_gia VARCHAR(255),
	mo_ta TEXT,
	vi_tri VARCHAR(10) UNIQUE,
	ngay_xuat_ban DATE,
	so_luong_ton_kho INT,
	isbn VARCHAR(20),
	trang_bia VARCHAR(100),
	the_loai INT,
	ngay_tao DATETIME
	
	FOREIGN KEY (the_loai) REFERENCES tags(ma_muc)
)

/*==============Reader===============*/

GO

CREATE PROC GetLastestAdultReaderCode
AS
	SELECT TOP 1 SUBSTRING(ma_doc_gia, 3, 7) AS code FROM readers WHERE ma_doc_gia LIKE 'NL%' ORDER BY ngay_tao DESC;
GO

CREATE PROC GetLastestChildReaderCode
AS
	SELECT TOP 1 SUBSTRING(ma_doc_gia, 3, 7) AS code FROM readers WHERE ma_doc_gia LIKE 'TE%' ORDER BY ngay_tao DESC;
GO

CREATE PROC GetReaders
AS
	SELECT * FROM readers;
GO

CREATE PROC GetAdultReaders
AS
	SELECT * FROM readers WHERE ma_doc_gia LIKE 'NL%';
GO

CREATE PROC CreateAdultReader @MADG CHAR(8), @PhoneNumber CHAR(11), @Avatar TEXT, @DisplayName VARCHAR(255), @Password VARCHAR(255), @Birth DATE, @Email VARCHAR(100), @Nation VARCHAR(10), @Nationality VARCHAR(20), @Sex CHAR(6), @Id VARCHAR(15), @IssuedPlace VARCHAR(20), @Job VARCHAR(20), @Degree VARCHAR(10), @CreatedDate DateTime
AS
	INSERT INTO readers(ma_doc_gia, so_dien_thoai, ho_ten, mat_khau, ngay_sinh, dan_toc, quoc_tinh, email, gioi_tinh, cmnd, noi_cap, nghe_nghiep, bang_cap, anh_dai_dien, ngay_tao, loai) 
	VALUES (@MADG, @PhoneNumber, @DisplayName, @Password, @Birth, @Nation, @Nationality, @Email, @Sex, @Id, @IssuedPlace, @Job, @Degree, @Avatar, @CreatedDate, 'Adult')
GO

CREATE PROC CreateChildReader @MADG CHAR(8),@PhoneNumber CHAR(11), @Avatar TEXT, @DisplayName VARCHAR(255), @Password VARCHAR(255), @Birth DATE, @Email VARCHAR(100), @Sex CHAR(6), @School VARCHAR(50), @Class VARCHAR(10), @Protector CHAR(10), @CreatedDate DateTime
AS
	INSERT INTO readers(ma_doc_gia, so_dien_thoai, ho_ten, mat_khau, ngay_sinh, email, gioi_tinh, truong, lop, nguoi_giam_ho, anh_dai_dien, ngay_tao, loai) 
	VALUES (@MADG, @PhoneNumber, @DisplayName, @Password, @Birth, @Email, @Sex, @School, @Class, @Protector, @Avatar, @CreatedDate, 'Child')
GO

CREATE PROC UpdateAdultReader @MADG CHAR(8), @PhoneNumber CHAR(11), @Avatar TEXT, @DisplayName VARCHAR(255), @Password VARCHAR(255), @Birth DATE, @Email VARCHAR(100), @Nation VARCHAR(10), @Nationality VARCHAR(20), @Sex CHAR(6), @Id VARCHAR(15), @IssuedPlace VARCHAR(20), @Job VARCHAR(20), @Degree VARCHAR(10)
AS
	UPDATE readers SET so_dien_thoai=@PhoneNumber, ho_ten=@DisplayName,mat_khau=@Password,ngay_sinh=@Birth,dan_toc=@Nation,quoc_tinh=@Nationality,email=@Email,gioi_tinh=@Sex,cmnd=@Id,noi_cap=@IssuedPlace,nghe_nghiep=@Job,bang_cap=@Degree,anh_dai_dien=@Avatar WHERE ma_doc_gia=@MADG;
GO

CREATE PROC UpdateChildReader @MADG CHAR(8), @PhoneNumber CHAR(11), @Avatar TEXT, @DisplayName VARCHAR(255), @Password VARCHAR(255), @Birth DATE, @Email VARCHAR(100), @Nation VARCHAR(10), @Nationality VARCHAR(20), @Sex CHAR(6), @School VARCHAR(50), @Class VARCHAR(10), @Protector CHAR(10)
AS
	UPDATE readers SET so_dien_thoai=@PhoneNumber, ho_ten=@DisplayName,mat_khau=@Password,ngay_sinh=@Birth,dan_toc=@Nation,quoc_tinh=@Nationality,email=@Email,gioi_tinh=@Sex,truong=@School,lop=@Class,nguoi_giam_ho=@Protector,anh_dai_dien=@Avatar WHERE ma_doc_gia=@MADG;
GO

CREATE PROC CheckUserExist @UserName CHAR(8)
AS
	SELECT * FROM readers WHERE ma_doc_gia=@UserName;
GO

CREATE PROC DeleteReader @MADG CHAR(10)
AS
	DELETE FROM readers WHERE ma_doc_gia=@MADG;
GO


/*============== Book ===============*/

CREATE PROC GetBooks
AS
	SELECT * FROM books;
GO

--CREATE PROC CreateBook @Name VARCHAR(255), @Author VARCHAR(255), @Description TEXT, @Cover VARCHAR(255), @Publish DATE, @ISBN VARCHAR(20), @Position VARCHAR(10), @Remain INT
--AS
--	INSERT INTO books(ten_sach, ten_tac_gia, mo_ta, trang_bia, ngay_xuat_ban, ISBN, vi_tri, so_luong_ton_kho)
--	VALUES(@Name, @Author, @Description, @Cover, @Publish, @ISBN, @Position, @Remain);
--GO

--CREATE PROC UpdateBook @Id INT, @Name VARCHAR(255), @Author VARCHAR(255), @Description TEXT, @Cover VARCHAR(255), @Publish DATE, @ISBN VARCHAR(20), @Position VARCHAR(10), @Remain INT
--AS
--	UPDATE books SET ten_sach=@Name,ten_tac_gia=@Author,mo_ta=@Description,trang_bia=@Cover,ngay_xuat_ban=@Publish,ISBN=@ISBN,vi_tri=@Position,so_luong_ton_kho=@Remain WHERE ma_sach = @Id;
--GO

CREATE PROC DeleteBook @Id INT
AS
	DELETE books WHERE ma_sach=@Id;
GO

CREATE PROC FindWithBookName @Name NVARCHAR(255)
AS
	SELECT * FROM books WHERE ten_sach LIKE @Name + '%';
GO

CREATE PROC FindWithAuthorName @Name NVARCHAR(255)
AS
	SELECT * FROM books WHERE ten_tac_gia LIKE @Name + '%';
GO

CREATE PROC FindWithPublishDate @Publish DATE
AS
	SELECT * FROM books WHERE ngay_xuat_ban = @Publish;
GO

CREATE PROC FindWithBookTag @TagId INT
AS
	SELECT * FROM books WHERE the_loai = @TagId;
GO

/*============== Tag ===============*/
CREATE PROC GetTags
AS
	SELECT * FROM tags;
GO