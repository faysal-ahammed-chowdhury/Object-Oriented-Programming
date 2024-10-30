using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Point // struct is a value type user-defined data type.
    {
        public int x;
        public int y;

        // programmer can't define his own parameterless constructor in C#
        //Point()
        //{
        //    x = 5;
        //    y = 5;
        //}

        public Point(int x, int y) // parameterized constructor
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine("({0},{1})", x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;
            p.x = 5; p.y = 10;
            p.Print();

            Point p2 = new Point(8, 10);
            p2.Print();

            Point p3 = p2;
            p3.x++;
            p3.y++;
            p2.Print(); // p2 will not change because struct is a value type data
            p3.Print();
        }
    }
}
