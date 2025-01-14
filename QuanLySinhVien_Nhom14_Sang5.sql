create database QLSV
go
use QLSV
go
-- Người dùng
create table DangNhapGiangVien(
	 [MaGV] nvarchar(11) not null
	,[MatKhau] nvarchar(30)
)
-- Admin
create table DangNhapAdmin(
	 [TenTaiKhoan] nvarchar(11) not null
	,[MatKhau] nvarchar(30)
)
-- Sinh viên
create table SinhVien
(
	 [MaSV] nvarchar(11) not null
	,[TenSV] nvarchar(40)
	,[GioiTinh] nvarchar(3)
	,[NgaySinh] date
	,[CCCD] nvarchar(12)
	,[DiaChi] nvarchar(400)
	,[QueQuan] nvarchar(30)
	,[NienKhoa] nvarchar(30)
	,[MaLop] nvarchar(7) not null
)
-- Khoa
create table Khoa
(
	 [MaKhoa] nvarchar(8) not null
	,[TenKhoa] nvarchar(40)
)
--Chuyên ngành
create table ChuyenNganh
(
	 [MaChuyenNganh] nvarchar(8) not null
	,[TenChuyenNganh] nvarchar(80)
	,[MaKhoa] nvarchar(8) not null
)
--Giảng viên
create table GiangVien
(
	 [MaGV] nvarchar(11) not null
	,[TenGV] nvarchar(60)
	,[GioiTinh] nvarchar(3)
	,[NgaySinh] date
	,[ChucVu] nvarchar(30)
	,[MaKhoa] nvarchar(8) not null
)
-- Đảm nhận
create table DamNhan(
	  [MaGV] nvarchar(11) not null
	 ,[MaLopHP] nvarchar(11) not null
	 ,[ThoiGianBatDau] date
	 ,[ThoiGianKetThuc] date
	 ,[ThoiGianHoc] nvarchar(30)
)
-- Điểm hoc phần
create table DiemHocPhan(
	[DiemThi] float,
	[DiemHeSo1] float,
	[DiemHeSo2] float,
	[DiemTBMon] float,
	[XepLoai] nvarchar(3),
	[NamHoc] nvarchar(30),
	[MaSV] nvarchar(11) not null,
	[MaLopHP] nvarchar(11) not null,
	[MaGV] nvarchar(11) not null
)

create table XepLoai(
	[DiemTBTatCaCacMon] float,
	[HocLuc] nvarchar(12),
	[MaSV] nvarchar(11) not null,
)

-- Điểm rèn luyện
create table DiemRenLuyen(
	 [MaHD] nvarchar(5) not null
	,[NamHoc] nvarchar(30)
	,[HocKy] int
	,[TenHD] nvarchar(200)
	,[ThoiGian] date
	,[Diem] int
	,[MaSV] nvarchar(11) not null
)
-- Học phần
create table HocPhan(
	 [MaHP] nvarchar(11) not null
	,[TenHP] nvarchar(60)
	,[SoTC] int
	,[MaKhoa] nvarchar(8) not null
	,[HocKy] int
)
-- Đăng ký
create table DangKy(
	 [MaSV] nvarchar(11) not null
	,[MaLopHP] nvarchar(11) not null
	,[ThoiGianBatDau] date
	,[ThoiGianKetThuc] date
)
-- Lớp của học phần
create table LopHocPhan(
	  [MaHP] nvarchar(11) not null
	 ,[MaLopHP] nvarchar(11) not null
	 ,[PhongHoc] nvarchar(8)	 
)
-- Lớp của sinh viên
create table Lop(
	 [MaLop] nvarchar(7) not null
	,[MaChuyenNganh] nvarchar(8) not null
	,[MaGV] nvarchar(11) not null
)
-- Học phí
create table HocPhi(
	 [MaMon] nvarchar(11) not null
	,[TienTinChi] int
	,[TongTienTinChi] float
)
create table DongHocPhi(
     [MaSV] nvarchar(11) not null
	,[HoTenSV] nvarchar(40)
	,[TongTien] float
	,[HocKy] int
)

----------------------------------------------Khóa chính
alter table SinhVien
add constraint PK_SinhVien primary key([MaSV])
----Bảng khoa
alter table Khoa
add constraint PK_Khoa primary key ([MaKhoa])
---- Bảng chuyên ngành
alter table ChuyenNganh
add constraint PK_ChuyenNganh primary key ([MaChuyenNganh])
----Bảng giảng viên
alter table GiangVien
add constraint PK_GiangVien primary key ([MaGV])
---- Bảng đảm nhận dạy
alter table DamNhan
add constraint PK_DamNhan primary key ([MaGV],[MaLopHP])
----Bảng môn học
alter table HocPhan
add constraint PK_HocPhan primary key ([MaHP])
----Bảng lớp của sinh viên
alter table Lop
add constraint PK_Lop primary key ([MaLop])
----Bảng lớp học phần
alter table LopHocPhan
add constraint PK_LopHocPhan primary key ([MaLopHP])
---- Bảng điểm rèn luyện

---- Bảng đăng ký môn học
alter table DangKy
add constraint PK_DangKy primary key ([MaSV],[MaLopHP])
---- Bảng đăng nhập giảng viên
alter table DangNhapGiangVien
add constraint PK_DangNhapGiangVien primary key ([MaGV])
---- Bảng đăng nhập admin
alter table DangNhapAdmin
add constraint PK_DangNhapAdmin primary key ([TenTaiKhoan])
---- Bảng điểm học phần
alter table DiemHocPhan 
add constraint PK_DiemHocPhan primary key ([MaSV],[MaLopHP],[MaGV])
---- Bảng học phí
alter table HocPhi
add constraint PK_HocPhi primary key ([MaMon])
----Bảng đóng học phí
alter table DongHocPhi
add constraint PK_DongHocPhi primary key([MaSV])
-----------------------------------------Khóa ngoại
--Khóa ngoại
------
alter table SinhVien
add constraint FK_Lop_SinhVien foreign key([MaLop])
references Lop ([MaLop])
------
alter table HocPhi
add constraint FK_HocPhan_HocPhi foreign key([MaMon])
references HocPhan ([MaHP])



alter table DangNhapGiangVien
add constraint FK_GiangVien_DangNhapGiangVien foreign key([MaGV])
references GiangVien ([MaGV])
------
alter table HocPhan
add constraint FK_Khoa_HocPhan foreign key([MaKhoa])
references Khoa([MaKhoa])
-----
alter table DiemRenLuyen
add constraint FK_SinhVien_DiemRenLuyen foreign key ([MaSV])
references SinhVien ([MaSV])
-----
alter table ChuyenNganh
add constraint FK_Khoa_ChuyenNganh foreign key ([MaKhoa])
references Khoa ([MaKhoa])
----
alter table Lop
add constraint FK_GiangVien_Lop foreign key([MaGV])
references GiangVien ([MaGV])
------
alter table GiangVien
add constraint FK_Khoa_GiangVien foreign key([MaKhoa])
references Khoa ([MaKhoa])
------
alter table DongHocPhi
add constraint FK_SinhVien_DongHocPhi foreign key([MaSV])
references SinhVien ([MaSV])

alter table DiemHocPhan
add constraint FK_SinhVien_DiemHocPhan foreign key([MaSV])
references SinhVien ([MaSV])

alter table DiemHocPhan
add constraint FK_LopHocPhan_DiemHocPhan foreign key([MaLopHP])
references LopHocPhan ([MaLopHP])
alter table DiemHocPhan
add constraint FK_GiangVien_DiemHocPhan foreign key([MaGV])
references GiangVien ([MaGV])
---
alter table DangKy
add constraint FK_SinhVien_DangKy foreign key ([MaSV])
references SinhVien ([MaSV])

alter table DamNhan
add constraint FK_GiangVien_DamNhan foreign key ([MaGV])
references GiangVien ([MaGV])

alter table XepLoai
add constraint FK_SinhVien_XepLoai foreign key ([MaSV])
references SinhVien ([MaSV])

-----------------------------------------------------------------------------------

--Ràng buộc miền giá trị
----Bảng sinh viên
-----------------------Giới tính
alter table SinhVien
add constraint CK_SinhVien1 check ([GioiTinh] = N'Nữ' or [GioiTinh] = N'Nam')
-----------------------Ngày sinh
alter table SinhVien
add constraint CK_SinhVien2 check ((Year(GETDATE()) -Year([NgaySinh])) >= 18)
----Bảng giảng viên
-----------------------Giới tính
alter table GiangVien
add constraint CK_GiangVien1 check ([GioiTinh] = N'Nữ' or [GioiTinh] = N'Nam')
-----------------------Tuổi về hưu
alter table GiangVien
add constraint CK_GiangVien2 check (([GioiTinh] = N'Nữ' AND (Year(GETDATE()) - Year([NgaySinh])) <= 55) OR ([GioiTinh] = N'Nam' AND (Year(GETDATE()) - Year([NgaySinh])) <= 60))
----Bảng điểm học phần
----------------------Điểm
alter table DiemHocPhan
add constraint CK_DiemHocPhan1 check ([DiemThi] >= 0 and [DiemThi] <= 10)
alter table DiemHocPhan
add constraint CK_DiemHocPhan2 check ([DiemHeSo1] >= 0 and [DiemHeSo1] <= 10)
alter table DiemHocPhan
add constraint CK_DiemHocPhan3 check ([DiemHeSo2] >= 0 and [DiemHeSo2] <= 10)
----------------------Xếp loại

----------------------Học lực
----Bảng điểm rèn luyện
----------------------Điểm
alter table DiemRenLuyen
add constraint CK_DiemRenLuyen1 check ([Diem] >= 0 and [Diem] <=10)
----Bảng học phí
---------------------Tổng tiền
alter table DongHocPhi
add constraint CK_DongHocPhi1 check ([TongTien] >= 0)

-----------------------------------------------------------Gía trị mặc định
----Bảng học phí
----------------------Tiền tín chỉ
alter table HocPhi
add constraint DF_HocPhi
default 300000 for [TienTinChi]
go
create proc themKhoa(@sMaKhoa nvarchar(8), @sTenKhoa nvarchar(40))
as
begin
insert into Khoa(MaKhoa, TenKhoa)
values(@sMaKhoa,@sTenKhoa)
end
go
--------Xóa khoa
create proc xoaKhoa(@sMaKhoa nvarchar(8))
as
begin
delete from Khoa
where MaKhoa = @sMaKhoa
end
go
--------Sửa khoa
create proc suaKhoa(@sMaKhoa nvarchar(8),@sTenKhoa nvarchar(40))
as 
begin
update Khoa
set TenKhoa = @sTenKhoa 
where MaKhoa = @sMaKhoa
end
go
---------Lấy DS Khoa
create proc LayDSKhoa
as
begin
select * from Khoa
end
go
----Hien Danh Sach Giang Vien, Them - Xoa - Sua GV
-------------Thêm giảng viên
create proc ThemDangNhapGiangVien
@sMaGV nvarchar(11),
@sMatKhau nvarchar(30)
as
begin
    Insert into DangNhapGiangVien values(@sMaGV, @sMatKhau)
end
go
create proc SuaDangNhapGiangVien
@sMaGV nvarchar(11),
@sMatKhau nvarchar(30)
as
begin
    update DangNhapGiangVien 
    set MatKhau = @sMatKhau
    where MaGV = @sMaGV
end
go
create proc XoaDangNhapGiangVien
@sMaGV nvarchar(11)
as
begin
    delete DangNhapGiangVien where MaGV = @sMaGV
end
go
create proc ThemGiangVien
@sMaGV nvarchar(11),
@sTenGV nvarchar(60),
@sGioiTinh nvarchar(3),
@sNgaySinh date,
@sChucVu nvarchar(30),
@sMaKhoa nvarchar(8)
as
begin
    Insert into GiangVien values(@sMaGV, @sTenGV, @sGioiTinh, @sNgaySinh, @sChucVu, @sMaKhoa)
	exec ThemDangNhapGiangVien @sMaGV,'12345'
end
go
create proc SuaGiangVien
@sMaGV nvarchar(11),
@sTenGV nvarchar(60),
@sGioiTinh nvarchar(3),
@sNgaySinh date,
@sChucVu nvarchar(30),
@sMaKhoa nvarchar(8)
as
begin
    update GiangVien 
    set TenGV = @sTenGV,
        GioiTinh = @sGioiTinh,
        NgaySinh = @sNgaySinh,
		ChucVu = @sChucVu,
		MaKhoa = @sMaKhoa
    where MaGV = @sMaGV
end
go
create proc XoaGiangVien
@sMaGV nvarchar(11)
as
begin
	exec XoaDangNhapGiangVien @sMaGV
    delete GiangVien where MaGV = @sMaGV	
end
go

create proc LayTTGVTheoMaGV(@sMaGV nvarchar(11))
as
begin
	Select GiangVien.MaGV,GiangVien.TenGV,GiangVien.GioiTinh,GiangVien.NgaySinh,GiangVien.ChucVu,Khoa.TenKhoa
	from GiangVien join Khoa on GiangVien.MaKhoa = Khoa.MaKhoa
	where MaGV = @sMaGV
end
go
-----Lấy giảng viên theo khoa
create proc LayGiangVienTheoKhoa(@sMaKhoa nvarchar(8))
as
begin
	Select * from GiangVien
	where GiangVien.MaKhoa = @sMaKhoa
end
go
-----Lấy giảng viên theo theo mã giảng viên
create proc LayGiangVienTheoMaSV(@sMaGV nvarchar(11))
as
begin
	Select * from GiangVien
	where GiangVien.MaGV = @sMaGV
end
go
----Lấy giảng viên theo giới tính
create proc LayGiangVienTheoGioiTinh(@sGioiTinh nvarchar(3))
as
begin
	Select * from GiangVien
	where GiangVien.GioiTinh = @sGioiTinh
end
go
----Lấy giảng viên theo chức vụ
CREATE PROCEDURE LayGiangVienTheoChucVuVaKhoa(
    @sChucVu NVARCHAR(30),
    @sMaCN nvarchar(8))
AS
BEGIN
    SELECT *
    FROM GiangVien
    WHERE GiangVien.ChucVu = @sChucVu
          AND GiangVien.MaKhoa = (SELECT ChuyenNganh.MaKhoa
                                   FROM ChuyenNganh
                                   WHERE MaChuyenNganh = @sMaCN)
END;
go          
----Lấy giảng viên theo ds
create proc LayDSGiangVien
as
begin
	Select * from GiangVien
end
go
-----Them - Xoa - Sua Chuyen Nganh
create proc ThemChuyenNganh
@sMaChuyenNganh nvarchar(8),
@sTenChuyenNganh nvarchar(80),
@sMaKhoa nvarchar(8)
as
begin
    Insert into ChuyenNganh values(@sMaChuyenNganh, @sTenChuyenNganh, @sMaKhoa)
end
go
create proc SuaChuyenNganh
@sMaChuyenNganh nvarchar(8),
@sTenChuyenNganh nvarchar(80),
@sMaKhoa nvarchar(8)
as
begin
    update ChuyenNganh 
    set TenChuyenNganh = @sTenChuyenNganh,
		MaKhoa = @sMaKhoa
    where MaChuyenNganh = @sMaChuyenNganh
end
go
create proc XoaChuyenNganh(
@sMaChuyenNganh nvarchar(8))
as
begin
    delete from ChuyenNganh where MaChuyenNganh = @sMaChuyenNganh
end
go
create proc LayMaVaTenCN
as
begin
	Select MaChuyenNganh,TenChuyenNganh from ChuyenNganh
end
go
create proc LayChuyenNganhBangMaChuyenNganh (@sMaChuyenNganh nvarchar(8))
as
begin
	select * from ChuyenNganh
	where MaChuyenNganh = @sMaChuyenNganh
end
go
create proc LayChuyenNganhBangMaKhoa (@MaKhoa nvarchar(8))
as
begin
	select * from ChuyenNganh
	where MaKhoa = @MaKhoa
end
go
create proc LayDSChuyenNganh
as
begin
	Select * from ChuyenNganh
end
go
----Them Xoa Sua Hoc Phan
create proc ThemHocPhan
@sMaHP nvarchar(11),
@sTenHP nvarchar(60),
@sSoTC int,
@sMaKhoa nvarchar(8),
@sHocKy int
as
begin
    Insert into HocPhan values(@sMaHP, @sTenHP, @sSoTC, @sMaKhoa, @sHocKy)
end
go
create proc SuaHocPhan
@sMaHP nvarchar(11),
@sTenHP nvarchar(60),
@sSoTC int,
@sMaKhoa nvarchar(8),
@sHocKy int
as
begin
    update HocPhan 
    set TenHP = @sTenHP,
		SoTC = @sSoTC,
		MaKhoa = @sMaKhoa,
		HocKy = @sHocKy
    where MaHP = @sMaHP
end
go
create proc XoaHocPhan
@sMaHP nvarchar(11)
as
begin
    delete HocPhan where MaHP = @sMaHP
end
go
create proc LayDSHocPhan
as
begin
	Select * from HocPhan
end
go
create proc LayHocPhanBangMaHocPhan(@MaHP nvarchar(11))
as
begin
	Select * from HocPhan
	where MaHP = @MaHP
end
go
create proc LayDSSinhVienTheoKhoa(@MaKhoa nvarchar(8))
as
begin
	sELECT SinhVien.MaSV,SinhVien.TenSV,SinhVien.GioiTinh,SinhVien.NgaySinh,SinhVien.CCCD,SinhVien.DiaChi,SinhVien.QueQuan,
	SinhVien.NienKhoa,Khoa.TenKhoa
	FROM SinhVien join Lop on SinhVien.MaLop = Lop.MaLop
	join ChuyenNganh on Lop.MaChuyenNganh = ChuyenNganh.MaChuyenNganh
	join Khoa on ChuyenNganh.MaKhoa = Khoa.MaKhoa
	where Khoa.MaKhoa = @MaKhoa
end
go
create proc LayHocPhanBangMaKhoa(@MaKhoa nvarchar(8))
as
begin
	select * from HocPhan
	where MaKhoa = @MaKhoa
end
go
-----Them Xoa Sua Lop
create proc ThemLop
@sMaLop nvarchar(11),
@sMaChuyenNganh nvarchar(8),
@sMaGV nvarchar(11)
as
begin
    Insert into Lop values(@sMaLop, @sMaChuyenNganh, @sMaGV)
end
go
create proc SuaLop
@sMaLop nvarchar(11),
@sMaChuyenNganh nvarchar(8),
@sMaGV nvarchar(11)
as
begin
    update Lop 
    set MaChuyenNganh = @sMaChuyenNganh,
		MaGV = @sMaGV
    where MaLop = @sMaLop
end
go
create proc XoaLop
@sMaLop nvarchar(11)
as
begin
    delete Lop where MaLop = @sMaLop
end
go
-------------------Lấy dữ liệu của mã lớp
create proc LayDSSLop
as
begin
	Select * from Lop
end
go
create proc LayDuLieuLopTheoMaLop (@sMaLop nvarchar(7))
as
begin
select * from Lop
where MaLop = @sMaLop
end
go
create proc LayDuLieuLopTheoMaChuyenNganh (@sMaChuyenNganh nvarchar(8))
as
begin
select * from Lop
where MaChuyenNganh = @sMaChuyenNganh
end
go
create proc LayDuLieuLopTheoMaGV (@sMaGV nvarchar(11))
as
begin
SELECT Lop.MaLop, ChuyenNganh.TenChuyenNganh, Khoa.TenKhoa,GiangVien.TenGV
FROM Lop
JOIN ChuyenNganh ON Lop.MaChuyenNganh = ChuyenNganh.MaChuyenNganh 
JOIN Khoa ON ChuyenNganh.MaKhoa = Khoa.MaKhoa 
join GiangVien on Lop.MaGV = GiangVien.MaGV
WHERE Lop.MaGV = @sMaGV;
end
go
----- Them Xoa Sua Sinh Vien
create proc ThemSinhVien
@sMaSV nvarchar(11),
@sTenSV nvarchar(40),
@sGioiTinh nvarchar(3),
@sNgaySinh date,
@sCCCD nvarchar (12),
@sDiaChi nvarchar (400),
@sQueQuan nvarchar (30),
@sNienKhoa nvarchar (30),
@sMaLop nvarchar(7)
as
begin
    Insert into SinhVien values(@sMaSV, @sTenSV, @sGioiTinh, @sNgaySinh, @sCCCD, @sDiaChi, @sQueQuan, @sNienKhoa, @sMaLop)
end
go
create proc SuaSinhVien
@sMaSV nvarchar(11),
@sTenSV nvarchar(40),
@sGioiTinh nvarchar(3),
@sNgaySinh date,
@sCCCD nvarchar (12),
@sDiaChi nvarchar (400),
@sQueQuan nvarchar (30),
@sNienKhoa nvarchar (30),
@sMaLop nvarchar(7)
as
begin
    update SinhVien 
    set TenSV = @sTenSV,
		GioiTinh = @sGioiTinh,
		NgaySinh = @sNgaySinh,
		CCCD = @sCCCD,
		DiaChi = @sDiaChi,
		QueQuan = @sQueQuan,
		NienKhoa = @sNienKhoa,
		MaLop = @sMaLop
    where MaSV = @sMaSV
end
go
create proc XoaSinhVien
@sMaSV nvarchar(11)
as
begin
    delete SinhVien where MaSV = @sMaSV
end
go
create proc LayDSSinhVien
as
begin
	Select * from SinhVien
end
select * from SinhVien
go
----Them Xoa Sua Lop Hoc Phan	
create proc ThemLopHocPhan
@sMaHP nvarchar(11),
@sMaLopHP nvarchar(11),
@sPhongHoc nvarchar(8)
as
begin
    Insert into LopHocPhan values(@sMaHP, @sMaLopHP, @sPhongHoc)
end
go
----Lấy dữ liệu
create proc LayDuLieuTheoMaSV(@sMaSV nvarchar(11))
as
begin
	Select * from SinhVien
	where MaSV = @sMaSV
end
go
create proc LayDuLieuSinhVienTheoGioiTinh(@sGioiTinh nvarchar(3))
as
begin
	Select * from SinhVien
	where GioiTinh = @sGioiTinh
end
go
create proc LayDuLieuSinhVienTheoMaLop(@sMaLop nvarchar(7))
as
begin
	Select * from SinhVien
	where MaLop = @sMaLop
end
go
create proc LayDuLieuSinhVienTheoNienKhoa(@sNienKhoa nvarchar(30))
as
begin
	Select * from SinhVien
	where NienKhoa = @sNienKhoa
end
go
----Them Xoa Sua Lop Hoc Phan	
create proc SuaLopHocPhan
@sMaHP nvarchar(11),
@sMaLopHP nvarchar(11),
@sPhongHoc nvarchar(8)
as
begin
    update LopHocPhan 
    set MaHP = @sMaHP,
		PhongHoc = @sPhongHoc
    where MaLopHP = @sMaLopHP
end
go
create proc XoaLopHocPhan
@sMaLopHP nvarchar(11)
as
begin
    delete LopHocPhan where MaLopHP = @sMaLopHP
end
go
create proc LayDSLopHP
as
begin
	Select * from LopHocPhan
end
go
------Lấy dữ liệu theo mã học phần
create proc LayLopHocPhanTheoMaHP(@sMaHP nvarchar(11))
as
begin
select * from LopHocPhan
where MaHP = @sMaHP 
end
go
create proc LayLopHocPhanTheoPhongHoc(@sPhongHoc nvarchar(8))
as
begin
select * from LopHocPhan
where  PhongHoc = @sPhongHoc
end
go
----Them Xoa Sua Dam Nhan
create proc ThemDamNhan
@sMaGV nvarchar(11),
@sMaLopHP nvarchar(11),
@sThoiGianBatDau date,
@sThoiGianKetThuc date,
@sThoiGianHoc nvarchar(30)
as
begin
    Insert into DamNhan values(@sMaGV, @sMaLopHP, @sThoiGianBatDau, @sThoiGianKetThuc, @sThoiGianHoc)
end
go
create proc SuaDamNhan
@sMaGV nvarchar(11),
@sMaLopHP nvarchar(11),
@sThoiGianBatDau date,
@sThoiGianKetThuc date,
@sThoiGianHoc nvarchar(30)
as
begin
    update DamNhan 
    set MaGV = @sMaGV,
		MaLopHP = @sMaLopHP,
		ThoiGianBatDau = @sThoiGianBatDau,
		ThoiGianKetThuc = @sThoiGianKetThuc,
		ThoiGianHoc = @sThoiGianHoc
    where MaLopHP = @sMaLopHP
end
go
create proc XoaDamNhan
@sMaLopHP nvarchar(11)
as
begin
    delete DamNhan where MaLopHP = @sMaLopHP
end
go
create proc LayDuLieuDamNhan(@sMaGV nvarchar(11))
as
begin
select DamNhan.ThoiGianBatDau,DamNhan.ThoiGianKetThuc,DamNhan.ThoiGianHoc, DamNhan.MaLopHP,HocPhan.TenHP,HocPhan.SoTC
from DamNhan join LopHocPhan on DamNhan.MaLopHP = LopHocPhan.MaLopHP join HocPhan on LopHocPhan.MaHP = HocPhan.MaHP
where MaGV = @sMaGV
end
go
create proc LayDuLieuDuLieuDamNhanTheoMaGV(@sMaGV nvarchar(11))
as
begin
Select * from DamNhan
where MaGV = @sMaGV
end
go
create proc LayDuLieuDuLieuThoiGianHocFromDamNhan(@sThoiGianHoc nvarchar(30))
as
begin
select * from DamNhan
where ThoiGianHoc = @sThoiGianHoc
end
go
create proc LayDuLieuMaLopHPFromDamNhan(@sMaLopHP nvarchar(11))
as
begin
select * from DamNhan
where MaLopHP = @sMaLopHP
end
go
----Them Xoa Sua Dang Ky
create proc ThemDangKy
@sMaSV nvarchar(11),
@sMaLopHP nvarchar(11),
@sThoiGianBatDau date,
@sThoiGianKetThuc date
as
begin
    Insert into DangKy values(@sMaSV, @sMaLopHP, @sThoiGianBatDau, @sThoiGianKetThuc)
end
go
create proc DemSoLanXuatHienCuaMaSVTrongLopHP(@sMaSV nvarchar(11),@sMaLopHP nvarchar(11))
as
begin
	Select COUNT(MaSV) from DangKy where MaSV = @sMaSV and MaLopHP = @sMaLopHP
end
go
create proc SuaDangKy
@sMaSV nvarchar(11),
@sMaLopHP nvarchar(11),
@sThoiGianBatDau date,
@sThoiGianKetThuc date
as
begin
    update DangKy 
    set ThoiGianBatDau = @sThoiGianBatDau,
		ThoiGianKetThuc = @sThoiGianKetThuc
    where MaLopHP = @sMaLopHP and MaSV = @sMaSV				
end
go
create proc XoaDangKy
@sMaSV nvarchar(11),
@sMaLopHP nvarchar(11)
as
begin
    delete DangKy where MaLopHP = @sMaLopHP and MaSV = @sMaSV		
end
go
create proc LayDuLieuDangKyTheoMaSV(@sMaSV nvarchar(11))
as
begin
	Select * from DangKy
	where MaSV = @sMaSV
end
go
create proc LayDuLieuDangKyTheoMaLopHP(@sMaLopHocPhan nvarchar(11))
as
begin
	Select * from DangKy
	where MaLopHP = @sMaLopHocPhan
end
go
-----Them Xoa Sua Diem Ren Luyen
create proc ThemDiemRenLuyen
@sMaHD nvarchar(5),
@sNamHoc nvarchar(30),
@sHocKy int,
@sTenHD nvarchar(200),
@sThoiGian date,
@sDiem int,
@sMaSV nvarchar(11)
as
begin
    Insert into DiemRenLuyen values(@sMaHD, @sNamHoc, @sHocKy, @sTenHD, @sThoiGian, @sDiem, @sMaSV)
end
go
create proc SuaRenLuyen 
@sMaHD nvarchar(5),
@sNamHoc nvarchar(30),
@sHocKy int,
@sTenHD nvarchar(200),
@sThoiGian date,
@sDiem int,
@sMaSV nvarchar(11)
as
begin
    update DiemRenLuyen  
    set	NamHoc = @sNamHoc,
		HocKy = @sHocKy,
		TenHD = @sTenHD,
		ThoiGian = @sThoiGian,
		Diem = @sDiem
    where @sMaHD = @sMaHD and MaSV = @sMaSV				
end
go
create proc XoaRenLuyen
@sMaHD nvarchar(5),
@sMaSV nvarchar(11)
as
begin
    delete DiemRenLuyen where MaHD = @sMaHD and MaSV = @sMaSV	
end
go
create proc LayDSDiemRenLuyen
as
begin
	Select * from DiemRenLuyen
end
go
--------------Lấy hoạt động theo mã sinh viên
create proc LayHoatDongTheoMaHD(@sMaHD nvarchar(5))
as 
begin
	Select * from DiemRenLuyen
	where MaHD = @sMaHD
end
go
create proc LayHoatDongTheoMaSV(@sMaSV nvarchar(11))
as 
begin
	Select * from DiemRenLuyen
	where MaSV = @sMaSV
end
go
create proc LayHoatDongTheoHocKy(@sHocKy int)
as
begin
	Select * from DiemRenLuyen
	where HocKy = @sHocKy
end
go
-----Them Xoa Sua DangNhapGiangVien
create proc LayDSTKDangNhapGVByMa(@MaGV nvarchar(11))
as
begin
	Select * from DangNhapGiangVien where MaGV = @MaGV
end
go
create proc ThemDangNhapAdmin(@TenTK nvarchar(11), @MatKhau nvarchar(30))
as
begin
	insert into DangNhapAdmin(TenTaiKhoan,MatKhau) values(@TenTK,@MatKhau)
end
go
create proc LayDSTKDangNhapAdminByTen(@TenTK nvarchar(11))
as
begin
	Select * from DangNhapAdmin where TenTaiKhoan = @TenTK
end
go
exec ThemDangNhapAdmin 'Admin','123'
----Them Xoa Sua HocPhi
go
create proc TinhTongTienHocPhi(@sMaMon nvarchar(11))
as
begin
  Update HocPhi
  set TongTienTinChi = (Select HocPhan.SoTC
                        from HocPhan
						where HocPhi.MaMon = HocPhan.MaHP) * TienTinChi
  where HocPhi.MaMon = @sMaMon
end
go
create proc ThemHocPhi(
@sMaMon nvarchar(11))
as
begin
    declare @TongTienHocPhi float;   
    insert into HocPhi(MaMon,TienTinChi) values(@sMaMon, 300000);
	exec TinhTongTienHocPhi @sMaMon
end
go
Create proc capNhapDiemTrungBinhFromDiemHocPhan(@sMaSV nvarchar(11), @sMaLopHP nvarchar(11), @sMaGV nvarchar(11))
As
Begin
Update DiemHocPhan
set [DiemTBMon] = Round(((DiemHeSo1 + (DiemHeSo2 * 2)) / 3) * 0.4 + (DiemThi * 0.6),2)
where [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV and [DiemHocPhan].[MaSV] = @sMaSV
print N'Cập nhập thành công: '+ @sMaSV
End
go
create proc xepLoaiFromDiemHocPhan(@sMaSV nvarchar(11), @sMaLopHP nvarchar(11), @sMaGV nvarchar(11))
As
Begin
DECLARE @sDiemTBMon float
select @sDiemTBMon = DiemHocPhan.DiemTBMon from DiemHocPhan where MaSV = @sMaSV and  [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV
if(@sDiemTBMon >= 8 and @sDiemTBMon <= 10)
Begin
  Update DiemHocPhan
  set [XepLoai] = 'A'
  where [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV and [DiemHocPhan].[MaSV] = @sMaSV
End
else if(@sDiemTBMon >= 7 and @sDiemTBMon < 8)
Begin
  Update DiemHocPhan
  set [XepLoai] = 'B'
  where [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV and [DiemHocPhan].[MaSV] = @sMaSV
End
else if(@sDiemTBMon >= 6 and @sDiemTBMon < 7)
Begin
  Update DiemHocPhan
  set [XepLoai] = 'C'
  where [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV and [DiemHocPhan].[MaSV] = @sMaSV
End
else if(@sDiemTBMon >= 5 and @sDiemTBMon < 6)
Begin
  Update DiemHocPhan
  set [XepLoai] = 'D'
  where [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV and [DiemHocPhan].[MaSV] = @sMaSV
End
else
Begin
  Update DiemHocPhan
  set [XepLoai] = 'F'
  where [DiemHocPhan].[MaLopHP] = @sMaLopHP and [DiemHocPhan].[MaGV] = @sMaGV and [DiemHocPhan].[MaSV] = @sMaSV
End
End
go
create proc layDiemTBTatCaCacMon (@sMaSV nvarchar(11))
AS
Begin
update XepLoai 
set XepLoai.DiemTBTatCaCacMon = (select avg(DiemHocPhan.DiemTBMon)
                                 from DiemHocPhan
                                 where DiemHocPhan.MaSV = XepLoai.MaSV and XepLoai.MaSV = @sMaSV)
where XepLoai.MaSV = @sMaSV
End
go
create proc xetHocLucChoSinhVien(@sMaSV nvarchar(11))
as 
begin
declare @sDiemTBTatCaCacMon float
select @sDiemTBTatCaCacMon = XepLoai.DiemTBTatCaCacMon from XepLoai where MaSV = @sMaSV
if(@sDiemTBTatCaCacMon >= 9 and @sDiemTBTatCaCacMon <= 10)
Begin
  Update XepLoai
  set [HocLuc] = N'Xuất sắc'
  where XepLoai.MaSV = @sMaSV
End
else if(@sDiemTBTatCaCacMon >= 8 and @sDiemTBTatCaCacMon < 9)
Begin
  Update XepLoai
  set [HocLuc] = N'Giỏi'
  where XepLoai.MaSV = @sMaSV
End
else if(@sDiemTBTatCaCacMon >= 6 and @sDiemTBTatCaCacMon < 8)
Begin
  Update XepLoai
  set [HocLuc] = N'Khá'
  where XepLoai.MaSV = @sMaSV
End
else if(@sDiemTBTatCaCacMon >= 5 and @sDiemTBTatCaCacMon < 6)
Begin
  Update XepLoai
  set [HocLuc] = N'Trung Binh'
  where XepLoai.MaSV = @sMaSV
End
else 
Begin
  Update XepLoai
  set [HocLuc] = N'Yếu'
  where XepLoai.MaSV = @sMaSV
End
end
go
create proc xoaDuLieuXepLoai(@sMaSV nvarchar(11))
as
begin
Delete from XepLoai where MaSV = @sMaSV
end
go
create proc themDuLieuVaoXepLoai(@sMaSV nvarchar(11))
as
begin
exec xoaDuLieuXepLoai @sMaSV
insert into XepLoai(MaSV)
values(@sMaSV)
exec layDiemTBTatCaCacMon @sMaSV
exec xetHocLucChoSinhVien @sMaSV
end
go
create proc ThemDiemHocPhan(@sDiemThi float, @DiemHeSo1 float,@DiemHeSo2 float, @sNamHoc nvarchar(30),@sMaSV nvarchar(11), @sMaLopHP nvarchar(11), @sMaGV nvarchar(11))
as
begin 
Insert into DiemHocPhan(DiemThi,DiemHeSo1,DiemHeSo2,NamHoc,MaSV,MaLopHP,MaGV) values(@sDiemThi, @DiemHeSo1, @DiemHeSo2,@sNamHoc,@sMaSV,@sMaLopHP,@sMaGV)
exec capNhapDiemTrungBinhFromDiemHocPhan @sMaSV,@sMaLopHP,@sMaGV
exec xepLoaiFromDiemHocPhan @sMaSV, @sMaLopHP, @sMaGV
exec themDuLieuVaoXepLoai @sMaSV
end
go
create proc LayDSDiemHPTheoMaSVVaHocKy( @sMaSV nvarchar(11),@sHocKy nvarchar(11))
as
begin
	Select * from DiemHocPhan where MaSV = @sMaSV and NamHoc = @sHocKy
end
go
create proc LayDSDiemHP
as
begin
	Select * from DiemHocPhan
end
go
create proc LayDiemTBTichLuy(@sMaSV nvarchar(11))
as
begin
	Select DiemTBTatCaCacMon from XepLoai where MaSV = @sMaSV
end

go
create proc LayXepLoai(@sMaSV nvarchar(11))
as
begin
	Select HocLuc from XepLoai where MaSV = @sMaSV
end
go
create proc TongTienDongHocPhiChoAllMon(@sMaSV nvarchar(11))
as 
begin
declare @tien float

	Select @tien = Sum(HocPhi.TongTienTinChi)
	             From DongHocPhi join DangKy
				 on DongHocPhi.MaSV = DangKy.MaSV join LopHocPhan
				 on DangKy.MaLopHP = LopHocPhan.MaLopHP join HocPhan
				 on LopHocPhan.MaHP = HocPhan.MaHP join HocPhi
				 on HocPhan.MaHP = HocPhi.MaMon
				 where DongHocPhi.MaSV = @sMaSV

update DongHocPhi
set TongTien = @tien
where DongHocPhi.MaSV = @sMaSV
end
go
create proc LayTenSVBangMa(@sMaSV nvarchar(11))
as
begin
	update DongHocPhi
	set HoTenSV = (Select TenSV from SinhVien where MaSV = @sMaSV)
	where MaSV = @sMaSV
end
go
create proc NhapMaSinhVienChoDongHocPhi(@sMaSV nvarchar(11))
as 
begin 
  declare @TenSV char
  insert into DongHocPhi(MaSV) values (@sMaSV)
  exec LayTenSVBangMa @sMaSV
  exec TongTienDongHocPhiChoAllMon @sMaSV
end
go
create proc LayDSHDNhoMaSV(@MaSV nvarchar(11))
as
begin
	Select * from DongHocPhi where MaSV = @MaSV
end
go
create proc LayTongTienNhoMaSV(@MaSV nvarchar(11))
as
begin
	Select TongTien from DongHocPhi where  MaSV = @MaSV
end
go
create proc DemSoLanXuatHienCuaMaSV(@MaSV nvarchar(11))
as
begin
	Select COUNT(MaSV) from DongHocPhi where MaSV = @MaSV
end
go
create proc LayDSMonHocNhoMaSV(@MaSV nvarchar(11))
as
begin
	Select * from DangKy where MaSV = @MaSV
end
go
create proc suaDiem(@MaSV nvarchar(11), @MaLopHP nvarchar(11), @MaGV nvarchar(11), @DiemHeSo1 float, @DiemHeSo2 float, @DiemThi float, @NamHoc nvarchar(30))
as 
begin
	update DiemHocPhan
	set DiemHeSo1 = @DiemHeSo1, DiemHeSo2 = @DiemHeSo2, DiemThi = @DiemThi
	where MaSV = @MaSV and MaGV = @MaGV and MaLopHP = @MaLopHP;
	exec capNhapDiemTrungBinhFromDiemHocPhan @MaSV, @MaLopHP, @MaGV;
	exec xepLoaiFromDiemHocPhan @MaSV, @MaLopHP, @MaGV
	exec themDuLieuVaoXepLoai @MaSV
	exec layDiemTBTatCaCacMon @MaSV
	exec xetHocLucChoSinhVien @MaSV
end
go
create proc xoaDiem(@MaSV nvarchar(11), @MaLopHP nvarchar(11), @MaGV nvarchar(11))
as
begin
 delete from DiemHocPhan
 where MaSV = @MaSV and MaLopHP = @MaLopHP and MaGV = @MaGV
 exec layDiemTBTatCaCacMon @MaSV
 exec xetHocLucChoSinhVien @MaSV
 exec themDuLieuVaoXepLoai @MaSV
end
go
create proc LayDiemHocPhanTheoMaSV(@MaSV nvarchar(11))
as
begin
	select * from DiemHocPhan
	where MaSV = @MaSV
end
go
create proc LayDiemHocPhanTheoMaLopHP(@MaLopHP nvarchar(11))
as
begin
	select * from DiemHocPhan
	where MaLopHP = @MaLopHP
end
go
create proc LayDiemHocPhanTheoMaGV(@MaGV nvarchar(11))
as
begin
	select * from DiemHocPhan
	where MaGV = @MaGV
end
go
create proc LayHocPhiTinChiTheoMaHP (@MaMon nvarchar(11))
as
begin
	Select * from HocPhi
	where MaMon = @MaMon
end
go
create proc LayTongTienTheoMaSV(@MaSV nvarchar(11))
as
begin
	select * from DongHocPhi
	where MaSV = @MaSV
end
go
create proc LayXepLoaiTheoMaSV(@MaSV nvarchar(11))
as
begin
	Select * from XepLoai
	where MaSV = @MaSV
end
go
create proc LayDSDiemCuaMaSV(@sMaSV nvarchar(11))
as
begin
	 SELECT SinhVien.MaSV,DiemHocPhan.DiemHeSo1,DiemHocPhan.DiemHeSo2,DiemHocPhan.DiemThi,DiemHocPhan.DiemTBMon,DiemHocPhan.XepLoai,XepLoai.DiemTBTatCaCacMon,XepLoai.HocLuc,DiemHocPhan.MaLopHP
    FROM DiemHocPhan 
    LEFT JOIN XepLoai  ON DiemHocPhan.MaSV = XepLoai.MaSV join SinhVien on XepLoai.MaSV = SinhVien.MaSV
    WHERE DiemHocPhan.MaSV = @sMaSV;
end
go
create proc LayTTLopHP(@sMaLopHP nvarchar(11))
as
begin
	Select HocPhan.TenHP, LopHocPhan.MaLopHP,LopHocPhan.PhongHoc,GiangVien.TenGV,Khoa.TenKhoa
	from LopHocPhan join HocPhan on LopHocPhan.MaHP = HocPhan.MaHP join Khoa 
	on HocPhan.MaKhoa = Khoa.MaKhoa join DamNhan on LopHocPhan.MaLopHP = DamNhan.MaLopHP
	join GiangVien on DamNhan.MaGV = GiangVien.MaGV
	where LopHocPhan.MaLopHP = @sMaLopHP
end
go
create proc LayDSSinhVienCuaLopHP(@sMaLopHP nvarchar(11))
as
begin
	Select LopHocPhan.MaLopHP,LopHocPhan.PhongHoc,HocPhan.TenHP,SinhVien.MaSV,SinhVien.TenSV,GiangVien.TenGV
	From LopHocPhan join DangKy on LopHocPhan.MaLopHP = DangKy.MaLopHP
	join HocPhan on LopHocPhan.MaHP = HocPhan.MaHP join SinhVien on 
	DangKy.MaSV = SinhVien.MaSV join DamNhan on LopHocPhan.MaLopHP = DamNhan.MaLopHP
	join GiangVien on DamNhan.MaGV = GiangVien.MaGV
	where LopHocPhan.MaLopHP = @sMaLopHP 
end
go
CREATE PROC LayDSLopHoc(@sMaLop nvarchar(7))
AS
BEGIN
    DECLARE @SoLuong int;
    SET @SoLuong = (SELECT COUNT(*) FROM SinhVien WHERE MaLop = @sMaLop);

    SELECT Lop.MaLop, GiangVien.TenGV, ChuyenNganh.TenChuyenNganh,Khoa.TenKhoa, @SoLuong AS SoLuong
    FROM Lop
    JOIN ChuyenNganh ON Lop.MaChuyenNganh = ChuyenNganh.MaChuyenNganh
    JOIN Khoa ON ChuyenNganh.MaKhoa = Khoa.MaKhoa
    JOIN GiangVien ON GiangVien.MaGV = Lop.MaGV
    WHERE Lop.MaLop = @sMaLop;
END;
go
create proc LaySVLopHoc(@sMaLop nvarchar(7))
as
begin
select SinhVien.MaSV,SinhVien.TenSV,SinhVien.CCCD,SinhVien.DiaChi,SinhVien.GioiTinh,SinhVien.NienKhoa,SinhVien.QueQuan,ChuyenNganh.TenChuyenNganh,Khoa.TenKhoa
from Lop
join SinhVien on Lop.MaLop = SinhVien.MaLop
join GiangVien on GiangVien.MaGV = Lop.MaGV
join ChuyenNganh on Lop.MaChuyenNganh = ChuyenNganh.MaChuyenNganh
join Khoa on ChuyenNganh.MaKhoa = Khoa.MaKhoa
where Lop.MaLop = @sMaLop
end
go
create proc InHoaDon(@sMaSV nvarchar(11))
as
begin
	Select SinhVien.MaSV,SinhVien.TenSV,HocPhan.TenHP,HocPhan.SoTC,HocPhi.TongTienTinChi,DongHocPhi.TongTien from DongHocPhi
	join SinhVien on DongHocPhi.MaSV = SinhVien.MaSV
	join DangKy on SinhVien.MaSV = DangKy.MaSV
	join LopHocPhan on DangKy.MaLopHP = LopHocPhan.MaLopHP
	join HocPhan on HocPhan.MaHP = LopHocPhan.MaHP
	join HocPhi on HocPhan.MaHP = HocPhi.MaMon
	where DongHocPhi.MaSV = @sMaSV
end
go
create proc LayHocPhanBangTenHocPhan(@sMaHP nvarchar(11))
as
begin
	Select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,HocPhan.HocKy,Khoa.TenKhoa from HocPhan
	join Khoa on HocPhan.MaKhoa = Khoa.MaKhoa
	where MaHP = @sMaHP
end
go
create proc LayHP(@sTenHP nvarchar(60))
as
begin
	Select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,HocPhan.HocKy,Khoa.TenKhoa from HocPhan
	join Khoa on HocPhan.MaKhoa = Khoa.MaKhoa
	where HocPhan.TenHP = @sTenHP
end
go
create proc TraCuuDLLopHoc
as
begin
	Select Lop.MaLop,ChuyenNganh.TenChuyenNganh,Khoa.TenKhoa,GiangVien.TenGV From Lop join ChuyenNganh
	on Lop.MaChuyenNganh = ChuyenNganh.MaChuyenNganh join GiangVien on 
	Lop.MaGV = GiangVien.MaGV join Khoa on ChuyenNganh.MaKhoa = Khoa.MaKhoa
end
go
create proc TraCuuDLHocPhan
as
begin
	Select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,Khoa.TenKhoa,HocPhan.HocKy
	from HocPhan join Khoa
	on HocPhan.MaKhoa = Khoa.MaKhoa
end
go
create proc TraCuuDLLopHP
as
begin
	Select LopHocPhan.MaLopHP,HocPhan.TenHP,LopHocPhan.PhongHoc from LopHocPhan join HocPhan
	on LopHocPhan.MaHP = HocPhan.MaHP
end
go
create proc TraCuuDLChuyenNganh
as
begin
	Select ChuyenNganh.MaChuyenNganh,ChuyenNganh.TenChuyenNganh,Khoa.TenKhoa from ChuyenNganh join Khoa
	on ChuyenNganh.MaKhoa = Khoa.MaKhoa
end
go
create proc TraCuuDLDamNhan
as
begin
	Select DamNhan.MaGV,HocPhan.TenHP,DamNhan.MaLopHP,DamNhan.ThoiGianBatDau,DamNhan.ThoiGianKetThuc,DamNhan.ThoiGianHoc 
	from DamNhan join GiangVien
	on DamNhan.MaGV = GiangVien.MaGV join LopHocPhan 
	on DamNhan.MaLopHP = LopHocPhan.MaLopHP join HocPhan
	on LopHocPhan.MaHP = HocPhan.MaHP
end
go
create proc TraCuuDLDangKy
as
begin
	Select DangKy.MaSV,SinhVien.TenSV,DangKy.ThoiGianBatDau,DangKy.ThoiGianKetThuc 
	from DangKy join SinhVien
	on DangKy.MaSV = SinhVien.MaSV join LopHocPhan
	on DangKy.MaLopHP = LopHocPhan.MaLopHP join HocPhan
	on LopHocPhan.MaHP = HocPhan.MaHP
end
go
create proc TraCuuDSGiangVien
as
begin
	Select GiangVien.MaGV,GiangVien.TenGV,GiangVien.GioiTinh,GiangVien.NgaySinh,GiangVien.ChucVu,Khoa.TenKhoa
	from GiangVien join Khoa
	on GiangVien.MaKhoa = Khoa.MaKhoa
end
go
create proc TraCuuDSLopTheoTenKhoa(@MaKhoa nvarchar(8))
as
begin
 Select Lop.MaLop,ChuyenNganh.TenChuyenNganh,GiangVien.TenGV from Khoa join ChuyenNganh 
 ON Khoa.MaKhoa = ChuyenNganh.MaKhoa join
 Lop on ChuyenNganh.MaChuyenNganh = Lop.MaChuyenNganh join
 GiangVien on GiangVien.MaGV = Lop.MaGV
 where Khoa.MaKhoa = @MaKhoa
end

go
create proc TraCuuDSChuyenNganhTheoTenKhoa(@MaKhoa nvarchar(8))
as
begin
 Select ChuyenNganh.MaChuyenNganh,ChuyenNganh.TenChuyenNganh,Khoa.TenKhoa from Khoa join ChuyenNganh
 ON ChuyenNganh.MaKhoa = Khoa.MaKhoa
 where Khoa.MaKhoa = @MaKhoa
end
go
create proc TraCuuDSHocPhanTheoTenKhoa(@MaKhoa nvarchar(8))
as
begin
 Select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,HocPhan.HocKy,Khoa.TenKhoa
 From Khoa join HocPhan on Khoa.MaKhoa = HocPhan.MaKhoa
 where Khoa.MaKhoa = @MaKhoa
end
go
create proc TraCuuTTCNTheoMaCN(@MaCN nvarchar(8))
as
begin
	Select ChuyenNganh.MaChuyenNganh,ChuyenNganh.TenChuyenNganh,Khoa.TenKhoa from ChuyenNganh 
	join Khoa on ChuyenNganh.MaKhoa = Khoa.MaKhoa
	where ChuyenNganh.MaChuyenNganh = @MaCN
end
go
create proc TraCuuTTDSHocPhanTheoMaCN(@MaCN nvarchar(8))
as
begin
	Select HocPhan.MaHP,HocPhan.TenHP,HocPhan.SoTC,HocPhan.HocKy from ChuyenNganh 
	join Khoa on ChuyenNganh.MaKhoa = Khoa.MaKhoa join HocPhan on Khoa.MaKhoa = HocPhan.MaKhoa
	where ChuyenNganh.MaChuyenNganh = @MaCN
end
go
create proc LayDiemRLTheoMaSV(@sMaSV nvarchar(11))
as 
begin
	Select DiemRenLuyen.MaHD,DiemRenLuyen.TenHD,DiemRenLuyen.NamHoc,DiemRenLuyen.ThoiGian,DiemRenLuyen.NamHoc,DiemRenLuyen.Diem,SinhVien.TenSV
	from DiemRenLuyen 
	join SinhVien
	on DiemRenLuyen.MaSV = SinhVien.MaSV
	where DiemRenLuyen.MaSV = @sMaSV
end
select * from DiemRenLuyen
go
create proc LayDiemRLTheoMaKhoa(@sMaKhoa nvarchar(8))
as 
begin
	Select DiemRenLuyen.MaHD,DiemRenLuyen.TenHD,DiemRenLuyen.NamHoc,DiemRenLuyen.ThoiGian,DiemRenLuyen.NamHoc,DiemRenLuyen.Diem,SinhVien.TenSV
	from DiemRenLuyen 
	join SinhVien
	on DiemRenLuyen.MaSV = SinhVien.MaSV
	join Lop on SinhVien.MaLop = Lop.MaLop join ChuyenNganh on Lop.MaChuyenNganh = ChuyenNganh.MaChuyenNganh
	join Khoa on ChuyenNganh.MaKhoa = Khoa.MaKhoa
	where Khoa.MaKhoa = @sMaKhoa
end
go
---Thêm khoa
exec themKhoa 'QTKD',N'Quản trị kinh doanh'
exec themKhoa 'DL', N'Du Lịch'
exec themKhoa 'CNTT',N'Công nghệ thông tin'
---Thêm giảng viên
exec ThemGiangVien 'GVQTKD1', N'Trần Thị Thảo',N'Nữ','1999/04/23',N'CVHT','QTKD'
exec ThemGiangVien 'GVQTKD4', N'Trần Bảo Ngọc',N'Nữ','1998/05/03',N'CVHT','QTKD'
exec ThemGiangVien 'GVQTKD10',N'Nguyễn Minh Tú',N'Nữ','1987/05/05',N'CVHT','QTKD'
exec ThemGiangVien 'GVQTKD2', N'Trần Ngọc Hân',N'Nữ','1996/05/12',N'Trưởng môn QTKD','QTKD'
exec ThemGiangVien 'GVQTKD3', N'Trần Bảo Linh',N'Nữ','1970/03/05',N'Giảng viên','QTKD'
exec ThemGiangVien 'GVQTKD5', N'Trần Hữu Nam',N'Nam','2000/05/24',N'Giảng viên','QTKD'
exec ThemGiangVien 'GVLG1', N'Nguyễn Tú Uyên',N'Nữ','2001/02/02',N'CVHT','QTKD'
exec ThemGiangVien 'GVLG4', N'Lý Nhã Văn',N'Nữ','1999/04/23',N'CVHT','QTKD'
exec ThemGiangVien 'GVLG10',N'Trần Thị Cẩm Tiên',N'Nữ','1999/07/17',N'CVHT','QTKD'
exec ThemGiangVien 'GVLG2', N'Nguyễn Bảo Hân',N'Nữ','1987/04/03',N'Trưởng môn QTKD','QTKD'
exec ThemGiangVien 'GVLG3', N'Nguyễn Thùy Trang',N'Nữ','1997/05/18',N'Giảng viên','QTKD'
exec ThemGiangVien 'GVLG5', N'Nguyễn Văn An',N'Nam','1987/12/12',N'Giảng viên','QTKD'
exec ThemGiangVien 'GVTM1', N'Trần Thị Thảo Ngọc',N'Nữ','1988/12/03',N'CVHT','QTKD'
exec ThemGiangVien 'GVTM4', N'Nguyễn Kim Ngân' ,N'Nữ','1999/06/23',N'CVHT','QTKD'
exec ThemGiangVien 'GVTM10', N'Nguyễn Thị Thu Thảo',N'Nữ','1999/09/23',N'CVHT','QTKD'
exec ThemGiangVien 'GVTM2', N'Nguyễn Thanh Thảo',N'Nữ','1999/05/25',N'Trưởng môn QTKD','QTKD'
exec ThemGiangVien 'GVTM3', N'Trần Thị Thanh Trúc',N'Nữ','1978/01/23',N'Giảng viên','QTKD'
exec ThemGiangVien 'GVTM5', N'Nguyễn Công Tiến',N'Nam','1980/05/06',N'Giảng viên','QTKD'
exec ThemGiangVien 'GVKS1', N'Lê Bảo Nam',N'Nam','1981/03/29',N'CVHT','DL'
exec ThemGiangVien 'GVKS6', N'Lê Ngọc Hân',N'Nữ','1999/02/23',N'CVHT','DL'
exec ThemGiangVien 'GVKS4', N'Nguyễn Thị Thanh Trúc',N'Nữ','2002/05/06',N'CVHT','DL'
exec ThemGiangVien 'GVKS2', N'Nguyễn Minh Hiếu',N'Nam','1974/02/02',N'Giảng viên','DL'
exec ThemGiangVien 'GVKS3', N'Trần Huyền Trang',N'Nữ','1976/04/03',N'Giảng viên','DL'
exec ThemGiangVien 'GVKS5', N'Nguyễn Quang Sáng',N'Nam','1977/05/21',N'Giảng viên','DL'
exec ThemGiangVien 'GVNH1', N'Trần Hoàng Phong',N'Nam','1980/04/25',N'CVHT','DL'
exec ThemGiangVien 'GVNH6', N'Lý Nhã Kỳ',N'Nữ','1984/05/30',N'CVHT','DL'
exec ThemGiangVien 'GVNH4', N'Võ Hoàng Yến',N'Nữ','1974/03/22',N'CVHT','DL'
exec ThemGiangVien 'GVNH2', N'Nguyễn Trần Tuấn Minh',N'Nam','1975/04/27',N'Giảng viên','DL'
exec ThemGiangVien 'GVNH3', N'Nguyễn Thị Minh Anh',N'Nữ','1972/05/12',N'Giảng viên','DL'
exec ThemGiangVien 'GVNH5', N'Nguyễn Huy Hoàng',N'Nam','1999/01/20',N'Giảng viên','DL'
exec ThemGiangVien 'GVLH1', N'Trần Vũ Hoàng',N'Nam','1972/04/11',N'CVHT','DL'
exec ThemGiangVien 'GVLH6', N'Trần Thị Cẩm Nhung',N'Nữ','1980/07/01',N'CVHT','DL'
exec ThemGiangVien 'GVLH4', N'Mai Hồng Ngọc',N'Nữ','1985/01/01',N'CVHT','DL'
exec ThemGiangVien 'GVLH2', N'Nguyễn Trần Tuấn Linh',N'Nam','1970/05/06',N'Giảng viên','DL'
exec ThemGiangVien 'GVLH3', N'Nguyễn Thúc Thùy Tiên',N'Nữ','1980/07/13',N'Giảng viên','DL'
exec ThemGiangVien 'GVLH5', N'Mạc Trung Kiên',N'Nam','1980/06/13',N'Giảng viên','DL'
exec ThemGiangVien 'GVCNTT1',N'Trương Bá Thái',N'Nam','1983/06/21',N'CVHT','CNTT'
exec ThemGiangVien 'GVCNTT2',N'Tiêu Kim Cương',N'Nam','1980/07/21',N'Giảng viên','CNTT'
exec ThemGiangVien 'GVCNTT3',N'Nguyễn Thị Hồng Mỹ',N'Nữ','1980/04/25',N'CVHT','CNTT'
exec ThemGiangVien 'GVCNTT4',N'Lê Thọ',N'Nam','1970/07/25',N'Giảng viên','CNTT'
exec ThemGiangVien 'GVCNTT5',N'Mai Kỷ Tuyên',N'Nữ','1987/03/11',N'CVHT','CNTT'
exec ThemGiangVien 'GVDH1',N'Nguyễn Phong Lan',N'Nữ','1979/01/11',N'CVHT','CNTT'
exec ThemGiangVien 'GVDH2',N'Nguyễn Ngọc Cẩm Tú',N'Nữ','1977/05/25',N'Giảng viên','CNTT'
exec ThemGiangVien 'GVDH3',N'Phạm Thị Mười',N'Nữ','1976/02/23',N'CVHT','CNTT'
exec ThemGiangVien 'GVDH4',N'Đoàn Quốc Thuận',N'Nam','1975/03/03',N'Giảng viên','CNTT'
exec ThemGiangVien 'GVDH5',N'Trần Thảo Nhi',N'Nữ','1980/06/23',N'CVHT','CNTT'
exec ThemGiangVien 'GVMMT1',N'Hoàng Thùy Lan',N'Nữ','1977/06/19',N'CVHT','CNTT'
exec ThemGiangVien 'GVMMT2',N'Nguyễn Ngọc Ánh Mỹ',N'Nữ','1970/05/29',N'Giảng viên','CNTT'
exec ThemGiangVien 'GVMMT3',N'Nguyễn Thị Mộng Hằng',N'Nữ','1984/07/08',N'CVHT','CNTT'
exec ThemGiangVien 'GVMMT4',N'Cao Trần Thái Anh',N'Nam','1980/08/28',N'Giảng viên','CNTT'
exec ThemGiangVien 'GVMMT5',N'Nguyễn Thanh Vũ',N'Nam','1976/05/27',N'CVHT','CNTT'
----Chuyên ngành
exec ThemChuyenNganh '6810206',N'Quản trị khách sạn','DL'
exec ThemChuyenNganh '7810201', N'Quản trị nhà hàng' ,'DL'
exec ThemChuyenNganh '7810103',N'Quản trị dịch vụ du lịch và lữ hành','DL'
exec ThemChuyenNganh '7510605',N'Logistics','QTKD'
exec ThemChuyenNganh '7340101',N'Quản trị kinh doanh','QTKD'
exec ThemChuyenNganh '7340121',N'Kinh doanh thương mại','QTKD'
exec ThemChuyenNganh '7210403',N'Thiết kế đồ họa','CNTT'
exec ThemChuyenNganh '7480102',N'Mạng máy tính','CNTT'
exec ThemChuyenNganh '7340405',N'Công nghệ thông tin','CNTT'
----Học phần
exec ThemHocPhan 'CSC104140',N'Quản trị chuỗi cung ứng',2,'QTKD',1
exec ThemHocPhan 'CSC104190',N'Đạo đức kinh doanh',2,'QTKD',1
exec ThemHocPhan 'CNC104030',N'Xử lý bảng tính',2,'QTKD',2
exec ThemHocPhan 'CNC104210',N'Quản trị nguồn nhân lực',2,'QTKD',2
exec ThemHocPhan 'CNC104260',N'Phân tích hoạt động kinh tế',3,'QTKD',3
exec ThemHocPhan 'CNC104121',N'Quản trị chất lượng',3,'QTKD',3
exec ThemHocPhan 'CSC103010',N'Nguyên lý thống kê',2,'QTKD',1
exec ThemHocPhan 'CSC104231',N'Marketing căn bản',2,'QTKD',1
exec ThemHocPhan 'CNC104360',N'Hệ thống thông tin thương mại',2,'QTKD',2
exec ThemHocPhan 'CNC104370',N'Khai thác trang thiết bị bán hàng',2,'QTKD',2
exec ThemHocPhan 'CNC104350',N'Lập kế hoạch bán hàng',2,'QTKD',3
exec ThemHocPhan 'CNC104540',N'Tư vấn và đàm phán trong kinh doanh',3,'QTKD',3
exec ThemHocPhan 'CSC104060',N'Nhập môn Logistics',2,'QTKD',1
exec ThemHocPhan 'CSK104020',N'Kinh tế vi mô',3,'QTKD',1
exec ThemHocPhan 'CNC104410',N'Nghiệp vụ xuất nhập khẩu',3,'QTKD',2
exec ThemHocPhan 'CNC104430',N'Quan hệ với nhà cung cấp và khách hàng',2,'QTKD',3
exec ThemHocPhan 'CSC104100',N'Bảo quản hàng hóa',3,'QTKD',3
exec ThemHocPhan 'CSK115050',N'Tổng quan nhà hàng',2,'DL',1
exec ThemHocPhan 'CSK115030',N'Văn hóa ẩm thực',3,'DL',1
exec ThemHocPhan 'CSK115040',N'An toàn an ninh trong nhà hàng – khách sạn',3,'DL',2
exec ThemHocPhan 'CSK115071',N'Anh văn chuyên ngành nhà hàng 1',2,'DL',2
exec ThemHocPhan 'CNK115070',N'Nghiệp vụ Bar',3,'DL',3
exec ThemHocPhan 'CNK115080',N'Nghiệp vụ phục vụ bàn',4,'DL',3
exec ThemHocPhan 'CSC115040',N'Tổng quan khách sạn',2,'DL',1
exec ThemHocPhan 'CSC105031',N'Cơ sở văn hóa Việt Nam',3,'DL',1
exec ThemHocPhan 'CNC115120',N'Nghiệp vụ lễ tân',4,'DL',2
exec ThemHocPhan 'CNC115130',N'Nghiệp vụ buồng phòng',4,'DL',2
exec ThemHocPhan 'CNC115110',N'Nghiệp vụ thanh toán',2,'DL',3
exec ThemHocPhan 'CNC115190',N'Quản trị lễ tân',2,'DL',3
exec ThemHocPhan 'CSC115010',N'Địa lý và tổng quan kinh tế xã hội Việt Nam',3,'DL',1
exec ThemHocPhan 'CSK115010',N'Văn hóa Việt Nam',3,'DL',1
exec ThemHocPhan 'CNC115300',N'Du lịch bền vững',2,'DL',2
exec ThemHocPhan 'CNK115031',N'Nghiệp vụ hướng dẫn du lịch 1',3,'DL',2
exec ThemHocPhan 'CNK115032',N'Nghiệp vụ hướng dẫn du lịch 2',3,'DL',3
exec ThemHocPhan 'CNK115040',N'Y tế du lịch',2,'DL',3
exec ThemHocPhan 'CSC106051',N'Kỹ thuật lập trình',4,'CNTT',1
exec ThemHocPhan 'CSC106370',N'Lập trình hướng đối tượng',4,'CNTT',1
exec ThemHocPhan 'CNC107420',N'Lập trình Java',3,'CNTT',2
exec ThemHocPhan 'CNC107463',N'Lập trình Front-End Web 1',4,'CNTT',2
exec ThemHocPhan 'CNC107270',N'Lập trình ứng dụng',3,'CNTT',3
exec ThemHocPhan 'CNC107400',N'Nhập môn công nghệ phần mềm',3,'CNTT',3
exec ThemHocPhan 'CSC106111',N'Mạng máy tính',3,'CNTT',1
exec ThemHocPhan 'CSC106132',N'Nhập môn công nghệ thông tin và truyền thông',4,'CNTT',1
exec ThemHocPhan 'CNC108066',N'Quản trị hệ thống Linux 1',4,'CNTT',2
exec ThemHocPhan 'CNC108222',N'Quản trị hệ thống Windows 1',3,'CNTT',2
exec ThemHocPhan 'CNC108062',N'Quản trị hệ thống Linux 2',3,'CNTT',3
exec ThemHocPhan 'CNC108223',N'Quản trị hệ thống Windows 2',3,'CNTT',3
exec ThemHocPhan 'CNC121390',N'Nghệ thuật chữ',3,'CNTT',1
exec ThemHocPhan 'CSC121030',N'Luật xa gần',2,'CNTT',1
exec ThemHocPhan 'CNC121020',N'Nhiếp ảnh',2,'CNTT',2
exec ThemHocPhan 'CNC121260',N'Xử lý ảnh',4,'CNTT',2
exec ThemHocPhan 'CNC121090',N'Xử lý phim',3,'CNTT',3
exec ThemHocPhan 'CNC121290',N'Dàn trang với Adobe Indesign',3,'CNTT',3
---Lớp
exec ThemLop 'CD22KD1','7340101','GVQTKD1'
exec ThemLop 'CD22KD2','7340101','GVQTKD4'
exec ThemLop 'CD21KD1','7340101','GVQTKD10'
exec ThemLop 'CD21KD2','7340101','GVQTKD1'
exec ThemLop 'CD22LG1','7510605','GVLG1'
exec ThemLop 'CD22LG2','7510605','GVLG4'
exec ThemLop 'CD21LG1','7510605','GVLG10'
exec ThemLop 'CD21LG2','7510605','GVLG1'
exec ThemLop 'CD22TM1','7340121','GVTM1'
exec ThemLop 'CD22TM2','7340121','GVTM10'
exec ThemLop 'CD21TM1','7340121','GVTM10'
exec ThemLop 'CD21TM2','7340121','GVTM4'
exec ThemLop 'CD22KS1','6810206','GVKS1'
exec ThemLop 'CD22KS2','6810206','GVKS6'
exec ThemLop 'CD21KS1','6810206','GVKS4'
exec ThemLop 'CD21KS2','6810206','GVKS4'
exec ThemLop 'CD22NH1','7810201','GVNH1'
exec ThemLop 'CD22NH2','7810201','GVNH6'
exec ThemLop 'CD21NH1','7810201','GVNH6'
exec ThemLop 'CD21NH2','7810201','GVNH4'
exec ThemLop 'CD22LH1','7810103','GVLH1'
exec ThemLop 'CD22LH2','7810103','GVLH6'
exec ThemLop 'CD21LH1','7810103','GVLH4'
exec ThemLop 'CD21LH2','7810103','GVLH6'
exec ThemLop 'CD22TT1','7340405','GVCNTT1'
exec ThemLop 'CD22TT2','7340405','GVCNTT3'
exec ThemLop 'CD21TT1','7340405','GVCNTT5'
exec ThemLop 'CD21TT2','7340405','GVCNTT3'
exec ThemLop 'CD22DH1','7210403','GVDH1'
exec ThemLop 'CD22DH2','7210403','GVDH3'
exec ThemLop 'CD21DH1','7210403','GVDH5'
exec ThemLop 'CD21DH2','7210403','GVDH1'
exec ThemLop 'CD22MT1','7480102','GVMMT1'
exec ThemLop 'CD22MT2','7480102','GVMMT5'
exec ThemLop 'CD21MT1','7480102','GVMMT3'
exec ThemLop 'CD21MT2','7480102','GVMMT5'
---Sinh viên
exec ThemSinhVien '22211TT3268',N'Lê Thị Hằng',N'Nữ','2004/3/24','323454178356',N'02/1, Tổ 21, Khu phố 12, Phường Bình Tân, Thành Phố Biên Hòa, Tỉnh Đồng Nai',N'Đồng Nai','2022-2025','CD22TT1'
exec ThemSinhVien '22211TT3328',N'Nguyễn Thị Hoa',N'Nữ','2003/10/2','323298378312',N'L1, Quận 1, Thành Phố Hồ Chí Minh',N'Cần Thơ','2022-2025','CD22TT1'
exec ThemSinhVien '22211TT3465',N'Nguyễn Diệp',N'Nữ','2004/8/5','043215678952',N'79/6, Tổ 6, Khu phố 5, Phường Phước Long B,Thủ Đức, TPHCM',N'Nam Định','2022-2025','CD22TT2'
exec ThemSinhVien '22211TT9832',N'Lê Hoài Nam',N'Nam','2004/9/12','043267812345',N'80/6, Tổ 3, Khu phố 6, Phường Phước Long A,Thủ Đức, TPHCM',N'Bình Định','2022-2025','CD22TT2'
exec ThemSinhVien '22111TT3278',N'Nguyễn Thanh Trúc',N'Nữ','2003/3/5','016352927261',N'11/23, Tổ 6, Khu phố 5, Phường Linh Chiểu,Thủ Đức, TPHCM',N'Ninh Bình','2012-2024','CD21TT1'
exec ThemSinhVien '22111TT6554',N'Trần Lĩnh',N'Nam','2004/6/5','023489165231',N'80A, Tổ 6, Khu phố 5, Phường Linh Trung,Thủ Đức, TPHCM',N'Cà Mau','2021-2024','CD21TT1'
exec ThemSinhVien'22111TT6352',N'Nguyễn Thanh Lam',N'Nữ','2002/4/12','037651076519',N'122/34, Tổ 4, Khu phố 7, Phường Linh Chiểu,Thủ Đức, TPHCM',N'Nam Định','2021-2024','CD21TT2'
exec ThemSinhVien'22111TT8755',N'Trần Hoài Bảo',N'Nam','2003/12/3','090651290145',N'99A, Tổ 6, Khu phố 5, Phường Linh Trung,Thủ Đức, TPHCM',N'Nghệ An','2021-2024','CD21TT2'
exec ThemSinhVien'22111MT3652',N'Trần Ngọc Linh',N'Nữ','2001/4/11','065201976521',N'69/87, Tổ A, Khu phố 9, Phường Linh Trung, Thú Đức, TPHCM',N'Lai Châu','2021-2024','CD21MT2'
exec ThemSinhVien'22111TT7522',N'Nguyễn Văn Nam',N'Nam','1900/5/24','098254012854',N'79A, Tổ 6, Khu phố Đông A, Phường Phong Phú, Thủ Đức, TPHCM',N'Cần Thơ','2021-2024','CD21MT2'
exec ThemSinhVien'22111MT7542',N'Ngô Bảo Uyên',N'Nữ','2002/8/22','062419273621',N'69/87/54, Tổ A, Khu phố 9, Phường Linh Trung, Thú Đức, TPHCM',N'Ninh Bình','2021-2024','CD21MT1'
exec ThemSinhVien'22111MT0825',N'Đinh Nguyễn An Bình',N'Nữ','2003/7/24','085410923450',N'79A, Tổ 3, Khu phố B, Phường Phong Phú, Thủ Đức, TPHCM',N'Lâm Đồng','2021-2024','CD21MT1'
exec ThemSinhVien'22211MT7252',N'Trần Bảo Linh',N'Nữ','2002/12/12','054291834561',N'669A, Tổ A, Khu phố 9, Phường Linh Trung, Thú Đức, TPHCM',N'Lâm Đồng','2022-2025','CD22MT1'
exec ThemSinhVien'22211MT7862',N'Nguyễn Thới',N'Nam','1900/12/25','098321054210',N'112/34, Tổ B, Khu phố Đông A, Phường Phong Phú, Thủ Đức, TPHCM',N'Bỉnh Dương','2022-2025','CD22MT1'
exec ThemSinhVien'22211MT6543',N'Lê Trúc Linh',N'Nữ','2003/12/5','073615201765',N'69B, Tổ NamA, Phường Linh Trung, Thuận An, Bình Dương',N'Quảng Nam','2022-2025','CD22MT2'
exec ThemSinhVien'22211MT9865',N'Nguyễn Thương',N'Nam','2004/9/20','097234018912',N'65/9/7, Tổ 7C, Khu phố Nam A, Tân Uyên, Bình Dương',N'Đà Nẵng','2022-2025','CD22MT2'
exec ThemSinhVien'22211DH1000',N'Trần Hoàng Thùy Lan',N'Nữ','2004/11/17','023086120865',N'123/QL1, Tổ 7, Khu phố Thắng Lợi, Thủ Đức, TPHCM',N'Thanh Hóa','2022-2025','CD22DH1'
exec ThemSinhVien'22211DH2017',N'Nguyễn Thương Vũ',N'Nam','2004/1/20','032198362156',N'65/9/7, Tổ 10, Quận Gò Vấp, TPHCM',N'Đà Lạt','2022-2025','CD22DH1'
exec ThemSinhVien'22211DH4767',N'Trần Hoàng Thùy Linh',N'Nữ','2002/12/2','263829102341',N'122/43,Tổ 3, Phường Bình Chánh, Thủ Đức , TPHCM',N'Quảng Ngãi','2022-2025','CD22DH2'
exec ThemSinhVien'22211DH2208',N'Nguyễn Văn Siêng',N'Nam','2004/3/29','032871092134',N'65/9/7, Tổ 10, Phường Hiệp Bình, TPHCM',N'Đà Nẵng','2022-2025','CD22DH2'
exec ThemSinhVien'22111DH3623',N'Ngô Kim Uyên',N'Nữ','2000/2/24','087365201865',N'Số 1 Lương Định Của, phường An Phú, thành phố Thủ Đức, TPHCM',N'Hà Nội','2021-2024','CD21DH1'
exec ThemSinhVien'22111DH8737',N'Nguyễn Duy Linh',N'Nam','2003/1/1','089174652981',N'934 Tỉnh lộ 43, khu phố 1, phường Bình Chiểu, thành phố Thủ Đức, TPHCM',N'Đà Lạt','2021-2024','CD21DH1'
exec ThemSinhVien'22111DH7562',N'Võ Như Quỳnh',N'Nữ','2000/3/14','073267524312',N'185 Đình Phong Phú, Khu Phố 3, Phường Tăng Nhơn Phú B, thành phố Thủ Đức, TPHCM',N'Phú Yên','2021-2024','CD21DH2'
exec ThemSinhVien'22111DH9754',N'Nguyễn Chiến',N'Nam','2004/5/24','076301980123',N'71 đường Nguyễn Tuyển, phường Bình Trưng Tây, thành phố Thủ Đức, TPHCM',N'Tiền Giang','2021-2024','CD21DH2'
exec ThemSinhVien'22111LG8754',N'Trần Thị Kim Ngân',N'Nữ','1999/3/14','042358712398',N'khu phố A, Đông Tx., 153 Quốc lộ 1K, Đông Hoà, Dĩ An, Bình Dương',N'Cao Bằng','2021-2024','CD21LG1'
exec ThemSinhVien'22111LG8755',N'Nguyễn Khiêm',N'Nam','1989/4/26','090923045061',N' 364 Lê Đức Thọ, Phường 6, Quận Gò Vấp, TP.HCM',N'Hà Giang','2021-2024','CD21LG1'
exec ThemSinhVien'22111LG2543',N'Nguyễn Hoàng Nguyên',N'Nữ','1999/3/14','036537289012',N'37 Nguyễn Văn Lượng, Phường 17, Gò Vấp, TPHCM',N'Lâm Đồng','2021-2024','CD21LG2'
exec ThemSinhVien'22111LG2766',N'Nguyễn Tấn Tài',N'Nam','1989/4/26','062481735201',N'563 Quang Trung, Phường 10, Gò Vấp,TPHCM',N'Hà Tĩnh','2021-2024','CD21LG2'
exec ThemSinhVien'22211LG8362',N'Trần Thị Kim Uyên',N'Nữ','2003/5/20','072536401230',N' 175 Đ. Cây Trâm, Phường 8, Gò Vấp, TPHCM',N'Bến Tre','2022-2025','CD22LG1'
exec ThemSinhVien'22211LG9172',N'Nguyễn Khiếm',N'Nam','1989/7/20','083627012975',N'9 Đ. số 3, Phường 9, Gò Vấp, TPHCM',N'Hà Giang','2022-2025','CD22LG1'
exec ThemSinhVien'22211LG2543',N'Nguyễn Hoàng',N'Nam','1999/3/14','063428761203',N'81 Quốc lộ 1K, khu phố 2, phường Linh Xuân, thành phố Thủ Đức, TPHCM',N'Hậu Giang','2022-2025','CD22LG2'
exec ThemSinhVien'22211LG2766',N'Trần Bá Triệu',N'Nam','1989/4/26','065201739012',N' 364 Lê Đức Thọ, Phường 6, Quận Gò Vấp, TP.HCM',N'Sóc Trăng','2022-2025','CD22LG2'
exec ThemSinhVien'22211KS3623',N'Trần Thị Kim',N'Nữ','2005/4/21','023450273628',N'311J 5A Đường G, Khu phố 1, phường An Phú, Thành phố Thủ Đức, TPHCM',N'Cà Mau','2022-2025','CD22KS1'
exec ThemSinhVien'22211KS4927',N'Nguyễn Chiến',N'Nam','2000/5/20','092753201986',N'9 Đ. số 3, Phường 9, Gò Vấp, TPHCM',N'Thanh Hóa','2022-2025','CD22KS1'
exec ThemSinhVien'22211KS3873',N'Phạm Hoàng Thảo Vy',N'Nữ','1976/3/14','035468192301',N'81 Quốc lộ 1K, khu phố 2, phường Linh Xuân, thành phố Thủ Đức, TPHCM',N'Hậu Giang','2022-2025','CD22KS2'
exec ThemSinhVien'22211KS9725',N'Trần Bá Nam',N'Nam','1989/4/26','098642102030',N'397 Phan Huy Ích, Phường 14, Gò Vấp, TP.HCM',N'Sóc Trăng','2022-2025','CD22KS2'
exec ThemSinhVien'22111KS3652',N'Nguyễn Thảo Linh',N'Nữ','2005/4/2','072638910234',N'134 Hồ Văn Tư, khu phố 2, phường Trường Thọ, thành phố Thủ Đức, TPHCM',N'Cà Mau','2021-2024','CD21KS1'
exec ThemSinhVien'22111KS8362',N'Nguyễn Hoàng Phúc',N'Nam','2000/3/20','064201989865',N'08 Hồ Thị Nhung, khu phố 4, Phường Bình Trưng Đông',N'Thái Nguyên','2021-2024','CD21KS1'
exec ThemSinhVien'22111KS3762',N'Phạm Ngọc Vy',N'Nữ','2003/5/30','063901287310',N' 168 Trương Văn Bang, Phường Thạnh Mỹ Lợi,TP. Thủ Đức, TPHCM',N'Nam Định','2021-2024','CD21KS2'
exec ThemSinhVien'22111KS3272',N'Nguyễn Tiến',N'Nam','1989/6/1','076243019823',N'418 Nguyễn Tất Thành, Phường 18, Quận 4,TPHCM',N'Cần Thơ','2021-2024','CD21KS2'
exec ThemSinhVien'22211TM8372',N'Trần Thị Kim Ngọc',N'Nữ','2003/2/12','253671026371',N'153 quốc Lộ 1K, khu phố Đông A, phường Đông Hòa, thành phố Dĩ An, tỉnh Bình Dương, Phường Đông Hòa, Thành phố Dĩ An, Tỉnh Bình Dương',N'Bình Dương','2022-2025','CD22TM1'
exec ThemSinhVien'22211TM6521',N'Nguyễn Khai Tâm',N'Nam','2000/6/20','072410263213',N'Khu phố Bình Thung 2, đường DT 743, phường Bình An, Dĩ An, Bình Dương',N'Phú Thọ','2022-2025','CD22TM1'
exec ThemSinhVien'22211TM9275',N'Phạm Hoàng Ngọc Vy',N'Nữ','1976/4/12','002836182736',N'2MWQ+2W4, Đường NB4, Khu Phố 1, Tân Uyên, Bình Dương',N'Hậu Giang','2022-2025','CD22TM2'
exec ThemSinhVien'22211TM6252',N'Trần Thanh Thái',N'Nam','1989/8/26','016390128374',N'Đường ĐX 124, khu phố 5, phường Tân An, thành phố Thủ Dầu Một, tỉnh Bình Dương., Phường Tân An, Thành phố Thủ Dầu Một, Tỉnh Bình Dương',N'Bắc Ninh','2022-2025','CD22TM2'
exec ThemSinhVien'22111TM6421',N'Nguyễn Thảo Lam',N'Nữ','2003/4/9','263578201923',N'1262 Đ. Kha Vạn Cân, Phường Linh Trung, Thủ Đức, Thành phố Hồ Chí Minh',N'Huế','2021-2024','CD21TM1'
exec ThemSinhVien'22111TM9735',N'Nguyễn Hoàng Phúc Tiến',N'Nam','2001/4/29','066342829123',N'24 Đ. Số 20, Linh Chiểu, Thủ Đức, Thành phố Hồ Chí Minh',N'Thái Nguyên','2021-2024','CD21TM1'
exec ThemSinhVien'22111TM0751',N'Phạm Ngọc Thảo Ninh',N'Nữ','2003/7/22','090230405060',N'763 Đ. Kha Vạn Cân, Khu phố 2, Thủ Đức, Thành phố Hồ Chí Minh',N'Bến Tre','2021-2024','CD21TM2'
exec ThemSinhVien'22111TM8512',N'Nguyễn Thúc Tiến',N'Nam','2003/3/12','014637901234',N' 7 Tân Phú, Quận 7, Thành phố Hồ Chí Minh',N'Quảng Nam','2021-2024','CD21TM2'
exec ThemSinhVien'22211KD6352',N'Phạm Vũ Hoàng Uyên',N'Nữ','2003/2/12','253671026371',N'153 quốc Lộ 1K, khu phố Đông A, phường Đông Hòa, thành phố Dĩ An, tỉnh Bình Dương, Phường Đông Hòa, Thành phố Dĩ An, Tỉnh Bình Dương',N'Bình Dương','2022-2025','CD22KD1'
exec ThemSinhVien'22211KD9272',N'Ngô Tất Đạt',N'Nam','2000/6/20','072410263213',N'Khu phố Bình Thung 2, đường DT 743, phường Bình An, Dĩ An, Bình Dương',N'Phú Thọ','2022-2025','CD22KD1'
exec ThemSinhVien'22211KD2752',N'Phạm Băng Băng',N'Nữ','1976/4/12','002836182736',N'2MWQ+2W4, Đường NB4, Khu Phố 1, Tân Uyên, Bình Dương',N'Hậu Giang','2022-2025','CD22KD2'
exec ThemSinhVien'22211KD0026',N'Trần Thanh Thái',N'Nam','1989/8/26','016390128374',N'Đường ĐX 124, khu phố 5, phường Tân An, thành phố Thủ Dầu Một, tỉnh Bình Dương, Phường Tân An, Thành phố Thủ Dầu Một, Tỉnh Bình Dương',N'Bắc Ninh','2022-2025','CD22KD2'
exec ThemSinhVien'22111KD7262',N'Trần Thu Thảo',N'Nữ','2003/4/9','263578201923',N'1262 Đ. Kha Vạn Cân, Phường Linh Trung, Thủ Đức, Thành phố Hồ Chí Minh',N'TPHCM','2021-2024','CD21KD1'
exec ThemSinhVien'22111KD1541',N'Nguyễn Hoàng Phúc Du',N'Nam','2001/4/29','066342829123',N'24 Đ. Số 20, Linh Chiểu, Thủ Đức, Thành phố Hồ Chí Minh',N'Bình Phước','2021-2024','CD21KD1'
exec ThemSinhVien'22111KD1638',N'Phạm Thúy Ngân',N'Nữ','2003/7/22','090230405060',N'05, ward, Vietnam, Đ. Trần Ngọc Diện, Thảo Điền, Quận 2, Thành phố Hồ Chí Minh',N'Vĩnh Phúc','2021-2024','CD21KD2'
exec ThemSinhVien'22111KD2763',N'Nguyễn Hồng Thanh',N'Nam','2003/3/12','014637901234',N' 4 Dương Quang Đông, Phường 5, Quận 8, Thành phố Hồ Chí Minh',N'An Giang','2021-2024','CD21KD2'
exec ThemSinhVien'22211NH6352',N'Trần Thị Kim Duyên',N'Nữ','2004/4/5','026453987621',N'153 quốc Lộ 1K, khu phố Đông A, phường Đông Hòa, thành phố Dĩ An, tỉnh Bình Dương, Phường Đông Hòa, Thành phố Dĩ An, Tỉnh Bình Dương',N'Hà Nội','2022-2025','CD22NH1'
exec ThemSinhVien'22211NH9272',N'Nguyễn Khai Tiến',N'Nam','2000/7/13','007263789123',N'Khu phố Bình Thung 2, đường DT 743, phường Bình An, Dĩ An, Bình Dương',N'Phú Thọ','2022-2025','CD22NH1'
exec ThemSinhVien'22211NH2752',N'Phạm Minh Triệu',N'Nữ','2002/4/23','038746283612',N'99-99A Trần Quốc Thảo, Phường 7, Quận 3, Thành phố Hồ Chí Minh',N'Hậu Giang','2022-2025','CD22NH2'
exec ThemSinhVien'22211NH0026',N'Trần Thanh Thản',N'Nam','2004/3/24','075263517263',N'18 Đường Đoàn Như Hài, Phường 13, Quận 4, Thành phố Hồ Chí Minh',N'Bắc Ninh','2022-2025','CD22NH2'
exec ThemSinhVien'22111NH3282',N'Trần Thị Mỹ Duyên',N'Nữ','2003/5/5','063527253610',N'203 Đ. An Dương Vương, Phường 8, Quận 5, Thành phố Hồ Chí Minh',N'Bình Định','2021-2024','CD22NH1'
exec ThemSinhVien'22111NH8722',N'Nguyễn Khai Tiến Lục',N'Nam','1999/6/13','072635401823',N'107 Đ.Cao Văn Lầu, Phường 1, Quận 6, Thành phố Hồ Chí Minh',N'Huế','2021-2024','CD21NH1'
exec ThemSinhVien'22111NH9365',N'Phạm Mỹ Anh',N'Nữ','2002/6/23','027364829123',N'387A Trường Chinh, Phường 14, Tân Bình, Thành phố Hồ Chí Minh',N'Long An','2021-2024','CD21NH2'
exec ThemSinhVien'22111NH7542',N'Trần Chiến Đấu',N'Nam','2000/7/24','046350293742',N'Số 6 Phan Đăng Lưu, Phường 14, Bình Thạnh, Thành phố Hồ Chí Minh',N'Hòa Bình','2021-2024','CD21NH2'
exec ThemSinhVien'22211LH3826',N'Trần Thị Kim',N'Nữ','2004/7/29','072536281920',N' 349 Đường Tân Túc, TT. Tân Túc, Bình Chánh, Thành phố Hồ Chí Minh',N'Nghệ An','2022-2025','CD22LH1'
exec ThemSinhVien'22211LH7362',N'Nguyễn Tiến Nam',N'Nam','2000/8/13','062502401096',N'521 Đ. Kinh Dương Vương, An Lạc, Bình Tân, Thành phố Hồ Chí Minh',N'Thái Bình','2022-2025','CD22LH1'
exec ThemSinhVien'22211LH2836',N'Phạm Minh Anh',N'Nữ','2002/9/23','015372918352',N'387A Trường Chinh, Phường 14, Quận Tân Bình, TP. HCM',N'Kiên Giang','2022-2025','CD22LH2'
exec ThemSinhVien'22211LH2973',N'Trần Thân',N'Nam','2004/12/24','001628374621',N'332 Quang Trung, Phường 10, Gò Vấp, Thành phố Hồ Chí Minh',N'Hòa Bình','2022-2025','CD22LH2'
exec ThemSinhVien'22111LH2752',N'Trần Thị Hồng Mỹ',N'Nữ','2002/6/7','026354817344',N' 48 Lê Hồng Phong, Tân Đông Hiệp, Dĩ An, Bình Dương',N'Bắc Kạn','2021-2024','CD22LH1'
exec ThemSinhVien'22111LH2763',N'Nguyễn Xuân Bắc',N'Nam','1999/6/9','023401976512',N'719 QL13, Hiệp Bình Phước, Thủ Đức, Thành phố Hồ Chí Minh',N'Hà Giang','2021-2024','CD21LH1'
exec ThemSinhVien'22111LH2816',N'Phạm Quỳnh Anh',N'Nữ','2002/8/23','062537180651',N'2 Đ. Số 5, Khu phố 1, Thủ Đức, Thành phố Hồ Chí Minh',N'Hưng Yên','2021-2024','CD21LH2'
--Học phần
exec ThemLopHocPhan'CSC104140','LCCU01','A201'
exec ThemLopHocPhan'CSC104140','LCCU02','A202'
exec ThemLopHocPhan'CSC104190','DDKD01','A101'
exec ThemLopHocPhan'CSC104190','DDKD02','A102'
exec ThemLopHocPhan'CNC104030','XLBT01','A205'
exec ThemLopHocPhan'CNC104030','XLBT02','A206'
exec ThemLopHocPhan'CNC104210','QTNL01','D205'
exec ThemLopHocPhan'CNC104210','QTNL02','D206'
exec ThemLopHocPhan'CNC104260','PTHDKT01','D210'
exec ThemLopHocPhan'CNC104260','PKHDKT02','D111'
exec ThemLopHocPhan'CNC104121','PTQTCL01','D212'
exec ThemLopHocPhan'CNC104121','PTQTCL02','A222'
exec ThemLopHocPhan'CSC103010','NLTK01','D212'
exec ThemLopHocPhan'CSC103010','NLTK02','D322'
exec ThemLopHocPhan'CSC104231','MKT01','D111'
exec ThemLopHocPhan'CSC104231','MKT02','A122'
exec ThemLopHocPhan'CNC104360','HTTT01','A111'
exec ThemLopHocPhan'CNC104360','HTTT02','A222'
exec ThemLopHocPhan'CNC104370','KTTTBBH01','A100'
exec ThemLopHocPhan'CNC104370','KTTTBBH02','D203'
exec ThemLopHocPhan'CNC104350','KHBH01','A120'
exec ThemLopHocPhan'CNC104350','KHBH02','A210'
exec ThemLopHocPhan'CNC104540','TVDP01','D100'
exec ThemLopHocPhan'CNC104540','TVDP02','D202'
exec ThemLopHocPhan'CSC104060','NMLG01','A204'
exec ThemLopHocPhan'CSC104060','NMLG02','D121'
exec ThemLopHocPhan'CSK104020','KTVM01','A205'
exec ThemLopHocPhan'CSK104020','KTVM02','B222'
exec ThemLopHocPhan'CNC104410','NVXK01','A206'
exec ThemLopHocPhan'CNC104410','NVXK02','B224'
exec ThemLopHocPhan'CNC104430','QHNCCKH01','A206'
exec ThemLopHocPhan'CNC104430','QHNCCKH02','B224'
exec ThemLopHocPhan'CSC104100','BQHH01','A207'
exec ThemLopHocPhan'CSC104100','BQHH02','A208'
exec ThemLopHocPhan'CSK115050','TQNH01','A208'
exec ThemLopHocPhan'CSK115050','TQNH02','A224'
exec ThemLopHocPhan'CSK115030','VHAT01','A210'
exec ThemLopHocPhan'CSK115030','VHAT02','A204'
exec ThemLopHocPhan'CSK115040','ATAN01','A134'
exec ThemLopHocPhan'CSK115040','ATAN02','A225'
exec ThemLopHocPhan'CSK115071','AVCNNH01','A206'
exec ThemLopHocPhan'CSK115071','AVCNNH02','D411'
exec ThemLopHocPhan'CNK115070','NVBAR01','D301'
exec ThemLopHocPhan'CNK115070','NVBAR02','D311'
exec ThemLopHocPhan'CNK115080','NVPVBAN01','D304'
exec ThemLopHocPhan'CNK115080','NVPVBAN02','D314'
exec ThemLopHocPhan'CSC115040','TQKS01','D204'
exec ThemLopHocPhan'CSC115040','TQKS02','D215'
exec ThemLopHocPhan'CSC105031','CSVH01','D300'
exec ThemLopHocPhan'CSC105031','CSVH02','D601'
exec ThemLopHocPhan'CNC115120','NVLT01','D314'
exec ThemLopHocPhan'CNC115120','NVLT02','D312'
exec ThemLopHocPhan'CNC115130','NVBP01','D207'
exec ThemLopHocPhan'CNC115130','NVBP02','D213'
exec ThemLopHocPhan'CNC115110','NVTT01','D210'
exec ThemLopHocPhan'CNC115110','NVTT02','D212'
exec ThemLopHocPhan'CNC115190','QTLT01','D210'
exec ThemLopHocPhan'CNC115190','QTLT02','D212'
exec ThemLopHocPhan'CSC115010','DLKTXH01','D211'
exec ThemLopHocPhan'CSC115010','DLKTXH02','D215'
exec ThemLopHocPhan'CSK115010','VHVN01','D212'
exec ThemLopHocPhan'CSK115010','VHVN02','D218'
exec ThemLopHocPhan'CNC115300','DLBV01','D213'
exec ThemLopHocPhan'CNC115300','DLBV02','D220'
exec ThemLopHocPhan'CNK115031','NVHDDL101','D202'
exec ThemLopHocPhan'CNK115031','NVHDDL102','D301'
exec ThemLopHocPhan'CNK115032','NVHDDL201','D205'
exec ThemLopHocPhan'CNK115032','NVHDDL202','D305'
exec ThemLopHocPhan'CNK115040','YTDL01','D205'
exec ThemLopHocPhan'CNK115040','YTDL02','D305'
exec ThemLopHocPhan'CSC106051','KTLT01','B102A'
exec ThemLopHocPhan'CSC106051','KTLT02','B102B'
exec ThemLopHocPhan'CSC106370','LTHDT01','B202A'
exec ThemLopHocPhan'CSC106370','LTHDT02','B102A'
exec ThemLopHocPhan'CNC107420','LTJAVA01','B203A'
exec ThemLopHocPhan'CNC107420','LTJAVA02','B203B'
exec ThemLopHocPhan'CNC107463','LTFE01','B201A'
exec ThemLopHocPhan'CNC107463','LTFE02','B201B'
exec ThemLopHocPhan'CNC107270','LTUD01','B102A'
exec ThemLopHocPhan'CNC107270','LTUD02','B102B'
exec ThemLopHocPhan'CNC107400','NMCNPM01','B102A'
exec ThemLopHocPhan'CNC107400','NMCNPM02','B102B'
exec ThemLopHocPhan'CNC107400','MMT01','B101A'
exec ThemLopHocPhan'CNC107400','MMT02','B201A'
exec ThemLopHocPhan'CSC106132','NMCNTT01','B102A'
exec ThemLopHocPhan'CSC106132','NMCNTT02','B102B'
exec ThemLopHocPhan'CNC108066','QTLX101','B101A'
exec ThemLopHocPhan 'CNC108066','QTLX102','B201A'
exec ThemLopHocPhan'CNC108062','QTLX201','B101A'
exec ThemLopHocPhan'CNC108062','QTLX202','B201A'
exec ThemLopHocPhan'CNC108222','QTWD101','B209A'
exec ThemLopHocPhan'CNC108222','QTWD102','B209B'
exec ThemLopHocPhan'CNC108222','QTWD201','B209A'
exec ThemLopHocPhan'CNC108222','QTWD202','B209B'
exec ThemLopHocPhan'CNC121390','NTC01','B201A'
exec ThemLopHocPhan'CNC121390','NTC02','B201B'
exec ThemLopHocPhan'CSC121030','LXG01','B002B'
exec ThemLopHocPhan'CSC121030','LXG02','B002C'
exec ThemLopHocPhan'CNC121020','NA01','B203A'
exec ThemLopHocPhan'CNC121020','NA02','B203B'
exec ThemLopHocPhan'CNC121260','XLA01','B101B'
exec ThemLopHocPhan'CNC121260','XLA02','B201B'
exec ThemLopHocPhan'CNC121090','LXP01','B002B'
exec ThemLopHocPhan'CNC121090','LXP02','B002C'
exec ThemLopHocPhan'CNC121290','DTADOBE01','B002B'
exec ThemLopHocPhan'CNC121290','DTADOBE02','B002C'
---Dam nhan
exec ThemDamNhan'GVQTKD3','LCCU01','2022/10/1','2022/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVQTKD3','LCCU02','2022/10/1','2022/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVQTKD2','DDKD01','2022/10/1','2022/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVQTKD2','DDKD02','2022/10/1','2022/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVQTKD1','XLBT01','2022/10/1','2022/12/30',N'T3 7h - 11h'
exec ThemDamNhan'GVQTKD1','XLBT02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVQTKD4','QTNL01','2022/10/1','2022/12/30',N'T3 7h - 11h'
exec ThemDamNhan'GVQTKD4','QTNL02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVQTKD10','PTHDKT01','2021/10/1','2021/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVQTKD10','PKHDKT02','2021/10/1','2021/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVQTKD5','PTQTCL01','2021/10/1','2021/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVQTKD5','PTQTCL02','2021/10/1','2021/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVTM1','NLTK01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVTM1','NLTK02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVTM4','DDKD01','2022/10/1','2022/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVTM4','DDKD02','2022/10/1','2022/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVTM10','XLBT01','2022/10/1','2022/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVTM10','XLBT02','2022/10/1','2022/12/30',N'T7 12h45 - 5h'
exec ThemDamNhan'GVTM2','QTNL01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVTM2','QTNL02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVTM3','PTHDKT01','2021/10/1','2021/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVTM3','PKHDKT02','2021/10/1','2021/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVTM5','PTQTCL01','2021/10/1','2021/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVTM5','PTQTCL02','2021/10/1','2021/12/30',N'T7 12h45 - 5h'
exec ThemDamNhan'GVLG1','NMLG01','2022/10/1','2022/12/30',N'T3 7h - 11h'
exec ThemDamNhan'GVLG1','NMLG02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVLG4','KTVM01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVLG4','KTVM02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVLG10','NVXK01','2022/10/1','2022/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVLG10','NVXK02','2022/10/1','2022/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVLG3','QHNCCKH01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVLG3','QHNCCKH02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVLG5','BQHH01','2021/10/1','2021/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVLG5','BQHH02','2021/10/1','2021/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVKS1','VHAT01','2022/10/1','2022/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVKS1','VHAT02','2022/10/1','2022/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVKS2','TQNH01','2022/10/1','2022/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVKS2','TQNH02','2022/10/1','2022/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVKS3','ATAN01','2022/10/1','2022/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVKS3','ATAN02','2022/10/1','2022/12/30',N'T7 12h45 - 5h'
exec ThemDamNhan'GVKS4','AVCNNH01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVKS4','AVCNNH02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVKS5','NVBAR01','2021/10/1','2021/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVKS5','NVBAR02','2021/10/1','2021/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVKS6','NVPVBAN01','2021/10/1','2021/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVKS6','NVPVBAN02','2021/10/1','2021/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVNH1','TQKS01','2022/10/1','2022/12/30',N'T3 7h - 11h'
exec ThemDamNhan'GVNH1','TQKS02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVNH2','CSVH01','2022/10/1','2022/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVNH2','CSVH02','2022/10/1','2022/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVNH3','NVLT01','2022/10/1','2022/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVNH3','NVLT02','2022/10/1','2022/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVNH4','NVBP01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVNH4','NVBP02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVNH5','NVTT01','2021/10/1','2021/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVNH5','NVTT02','2021/10/1','2021/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVNH6','QTLT01','2021/10/1','2021/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVNH6','QTLT02','2021/10/1','2021/12/30',N'T7 12h45 - 5h'
exec ThemDamNhan'GVLH1','DLKTXH01','2022/10/1','2022/12/30',N'T3 7h - 11h'
exec ThemDamNhan'GVLH1','DLKTXH02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVLH2','VHVN01','2022/10/1','2022/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVLH2','VHVN02','2022/10/1','2022/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVLH3','DLBV01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVLH3','DLBV02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVLH4','NVHDDL101','2022/10/1','2022/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVLH4','NVHDDL102','2022/10/1','2022/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVLH5','NVHDDL201','2021/10/1','2021/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVLH5','NVHDDL202','2021/10/1','2021/12/30',N'T7 12h45 - 5h'
exec ThemDamNhan'GVLH6','YTDL01','2021/10/1','2021/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVLH6','YTDL02','2021/10/1','2021/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVCNTT1','KTLT01','2022/10/1','2022/12/30',N'T3 7h - 11h'
exec ThemDamNhan'GVCNTT1','KTLT02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVCNTT2','LTHDT01','2022/10/1','2022/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVCNTT2','LTHDT02','2022/10/1','2022/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVCNTT3','LTJAVA01','2022/10/1','2022/12/30',N'T5 7h - 11h'
exec ThemDamNhan'GVCNTT3','LTJAVA02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVCNTT4','LTFE01','2022/10/1','2022/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVCNTT4','LTFE02','2022/10/1','2022/12/30',N'T6 12h45 - 5h'
exec ThemDamNhan'GVCNTT5','LTUD01','2021/10/1','2021/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVCNTT5','LTUD02','2021/10/1','2021/12/30',N'T7 12h45 - 5h'
exec ThemDamNhan'GVCNTT2','NMCNPM01','2021/10/1','2021/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVCNTT2','NMCNPM02','2021/10/1','2021/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVMMT1','MMT01','2022/10/1','2022/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVMMT1','MMT02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVMMT2','NMCNTT01','2022/10/1','2022/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVMMT2','NMCNTT02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVMMT3','QTLX101','2022/10/1','2022/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVMMT3','QTLX102','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVMMT4','QTLX201','2022/10/1','2022/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVMMT4','QTLX202','2022/10/1','2022/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVMMT5','QTWD101','2021/10/1','2021/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVMMT5','QTWD102','2021/10/1','2021/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVMMT3','QTWD201','2021/10/1','2021/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVMMT3','QTWD202','2021/10/1','2021/12/30',N'T2 12h45 - 5h'
exec ThemDamNhan'GVDH1','NTC01','2022/10/1','2022/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVDH1','NTC02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVDH2','LXG01','2022/10/1','2022/12/30',N'T4 7h - 11h'
exec ThemDamNhan'GVDH2','LXG02','2022/10/1','2022/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVDH3','NA01','2022/10/1','2022/12/30',N'T6 7h - 11h'
exec ThemDamNhan'GVDH3','NA02','2022/10/1','2022/12/30',N'T5 12h45 - 5h'
exec ThemDamNhan'GVDH4','XLA01','2022/10/1','2022/12/30',N'T7 7h - 11h'
exec ThemDamNhan'GVDH4','XLA02','2022/10/1','2022/12/30',N'T4 12h45 - 5h'
exec ThemDamNhan'GVDH5','LXP01','2021/10/1','2021/12/30',N'T2 7h - 11h'
exec ThemDamNhan'GVDH5','LXP02','2021/10/1','2021/12/30',N'T3 12h45 - 5h'
exec ThemDamNhan'GVDH4','DTADOBE01','2021/10/1','2021/12/30',N'T2 7h - 11h'
---Đăng ký
exec ThemDangKy '22211TT3268','KTLT01','2022/10/1','2022/12/30'
exec ThemDangKy '22211TT3268','LTHDT01','2022/10/1','2022/12/30'
exec ThemDangKy '22211TT3268','LTJAVA01','2022/10/1','2022/12/30'
exec ThemDangKy '22211TT3328','KTLT02','2022/10/1','2022/12/30'
exec ThemDangKy '22211TT3465','LTHDT01','2022/10/1','2022/12/30'
--Điểm rèn luyện
exec ThemDiemRenLuyen '00001','2021-2022','1',N'Ngày Hội Sách','2021/06/05','5','22211LH7362'
exec ThemDiemRenLuyen'00001','2021-2022','1',N'Ngày Hội Sách','2021/06/05','5','22111LH2816'
exec ThemDiemRenLuyen'00001','2021-2022','1',N'Ngày Hội Sách','2021/06/05','5','22111LH2763'
exec ThemDiemRenLuyen'00001','2021-2022','1',N'Ngày Hội Sách','2021/06/05','5','22111LH2752'
exec ThemDiemRenLuyen'00002','2021-2022','1',N'Kỉ Niệm Ngày Quân Đội Nhân Dân Việt Nam','2021/06/05','5','22211LH7362'
exec ThemDiemRenLuyen'00002','2021-2022','1',N'Kỉ Niệm Ngày Quân Đội Nhân Dân Việt Nam','2021/06/05','5','22111LH2816'
exec ThemDiemRenLuyen'00002','2021-2022','1',N'Kỉ Niệm Ngày Quân Đội Nhân Dân Việt Nam','2021/06/05','5','22111LH2763'
exec ThemDiemRenLuyen'00002','2021-2022','1',N'Kỉ Niệm Ngày Quân Đội Nhân Dân Việt Nam','2021/06/05','5','22111LH2752'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111LH2816'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111LH2763'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111LH2752'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111NH3282'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111NH7542'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111KD2763'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111TM9735'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111DH9754'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111MT3652'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111LG8755'
exec ThemDiemRenLuyen'00003','2021-2022','1',N'Tổ chức lấy ý kiến phản hồi từ người học về hoạt động giảng dạy của giảng viên học kì 1 năm học 2021 - 2022','2021/12/31','5','22111TT3278'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111TM6421'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111KD1541'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111MT7542'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111TT6554'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111TT3278'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111DH3623'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111NH3282'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111MT0825'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111LG8754'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111KD1541'
exec ThemDiemRenLuyen'00004','2021-2022','1',N'Vận động xây dựng 2 căn nhà tình bạn cho HSSV khóa 21','2021/11/15','10','22111MT7542'
----Hoc phi
exec ThemHocPhi 'CSC104140'
exec ThemHocPhi'CSC104190'
exec ThemHocPhi'CNC104030'
exec ThemHocPhi'CNC104210'
exec ThemHocPhi'CNC104260'
exec ThemHocPhi'CNC104121'
exec ThemHocPhi'CSC103010'
exec ThemHocPhi'CSC104231'
exec ThemHocPhi'CNC104360'
exec ThemHocPhi'CNC104370'
exec ThemHocPhi'CNC104350'
exec ThemHocPhi'CNC104540'
exec ThemHocPhi'CSC104060'
exec ThemHocPhi'CSK104020'
exec ThemHocPhi 'CNC104410'
exec ThemHocPhi 'CNC104430'
exec ThemHocPhi'CSC104100'
exec ThemHocPhi'CSK115050'
exec ThemHocPhi'CSK115030'
exec ThemHocPhi'CSK115040'
exec ThemHocPhi'CSK115071'
exec ThemHocPhi'CNK115070'
exec ThemHocPhi'CNK115080'
exec ThemHocPhi'CSC115040'
exec ThemHocPhi'CSC105031'
exec ThemHocPhi'CNC115120'
exec ThemHocPhi'CNC115130'
exec ThemHocPhi'CNC115110'
exec ThemHocPhi'CNC115190'
exec ThemHocPhi'CSC115010'
exec ThemHocPhi'CSK115010'
exec ThemHocPhi'CNC115300'
exec ThemHocPhi'CNK115031'
exec ThemHocPhi'CNK115032'
exec ThemHocPhi'CNK115040'
exec ThemHocPhi'CSC106051'
exec ThemHocPhi'CSC106370'
exec ThemHocPhi'CNC107420'
exec ThemHocPhi'CNC107463'
exec ThemHocPhi'CNC107270'
exec ThemHocPhi'CNC107400'
exec ThemHocPhi'CNC108066'
exec ThemHocPhi'CSC106132'
exec ThemHocPhi'CNC108062'
exec ThemHocPhi'CNC108222'
exec ThemHocPhi'CNC121390'
exec ThemHocPhi'CSC121030'
exec ThemHocPhi'CNC121020'
exec ThemHocPhi'CNC121260'
exec ThemHocPhi'CNC121090'
exec ThemHocPhi'CNC121290'
----Điểm HP
exec ThemDiemHocPhan '7.3','8','7',N'1','22211TT3268','KTLT01','GVCNTT1'
---Đóng học phí
exec NhapMaSinhVienChoDongHocPhi '22211TT3268'