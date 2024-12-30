Select war.WarehouseID, Manager, SUM(QuantityOnHand) "Total Quantity"
From WAREHOUSE war
Inner Join INVENTORY inv on war.WarehouseID = inv.WarehouseID
Where SKU_Description LIKE '%Tent%'
Group By War.WarehouseID, Manager
having Sum(QuantityOnHand) > 100