using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamePlay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the employee's name: ");
            string name = Console.ReadLine();
            string[] names = name.Split((string[])null, 3, StringSplitOptions.RemoveEmptyEntries);

            string firstName = names[0];
            firstName.TrimStart();
            firstName.TrimEnd();
            firstName = firstName.First().ToString().ToUpper() + firstName.Substring(1);

            string middleName = names[1];
            middleName.TrimStart();
            middleName.TrimEnd();
            middleName = middleName.First().ToString().ToUpper() + middleName.Substring(1);


            var lastName = names[2];
            lastName.TrimStart();
            lastName.TrimEnd();
            string[] arr = lastName.Split((string[])null, 2, StringSplitOptions.RemoveEmptyEntries);

            arr[0] = arr[0].First().ToString().ToUpper() + arr[0].Substring(0);

            try
            {
                arr[1] = arr[1].First().ToString().ToUpper() + arr[1].Substring(1);
                lastName = String.Format("{0}-{1}", arr[0], arr[1] );
            }
            catch (Exception)
            {
                lastName = arr[0];
            }

            Console.WriteLine("The nameplate name is: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("The name for the comany directory is: {0}, {1} {2}", lastName, firstName, middleName.First().ToString());
            Console.WriteLine("The initials for the user ID is: {0}{1}{2}", firstName.First().ToString().ToLower(), middleName.First().ToString().ToLower(), lastName.First().ToString().ToLower());
            string email = firstName.Substring(0, 5).First().ToString().ToLower() + firstName.Substring(1, 5) +
                           middleName.Substring(0, 2).First().ToString().ToLower() + middleName.Substring(1, 1) +
                           firstName.Length + middleName.Length + lastName.Length; 
            Console.WriteLine("The email address is: {0}@apexpaper.com", email );
        }
    }
}
