using System;
using System.Threading;

namespace Chap19App
{
    class Program
    {
        static void DoSomething()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);
            }
        }

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(DoSomething));
            Thread thread2 = new Thread(DoSomething);

            Console.WriteLine("스레드 시작");
            thread1.Start();
            thread2.Start();

            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Main thread : {i}");
                Thread.Sleep(10);
                try
                {
                    if (i == 25)
                        thread1.Abort();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                }
            }

            Console.WriteLine("스레드 종료 대기...");
            thread1.Join();
            thread2.Join();

            Console.WriteLine("프로세스 종료...");
        }
    }
}
