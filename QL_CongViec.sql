create database QL_CongViec
go
use QL_CongViec
go
CREATE TABLE TaiKhoan
(
  TenDangNhap VARCHAR(100) NOT NULL,
  MatKhau VARCHAR(100) NOT NULL,
  PRIMARY KEY (TenDangNhap)
);

CREATE TABLE Truong
(
  MaTruong VARCHAR(10) NOT NULL,
  TenTruong VARCHAR(100) NOT NULL,
  DiaChi VARCHAR(100) NOT NULL,
  Luong1CaDay INT NOT NULL,
  PRIMARY KEY (MaTruong)
);

CREATE TABLE MonHoc
(
  MaMon VARCHAR(10) NOT NULL,
  TenMon VARCHAR(100) NOT NULL,
  SoCaDay INT NOT NULL,
  MaTruong VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaMon),
  FOREIGN KEY (MaTruong) REFERENCES Truong(MaTruong)
);

CREATE TABLE TK_Truong
(
  TenDangNhap VARCHAR(100) NOT NULL,
  MaTruong VARCHAR(10) NOT NULL,
  PRIMARY KEY (TenDangNhap, MaTruong),
  FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap),
  FOREIGN KEY (MaTruong) REFERENCES Truong(MaTruong)
);

CREATE TABLE MonHocDay
(
  TenDangNhap VARCHAR(100) NOT NULL,
  MaMon VARCHAR(10) NOT NULL,
  PRIMARY KEY (TenDangNhap, MaMon),
  FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap),
  FOREIGN KEY (MaMon) REFERENCES MonHoc(MaMon)
);