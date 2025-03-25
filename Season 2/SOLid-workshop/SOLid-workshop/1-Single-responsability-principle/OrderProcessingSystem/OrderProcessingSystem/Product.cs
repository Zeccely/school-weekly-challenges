// File: Product.cs

namespace OrderProcessingSystem;

public enum ProductName
{
    Laptop,
    Smartphone,
    Headphones,
    Tablet,
    Monitor,
    Keyboard,
    Mouse
}

public class Product
{
    public ProductName Name { get; private set; }
    public int Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(ProductName name, int price, int quantity)
    {
        if (price < 0) throw new ArgumentException("Price cannot be negative.");
        if (quantity < 0) throw new ArgumentException("Quantity cannot be negative.");

        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public void UpdateQuantity(int amount)
    {
        if (Quantity + amount < 0)
        {
            throw new InvalidOperationException("Insufficient stock to update the quantity.");
        }
        Quantity += amount;
    }
}
