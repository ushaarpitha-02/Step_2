using System;
namespace Payments
{


class PaymentService
{
    //Credit Card Payment
    public void Pay(string cardNumber, string expiryDate, string cvv, double amount)
    {
        Console.WriteLine($"[Credit Card] Paid Rupees:{amount} using card ending with {cardNumber} having:{cvv} which expires on:{expiryDate}");
    }

    //UPI Payment
    public void Pay(string upiId, double amount)
    {
        Console.WriteLine($"[UPI] Paid Rupees:{amount} using UPI ID:{upiId}");
    }

    //Wallet Payment
    public void Pay(string walletId, string pin, double amount)
    {
        Console.WriteLine($"[Wallet] Paid Rupees:{amount} using Wallet ID:{walletId}");
    }
}

class Program
{
    static void Main()
    {
        PaymentService payment = new PaymentService();

        // Calling different overloaded methods
        payment.Pay("128736714781", "12/26", "123", 1500.00);     // Credit Card
        payment.Pay("user@upi", 500.00);                              // UPI
        payment.Pay("WALLET123", "4321", 700.00);                     // Wallet
    }
}
}