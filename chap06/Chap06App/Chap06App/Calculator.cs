using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap06App
{
    class Calculator
    {


        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            int y = Calculator.Plus(5, 6);
            int z = Calculator.Plus(7, 8);

            int result = x + y + z;
            Console.WriteLine($"결과는 {result}");
        }

        private static int Plus(int v1, int v2)
        {
            // throw new NotImplementedException();
            Console.WriteLine("Input : {0}, {1}", v1, v2);
            return (v1 + v2);
        }
    }
}
