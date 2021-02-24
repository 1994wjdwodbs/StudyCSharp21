using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;

            Console.WriteLine($"Before Swap {a}, {b}");
            // Program.Swap(a, b);
            Program.Swap(ref a, ref b);
            Console.WriteLine($"After Swap {a}, {b}");
            // double x = 4.28d;
            // double y = 3.12352f;

            unsafe
            {   
                Console.WriteLine($"{sizeof(char *)}");
                Console.WriteLine($"{sizeof(byte *)}");
                Console.WriteLine($"{sizeof(short *)}");
                Console.WriteLine($"{sizeof(int *)}");
                Console.WriteLine($"{sizeof(long *)}");
                Console.WriteLine($"{sizeof(long)}");

                double x = 2.0d;
                double y = 3.14d;

                long x_ = *((long *) &x);
                long y_ = *((long *) &y);

                // double 내부 메모리 (비트) 출력
                int * p = (int *) &y;
                for (int i = 0; i < 64; i++)
                {
                    int tmp = *((p + ((63 - i)/32))) & (1 << (63 - i));
                        if (tmp != 0)
                            Console.Write("1");
                        else
                            Console.Write("0");

                        if ((i + 1) == 1 || (i + 1) == 11 + 1)
                            Console.Write(" ");
                }
                Console.WriteLine("");
                x_ = x_ ^ y_;
                y_ = x_ ^ y_;
                x_ = x_ ^ y_;

                x = *((double *) &x_);
                y = *((double *) &y_);

                Console.WriteLine($"{x}, {y}");

            }
        }

        private static void Swap(ref int a, ref int b)
        {
            // throw new NotImplementedException();
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
