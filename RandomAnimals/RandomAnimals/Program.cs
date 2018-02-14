using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] arrObj = new Object[10];
            Random rand = new Random();
    
            for (int i = 0; i < 10; i++)
            {
                switch (rand.Next(0, 3))
                {
                    case 0:
                        arrObj[i] = new Dog();
                        break;
                    case 1:
                        arrObj[i] = new Cat();
                        break;
                    case 2:
                        arrObj[i] = new Bird();
                        break;
                }
                
            }

            foreach (Object animal in arrObj)
            {
                Console.WriteLine(animal.ToString());
            }


        }
    }

    class Dog
    {
        public override string ToString()
        {
            return "Woof";
        }
    }

    class Cat
    {
        public override string ToString()
        {
            return "Meow";
        }
    }

    class Bird
    {
        public override string ToString()
        {
            return "Tweet";
        }
    }

}
