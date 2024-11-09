create database Kulup
use Kulup

CREATE TABLE Kulup (
    KulupID INT PRIMARY KEY IDENTITY,
    KulupAdi VARCHAR(100),
    KurulusYili INT
);


CREATE TABLE OgrenciKulup (
    OgrenciID INT,
    KulupID INT,
    Rol VARCHAR(50),
    KatilimTarihi DATE,
    PRIMARY KEY (OgrenciID, KulupID),
    FOREIGN KEY (KulupID) REFERENCES Kulup(KulupID)
);


INSERT INTO Kulup (KulupAdi, KurulusYili) VALUES
('Tiyatro Kulübü', 2005),
('Müzik Kulübü', 2003),
('Spor Kulübü', 2010),
('Edebiyat Kulübü', 2008),
('Resim Kulübü', 2007);


INSERT INTO OgrenciKulup (OgrenciID, KulupID, Rol, KatilimTarihi) VALUES
(1, 1, 'Başkan', '2023-01-10'),
(2, 1, 'Üye', '2023-01-15'),
(3, 1, 'Sekreter', '2023-01-20'),
(4, 2, 'Başkan', '2023-02-01'),
(5, 2, 'Üye', '2023-02-05'),
(6, 2, 'Üye', '2023-02-10'),
(7, 3, 'Başkan', '2023-03-01'),
(8, 3, 'Üye', '2023-03-05'),
(9, 3, 'Üye', '2023-03-10'),
(10, 4, 'Başkan', '2023-04-01'),
(11, 4, 'Üye', '2023-04-05'),
(12, 4, 'Sekreter', '2023-04-10'),
(13, 5, 'Başkan', '2023-05-01'),
(14, 5, 'Üye', '2023-05-05'),
(15, 5, 'Üye', '2023-05-10');
