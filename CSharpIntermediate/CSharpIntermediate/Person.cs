using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Person
    {
        public string LastName { get; set; }
        public DateTime Birthdate
        { get; }

        public int Age
        {
            get
            {
                var result = DateTime.Now - Birthdate;
                return result.Days / 365;
            }
        }


        private protected string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public Person(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to} I am {_name}.  I was born {Birthdate}");
        }


    }
}
