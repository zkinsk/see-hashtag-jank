using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_with_mosh.Arrays
{
    internal class ArrayActivity1
    {
        public static void Run()
        {
            var numbers = new[] { 3, 7, 8, 10 };
            Console.WriteLine($"Length :: {numbers.Length}");

            var indexOfNumber = Array.IndexOf(numbers, 99);
            Console.WriteLine($"index :: {indexOfNumber}");

            var newArray = new int[3];

            Array.Copy(numbers, newArray, 3);
            foreach(var number in newArray)
            {
                Console.Write(number + ", ");
            }
        }
    }
}
