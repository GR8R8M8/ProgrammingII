using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSomeText
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string filePath = Directory.GetCurrentDirectory() + "/SomeText.txt";
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string contents = sr.ReadLine();

                Console.WriteLine("The contents are:\n {0}", contents);
                fs.Close();
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            catch
            {
                Console.WriteLine("Unhandled exception!");
            }
        }
    }
}
