using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(123 + 456);
            Console.WriteLine("123" + 456);
            Console.WriteLine("123" + "456");
            Console.WriteLine($"123{456}"); // C# 6.0 이후 문자열 만드는 방법
            var p2 = 456;
            Console.WriteLine("123" + p2);

            // 관계 연산자
            int a = 30;
            var b = 30;
            Console.WriteLine(a < b); // False
            Console.WriteLine(a > b); // False
            Console.WriteLine(a <= b); // True
            Console.WriteLine(a >= b); // True
            Console.WriteLine(a == b); // True
            Console.WriteLine(a != b); // False

            // 논리 연산자
            Console.WriteLine(10 > 9 && a > 0); // True
            Console.WriteLine(a > b || b > 0); // True
            Console.WriteLine(!(a < b)); // True

            // 조건 연산자 (단항 if문 대체 가능)
            string result;
            /*
            if (a == 30)
                result = "삼십";
            else
                result = "삼십아님";
            */
            result = (a == 30 ? "삼십" : "삼십아님");
            Console.WriteLine(result);

            // 비트 연산자
            int x = 17, y = 56;
            // XOR 연산자를 이용한 SWAP
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;
            Console.WriteLine($"x:{x}, y:{y}");

            // NULL (병합) 연산자
            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}");
        }
    }
}
