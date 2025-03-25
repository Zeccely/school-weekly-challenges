// File: Program.cs

namespace CustomerDiscounts;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter customer type (Regular, VIP, Seasonal): ");
        string? customerTypeInput = Console.ReadLine();
        if (!Enum.TryParse<CustomerType>(customerTypeInput, true, out var customerType))
        {
            Console.WriteLine("Invalid customer type. Exiting...");
            return;
        }

        Console.Write("Enter the amount: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            Console.WriteLine("Invalid amount. Exiting...");
            return;
        }

        var discountCalculator = new DiscountCalculator();

        decimal finalAmount = discountCalculator.ApplyDiscount(customerType, amount);

        Console.WriteLine($"Amount before discount: {amount:C}");
        Console.WriteLine($"Amount after discount: {finalAmount:C}");
    }
}
