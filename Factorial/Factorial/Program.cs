using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to get the factorial of: ");
            int n = Convert.ToInt16(Console.ReadLine());
            Iter(n);
            Recur(n, 1);
        }

        static void Iter(int n)
        {
            int ans = 1;
            for (int i = n; i > 0; i--)
            {
                ans *= i;
            }
            Console.WriteLine("Factorial iteratively is: {0}", ans);
        }

        static void Recur(int n, int ans)
        {
            if (n > 1)
            {
                Recur(n- 1, ans * n);
            }
            else
            {
                Console.WriteLine("Factorial recursivley is: {0}", ans);
            }
        }
    }
}
