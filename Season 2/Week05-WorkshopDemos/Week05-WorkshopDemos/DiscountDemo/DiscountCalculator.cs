public class DiscountCalculator
{
    public decimal ApplyPercentageDiscount(decimal totalAmount, decimal discountPercentage)
    {
        return totalAmount - (totalAmount * discountPercentage);
    }

    public decimal ApplyVoucherDiscount(decimal totalAmount, decimal voucherValue)
    {
        return totalAmount - voucherValue;
    }
}
