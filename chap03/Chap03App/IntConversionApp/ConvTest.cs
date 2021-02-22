using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;

            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int값은 {inCastVal}");

            inCastVal = +5;
            short shCastVal = (short) inCastVal;
            Console.WriteLine($"int값 변환한 short값은 {shCastVal}"); // Overflow

            float flVal = 3.141592f;
            inCastVal = (int)flVal;
            Console.WriteLine($"float값 변환한 int값은 {inCastVal}");
            double dlVal = inCastVal;
            Console.WriteLine($"int값 변환한 double값은 {dlVal}");

            object obj = 20; // Boxing
            int inUnboxingVal = (int) obj; // UnBoxing

            string strVal = "200";
            int result = Convert.ToInt32(strVal) * 3;
        }
    }
}
