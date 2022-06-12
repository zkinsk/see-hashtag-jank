namespace hello_world_with_mosh
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public Person (string firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName = null!;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello my name is {FirstName} {LastName}");
        }
    }
}