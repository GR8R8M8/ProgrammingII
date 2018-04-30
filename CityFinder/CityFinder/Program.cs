using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CityFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>{"Rome","London","Nairobi","Zurich","Los Angeles","New Delhi","Amsterdam","Abu Dhabi","Paris","Anaheim"};

            var search = from c in cities
                where c.First().ToString().ToUpper() == "A" && c.Last().ToString().ToUpper() == "M"
                select c;

            foreach (var c in search)
            {
                Console.WriteLine(c);
            }
        }
    }
}
