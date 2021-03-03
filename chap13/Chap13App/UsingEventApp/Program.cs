using System;

namespace UsingEventApp
{
    // 메시지 받아서 처리하는 대리자 선언
    delegate void EventHandler(string message);
    
    // 이벤트 선언, 사용하는 객체
    class CustomNotifier
    {
        public event EventHandler SomethingHappend;

        public void DoSomething(int number)
        {
            int count = 0; // 박수 횟수
            string total_str = null;

            for(int tmp = number; tmp != 0; tmp = tmp / 10)
            {
                if (tmp > 0 && (tmp % 10) % 3 == 0) // 3, 6, 9
                    count++;
            }
            for (int i = 0; i < count; i++)
                total_str += '짝'; //Console.Write("짝");
            if (count == 0)
            {
                if (number % 3 == 0) // 3의 배수 카운트
                    total_str += '짝'; //Console.Write("짝");
                else // 이도 저도 아닌 경우, 숫자 출력
                    total_str += number.ToString();
            }
            total_str += '!';

            // 대리자에 등록된 함수에 total_str 인수 전달 및 호출
            SomethingHappend(total_str);
        }
    }

    class Program
    {
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            // 메서드와 이벤트를 연결
            notifier.SomethingHappend += new EventHandler(MyHandler);

            for (int i = 1; i <= 1000; i++)
                notifier.DoSomething(i);
        }
    }
}
