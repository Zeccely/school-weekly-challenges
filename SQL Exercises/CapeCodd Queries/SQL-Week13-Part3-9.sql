Select ri.OrderMonth, ri.OrderYear, SUM(ExtendedPrice) TotalSales
From Order_Item  oi
Inner Join Retail_Order ri on ri.Ordernumber = oi.Ordernumber

Group by OrderMonth, OrderYear