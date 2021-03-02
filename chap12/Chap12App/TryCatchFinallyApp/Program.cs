using System;

namespace TryCatchFinallyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요 : ");
                string temp = Console.ReadLine(); // string으로 입력받음
                int divisor = int.Parse(temp);

                Console.Write("피제수를 입력하세요 : ");
                temp = Console.ReadLine();
                int dividend = int.Parse(temp);

                Console.WriteLine($"{dividend} / {divisor} = {Divide(dividend, divisor)}");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"미구현 예외 발생 : {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"입력값 예외 발생 : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외 발생 : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("예외 발생 유무와 상관없이 늘 실행! try문 내부 리소스 해제...");
            }
        }

        private static Object Divide(int dividend, int divisor)
        {
           
            // throw new NotImplementedException();
            if (divisor == 0)
                throw new DivideByZeroException("제수 : 0 입력됨");
            return (dividend / divisor);
        }
    }
}
