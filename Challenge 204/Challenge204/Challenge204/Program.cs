using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge204
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write down a phrase:");
            PotatoCounter(Console.ReadLine());
        }

        static void PotatoCounter(string input)
        {
            int count = 0;
            int spud = 0;
            char[] characters = input.ToCharArray();
            string potatoWord = "potato";

            if (input.Contains("potato"))
            {
                while ((spud = input.IndexOf(potatoWord, spud)) != -1)
                {
                    spud += potatoWord.Length;
                    count++;
                }
            }
            if (count > 1 || count == 0)
            {
                potatoWord += "es";
            }

            Console.WriteLine("There was " + count + " " + potatoWord + " in this phrase.");

            PotatoCounter(Console.ReadLine());
        }
    }
}
