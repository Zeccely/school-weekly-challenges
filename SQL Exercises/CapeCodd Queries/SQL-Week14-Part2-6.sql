Select WarehouseID, Manager, Warehousecity
from WAREHOUSE
where warehouseID in 
(Select warehouseID
From INVENTORY
where QuantityOnHand < QuantityOnOrder and 
SKU_Description = 'Half-Dome Tent')