using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Child : Parent // syntax of inherit
    {
        public Child()
        {
            Console.WriteLine("Child Default Constructor");
        }

        public Child(string name) : base(name) // we can call parent's constructor by base(), if we don't call any constructore, the compiler(or something) automatically call the default constructor of parent class
        {
            Console.WriteLine("Child Paraneterized Constructor");
        }
    }
}
