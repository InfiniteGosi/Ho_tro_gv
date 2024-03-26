CREATE DATABASE QL_CongViec
GO
USE QL_CongViec
GO


CREATE TABLE TaiKhoan
(
  TenDangNhap VARCHAR(100) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  MatKhau VARCHAR(100) NOT NULL,
  PRIMARY KEY (TenDangNhap)
);

CREATE TABLE Truong
(
  MaTruong VARCHAR(10) NOT NULL,
  TenTruong NVARCHAR(100) NOT NULL,
  Luong1CaDay INT NOT NULL,
  PRIMARY KEY (MaTruong)
);

CREATE TABLE MonHoc
(
  MaMon VARCHAR(10) NOT NULL,
  TenMon NVARCHAR(50) NOT NULL,
  MaTruong VARCHAR(10) NOT NULL,
  PRIMARY KEY (MaMon),
  FOREIGN KEY (MaTruong) REFERENCES Truong(MaTruong)
);

CREATE TABLE CaHoc
(
  Ngay DATE NOT NULL,
  Ca INT NOT NULL,
  MaMon VARCHAR(10) NOT NULL,
  MaTruong VARCHAR(10) NOT NULL,
  Mau VARCHAR(50) NOT NULL,
  TenDangNhap VARCHAR(100) NOT NULL,
  PRIMARY KEY (TenDangNhap, Ngay, Ca),
  FOREIGN KEY (MaMon) REFERENCES MonHoc(MaMon),
  FOREIGN KEY (MaTruong) REFERENCES Truong(MaTruong),
  FOREIGN KEY (TenDangNhap) REFERENCES TaiKhoan(TenDangNhap),
);


insert into TaiKhoan values('khangho150', 'khangho150@gmail.com', '123')
insert into TaiKhoan values('test123', 'test@gmail.com', '123')
select * from TaiKhoan
delete from TaiKhoan where TenDangNhap = 'khangho150'


insert into Truong values('TDTU', N'Đại học Tôn Đức Thắng', 150000)
insert into Truong values('HMUS', N'Đại học khoa học tự nhiên TPHCM', 100000)
select * from Truong
delete from Truong 

insert into MonHoc values('M001', N'Giải tích', 'TDTU')
insert into MonHoc values('M002', N'Công nghệ phần mềm', 'TDTU')
insert into MonHoc values('M003', N'Hệ cơ sở dữ liệu', 'TDTU')

insert into MonHoc values('C001', N'Giải tích 1', 'HMUS')
insert into MonHoc values('C002', N'Lập trình web', 'HMUS')
insert into MonHoc values('C003', N'Cấu trúc dữ liệu', 'HMUS')
select * from MonHoc
delete from MonHoc


select * from CaHoc
delete from CaHoc

select m.MaMon, m.MaTruong 
from CaHoc c 
inner join MonHoc m on m.MaMon = c.MaMon 
inner join Truong t on t.MaTruong = c.MaTruong 
where c.Ca = 2 
  and c.Ngay = '1/12/2023' 
  and c.TenDangNhap = 'khangho150';

SELECT mh.MaMon, mh.TenMon, t.TenTruong, t.Luong1CaDay, COUNT(ch.Ngay) AS SoCaHoc, (t.Luong1CaDay * COUNT(ch.Ngay)) AS TongLuongTheoMon, SUM(t.Luong1CaDay * COUNT(ch.Ngay)) OVER () AS LuongTong 
FROM MonHoc mh INNER JOIN Truong t ON mh.MaTruong = t.MaTruong INNER JOIN CaHoc ch ON mh.MaMon = ch.MaMon 
Where ch.TenDangNhap like 'Khangho150'
GROUP BY mh.MaMon, mh.TenMon, t.TenTruong, t.Luong1CaDay

select ch.MaMon, mh.TenMon, t.TenTruong, ch.Ca
from cahoc ch, MonHoc mh, Truong t 
where ch.MaMon = mh.MaMon and ch.MaTruong = t.MaTruong and ch.TenDangNhap = 'khangho150' and ch.Ngay = '3/24/2024'