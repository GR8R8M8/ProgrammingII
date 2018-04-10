using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string words = Console.ReadLine();

            Console.WriteLine("Enter your shift: ");
            int shift = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Encrypted Text: ");
            Console.WriteLine(Encrypt(words, shift));
        }

        public static string Encrypt(string words, int shift)
        {
            string output = string.Empty;

            foreach (char ch in words)
                output += Move(ch, shift);

            return output;
        }

        private static char Move(char ch, int shift)
        {
            if (!char.IsLetter(ch))
                return ch;

            char offset = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + shift) - offset) % 26) + offset);
        }


    }
}
