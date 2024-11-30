CREATE TABLE docgia
(
madg nvarchar(10) primary key,
hotendg nvarchar(50) not null,
gioitinhdg nvarchar(10),
ngaysinhdg date,
diachidg nvarchar(100),
sdtdg nvarchar(20),
ghichudg nvarchar(200),
);

CREATE TABLE thuthu
(
matt nvarchar(10) primary key,
hotentt nvarchar(50) not null,
gioitinhtt nvarchar(10),
ngaysinhtt date,
diachitt nvarchar(100) not null,
sdttt nvarchar(20) not null,
ghichutt nvarchar(200),
);

CREATE TABLE tacgia
(
matg nvarchar(10) primary key,
hotentg nvarchar(50) not null,
tieusutg nvarchar(200),
);

CREATE TABLE theloai
(
matl nvarchar(10) primary key,
hotentl nvarchar(50) not null,
motatl nvarchar(200),
);

CREATE TABLE nhaxuatban
(
manxb nvarchar(10) primary key,
tennxb nvarchar(50) not null,
diachinxb nvarchar(100) not null,
sdtnxb nvarchar(20) not null,
ghichunxb nvarchar(200),
);

CREATE TABLE sach
(
mas nvarchar(10) primary key,
tens nvarchar(50) not null,
matg nvarchar(10) not null,
manxb nvarchar(10) not null,
matl nvarchar(10) not null,
namxb nvarchar(10),
ghichus nvarchar(200),
foreign key (matg) references tacgia(matg),
foreign key (manxb) references nhaxuatban(manxb),
foreign key (matl) references theloai(matl),
);

CREATE TABLE phieumuon
(
mapm nvarchar(10) primary key,
matt nvarchar(10) not null,
madg nvarchar(10) not null,
ngaylapphieu date not null,
foreign key (madg) references docgia(madg),
foreign key (matt) references thuthu(matt),
);

CREATE TABLE chitietphieumuon
(
mapm nvarchar(10) ,
mas nvarchar(10) ,
ngaymuon date not null,
ngaytra date not null,
ghichuctpm nvarchar(200),
primary key (mapm, mas),
foreign key (mapm) references phieumuon(mapm),
foreign key (mas) references sach(mas),
);

CREATE TABLE phieutra
(
mapt nvarchar(10) primary key,
matt nvarchar(10) not null,
madg nvarchar(10) not null,
ngaylapphieu date not null,
foreign key (madg) references docgia(madg),
foreign key (matt) references thuthu(matt),
);

CREATE TABLE chitietphieutra
(
mapt nvarchar(10),
mapm nvarchar(10),
mas nvarchar(10),
ngaytra date not null,
ghichuctpt nvarchar(200),
primary key (mapt, mapm, mas),
foreign key (mapt) references phieutra(mapt),
foreign key (mapm) references phieumuon(mapm),
foreign key (mas) references sach(mas),
);

CREATE VIEW ThongKeSach AS
SELECT 
    N'Tất cả sách' AS Loai,
    s.mas AS MaSach,
    s.tens AS TenSach,
    s.namxb AS NamXuatBan,
    tg.hotentg AS TacGia,
    nxb.tennxb AS NhaXuatBan,
    tl.hotentl AS TheLoai,
    NULL AS NgayMuon,
    NULL AS NgayTra,
    NULL AS SoNgayTreHan
FROM 
    sach s
    JOIN tacgia tg ON s.matg = tg.matg
    JOIN nhaxuatban nxb ON s.manxb = nxb.manxb
    JOIN theloai tl ON s.matl = tl.matl

UNION

SELECT 
    N'Sách trễ hạn trả' AS Loai,
    s.mas AS MaSach,
    s.tens AS TenSach,
    NULL AS NamXuatBan,
    NULL AS TacGia,
    NULL AS NhaXuatBan,
    NULL AS TheLoai,
    ctpm.ngaymuon AS NgayMuon,
    ctpm.ngaytra AS NgayTra,
    DATEDIFF(day, ctpm.ngaytra, GETDATE()) AS SoNgayTreHan
FROM 
    chitietphieumuon ctpm
    JOIN sach s ON ctpm.mas = s.mas
WHERE 
    ctpm.ngaytra < GETDATE()

UNION

SELECT 
    N'Sách đang được mượn' AS Loai,
    s.mas AS MaSach,
    s.tens AS TenSach,
    NULL AS NamXuatBan,
    NULL AS TacGia,
    NULL AS NhaXuatBan,
    NULL AS TheLoai,
    ctpm.ngaymuon AS NgayMuon,
    ctpm.ngaytra AS NgayTra,
    NULL AS SoNgayTreHan
FROM 
    chitietphieumuon ctpm
    JOIN sach s ON ctpm.mas = s.mas
WHERE 
    ctpm.ngaytra > GETDATE()

SELECT 
    N'Sách không được mượn' AS Loai,
    s.mas AS MaSach,
    s.tens AS TenSach,
    s.namxb AS NamXuatBan,
    tg.hotentg AS TacGia,
    nxb.tennxb AS NhaXuatBan,
    tl.hotentl AS TheLoai,
    NULL AS NgayMuon,
    NULL AS NgayTra,
    NULL AS SoNgayTreHan
FROM 
    sach s
    JOIN tacgia tg ON s.matg = tg.matg
    JOIN nhaxuatban nxb ON s.manxb = nxb.manxb
    JOIN theloai tl ON s.matl = tl.matl
WHERE 
    s.mas NOT IN (SELECT mas FROM chitietphieumuon);


CREATE VIEW ThongKeDocGia AS
-- Tất cả độc giả
SELECT 
    N'Tất cả độc giả' AS Loai,
    d.madg AS MaDocGia,
    d.hotendg AS HoTenDocGia,
    d.gioitinhdg AS GioiTinh,
    d.ngaysinhdg AS NgaySinh,
    d.diachidg AS DiaChi,
    d.sdtdg AS SoDienThoai,
    d.ghichudg AS GhiChu
FROM 
    docgia d

UNION ALL

-- Độc giả không mượn sách
SELECT 
    N'Không mượn sách' AS Loai,
    d.madg AS MaDocGia,
    d.hotendg AS HoTenDocGia,
    d.gioitinhdg AS GioiTinh,
    d.ngaysinhdg AS NgaySinh,
    d.diachidg AS DiaChi,
    d.sdtdg AS SoDienThoai,
    d.ghichudg AS GhiChu
FROM 
    docgia d
    LEFT JOIN phieumuon pm ON d.madg = pm.madg
WHERE 
    pm.mapm IS NULL

UNION ALL

-- Độc giả đang mượn sách
SELECT 
    N'Đang mượn sách' AS Loai,
    d.madg AS MaDocGia,
    d.hotendg AS HoTenDocGia,
    d.gioitinhdg AS GioiTinh,
    d.ngaysinhdg AS NgaySinh,
    d.diachidg AS DiaChi,
    d.sdtdg AS SoDienThoai,
    d.ghichudg AS GhiChu
FROM 
    docgia d
    JOIN phieumuon pm ON d.madg = pm.madg
    JOIN chitietphieumuon ctp ON pm.mapm = ctp.mapm
WHERE 
    ctp.ngaytra > GETDATE()

UNION ALL

-- Độc giả trễ hạn
SELECT 
    N'Trễ hạn trả' AS Loai,
    d.madg AS MaDocGia,
    d.hotendg AS HoTenDocGia,
    d.gioitinhdg AS GioiTinh,
    d.ngaysinhdg AS NgaySinh,
    d.diachidg AS DiaChi,
    d.sdtdg AS SoDienThoai,
    d.ghichudg AS GhiChu
FROM 
    docgia d
    JOIN phieumuon pm ON d.madg = pm.madg
    JOIN chitietphieumuon ctp ON pm.mapm = ctp.mapm
WHERE 
    ctp.ngaytra < GETDATE();




