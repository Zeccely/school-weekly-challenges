Select inv.SKU, SKU_Description, Sum(QuantityOnHand) QOH
From INVENTORY inv
Inner Join WAREHOUSE war on war.WarehouseID = inv.WarehouseID
Group by inv.SKU, SKU_Description
Order by SKU