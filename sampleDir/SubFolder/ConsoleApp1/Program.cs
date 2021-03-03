using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 36;
            int limit_x = (int) Math.Ceiling(((1 + Math.Sqrt(5)) / 2) * a);
            int limit_y = (int) Math.Ceiling((((1 + Math.Sqrt(5)) / 2) * a) * Math.Sin(2*Math.PI/5));
            char[,]array = new char[limit_y,limit_x];
            for (int i = 0; i < limit_y; i++)
                for (int j = 0; j < limit_x; j++)
                    array[i,j] = '.';
            
            // 별의 직선을 지나는 일차함수들 사이에 별 채우기
            for(int x = 0; x < (limit_x) / 2; x++)
            {
                for (int y = f2(x, a); y <= f1(x, a) && y < limit_y; y++)
                {
                    array[y, x] = '*';
                    array[y, (limit_x - 1) - x] = '*';
                }
                for (int y = g2(x, a); y <= g1(x, a) && y < limit_y; y++)
                {
                    array[y, x] = '*';
                    array[y, (limit_x - 1) - x] = '*';
                }
            }

            // y축 뒤집기
            char[,] tmp = new char[limit_y, limit_x];
            for (int i = 0; i < limit_y; i++)
            {
                for (int j = 0; j < limit_x; j++)
                    tmp[i,j] = array[limit_y - 1 - i,j];
            }

            // 출력
            for (int i = 0; i < limit_y; i++)
            {
                for (int j = 0; j < limit_x; j++)
                    Console.Write(tmp[i, j]);
                Console.WriteLine("");
            }

            int f1(int x, int a)
            {
                return (int)Math.Ceiling(((((1 + Math.Sqrt(5)) / 2) *a) * Math.Sin(Math.PI / 5)));
            }
            int f2(int x, int a)
            {
                double tmp = (-1) * (Math.Tan(Math.PI / 5) * x) + ((((1 + Math.Sqrt(5)) / 2) * a) * Math.Sin(Math.PI / 5));
                return (int)Math.Ceiling(tmp);
            }

            int g1(int x, int a)
            {
                double tmp = (Math.Tan((2 * Math.PI) / 5) * (x - ((Math.Sqrt(5) - 1) / 4) * a));
                return (int)Math.Ceiling(tmp);
            }
            int g2(int x, int a)
            {
                double tmp = (Math.Tan((Math.PI) / 5) * (x - ((Math.Sqrt(5) - 1) / 4) * a));
                return (int)Math.Ceiling(tmp);
            }
        }
    }
}
