
using System;



namespace console_app_framework
{
    class Person
    {
        private string FirstName;
        public string LastName;
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Introduce()
        {
            Console.WriteLine($"Hello I am {this.FirstName} {this.LastName}");
        }
    }
}
