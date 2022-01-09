create proc usp_dangnhap @username nchar(10), @pass nchar(30)
as
	if not exists (select * from DocGia where MaDocGia = @username and MatKhau = @pass)
	begin
		RAISERROR(N'Mã đọc giả hoặc mật khẩu không đúng',16,1)
		return
	end
	select * from DocGia where MaDocGia = @username and MatKhau = @pass
go

exec usp_dangnhap N'NL00000001', N'hothienphuc1999'