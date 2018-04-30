using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a set of numbers on one line");
            string l = Console.ReadLine();

            List<int> num = new List<int>(l.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList());

            var sn = from int n in num
                let sqn = n * n
                select sqn;

            Console.WriteLine("Squared numbers:");
            foreach (int n in sn)
            {
                Console.Write(n + " ");
            }

        }
    }
}
