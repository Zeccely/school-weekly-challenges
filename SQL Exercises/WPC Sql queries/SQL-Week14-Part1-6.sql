Select OrderNumber, SUM(ExtendedPrice) TotalOrder
From ORDER_ITEM oi

group by OrderNumber
having SUM(Quantity) > 2