Select OrderNumber, SUM(ExtendedPrice) TotalOrder
From ORDER_ITEM oi
group by OrderNumber
having Count(Quantity) > 2