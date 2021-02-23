using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine(a);
                a = a - 2;
            }
            Console.WriteLine("출력종료");

            do
            {
                Console.WriteLine(a);
                a++;
            } while (a < 10);

            // for문
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i);

            // 중첩 for문
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine($"------{i}단 시작------");
                for (int j = 1; j < 10; j++)
                    Console.WriteLine($"{i} * {j} = {i * j}");
                
                Console.WriteLine($"------{i}단 종료------"); ;
            }
        }
    }
}
