using System;
using System.Collections.Generic;

namespace ConvertToRoman
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter a number to convert, type -1 to stop.");
                int num = Convert.ToInt16(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Converted to roman numerals, your number is: {0}\n", Conv(num));
                }
            }
        }

        private static string Conv(int num)
        {
            string romanNumeral ="";

            Dictionary<string, int> combo = new Dictionary<string, int>()
            {
                {"M", 1000},
                {"CM", 900},
                {"D", 500},
                {"CD", 400},
                {"C", 100},
                {"XC", 90},
                {"L", 50},
                {"XL", 40},
                {"X", 10},
                {"IX", 9},
                {"V", 5},
                {"IV", 4},
                {"I", 1}
            };

            foreach (KeyValuePair<string, int> set in combo)
            {

                if (num >= set.Value)
                {
                    int moddiv = num % set.Value;
                    int remainder = (num - moddiv) / set.Value;
                    num = moddiv;

                    while (remainder > 0)
                    {
                        romanNumeral += set.Key; remainder--;
                    }
                }
            }
            return romanNumeral;
        }
    }
}
