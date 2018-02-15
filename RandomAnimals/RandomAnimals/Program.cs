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
            Object prev = null;

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
                if (animal.Equals(prev) == true)
                {
                    Console.WriteLine("You got two in a row!");
                }
                prev = animal;
            }
        }
    }

    #region Animal
    abstract class Animal
    {
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (obj.ToString() == this.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    #endregion

    #region Dog : Animal
    class Dog : Animal
    {
        public override string ToString()
        {
            return "Woof";
        }
    }
    #endregion

    #region Cat : Animal
    class Cat : Animal
    {
        public override string ToString()
        {
            return "Meow";
        }
    }
    #endregion

    #region Bird : Animal
    class Bird : Animal
    {
        public override string ToString()
        {
            return "Tweet";
        }
    }
    #endregion
}
