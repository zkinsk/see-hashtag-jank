namespace ConstructorInheritance;

public class Vehicle
{
    private string _registrationNumber;

    public Vehicle(string regNumber)
    {
        Console.WriteLine("Vehicle Initialization");
        _registrationNumber = regNumber;
    }

    public string RegistrationNumber
    {
        get => _registrationNumber;
        set => _registrationNumber = value ?? throw new ArgumentNullException(nameof(value));
    }
}