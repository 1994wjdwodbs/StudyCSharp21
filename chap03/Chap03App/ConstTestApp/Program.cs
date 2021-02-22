using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTestApp
{
    class Program
    {
        enum Season
        {
            Spring, Summer, Fall, Winter
        }
        static void Main(string[] args)
        {
            Console.WriteLine("상수 테스트");
            const double PI = 3.141592; // 상수
            Console.WriteLine($"원주율 값 : {PI}");

            Season mySeason = Season.Summer;
            mySeason = Season.Winter;
            Console.WriteLine($"Weather : {mySeason}");
            int a = 0;
            int? b = null;
            Console.WriteLine($"a : {a}");
            Console.WriteLine($"b : {b}");
        }
    }
}
