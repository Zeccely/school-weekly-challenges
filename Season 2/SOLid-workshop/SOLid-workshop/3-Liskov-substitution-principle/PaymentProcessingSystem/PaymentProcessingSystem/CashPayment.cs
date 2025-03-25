// File: CashPayment.cs

namespace PaymentProcessingSystem;

public class CashPayment : PaymentProcessor
{
    public override void ProcessOnlinePayment(decimal amount)
    {
        throw new InvalidOperationException("Cash payment cannot be processed online!");
    }
}
