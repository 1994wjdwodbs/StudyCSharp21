using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList array = new ArrayList();

            array.Add(80);
            array.Add(74);
            array.Add(81);
            array.Add(90);
            array.Add(34);

            int x = array.IndexOf(81);
            array.Insert(x, 50);
            Console.WriteLine("81위치에 50 추가");

            // Console.WriteLine($"{array.IndexOf(81)}");
            foreach (var item in array)
                Console.WriteLine($"{item}");

            array.Remove(90);
            Console.WriteLine("90 삭제");

            foreach (var item in array)
                Console.WriteLine($"{item}");

            array.Sort();

            Console.WriteLine("정렬");
            foreach (var item in array)
                Console.WriteLine($"{item}");
        }
    }
}
