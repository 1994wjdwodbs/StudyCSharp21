using System;
using System.Threading;

namespace ThreadStateApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            //
            // 요약:
            //     The thread has been started and not yet stopped.
            // Running = 0,
            //
            // 요약:
            //     The thread is being requested to stop. This is for internal use only.
            // StopRequested = 1,
            //
            // 요약:
            //     The thread is being requested to suspend.
            // SuspendRequested = 2,
            //
            // 요약:
            //     The thread is being executed as a background thread, as opposed to a foreground
            //     thread. This state is controlled by setting the System.Threading.Thread.IsBackground
            //     property.
           //  Background = 4,
            //
            // 요약:
            //     The System.Threading.Thread.Start method has not been invoked on the thread.
            // Unstarted = 8,
            //
            // 요약:
            //     The thread has stopped.
            // Stopped = 16,
            //
            // 요약:
            //     The thread is blocked. This could be the result of calling System.Threading.Thread.Sleep(System.Int32)
            //     or System.Threading.Thread.Join, of requesting a lock - for example, by calling
            //     System.Threading.Monitor.Enter(System.Object) or System.Threading.Monitor.Wait(System.Object,System.Int32,System.Boolean)
            //     - or of waiting on a thread synchronization object such as System.Threading.ManualResetEvent.
            // WaitSleepJoin = 32,
            //
            // 요약:
            //     The thread has been suspended.
            // Suspended = 64,
            //
            // 요약:
            //     The System.Threading.Thread.Abort(System.Object) method has been invoked on the
            //     thread, but the thread has not yet received the pending System.Threading.ThreadAbortException
            //     that will attempt to terminate it.
            // AbortRequested = 128,
            //
            // 요약:
            //     The thread state includes System.Threading.ThreadState.AbortRequested and the
            //     thread is now dead, but its state has not yet changed to System.Threading.ThreadState.Stopped.
            // Aborted = 256
            Console.WriteLine($"{state} : {(int)state}");
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
                PrintState((ThreadState) ((int) Math.Pow(2.0d, (double) i)));
        }
    }
}
