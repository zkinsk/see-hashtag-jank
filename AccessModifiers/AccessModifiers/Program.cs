namespace AccessModifiers;

public class GoldCustomer : Customer
{
    public void OfferVoucher()
    {
        Console.WriteLine("Voucher Offered");
    }
}

public static class Program
{
    private static void Main()
    {
        var customer = new Customer();
        customer.Promote();

        var goldCustomer = new GoldCustomer();
        goldCustomer.OfferVoucher();
    }
}