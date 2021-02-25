using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    // 생일정보 클래스
    class BirthdayInfo
    {
        private string name;
        private DateTime birthday;

        // 프로퍼티
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // 프로퍼티
        public DateTime BBirthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthDay()
        {
            return this.birthday;
        }
        public void SetBirthDay(DateTime birthday)
        {
            this.birthday = birthday;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo info = new BirthdayInfo();
            info.SetName("홍길동");
            info.SetBirthDay(new DateTime(1990, 1, 8));

            Console.WriteLine($"이름 : {info.GetName()}");
            Console.WriteLine($"생일 : {info.GetBirthDay()}");

            BirthdayInfo info2 = new BirthdayInfo();
            info2.Name = "홍길순";
            Console.WriteLine($"이름 : {info2.Name}");
            info2.BBirthday = new DateTime(1992, 3, 16);
            Console.WriteLine($"생일 : {info2.BBirthday}");
        }
    }
}
