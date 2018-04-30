using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            FileStream fs = new FileStream("res/testRead.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string n = sr.ReadLine();
            fs.Close();
            sr.Close();

            List<int> num = new List<int>(n.Split((string[])null, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList());

            var query = from nt in num
                where nt == s
                select nt;

            for (int i = 0; i < num.Max(); i++)
            {
                s = i;
                Console.WriteLine("Key " + i + " occured " + query.Count() + " times");
            }

        }
    }
}
