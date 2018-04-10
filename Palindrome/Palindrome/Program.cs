using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public enum PalindromeType {Mirrored, Pivot, Neither};

        static void Main(string[] args)
        {
            string word = null;
            int M = 0;
            int P = 0;
            int N = 0;

            do
            {
                Console.WriteLine("Enter the word: ");
                word = Console.ReadLine();

                switch (Check(word))
                {
                    case PalindromeType.Mirrored:
                        Console.WriteLine("Mirrored");
                        M++;
                        break;

                    case PalindromeType.Pivot:
                        Console.WriteLine("Pivot");
                        P++;
                        break;

                    case PalindromeType.Neither:
                        Console.WriteLine("Neither!");
                        N++;
                        break;
                }
            } while (word != "QQQ");

            Console.WriteLine("Mirrored: " + M);
            Console.WriteLine("Pivot: " + P);
            Console.WriteLine("Neither: " + N);
        }

        static PalindromeType Check(string str)
        {
            str.First().ToString().ToLower();
            string strRev = new string(str.ToCharArray().Reverse().ToArray());

            if (str == strRev && str.Length % 2 == 0)
            {
                return PalindromeType.Mirrored;
            }

            if (str == strRev && str.Length % 2 > 0)
            {
                return PalindromeType.Pivot;
            }

            return PalindromeType.Neither;
        }
    }
}
