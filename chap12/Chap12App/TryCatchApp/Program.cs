using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException Ie)
            {
                Console.WriteLine(Ie.Message);
            }

            try
            {
                int x = 108, y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException De)
            {
                Console.WriteLine(De.Message);
            }

            Console.WriteLine("나머지 일처리 계속...");
            
            string strVal = null;
            //string strVal = "Hello World";
            try
            {
                string splitVal = strVal.Substring(6, 5);
                Console.WriteLine($"{splitVal}");
            }
            catch(NullReferenceException Ne)
            {
                Console.WriteLine(Ne.Message);
            }

            Console.WriteLine("일처리 또 있음..");


        }
    }
}
