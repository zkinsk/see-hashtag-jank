using Amazon;
using ConsoleApp1.GoldCustomer;

namespace AccessModifiers;

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