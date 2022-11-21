namespace AccessModifiers;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Promote()
    {
        var rating = CalculateRating();
        Console.WriteLine($"Promoted: {Name} {Id} - {rating}");
    }

    private int CalculateRating()
    {
        return 1;
    }
}