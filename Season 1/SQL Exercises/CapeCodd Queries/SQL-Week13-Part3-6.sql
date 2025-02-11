Select OrderNumber, Sum(ExtendedPrice) TotalOrder
From ORDER_ITEM oi
Group by OrderNumber