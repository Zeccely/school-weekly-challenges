decimal amount = 100m;
decimal percentage = 0.5m;
decimal voucherValue1 = 20m;
decimal voucherValue2 = 15m;

DiscountCalculator discountCalculator = new DiscountCalculator();

Console.WriteLine($"Percentage Discount ({percentage * 100}%)");
decimal discountedAmountPercentage = discountCalculator.ApplyPercentageDiscount(amount, percentage);
Console.WriteLine($"Original Amount: {amount:C}");
Console.WriteLine($"Discounted Amount: {discountedAmountPercentage:C}");
Console.WriteLine();

Console.WriteLine($"Voucher Discount ({voucherValue1}€ voucher)");
decimal discountedAmountVoucher1 = discountCalculator.ApplyVoucherDiscount(amount, voucherValue1);
Console.WriteLine($"Original Amount: {amount:C}");
Console.WriteLine($"Discounted Amount: {discountedAmountVoucher1:C}");
Console.WriteLine();

Console.WriteLine($"Voucher Discount ({voucherValue2}€ voucher)");
decimal discountedAmountVoucher2 = discountCalculator.ApplyVoucherDiscount(amount, voucherValue2);
Console.WriteLine($"Original Amount: {amount:C}");
Console.WriteLine($"Discounted Amount: {discountedAmountVoucher2:C}");
