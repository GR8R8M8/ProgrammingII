using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of numbers on one line");
            string l = Console.ReadLine();
            Console.WriteLine("Enter the number of top numbers");
            int am = Convert.ToInt16(Console.ReadLine());

            List<int> num = new List<int>(l.Split((string[])null, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList());
            num.Sort();

            var s = from n in num
                where n >= num[num.Count - am]
                select n;

            Console.WriteLine("Top Numbers: ");
            foreach (var n in s)
            {
                Console.WriteLine(n);
            }
        }
    }
}
