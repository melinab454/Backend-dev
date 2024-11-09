SELECT 
    c.CategoryName [Kategori],

    AVG(p.UnitPrice) [Ortalama Fiyat]

FROM Categories c
JOIN Products p ON c.CategoryID=p.CategoryID

GROUP BY  CategoryName
