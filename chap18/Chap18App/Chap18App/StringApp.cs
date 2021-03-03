using System;

namespace Chap18App
{
    class StringApp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("문자열 연습 시작");

            string msg1 = null;
            if(msg1 == null)
                Console.WriteLine("msg1 : " + msg1);
            string msg2 = "";
            if (msg2 == null)
                Console.WriteLine("msg2 : " + msg2);
            string msg3 = string.Empty;
            if (msg3 == null)
                Console.WriteLine("msg3 : " + msg3);

            string oldPath = "C:\\Program Files\\Bandizip"; // 경로 표시
            string newPath = @"C:\\Program Files\Bandizip"; // 경로 표시

            string greeting = "Hello World!";
            // var는 지역 변수에만 사용 가능합니다.
            // 클래스의 멤버 변수로 사용이 불가능합니다.
            var temp1 = "Local Variable String";

            char[] letters = { 'H', 'E', 'l', 'l', 'o' };
            // Console.WriteLine(sizeof(char) * letters.Length);

            string s1 = "Hello ";
            string s2 = "World!";
            s1 += s2;
            Console.WriteLine($"{s1}");

            string s3 = "Hello ";
            string s4 = s3;
            s3 += "World!";
            Console.WriteLine($"{s4}");

            // Carriage Return, New Line
            string row = "ROW\rrow\r\nRow3";
            Console.Write(row);

            Console.Write("\n" + "Row111" + Environment.NewLine + "Row222" + Environment.NewLine + "Row333");

            string oldLine = "Test" +
                "Test2" +
                "Test3";
            string multiLine =
                @"New Test
These are multiline
end.";
            Console.WriteLine('\n' + oldLine);
            Console.WriteLine('\n' + multiLine);

            Console.WriteLine($"\U0001F47D"); // \U0001F47D == 👽 (Emoji)

            var book =
                (
                    lastName: "박",
                    firstName: "상현",
                    title: "이것이 C#이다",
                    company: "한빛미디어",
                    releaseDate: "2018-07-01",
                    price: 30000,
                    page: 812
                );
            
            Console.WriteLine($"{book.lastName}{book.firstName} 저자의 {book.title} ({book.company})");
            Console.WriteLine($"{DateTime.Parse(book.releaseDate).ToString("yyyy년 MM dd일")} 출간," +
                $" 페이지수 {book.page}, 금액:{book.price:#,###}원");

            string s5 = " Visual C# Express ";
            Console.WriteLine(s5.Trim());

            var s6 = s5.Trim();
            Console.WriteLine(s6.Substring(7));
            Console.WriteLine(s6.Substring(7, 2));

            Console.WriteLine(s6.Replace("C#", "Basic"));
            Console.WriteLine(s6.Replace(s6.Substring(7, 2), "Basic"));

            Console.WriteLine(s6.IndexOf("C"));
            Console.WriteLine(s6.Length);
            Console.WriteLine(s6.ToLower());
            Console.WriteLine(s6.ToUpper());

            // null 문자열, 빈 문자열
            Console.WriteLine("null/빈문자열 처리");

            string str = "hello";
            string nullstr = null;
            string emptystr = string.Empty; // == " " or 선언만 해도 됨;

            Console.WriteLine(str + nullstr); // hello 출력
            Console.WriteLine(nullstr == emptystr);
            try
            {
                Console.WriteLine(nullstr.Equals(emptystr)); // 예외발생
                Console.WriteLine(emptystr.Length); // 0
                Console.WriteLine(nullstr.Length); // 예외발생
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

        }
    }
}
