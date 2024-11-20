using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {
        private string name;

        public Parent() 
        {
            Console.WriteLine("Parent Default Constructor");
        }

        public Parent(string name) : this() // we can call any constructor within same class by this method
        {
            this.Name = name;
            Console.WriteLine("Parent Parameterized Constructor");
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
