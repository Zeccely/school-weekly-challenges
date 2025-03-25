// File: CreditCardPayment.cs

namespace PaymentProcessingSystem;

public class CreditCardPayment : PaymentProcessor
{
    public override void ProcessOnlinePayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount} online.");
    }
}
