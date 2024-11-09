--1--
SELECT p.Ad, p.Soyad, m.MaasMiktari
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
WHERE m.GuncellemeTarihi = (
    SELECT MAX(GuncellemeTarihi)
    FROM Maaslar
    WHERE PersonelID = p.PersonelID
);



--2--
SELECT AVG(m.MaasMiktari) AS OrtalamaMaas
FROM Maaslar m
JOIN (SELECT PersonelID, MAX(GuncellemeTarihi) AS SonGuncelleme
      FROM Maaslar
      GROUP BY PersonelID) AS SonMaas
ON m.PersonelID = SonMaas.PersonelID AND m.GuncellemeTarihi = SonMaas.SonGuncelleme;

--3--
SELECT p.Pozisyon, MAX(m.MaasMiktari) AS EnYuksekMaas, MIN(m.MaasMiktari) AS EnDusukMaas
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
GROUP BY p.Pozisyon;

--4--
SELECT Ad, Soyad, Pozisyon
FROM Personel;

--5--
SELECT Pozisyon, COUNT(*) AS PersonelSayisi
FROM Personel
GROUP BY Pozisyon;

--6--

SELECT p.Ad, p.Soyad, m.MaasMiktari, m.GuncellemeTarihi
FROM Personel p
JOIN (SELECT PersonelID, MaasMiktari, MAX(GuncellemeTarihi) AS SonGuncelleme
      FROM Maaslar
      GROUP BY PersonelID) m
ON p.PersonelID = m.PersonelID;

--7--
SELECT Ad, Soyad
FROM Personel
WHERE Pozisyon = 'Öğretmen';

--8--

SELECT AVG(MaasMiktari) AS OrtalamaMaas
FROM Maaslar;


--9--
SELECT p.Ad, p.Soyad, m.MaasMiktari
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
ORDER BY m.MaasMiktari DESC
LIMIT 1;


--10-
SELECT p.Ad, p.Soyad, m.MaasMiktari, m.GuncellemeTarihi
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
WHERE p.Ad = 'Ahmet' AND p.Soyad = 'Yılmaz'
ORDER BY m.GuncellemeTarihi ASC;

--11--
SELECT p.Pozisyon, MAX(m.MaasMiktari) AS EnYuksekMaas, MIN(m.MaasMiktari) AS EnDusukMaas
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
GROUP BY p.Pozisyon
HAVING COUNT(*) > 1;

--12--
SELECT p.Ad, p.Soyad, m.GuncellemeTarihi
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
WHERE m.GuncellemeTarihi >= DATEADD(MONTH, -6, CURDATE());

--13--
SELECT p.Ad, p.Soyad, COUNT(m.MaasID) AS MaasGuncellemeSayisi
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
GROUP BY p.PersonelID
HAVING COUNT(m.MaasID) >= 2;
