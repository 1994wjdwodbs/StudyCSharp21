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
                double x = 4.28d;
                double y = 3.12352d;

                long x_ = *((long *) &x);
                long y_ = *((long *) &y);

                int *p = (int *) &x;
                for (int i = 0; i < 64; i++)
                {
                    int tmp = ((*p) & (1 << (63 - i)) != 0) ? 1 : 0;

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
