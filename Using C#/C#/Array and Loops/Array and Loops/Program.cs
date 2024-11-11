using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1D array
            Console.WriteLine("1D Array:");
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] b = a;
            Console.Write("a: ");
            foreach (int x in a)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
            Console.Write("b: ");
            foreach (int x in a)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();

            b[0] = 100; // changed in b will also change a because array is a reference type data

            Console.Write("a: ");
            foreach (int x in a)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();
            Console.Write("b: ");
            foreach (int x in a)
            {
                Console.Write("{0} ", x);
            }
            Console.WriteLine();

            // 2D array
            Console.WriteLine("\n2D Array:");
            int[,] arr = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }

            // Jagged Array
            Console.WriteLine("\nJagged Array:");
            int[][] jagged = new int[2][];
            jagged[0] = new int[2] {1, 2};
            jagged[1] = new int[4] {3, 4, 5, 6};
            foreach (int[] row in jagged)
            {
                foreach (int val in row)
                {
                    Console.Write("{0} ", val);
                }
                Console.WriteLine();
            }


            // Jagged Array of 2D array
            int[][,] jaggedOfMatrix = new int[2][,];
            jaggedOfMatrix[0] = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            jaggedOfMatrix[1] = new int[2, 3] { {5,6, 7 }, { 8, 9, 10} };

            foreach (int[,] row in jaggedOfMatrix)
            {
                // each row is a 2D array
            }
        }
    }
}
