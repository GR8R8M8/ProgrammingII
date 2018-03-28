using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Ages = new List<int>();

            Random gen = new Random();

            for (int i = 0; i < 100; i++)
            {
                Ages.Add(gen.Next(15,23));
            }

            List<int> oAges = new List<int>(Ages.FindAll(age => age >= 20));
            List<int> yAges = new List<int>(Ages.FindAll(age => age < 20));

            Console.WriteLine("There are {0} people below 20 years old", yAges.Count);
            foreach (int num in yAges)
            {
                Console.Write(num + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("There are {0} people 20 or over", oAges.Count);
            foreach (int num in oAges)
            {
                Console.Write(num + ", ");
            }
        }
    }
}
