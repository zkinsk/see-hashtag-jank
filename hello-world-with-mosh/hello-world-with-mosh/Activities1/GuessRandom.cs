using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_with_mosh.Activities1
{
    internal class GuessRandom
    {
        public static void Guess()
        {
            var random = new Random();
            var number = random.Next(1, 10);

            var guesses = 0;
            const int maxGuesses = 3;
            while (true)
            {
                Console.Write("Make a guess :: ");
                var guess = Console.ReadLine();
                if (String.IsNullOrEmpty(guess)) continue;
                if (number == Int32.Parse(guess))
                {
                    Console.WriteLine("you got it!");
                    break;
                }
                guesses++;
                if (guesses < maxGuesses)
                {
                    Console.WriteLine("Try again!");
                    continue;
                }
                Console.WriteLine($"Sorry you missed it :: {number}");
            }
        }
    }
}
