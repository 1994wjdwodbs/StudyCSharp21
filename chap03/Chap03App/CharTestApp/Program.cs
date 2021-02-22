using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch1 = 't';
            char ch2 = '\t';
            char ch3 = '\n';
            char ch4 = '\0';
            Console.WriteLine($"{ch1},{ch2},{ch3},{ch4}");
            // 문자열
            string str1 = "\a\tHello, \tWorld!";
            Console.WriteLine($"{str1}");

            bool isCorrect = false;
            if (isCorrect)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine(isCorrect);
        }
    }
}
