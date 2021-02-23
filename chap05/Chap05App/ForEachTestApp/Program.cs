using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] srcs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // for문
            for (int i = 0; i < srcs.Length; i++)
                Console.WriteLine($"src[{i}] = {srcs[i]}");

            int idx = 0;
            // foreach
            foreach (int i in srcs)
            {
                Console.WriteLine($"src[{idx++}] = {i}");
            }
            foreach (int i in srcs)
            {
                if (i % 3 == 0)
                    Console.WriteLine($"3의 배수 : {i}");
                else
                    continue;
            }

        }
    }
}
