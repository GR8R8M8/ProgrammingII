using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InchesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of inches:");
            Convert(System.Convert.ToInt16(Console.ReadLine()));
        }

        static void Convert(int Inches)
        {
            Console.WriteLine("Converted Data:");
            Console.WriteLine("Feet: {0}", Inches / 12);
            Console.WriteLine("Inches {0}", Inches % 12);
        }
    }
}
