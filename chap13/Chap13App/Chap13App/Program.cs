using System;

namespace Chap13App
{
    // 대리자 (메소드를 다른 메소드의 인수로 전달하는 데 사용되는 형식)
    delegate int MyDelegate(int a, int b); 

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return (a + b);
        }
        public int Minus(int a, int b)
        {
            return (a - b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate[] Callback;

            Callback = new MyDelegate[] { new MyDelegate(calc.Plus), new MyDelegate(calc.Minus)};

            Console.WriteLine($"result = {Callback[0](3, 4)}");
            Console.WriteLine($"result = {Callback[1](4, 3)}");
        }
    }
}
