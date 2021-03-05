using System;
using System.Threading;

namespace SideTaskApp
{
    class Program
    {
        class SideTask
        {
            int Count { get; set; }

            public SideTask(int count)
            {
                this.Count = count;
            }

            public void CountDown()
            {
                try
                {
                    while (Count > 0)
                    {
                        Console.WriteLine($"{Count} 남음");
                        Count--;
                        Thread.Sleep(10);
                    }
                    Console.WriteLine($"Count : {Count}"); // 0
                }
                catch (ThreadAbortException ex)
                {
                    Console.WriteLine("스레드 예외발생 : " + ex.Message);
                    Thread.ResetAbort();
                }
            }
        }
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false; // 이 스레드가 종료되기 전까지는 프로세스가 끝나지 않음
            // true : 백그라운드 스레드가 돌고있는 상태에도 메인스레드가 끝나면 백그라운드 스레드도 같이 종료

            SideTask task2 = new SideTask(200);
            Thread th2 = new Thread(task2.CountDown); // IsBackground (default) : false

            Console.WriteLine("스레드 시작!");
            th.Start();

            Thread.Sleep(1000);

            Console.WriteLine("임의 종료!");
            th.Abort();

            Console.WriteLine("종료 대기");
            th.Join();

            Console.WriteLine("스레드/프로세스 종료");
        }
    }
}
