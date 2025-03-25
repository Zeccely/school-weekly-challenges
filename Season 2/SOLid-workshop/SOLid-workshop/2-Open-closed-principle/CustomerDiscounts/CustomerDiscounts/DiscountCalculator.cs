// File: DiscountCalculator.cs

namespace CustomerDiscounts;

public class DiscountCalculator
{
    public decimal ApplyDiscount(CustomerType customerType, decimal amount)
    {
        decimal discount = CalculateDiscount(customerType, amount);
        return amount - discount;
    }

    private decimal CalculateDiscount(CustomerType customerType, decimal amount)
    {
        if (customerType == CustomerType.Regular)
        {
            return amount * 0.1m; // 10% discount
        }
        else if (customerType == CustomerType.VIP)
        {
            return amount * 0.2m; // 20% discount
        }
        else if (customerType == CustomerType.Seasonal)
        {
            return amount * 0.15m; // 15% discount
        }
        else
        {
            return 0; // No discount
        }
    }
}
