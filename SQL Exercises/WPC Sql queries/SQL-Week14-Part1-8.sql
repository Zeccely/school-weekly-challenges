Select SKU
From INVENTORY
Group by SKU
having AVG(QuantityOnHand) > MAX(QuantityOnOrder)