
CREATE DATABASE Personel
--drop database Personel
use Personel
CREATE TABLE Personel (
    PersonelID INT PRIMARY KEY IDENTITY(1,1) ,
    Ad NVARCHAR(50),
    Soyad NVARCHAR(50),
    Pozisyon NVARCHAR(50),
    BaslangicTarihi DATE
);
go

CREATE TABLE Maaslar (
    MaasID INT PRIMARY KEY IDENTITY(1,1) ,
    PersonelID INT,
    MaasMiktari DECIMAL(10, 2),
    GuncellemeTarihi DATE,
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
);

INSERT INTO Personel (Ad, Soyad, Pozisyon, BaslangicTarihi) VALUES
('Ahmet', 'Yılmaz', 'Müdür', '2022-01-15'),
('Mehmet', 'Kaya', 'Öğretmen', '2022-02-10'),
('Elif', 'Demir', 'Öğretmen', '2022-03-05'),
('Ayşe', 'Çelik', 'Sekreter', '2022-04-01'),
('Fatma', 'Arslan', 'Öğretmen', '2022-05-20'),
('Hasan', 'Yıldız', 'Hizmetli', '2022-06-10'),
('Ali', 'Öztürk', 'Müdür Yardımcısı', '2022-07-01'),
('Emine', 'Kara', 'Sekreter', '2022-08-25'),
('Murat', 'Akgün', 'Öğretmen', '2022-09-10'),
('Zeynep', 'Erdoğan', 'Hizmetli', '2022-10-15');


INSERT INTO Maaslar (PersonelID, MaasMiktari, GuncellemeTarihi) VALUES
(1, 15000, '2022-01-15'), (1, 16000, '2023-01-15'),
(2, 8000, '2022-02-10'), (2, 8500, '2023-02-10'),
(3, 7500, '2022-03-05'), (3, 8000, '2023-03-05'),
(4, 5000, '2022-04-01'), (4, 5200, '2023-04-01'),
(5, 7500, '2022-05-20'), (5, 7800, '2023-05-20'),
(6, 4000, '2022-06-10'), (6, 4200, '2023-06-10'),
(7, 12000, '2022-07-01'), (7, 12500, '2023-07-01'),
(8, 5000, '2022-08-25'), (8, 5300, '2023-08-25'),
(9, 7000, '2022-09-10'), (9, 7500, '2023-09-10'),
(10, 4000, '2022-10-15'), (10, 4300, '2023-10-15');
