/* 
Shipper Summary
*/

SELECT s.CompanyName,
		(SELECT SUM(o.freight) 
		FROM Sales.Orders o where o.shipperid = s.shipperid GROUP BY o.shipperid) AS TotalFreight,
       --SUM(o.freight) AS TotalFreight,
       SUM(od.unitprice * od.qty) AS TotalCostShipped,
       SUM(od.qty) AS TotalItemsShipped
FROM Sales.Shippers s
JOIN Sales.Orders o ON s.ShipperID = o.shipperid
JOIN Sales.OrderDetails od ON o.OrderID = od.OrderID
GROUP BY s.CompanyName, s.shipperid
ORDER BY TotalItemsShipped DESC;

