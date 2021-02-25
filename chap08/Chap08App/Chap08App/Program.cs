using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap08App
{
    interface ILogger
    {
        void WriteLog(string msg);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} log : {msg}");
        }
    }

    // 제어 역전(반전) 예시용 커스텀 클래스 (반자동 실행)
    class CustomLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} log : {msg}\a\a");
        }
    }

    class ClimateLogger
    {
        private ILogger logger;
        //public ClimateLogger()
        //{
        //    logger = new ConsoleLogger();
        //}
        public ClimateLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Start()
        {
            while (true)
            {
                Console.Write("물 온도 입력 : ");
                string temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                    break;

                logger.WriteLog("현재온도 : " + temp);
            }
        }
    }

    class Base_
    { }

    class Derived_ : Base_
    { }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그출력");

            // 파생 클래스에서 구현되었기 때문에 가능!!
            ILogger i = new ConsoleLogger();
            i.WriteLog("로그출력2");

            // [제어의 역전(반전)] // 반자동
            /*
            프로그래머가 작성한 프로그램이 재사용 라이브러리의 흐름 제어를 받게 되는 소프트웨어 디자인 패턴을 말한다. 
            줄여서 IoC(Inversion of Control)이라고 부른다. 전통적인 프로그래밍에서 흐름은 프로그래머가 작성한 프로그램이 
            외부 라이브러리의 코드를 호출해 이용한다. 하지만 제어 반전이 적용된 구조에서는 외부 라이브러리의 코드가 
            프로그래머가 작성한 코드를 호출한다. 
            
            설계 목적상 제어 반전의 목적은 다음과 같다.

            작업을 구현하는 방식과 작업 수행 자체를 분리한다.
            모듈을 제작할 때, 모듈과 외부 프로그램의 결합에 대해 고민할 필요 없이 모듈의 목적에 집중할 수 있다.
            다른 시스템이 어떻게 동작할지에 대해 고민할 필요 없이, 미리 정해진 협약대로만 동작하게 하면 된다.
            모듈을 바꾸어도 다른 시스템에 부작용을 일으키지 않는다.
            */
            ClimateLogger clogger = new ClimateLogger(new ConsoleLogger());
            clogger.Start();


            Base_ B = new Base_();
            Derived_ D = new Derived_();

            if(B is Derived_) // Base is Derived : False
            {
                Console.WriteLine("Base is Derived");
            }
            if(D is Base_) // Derived is Base : True
            {
                Console.WriteLine("Derived is Base");
            }


        }
    }
}
