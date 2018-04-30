using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Gettysburg
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = File.ReadAllText("res/Gettysburg.txt");

            List<string> words = new List<string>(address.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' , '-' }, StringSplitOptions.RemoveEmptyEntries));

            var query = from word in words
                where word == "we"
                select word;


            Console.WriteLine(query.Count());

        }
    }
}
