using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string msg)
        {
            Console.WriteLine($"{DateTime.Now} : {msg}");
        }

    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleFormatLogger : IFormattableLogger
    {
        public void WriteLog(string format, params object[] args)
        {
            // throw new NotImplementedException();
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            // throw new NotImplementedException();
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그 메시지");

            // 파생 클래스에서 구현되었기 때문에 가능!!
            ILogger ilogger = new ConsoleLogger();
            ilogger.WriteLog("로그 메시지");

            // 인터페이스를 상속받은 인터페이스를 구현한 클래스
            IFormattableLogger ilogger2 = new ConsoleFormatLogger();
            ilogger2.WriteLog("{0} * {1} = {2}", 3, 4, 3 * 4);
        }
    }
}
