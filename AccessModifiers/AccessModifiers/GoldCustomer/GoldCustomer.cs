using Amazon;

namespace ConsoleApp1.GoldCustomer;

public class GoldCustomer : Customer
{
    public void OfferVoucher()
    {
        this.Promote();
        Console.WriteLine("Voucher Offered");
    }
}