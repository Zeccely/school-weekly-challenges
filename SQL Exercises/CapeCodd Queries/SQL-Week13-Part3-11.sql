Select skud.SKU, SKU_Description, Sum(ExtendedPrice) Total
From SKU_DATA skud
Inner Join ORDER_ITEM oi on oi.SKU = skud.SKU
where SKU_Description LIKE 'Dive Mask%'
Group by skud.SKU, SKU_Description