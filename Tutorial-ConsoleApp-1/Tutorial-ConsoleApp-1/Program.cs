using System;

namespace Tutorial_ConsoleApp_1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number :: ");
            var nums = Console.ReadLine();
            var chars = new char[] { ',', ' ' };
            var numarray = nums.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            var maxNum = 0;
            foreach (var num in numarray)
            {
                if (int.Parse(num) > maxNum)
                {
                    maxNum = int.Parse(num);
                }
            }
            Console.Write("Max Num :: " + maxNum);
        }
    }
}
