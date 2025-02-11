Select SKU, inv.WarehouseID, SKU_Description, QuantityOnHand, QuantityOnOrder,
warehousecity, warehousestate
From INVENTORY inv
Inner Join WAREHOUSE war on war.WarehouseID = inv.WarehouseID
where QuantityOnHand > (Select AVG(QuantityOnHand)
From Inventory)
Order by warehousestate, warehouseCity
;