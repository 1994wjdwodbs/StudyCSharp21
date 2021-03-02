using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DegreeArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = (i * arr.GetLength(1)) + j + 1;
                    Console.Write($"arr[{i},{j}] : {arr[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
