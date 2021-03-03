using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!\n");
            sb.Append("My name is Hugo.\n");
            sb.Append("I'm 47years old.\n");
            sb.Append("Book price is 30,000won.\n");
            sb.Insert(6, "New ");

            Console.WriteLine(sb);
        }
    }
}
