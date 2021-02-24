using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14f + 5.6f = {y}");

            int z = Calculator.Plus(3, 4, 5);
            Console.WriteLine($"3 + 4 + 5 = {z}");

            int w = Calculator.Plus(3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine($"{w}");

        }

        // params
        private static int Plus(params int []v)
        {
            int result = 0;
            for (int i = 0; i < v.Length; i++)
                result += v[i];

            return result;
        }

        // 메소드 오버로딩
        private static int Plus(int v1, int v2)
        {
            // throw new NotImplementedException();

            return (v1 + v2);
        }

        private static float Plus(float v1, float v2)
        {
            // throw new NotImplementedException();

            return (v1 + v2);
        }

        private static int Plus(int v1, int v2, int v3)
        {
            // throw new NotImplementedException();

            return (v1 + v2 + v3);
        }
    }
}
