using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Child : Parent
    {
        public void MethodA()
        {
            Console.WriteLine("Child's MethodA");
        }

        public override void MethodB() // by using override we are overriding the parent's MethodB.
        {
            Console.WriteLine("Child's MethodB");
        }
    }
}
