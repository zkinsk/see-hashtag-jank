﻿namespace Amazon;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public void Promote()
    {
        var calculator = new RateCalculator();
        var rating = calculator.Calculcate(this);
        Console.WriteLine($"rating :: {rating}");
    }

}