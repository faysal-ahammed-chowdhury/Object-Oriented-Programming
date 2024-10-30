using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCastingAndTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // type casting are two types -
            // 1. Implicit type cast (no possibilities of data loss)
            // 2. Explicit type cast (there are possibilitites of data loss)
            int x = 5;
            long y = x; // implicit type cast
            short z = (short)x; // explicit type cast

            char c = 'A';
            int n = c; // implicit type cast
            byte b = (byte)c; // explicit type cast
            Console.WriteLine(n); // ascii value of 'A'
            Console.WriteLine(b); // ascii value of 'A'

            // type conversion - used for conversions that require transformation between fundamentally different types

            // type conversion (string to int) - (string must be fill by numeric char)
            string s = "545";
            // x = (int)s; // casting not possible
            x = Convert.ToInt32(s); // but conversion is possible (will throw an error if conversion is not possible for some reason)

            // int to string
            x = 1055;
            s = Convert.ToString(x);
            Console.WriteLine(s);

            // this is okay
            y = 1000000;
            x = Convert.ToInt32(y);
            Console.WriteLine(x);
            // but this is not ("y" is greater than "x's" max value, so this will throw an error)
            y = 10000000000;
            // x = Convert.ToInt32(y);
            Console.WriteLine(x);
        }
    }
}
