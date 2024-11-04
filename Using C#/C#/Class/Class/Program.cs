using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // struct vs class
            // almost similar but there are few minor changes. like-
            // 1. struct doesn't support inheritance, abstraction
            // 2. struct doesn't allowed us to create default constructor

            Student s1 = new Student();
            s1.Print();
            Student s2 = new Student(1, "Faysal", 3.53);
            s2.Print();
        }
    }
}
