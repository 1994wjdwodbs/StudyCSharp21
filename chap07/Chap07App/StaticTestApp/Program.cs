using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {

        public static int number;
        public float fnum;

        public float ProcSomething()
        {
            Console.Write($"{number}, 먼가를 한다.");
            return 1.0f;
        }
    }
    public class MyNonStaticClass
    {
        private int a;
        public static int b = 1;
        // static(정적) 생성자, 싱글톤에 사용됨
        // 정적 생성자는 해당 클래스의 멤버에 대한 첫 번째 참조 (인스턴스 생성 또는 자체 정적 메서드 / 클래스 속성) 직전에 실행되도록 보장됨
        /*
        클래스의 정적 생성자는 주어진 응용 프로그램 도메인에서 최대 한 번만 실행됩니다. 
        정적 생성자의 실행은 응용 프로그램 도메인 내에서 발생하는 다음 이벤트 중 첫 번째에 의해 트리거됩니다.
        클래스의 인스턴스가 생성됩니다.
        클래스의 모든 정적 멤버가 참조됩니다. 

        CLI 사양 (ECMA 335)은 섹션 8.9.5에 다음과 같이 명시되어 있습니다.

        유형에는 유형 이니셜 라이저 방법이있을 수도 있고 없을 수도 있습니다.
        타입은 타입-이니셜 라이저 메소드에 대해 완화 된 의미를 갖는 것으로 지정 될 수 있습니다 (아래의 편의를 위해이 완화 된 의미를 BeforeFieldInit라고 부릅니다).
        BeforeFieldInit로 표시된 경우 해당 유형에 대해 정의 된 정적 필드에 대한 첫 번째 액세스 시점 또는 그 이전에 유형의 이니셜 라이저 메서드가 실행됩니다.
        BeforeFieldInit로 표시되지 않은 경우 해당 유형의 이니셜 라이저 메서드는 다음 위치에서 실행됩니다 (즉, 트리거 됨).
        해당 유형의 정적 또는 인스턴스 필드에 대한 첫 번째 액세스
        해당 유형의 정적, 인스턴스 또는 가상 메서드의 첫 번째 호출
         */
        static MyNonStaticClass()
        {
            Console.WriteLine("Inside static constructor.");
            b = 11;
        }

        public void MyNonStaticMethod()
        {
            Console.WriteLine("Non-static method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // MyNonStaticClass mnsObj1; // = new MyNonStaticClass();
            Console.WriteLine($"{MyNonStaticClass.b}");
            //MyNonStaticClass mnsObj2 = new MyNonStaticClass();
            //Console.WriteLine($"{MyNonStaticClass.b}");
            //MyNonStaticClass mnsObj3 = new MyNonStaticClass();
            //Console.WriteLine($"{MyNonStaticClass.b}");
        }
    }
}
