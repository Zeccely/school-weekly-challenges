// File: PaymentProcessor.cs

namespace PaymentProcessingSystem;

public abstract class PaymentProcessor
{
    public abstract void ProcessOnlinePayment(decimal amount);
}
