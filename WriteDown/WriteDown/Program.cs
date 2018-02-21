using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteDown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to count down from: ");
            int num = Convert.ToInt16(Console.ReadLine());
            WriteDownLoop(num);
            Console.WriteLine("Counting down recursively");
            WriteDownRecursively(num);
        }

        static void WriteDownLoop(int n)
        {
            Console.WriteLine("Counting down with a loop...");
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine("{0}", i);

            }
        }

        static void WriteDownRecursively(int n)
        {
            Console.WriteLine("{0}", n);
            if (n > 1)
            {
                WriteDownRecursively(n - 1);
            }
        }
    }
}
