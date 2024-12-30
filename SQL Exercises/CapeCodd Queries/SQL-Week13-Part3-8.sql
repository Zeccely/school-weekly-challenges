Select Department, Sum(ExtendedPrice) Revenue
From ORDER_ITEM oi
Inner Join SKU_DATA skud on skud.SKU = oi.SKU
where Department = 'Water Sports'
Group by Department