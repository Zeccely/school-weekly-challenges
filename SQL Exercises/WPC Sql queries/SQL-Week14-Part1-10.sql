Select WarehouseId
From INVENTORY
Where SKU_Description LIKE '%Tent%'
Group by WarehouseID
Having SUM(QuantityOnHand) > SUM(QuantityOnOrder)/2