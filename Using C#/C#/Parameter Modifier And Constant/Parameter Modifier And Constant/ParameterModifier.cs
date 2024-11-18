using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameter_Modifier_And_Constant
{
    internal class ParameterModifier
    {
        // by using params we can pass values separated by comma and receive here as an array
        public int Addition(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }
        public int Addition(int x, params int[] values)
        {
            int sum = x;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }

        // this is not allowed (one method can have atmost one params and params must be the last parameter from right)
        //public int Addition(params int[] values, int x)
        //{
        //    int sum = 0;
        //    foreach (int value in values)
        //    {
        //        sum += value;
        //    }
        //    return sum;
        //}

        // ref - pass by reference (locating same memory address)
        public void Swap(ref int a, ref int b)
        {
            int tmp = a; 
            a = b; 
            b = tmp;
        }

        // out - pass by reference but variable must be assigned inside method
        public int Tmp(out int x)
        {
            x = 10;
            int ans = x + 5;
            return ans;
        }

        // optional parameter list - (provided default value of parameters)
        public int Addition(int a, int b, int c = 10)
        {
            return a + b + c;
        }
    }
}
