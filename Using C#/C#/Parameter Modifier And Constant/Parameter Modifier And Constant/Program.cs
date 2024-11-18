using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Modifier_And_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // params
            ParameterModifier p = new ParameterModifier();
            Console.WriteLine(p.Addition(1, 2, 3, 4, 5));
            Console.WriteLine(p.Addition(10, 1, 2, 3, 4, 5));

            // ref
            int a = 10, b = 20;
            Console.WriteLine("Before - a: {0}, b: {1}", a, b);
            p.Swap(ref a, ref b);
            Console.WriteLine("After - a: {0}, b: {1}", a, b);

            // out
            int x = 5;
            Console.WriteLine("x before: {0}", x);
            Console.WriteLine("Sum: {0}", p.Tmp(out x));
            Console.WriteLine("x after: {0}", x);

            // optional parameter
            Console.WriteLine("Sum: {0}", p.Addition(5, 5)); // addtion has 3 parameters, value of 3rd parameter is 10. So this line will print 20


            // const
            Constants c = new Constants();
            Console.WriteLine("Constant Value: {0}", Constants.x); // should call from class
            // Console.WriteLine("Constant Value: {0}", c.x); // not allowed

            // readonly
            Console.WriteLine("Readonly Value: {0}", c.y); // should call from object
            // Console.WriteLine("Constant Value: {0}", Constants.y); // not allowed

            // enum
            Console.WriteLine(Days.Monday);
            Console.WriteLine(Convert.ToInt32(Days.Monday)); // 2

            Console.WriteLine(Convert.ToInt32(Days.Saturday)); // 0
            Console.WriteLine(Convert.ToInt32(Days.Sunday)); // 1
            Console.WriteLine(Convert.ToInt32(Days.Monday)); // 2
            Console.WriteLine(Convert.ToInt32(Days.Tuesday)); // 0
            Console.WriteLine(Convert.ToInt32(Days.Wednesday)); // 1
            Console.WriteLine(Convert.ToInt32(Days.Thursday)); // 2
            Console.WriteLine(Convert.ToInt32(Days.Friday)); // 3

            Days today = Days.Monday;
            Console.WriteLine(today); // Output: Monday
        }
    }
}
