using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponentiation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to exponentiate: ");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a second number as the exponent: ");
            int num2 = Convert.ToInt16(Console.ReadLine());
            Iter(num1, num2);
            Recur(num1, num2, 1);
        }

        static void Iter(int n1, int n2)
        {
            int num = 1;
            for (int i = n2; i > 0; i--)
            {
                num *= n1;
            }

            Console.WriteLine("The numbers multiplied iterativley is: {0}", num);
        }

        static void Recur(int n1, int n2, int n3)
        {
            if (n2 > 0)
            {
                Recur(n1, n2 - 1, n3 *= n1);
            }
            else
            {
                Console.WriteLine("The numbers multiplied recursively is: {0}", n3);
            }
        }
    }
}
