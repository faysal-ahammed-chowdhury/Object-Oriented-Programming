using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // method overloading (compile time polymorphism) - the compiler determine which method to call at compile time by checking the parameter list.
            Calculator  c = new Calculator();
            Console.WriteLine(c.Addition(5, 10)); // int, int
            Console.WriteLine(c.Addition(5, 10, 20)); // int, int, int
            Console.WriteLine(c.Addition(5, 10, 20000000000)); // int, int, long
            Console.WriteLine(c.Addition(50000000000, 10, 2)); // long, int, int

            // method overriding (runtime polymorphism)
            Parent p1 = new Parent();
            Child c1 = new Child();

            // example without polymorphic object:
            // MethodA is not virtual, so it cannot be overridden, and Parent's MethodA is always called.
            // MethodB is virtual and overridden, but since we are using specific objects, behavior is straightforward.
            p1.MethodA();  // output: Parent's MethodA
            c1.MethodA();  // output: Child's MethodA
            p1.MethodB();  // output: Parent's MethodB
            c1.MethodB();  // output: Child's MethodB

            // example with polymorphic object:
            // Parent reference holding Child object allows us to achieve runtime polymorphism.
            Parent p2 = new Child();

            p2.MethodA();  // output: Parent's MethodA (no override, so resolved at compile-time)
            p2.MethodB();  // output: Child's MethodB (runtime polymorphism due to virtual/override)
        }
    }
}
