using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleColorChanger
{
    enum Colors { BlackOnWhite, BlueOnWhite, RedOnBlack, GreenOnYellow, BlueOnGreen };

    class Program
    {

        static void Main(string[] args)
        {
            Timer tmrColor = new Timer(timerMethod, null, 0, 500);
            Console.ReadLine();
        }

        static void timerMethod(object obj)
        {
            Random gen = new Random();

            Colors type = (Colors)gen.Next(0, 4); 


            switch (type)
            {
                case Colors.BlackOnWhite:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Watch the colors of the Console change \nPress Ctrl+C to end the program\n");
                    }
                    break;
                case Colors.BlueOnGreen:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Watch the colors of the Console change \nPress Ctrl+C to end the program\n");
                    }
                    break;
                case Colors.BlueOnWhite:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Watch the colors of the Console change \nPress Ctrl+C to end the program\n");
                    }
                    break;
                case Colors.GreenOnYellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Green;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Watch the colors of the Console change \nPress Ctrl+C to end the program\n");
                    }
                    break;
                case Colors.RedOnBlack:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("Watch the colors of the Console change \nPress Ctrl+C to end the program\n");
                    }
                    break;
            }


        }
    }
}
