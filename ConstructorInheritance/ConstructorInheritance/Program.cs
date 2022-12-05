// See https://aka.ms/new-console-template for more information


namespace ConstructorInheritance;

class Program
{
    public static void Main()
    {
        var car = new Car("4d;ald");

        Console.WriteLine(car.RegistrationNumber);
    }
}