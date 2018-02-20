using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNum1;
            int intNum2;

            Console.WriteLine("Enter a value for number 1");
            intNum1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter a value for number 2");
            intNum2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The sum is:");
            Sum(intNum1, intNum2);
            Difference(intNum1, intNum2); 
        }

        static void Sum(int Num1, int Num2)
        {
            Console.WriteLine("The sum is:");
            Console.WriteLine(Num1 + Num2);
        }

        static void Difference(int Num1, int Num2)
        {
            Console.WriteLine("The difference is:");
            Console.WriteLine(Num1 - Num2);
        }

    }
}
