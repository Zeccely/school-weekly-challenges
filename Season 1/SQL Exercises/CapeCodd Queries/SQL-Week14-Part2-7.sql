Select Distinct Sku, SKU_Description
from INVENTORY
where SKU in (
Select SKU 
From Order_item
where OrderNumber in
(Select OrderNumber
from RETAIL_ORDER
Where StoreNumber = 10))