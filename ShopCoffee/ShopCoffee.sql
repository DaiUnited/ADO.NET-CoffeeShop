use master
go
create database QuanLyQuanCafe
go
use QuanLyQuanCafe
go

create table LoaiDoUong
(
	MaLoaiDoUong nvarchar(100) not null,
	TenLoaiDoUong nvarchar(100)
	constraint pk_LoaiDoUong primary key(MaLoaiDoUong)
)
go

create table DoUong
(
	MaDoUong nvarchar(100) not null,
	TenDoUong nvarchar(100),
	GiaTien float,
	MaLoaiDoUong nvarchar(100)
	constraint pk_DoUong primary key(MaDoUong),
	constraint fk_DoUong_LoaiDoUong foreign key(MaLoaiDoUong) references LoaiDoUong(MaLoaiDoUong)
)
go

create table NhanVien
(
	MaNhanVien nvarchar(100) not null,
	MatKhau nvarchar(100) not null,
	TenNhanVien nvarchar(100),
	SoDienThoai nvarchar(10),
	NamSinh int,
	GioiTinh nvarchar(10)
	constraint pk_NhanVien primary key(MaNhanVien)
)
go

create table Ban
(
	MaBan nvarchar(100) not null,
	TenBan nvarchar(100),
	TrangThai nvarchar(100)
	constraint pk_Ban primary key(MaBan)
)
go

create table HoaDon
(
	MaHoaDon int identity(1,1) not null,
	NgayLap datetime,
	MaBan nvarchar(100) not null,
	MaNhanVien nvarchar(100) not null,
	ThanhTien float,
	constraint pk_HoaDon primary key(MaHoaDon),
	constraint fk_HoaDon_MaBan foreign key(MaBan) references Ban(MaBan),
	constraint fk_HoaDon_NhanVien foreign key(MaNhanVien) references NhanVien(MaNhanVien)
)
go

ALTER TABLE HoaDon
ADD TrangThai nvarchar(50)

create table ChiTietHoaDon
(
	MaHoaDon int not null, 
	MaDoUong nvarchar(100) not null,
	SoLuong int,
	TongTien float,
	constraint pk_ChiTietHoaDon primary key(MaHoaDon, MaDoUong),
	constraint fk_ChiTietHoaDon_HoaDon foreign key(MaHoaDon) references HoaDon(MaHoaDon),
	constraint fk_ChiTietHoaDon_DoUong foreign key(MaDoUong) references DoUong(MaDoUong)
)
go
