create proc themkhachhang
@tenkh nvarchar(30),@sdt varchar(20),@email nvarchar(50),@loai int
as begin
	insert into KhachHang values(@tenkh,@sdt,@email,@loai)
end
go
---các procedure 
create proc listKhachHang
as begin
	select * from KhachHang
end
go
create proc timKhachHangTheoSDT
@sdt nchar(4000)
as begin
	select * from KhachHang where DienThoai=@sdt
end
go
create proc timKhachHangTheoTen
@ten nvarchar(4000)
as begin
	select * from KhachHang where HoTen=@ten
end
go

create proc taoKhachHang
@ten nvarchar(4000), @sdt varchar(4000), @email nvarchar(4000), @loai int
as begin
	insert into KhachHang values(@ten, @sdt, @email, @loai)
end
go

create proc xoakhachhang
@makh int
as begin
	delete from KhachHang where ID_KhachHang=@makh
end
go

create proc suakhachhang
@makh int, @tenkh nvarchar(30),@sdt varchar(20),@email nvarchar(50),@loai int
as begin
	update KhachHang set HoTen=@tenkh, DienThoai=@sdt, Email = @email, Loai = @loai where ID_KhachHang=@makh
end
go

alter proc timkhachhangtheotenhoacsdt @ma nvarchar(50)
as begin
	select * from KhachHang where HoTen like '%'+@ma+'%' or DienThoai like '%'+@ma+'%'
end
go