Select Department, Sum(ExtendedPrice)
From ORDER_ITEM oi
Inner Join SKU_DATA skud on skud.SKU = oi.SKU
Group by Department