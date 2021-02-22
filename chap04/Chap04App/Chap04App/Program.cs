using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("자연수 입력 : ");
            int values;
            values = int.Parse(Console.ReadLine());

            if (values % 3 == 0)
                Console.WriteLine("3의 배수");
            else
                Console.WriteLine("3의 배수가 아님");

            if (values % 7 == 0)
                Console.WriteLine("7의 배수");
            else
                Console.WriteLine("7의 배수가 아님");
        }
    }
}
