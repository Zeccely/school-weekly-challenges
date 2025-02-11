Select SKU, WarehouseID, SKU_Description, QuantityOnHand, QuantityOnOrder
From INVENTORY
where QuantityOnHand > (
Select AVG(QuantityOnHand)
From Inventory)