using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCopyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] src = { 11, 21, 33, 45, 56 };
            int[] target = new int[src.Length];

            string[] src2 = { "Hello", "World", "~!!" };
            string[] target2 = new string[src2.Length];

            CopyArray<int>(src, target);
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            CopyArray<string>(src2, target2);
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
        }

        // 일반화 메소드
        private static void CopyArray<T>(T[] src, T[] target)
        {
            // throw new NotImplementedException();
            for (int i = 0; i < src.Length; i++)
                target[i] = src[i];
        }
    }
}
