Select WarehouseID
From INVENTORY
Group by WarehouseID
having SUM(QuantityOnHand) > SUM(QuantityOnOrder)