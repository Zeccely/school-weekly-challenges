// File: Program.cs

namespace OrderProcessingSystem;

public class Program
{
    public static void Main()
    {
        var orderManager = new OrderManager();

        // Sample data using ProductName enum with named arguments
        var inventory = new List<Product>
        {
            new Product(name: ProductName.Laptop, price: 1000, quantity: 10),
            new Product(name: ProductName.Smartphone, price: 800, quantity: 5),
            new Product(name: ProductName.Headphones, price: 150, quantity: 8),
        };

        var itemsOrdered = new Dictionary<ProductName, int>
        {
            { ProductName.Laptop, 2 },
            { ProductName.Smartphone, 1 }
        };

        // Calculate total cost
        decimal totalCost = orderManager.CalculateTotalCost(inventory, itemsOrdered);
        Console.WriteLine($"Total Cost: ${totalCost}");

        // Update inventory
        Console.WriteLine("Updating Inventory...");
        orderManager.UpdateInventory(inventory, itemsOrdered);

        Console.WriteLine("Updated Inventory:");
        foreach (var product in inventory)
        {
            Console.WriteLine($"{product.Name}: {product.Quantity}");
        }

        // Generate and display receipt
        string receipt = orderManager.GenerateReceipt(totalCost);
        Console.WriteLine("\n" + receipt);
    }
}
