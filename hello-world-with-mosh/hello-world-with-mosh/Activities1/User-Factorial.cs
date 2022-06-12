using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_with_mosh.Activities1
{
    internal class User_Factorial
    {
        public static void FigureFactorial()
        {
            Console.WriteLine("Factorial Figurer");
            var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input)) return;
            var number = Int32.Parse(input);
            var factorial = number;
            for (var i = number; i > 1; i--)
            {
                factorial *= i-1;
            }
            Console.WriteLine($"{number}! = {factorial}");
        }
    }
}
