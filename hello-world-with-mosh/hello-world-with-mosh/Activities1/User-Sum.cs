using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_with_mosh.Activities1
{
    internal class User_Sum
    {
        public static void EnterSum()
        {
            Console.WriteLine("Enter numbers to sum or ok to exit");
            var sum = 0;
            while (true)
            {
               var input = Console.ReadLine();
                if (input == "ok" || String.IsNullOrWhiteSpace(input)) {
                    break;
                }
                sum += Int32.Parse(input);
                Console.WriteLine($"sum :: {sum}");
            }
        }
    }
}
