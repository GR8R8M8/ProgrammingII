using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sortedNames = new string[] {"Nick", "Pierce", "Daniel", "Tyler", "Sydney", "Chris", "Kush", "Jordan", "Taylor", "Shamyl", "Jake", "Cole"};

            Random rnd = new Random();
            string[] randomNames = sortedNames.OrderBy(x => rnd.Next()).ToArray();

            var teams = from name in randomNames
                let i = Array.IndexOf(randomNames, name) + 1
                where  i % 3 == 0
                select (" " + name + " " + randomNames[i - 2] + " " + randomNames[i - 3]);

            foreach (var team in teams)
            {
                Console.WriteLine("Team: " + team);
            }

        }
    }
}
