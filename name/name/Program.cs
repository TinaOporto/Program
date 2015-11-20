using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Firstname: ");
            string fname = Console.ReadLine();

            Console.WriteLine("Enter Lastname: ");
            string lname = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your fullname is: " + fname + " " + lname );
            Console.WriteLine("Your age is: " + age + " years old");

            Console.ReadKey();
        }
    }
}
