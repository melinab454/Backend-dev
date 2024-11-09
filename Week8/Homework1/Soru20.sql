SELECT 
YEAR(o.OrderDate)AS [Yıl] ,
MONTH(o.OrderDate) AS [Ay],

FORMAT(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)), 'N2', 'tr-TR') AS [Toplam Tutar]
FROM Orders o
JOIN OrderDetails od ON o.OrderID= od.OrderID

GROUP BY YEAR(o.OrderDate), MONTH(o.OrderDate)
