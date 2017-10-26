using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Deliverable3_Lab2_EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Header
            Console.WriteLine("/********************************/");
            Console.WriteLine("/* Welcome to Even-Odd Madness! */");
            Console.WriteLine("/********************************/");
            Console.WriteLine();

            // Ask for user's first name
            Console.Write("Can I please have your name? ");

            string userName = Console.ReadLine();
            if (userName.Length <= 0)
            {
                Console.WriteLine("Drat! It appears you're going to be difficult. I shall refer to you as Dave from here.");
                userName = "Dave";
            }

            // Ask for interger input
            do
            {
                Console.Write($"{userName}, can you please enter in a whole number between 1 and 100? (No negatives por favor): ");
                long? userInput = Validate();

                if (userInput == null)
                {
                    Console.WriteLine($"I'm sorry {userName} I can't do that.");
                    Console.Write("Please try again, or quit. Press 'c' to continue, or any other key to exit: ");
                }
                else if (userInput < 0)
                {
                    Console.WriteLine("Be positive.");
                    Console.Write("Please try again, or quit. Press 'c' to continue, or any other key to exit: ");

                }
                else if (userInput == 0)
                {
                    Console.WriteLine("Gimme more than that dude...");
                    Console.Write("Please try again, or quit. Press 'c' to continue, or any other key to exit. ");
                }
                else if (userInput > 100)
                {
                    Console.WriteLine("Whoa there ace! Let's dial it back a little.");
                    Console.Write("Please try again, or quit. Press 'c' to continue, or any other key to exit: ");
                }
                else if (userInput % 2 == 0)
                {
                    if (userInput >= 2 && userInput <= 25)
                    {
                        Console.WriteLine("Even and less than 25.");
                    }
                    else if (userInput >= 26 && userInput <= 60)
                    {
                        Console.WriteLine("Even.");
                    }
                    else if (userInput > 60)
                    {
                        Console.WriteLine($"{userInput} and Even.");

                    }
                    Console.Write($"Thank you {userName}. Press 'c' to continue with another value (1-100), or any other key to exit: ");
                }
                else
                {
                    Console.WriteLine($"{userInput} and Odd.");
                    Console.Write($"Thank you {userName}. Press 'c' to continue with another value (1-100), or any other key to exit: ");
                }
            } while (Console.ReadLine().ToLower()[0] == 'c');

            Console.WriteLine();
            Console.WriteLine($"Thanks for playing {userName}. Have a good day!");
        }

        public static long? Validate ()
        {
            long x;
            bool valid = long.TryParse(Console.ReadLine(), out x);

            if (!valid)
            {
                return null;
            }

            return x;
        }
    }
}
