using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin checking for prime numbers.");
            PrimeChecker(Console.ReadKey());
        }

        static void PrimeChecker(System.ConsoleKeyInfo input)
        {
            //Setting up the constraints mentioned by the assignment
            int maximum = 97;
            int minimum = 2;
            int count = 0;

            Console.WriteLine("\n Prime number status of the numbers 2 to 97:");

            //For loop using the aforementioned constraints
            for (int i = minimum; i < maximum + 1; i++)
            {
                //If we divide any number by 1 the remainder will always be 0. Thus, it starts from 2.
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count++;
                    }
                }

                //Checking to see if it's really a prime number
                if (count == (i - 2))
                {
                    Console.WriteLine(i + ": Yes.");
                }
                else
                {
                    Console.WriteLine(i + ": No.");
                }

                //Reset the counter for the next number.
                count = 0;
            }
            Console.ReadKey();
        }
    }
}