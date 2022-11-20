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
            var numbers = new[] { 30, 7, 8, 10 };
            Console.WriteLine($"Length :: {numbers.Length}");

            var indexOfNumber = Array.IndexOf(numbers, 99);
            Console.WriteLine($"index :: {indexOfNumber}");

            var newArray = new int[3];

            Array.Copy(numbers, newArray, 3);
            Console.Write("Un Sorted :: ");
            foreach (var number in newArray)
            {
                Console.Write(number + ", ");
            }

            Array.Sort(newArray);
            Console.WriteLine();
            Console.Write("Sorted :: ");
            foreach (var (value, idx) in newArray.Select((value, idx) => (  value, idx)))
            {
                Console.Write(value + ", ");
            }
        }
    }
}
