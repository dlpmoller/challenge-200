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
            int maximum = 97;
            int minimum = 2;
            int count = 0;

            Console.WriteLine("\n Prime number status of the numbers 2 to 97:");

            for (int i = minimum; i < maximum + 1; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j != 0)
                    {
                        count++;
                    }
                }
                if (count == (i - 2))
                {
                    Console.WriteLine(i + ": Yes.");
                }
                else
                {
                    Console.WriteLine(i + ": No.");
                }

                count = 0;
            }
            Console.ReadKey();
        }
    }
}