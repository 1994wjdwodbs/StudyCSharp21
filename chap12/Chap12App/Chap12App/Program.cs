using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            try
            {
                for (int i = 0; i < arr.Length + 2; i++)
                    Console.WriteLine($"{i} 번째 값 : {arr[i]}");
            }
            catch(Exception e)
            {
                // throw;
            }
        }
    }
}
