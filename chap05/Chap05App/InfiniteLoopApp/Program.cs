using System;

namespace InfiniteLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            
            short idx = 0;
            while(true) // for (; true;)
            {
                Console.WriteLine($"idx = {idx++}");

                //if (idx == short.MaxValue)
                //    break;
            }
        }
    }
}
