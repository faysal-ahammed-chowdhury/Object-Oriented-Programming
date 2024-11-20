using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // by using polymorphism we can achieve parents data, which provide us re-use of codes.
            Child c1 = new Child();
            Child c2 = new Child("Faysal");
            Console.WriteLine(c2.Name);
        }
    }
}
