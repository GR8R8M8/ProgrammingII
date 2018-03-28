using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddColors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> color1 = new List<string>() {"blue", "pink", "purple"};
            List<string> color2 = new List<string>() {"navy", "violet"};

            color1.AddRange(color2);

            foreach (string col in color1)
            {
                Console.WriteLine(col);
            }
        }
    }
}
