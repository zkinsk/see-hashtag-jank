using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_with_mosh.Activities1
{
    internal class GreatestSeries
    {
        public static void Greatest()
        {
            Console.WriteLine("Greatest in a CSV series");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input)) return;
            var strings = input.Split(",");

            var max = 0;
            foreach(var s in strings)
            {
                var num = Int32.Parse(s);
                if(num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"Max :: {max}");
        }
    }
}
