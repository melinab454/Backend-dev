--1--

SELECT o.OgrenciID, o.Ad, o.Soyad, k.KulupAdi
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
JOIN Kulup k ON ok.KulupID = k.KulupID;

--2--

SELECT o.Ad, o.Soyad, ok.Rol
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
JOIN Kulup k ON ok.KulupID = k.KulupID
WHERE k.KulupAdi = 'Tiyatro Kulübü';

--3--
SELECT o.Ad, o.Soyad, k.KulupAdi
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
JOIN Kulup k ON ok.KulupID = k.KulupID
WHERE ok.Rol = 'Başkan';


--4--

SELECT k.KulupAdi, COUNT(ok.OgrenciID) AS UyeSayisi
FROM Kulup k
JOIN OgrenciKulup ok ON k.KulupID = ok.KulupID
GROUP BY k.KulupAdi;


--5--
SELECT o.Ad, o.Soyad, k.KulupAdi
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
JOIN Kulup k ON ok.KulupID = k.KulupID
ORDER BY k.KurulusYili ASC
LIMIT 1;

--6--

SELECT o.Ad, o.Soyad, k.KulupAdi, ok.KatilimTarihi
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
JOIN Kulup k ON ok.KulupID = k.KulupID;

--7--

SELECT DISTINCT ok.Rol
FROM OgrenciKulup ok
JOIN Kulup k ON ok.KulupID = k.KulupID
WHERE k.KulupAdi = 'Müzik Kulübü';


--8--

SELECT k.KulupAdi, COUNT(ok.OgrenciID) AS BaskanSayisi
FROM OgrenciKulup ok
JOIN Kulup k ON ok.KulupID = k.KulupID
WHERE ok.Rol = 'Başkan'
GROUP BY k.KulupAdi;

--9--

SELECT o.Ad, o.Soyad, k.KulupAdi, ok.KatilimTarihi
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
JOIN Kulup k ON ok.KulupID = k.KulupID
ORDER BY ok.KatilimTarihi DESC
LIMIT 1;

--10--

SELECT o.Ad, o.Soyad, COUNT(ok.KulupID) AS KatildigiKulupSayisi
FROM Ogrenci o
JOIN OgrenciKulup ok ON o.OgrenciID = ok.OgrenciID
GROUP BY o.OgrenciID
HAVING COUNT(ok.KulupID) > 1;
