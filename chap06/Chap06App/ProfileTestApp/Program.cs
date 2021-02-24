using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.PrintProfile("성명건", "010-6683-7732");

            if(Program.PrintProfile(null, "010-1111-2222") == -1)
                Console.WriteLine("프로필 출력 도중 오류가 발생했습니다.");

            Program.PrintProfile(phone: "010-9999-9999", name: "홍길동");
            Program.PrintProfile(name: "최백호");
        }

        public static int PrintProfile(string name, string phone = "010-1234-5678")
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1;
            }

            Console.WriteLine($"이름 : {name}, 폰번호 : {phone}");
            return 0;
        }
    }
}
