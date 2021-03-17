# C# 추가 학습

microsoft C# 가이드, 닷넷정복(책)을 참고하였습니다.</br>
(https://docs.microsoft.com/ko-kr/dotnet/csharp/ , http://soen.kr/)

### 프로그램(Program) vs 프로세스(Process) vs 스레드(Thread)

------------
#### 프로그램(Program)
"어떤 작업을 위해 실행 할 수 있는 파일"을 의미합니다.

------------
#### 프로세스(Process)
"컴퓨터에서 연속적으로 실행되고 있는 컴퓨터 프로그램"을 의미합니다.</br>
(메모리에 올라와 실행되고 있는 프로그램의 인스턴스 or 운영체제로부터 시스템 자원을 할당받는 작업의 단위</br>
, 동적인 개념으로는 실행된 프로그램을 의미)</br>

__- 프로세스의 개요__

> 프로세스는 각각 독립된 메모리 영역(Code, Data, Stack, Heap의 구조)을 할당 받는다.
> 
> 기본적으로 프로세스당 최소 1개의 스레드(메인 스레드)를 가지고 있다.
> 
> 각 프로세스는 별도의 주소 공간에서 실행되며, 한 프로세스는 다른 프로세스의 변수나 자료 구조에 접근할 수 없다.
> 
> 한 프로세스가 다른 프로세스의 자원에 접근하려면 프로세스 간의 통신(IPC, Inter-Process Communication)을 사용해야 한다.
> (ex : 파이프, 파일, 소켓 등을 이용한 통신 방법을 이용)

------------
#### 스레드(Thread)
"프로세스 내에서 실행되는 여러 흐름의 단위"를 의미합니다.</br>
(프로세스의 특정한 수행 경로, 프로세스가 할당받은 자원을 이용하는 실행의 단위,</br>
Light Weight Process라고도 함)</br>

__- 스레드의 개요__

> 스레드는 프로세스 내에서 각각 Stack만 따로 할당받고 Code, Data, Heap 영역은 공유한다.
> 
> 스레드는 한 프로세스 내에서 동작하는 여러 실행의 흐름으로, 프로세스 내의 주소 공간이나</br>
> 자원들(힙 공간 등)을 같은 프로세스 내에서 스레드끼리 공유하면서 실행된다.
> 
> 같은 프로세스 안에 있는 여러 스레드들은 같은 힙공간을 공유한다.</br>
> (반면에 프로세스는 다른 프로세스의 메모리에 직접 접근할 수 없다.)
> 
> 각각 스레드는 별도의 레지스터와 스택을 갖고 있지만, 힙 메모리는 서로 읽고 쓸 수 있다.
>
> 한 스레드가 프로세스 자원을 변경하면, 다른 이웃 스레드(sibiling thread)도 그 변경 결과를 즉시 볼 수 있다.
> 
> 1개의 프로세스를 3개의 스레드로 구성한 것은 3개의 프로세스와 비슷한 처리속도를 낸다. (주관적)
> 

------------
### Thread 클래스
스레드를 만들고 제어하며, 해당 속성을 설정하고, 상태를 가져옵니다.

프로세스가 시작되면 공용 언어 런타임 애플리케이션 코드를 실행하는 단일 포그라운드 스레드를 자동으로 만듭니다.</br>
프로세스는 주 포그라운드 스레드와 함께 프로세스와 관련된 프로그램 코드의 일부를 실행하는 스레드를 하나 이상 만들 수 있습니다.</br>
이러한 스레드는 포그라운드 또는 백그라운드에서 실행할 수 있습니다. 또한 클래스를 사용하여 ThreadPool 공용 언어 런타임에 의해</br>
관리되는 작업자 스레드에 대해 코드를 실행할 수 있습니다.

스레드가 클래스 생성자에서 실행할 메서드를 나타내는 대리자를 제공하여 스레드를 시작합니다. 그런 다음  Start()메서드를 호출하여 실행을 시작합니다.</br>

```csharp
using System;
using System.Threading;

// 간단 스레드 예제
public class ThreadExample {
    // The ThreadProc method is called when the thread starts.
    // It loops ten times, writing to the console and yielding
    // the rest of its time slice each time, and then ends.
    public static void ThreadProc() {
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("ThreadProc: {0}", i);
            // Yield the rest of the time slice.
            Thread.Sleep(0);
        }
    }

    public static void Main() {
        Console.WriteLine("Main thread: Start a second thread.");
        // The constructor for the Thread class requires a ThreadStart
        // delegate that represents the method to be executed on the
        // thread.  C# simplifies the creation of this delegate.
        Thread t = new Thread(new ThreadStart(ThreadProc));

        // Start ThreadProc.  Note that on a uniprocessor, the new
        // thread does not get any processor time until the main thread
        // is preempted or yields.  Uncomment the Thread.Sleep that
        // follows t.Start() to see the difference.
        t.Start();
        //Thread.Sleep(0);

        for (int i = 0; i < 4; i++) {
            Console.WriteLine("Main thread: Do some work.");
            Thread.Sleep(0);
        }

        Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
        t.Join();
        Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
        Console.ReadLine();
    }
}
```


[이전](https://github.com/1994wjdwodbs/StudyCSharp21)
