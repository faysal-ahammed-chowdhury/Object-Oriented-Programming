using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Calculator
    {
        public int Addition(int x, int y)
        {
            return x + y;
        }

        public int Addition(int x, int y, int z) // number of parameter different
        {
            return x + y + z;
        }

        public long Addition(int x, int y, long z) // parameter type different
        {
            return x + y + z;
        }
        public long Addition(long x, int y, int z) // parameter sequence(order) different
        {
            return x + y + z;
        }
    }
}
