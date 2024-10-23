using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            // three ways to print a variable
            int a = 10, b = 20;
            Console.WriteLine("{0}, {1}, {0}", a, b); // using placeholder
            Console.WriteLine($"{a}, {b}, {a}"); // string interpolation
            Console.WriteLine(a + ", " + b + ", " + a); // string concat

            // taking input
            Console.Write("Enter your name: ");
            string s = Console.ReadLine();
            Console.WriteLine(s);

            Console.Write("Enter Your Age: ");
            int n = Convert.ToInt32(Console.ReadLine()); // convert to int
            Console.WriteLine(n);

            Console.Write("Enter Your Height: ");
            int h = Int32.Parse(Console.ReadLine()); // convert to int
            Console.WriteLine(h);

            Console.Write("Enter a Number: ");
            Int32.TryParse(Console.ReadLine(), out int tmp); // try to convert int, if possible, otherwise tmp = 0
            Console.WriteLine(tmp);

            Console.Write("Enter any Character: ");
            int x = Console.Read(); // return ascii value of any char
            Console.WriteLine(x);
        }
    }
}