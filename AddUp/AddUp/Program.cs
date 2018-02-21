using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to count to: ");
            int num = Convert.ToInt16(Console.ReadLine());
            WriteUpLoop(num);
            Console.WriteLine("Counting up recursively");
            WriteUpRecursively(num);
        }

        static void WriteUpLoop(int n)
        {
            Console.WriteLine("Counting down with a loop...");
            for (int i = 1; n >= i; i++)
            {
                Console.WriteLine("{0}", i);
            }
        }

        static void WriteUpRecursively(int n)
        {
            if (n > 1)
            {
                WriteUpRecursively(n - 1);
            }

            Console.WriteLine("{0}", n);
        }
    }
}
