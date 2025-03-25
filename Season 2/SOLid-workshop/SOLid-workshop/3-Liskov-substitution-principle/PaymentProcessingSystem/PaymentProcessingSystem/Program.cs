// File: Program.cs

namespace PaymentProcessingSystem;

class Program
{
    static void Main()
    {
        PaymentProcessor creditCardPayment = new CreditCardPayment();
        PaymentProcessor cashPayment = new CashPayment();

        creditCardPayment.ProcessOnlinePayment(100);

        try
        {
            cashPayment.ProcessOnlinePayment(50);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
