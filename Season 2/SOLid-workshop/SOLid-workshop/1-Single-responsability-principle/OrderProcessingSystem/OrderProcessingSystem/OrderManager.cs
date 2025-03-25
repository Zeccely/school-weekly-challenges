// File: OrderManager.cs

namespace OrderProcessingSystem;

public class OrderManager
{
    public decimal CalculateTotalCost(List<Product> inventory, Dictionary<ProductName, int> itemsOrdered)
    {
        decimal total = 0;
        foreach (var item in itemsOrdered)
        {
            var product = inventory.Find(p => p.Name == item.Key);
            if (product != null)
            {
                total += product.Price * item.Value;
            }
        }
        return total;
    }

    public void UpdateInventory(List<Product> inventory, Dictionary<ProductName, int> itemsOrdered)
    {
        foreach (var item in itemsOrdered)
        {
            var product = inventory.Find(p => p.Name == item.Key);
            if (product != null)
            {
                product.UpdateQuantity(-item.Value);
            }
        }
    }

    public string GenerateReceipt(decimal totalCost)
    {
        return $"Receipt\n========\nTotal Cost: ${totalCost}\nThank you for your purchase!";
    }
}
