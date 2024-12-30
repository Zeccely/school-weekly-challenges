Select OrderNumber, Sum(ExtendedPrice)/Sum(Quantity) 
From ORDER_ITEM
Group by OrderNumber
