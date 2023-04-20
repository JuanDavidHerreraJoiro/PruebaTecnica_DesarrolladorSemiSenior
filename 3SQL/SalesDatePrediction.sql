/* 
Sales Date Prediction
*/

SELECT 
c.companyname AS CustomerName, 
MAX(o.OrderDate) AS LastOrderDate,
DATEADD(day, AVG(DATEDIFF(day, prev.OrderDate, o.OrderDate)), MAX(o.OrderDate)) AS NextPredictedOrder

FROM sales.Customers c
JOIN sales.Orders o ON c.custid = o.custid

CROSS APPLY (
   SELECT TOP 1 OrderDate FROM sales.Orders
   WHERE custid = o.custid AND OrderDate < o.OrderDate
   ORDER BY OrderDate DESC
) prev

GROUP BY c.companyname
ORDER BY c.CompanyName ASC;