using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열테스트");

            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                Console.WriteLine($"arr[{i}] : {arr[i]}");
            }
            Console.WriteLine($"{0b10}");
            
        }
    }
}
