﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge201
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your credit or debit card info and I swear I'll keep it safe for you. Trust me dude:");
            MaskCardInfo(Console.ReadLine());
        }

        static void MaskCardInfo (string input)
        {
            try
            {
                Convert.ToInt64(input);
                char[] characters = input.ToCharArray();
                int lengthOfCardNumber = characters.Length;
                string maskedCardInfo = "";

                for (int i = 0; i < lengthOfCardNumber-4; i++)
                {
                    maskedCardInfo += "#";
                }

                if (lengthOfCardNumber > 4)
                {
                    maskedCardInfo += characters[lengthOfCardNumber - 4].ToString();
                    maskedCardInfo += characters[lengthOfCardNumber - 3].ToString();
                    maskedCardInfo += characters[lengthOfCardNumber - 2].ToString();
                    maskedCardInfo += characters[lengthOfCardNumber - 1].ToString();
                }
                else
                {
                    maskedCardInfo = input;
                }

                //Slaps the last 4 digits on the end and reads the result to you.
                Console.WriteLine("So your card number is " + maskedCardInfo + "? Gotcha.");
                MaskCardInfo(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("That's not a card number.");
                MaskCardInfo(Console.ReadLine());
            }
        }
    }
}
