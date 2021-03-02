using System;

namespace DelegateChainApp
{
    class Program
    {
        delegate void AllCalc(int x, int y); // 대리자 선언

        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AllCalc all = new AllCalc(Plus) + new AllCalc(Minus) + new AllCalc(Multiple) + new AllCalc(Divide);
            all(10, 2);
        }
    }
}
