using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int v1 = 30, v2 = 40;
            //int result = v1 + v2;
            //Console.WriteLine("Result : " + result);
            sbyte sbMinVal = sbyte.MinValue;
            sbyte sbMaxVal = sbyte.MaxValue;
            Console.WriteLine($"sbyte의 최소값 : {sbMinVal}, 최대값 : {sbMaxVal}\n");
            byte bMinVal = byte.MinValue;
            byte bMaxVal = byte.MaxValue;
            Console.WriteLine($"byte의 최소값 : {bMinVal}, 최대값 : {bMaxVal}\n");
            short shMinVal = short.MinValue;
            short shMaxVal = short.MaxValue;
            Console.WriteLine($"short의 최소값 : {shMinVal}, 최대값 : {shMaxVal}\n");
            ushort ushMinVal = ushort.MinValue;
            ushort ushMaxVal = ushort.MaxValue;
            Console.WriteLine($"ushort의 최소값 : {ushMinVal}, 최대값 : {ushMaxVal}\n");
            int inMinVal = int.MinValue;
            int inMaxVal = int.MaxValue;
            Console.WriteLine($"int의 최소값 : {inMinVal}, 최대값 : {inMaxVal}\n");
            long longMinVal = long.MinValue;
            long longMaxVal = long.MaxValue;
            Console.WriteLine($"long의 최소값 : {longMinVal}, 최대값 : {longMaxVal}\n");
            ulong ulongMinVal = ulong.MinValue;
            ulong ulongMaxVal = ulong.MaxValue;
            Console.WriteLine($"ulong의 최소값 : {ulongMinVal}, 최대값 : {ulongMaxVal}\n");
            decimal dcMinVal = decimal.MinValue;
            decimal dcMaxVal = decimal.MaxValue;
            Console.WriteLine($"decimal의 최소값 : {dcMinVal}, 최대값 : {dcMaxVal}\n");

        }
    }
}
