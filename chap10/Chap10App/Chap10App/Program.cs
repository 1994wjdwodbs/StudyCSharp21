using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Program
    {
        class Test
        { }

        static void Main(string[] args)
        {
            int[] array = new int[5];
            var array2 = new int[] { 80, 84, 81, 90, 34 };
            array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            var idx = 0;
            foreach (var item in array)
                Console.WriteLine($"{idx++}번째 값 : {item}");

            // Test test = new Test();
            // test.
            Console.WriteLine($"Array type is {array.GetType()}");
            Console.WriteLine($"Base type of Array is {array.GetType().BaseType}");

            //System.Array
            System.Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            Console.WriteLine($"81이 있을법한 인덱스 x = {Array.BinarySearch<int>(array, 81)}");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            idx = Array.IndexOf(array, 34);
            Console.WriteLine($"34의 인덱스 : {idx}");


            Array.Clear(array, 3, 2);
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine($"{i}번째 값 : {array[i]}");
        }
    }
}
