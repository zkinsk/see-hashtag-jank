using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_with_mosh.Activities1
{
    internal class Three_Divisible
    {
        public static void three_divisible()
        { var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                var check = i % 3;
                if(check == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Numbers between 1 & 100 divisible by 3: {count}");
        }
    }
}
