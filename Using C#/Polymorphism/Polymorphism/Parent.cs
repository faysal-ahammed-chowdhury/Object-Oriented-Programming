using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Parent
    {
        public void MethodA()
        {
            Console.WriteLine("Parent's MethodA");
        }

        public virtual void MethodB() // by using virtual we are giving permission to c# that the function can be override.
        {
            Console.WriteLine("Parent's MethodB");
        }
    }
}
