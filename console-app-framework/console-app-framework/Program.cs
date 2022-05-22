
using System;

namespace console_app_framework

{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Scott";
            var lastName = "Zinski";
            var nameArray = new string[] { "Bob", "Frank", "Fran" };
            var allNames = String.Join(", ", nameArray);
            Console.WriteLine(allNames);
        }
    }
}
