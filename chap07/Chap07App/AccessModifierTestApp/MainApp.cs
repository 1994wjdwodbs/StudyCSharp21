using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        // 접근 한정자 default값 : private
        // public, protected, private, interval (빈도 순으로 많이 쓰임)
        private int temp; // 물온도

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 일정 온도를 벗어났습니다. 다시 셋팅해주세요");
                SetTemp(59);
                return;
            }
            this.temp = temp;
        }

        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            Console.WriteLine($"현재 온도는 {kitturami.GetTemp()}°C 입니다.");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);

            string[] args2 = new string[2];
            MainApp.Main(args2);

            if(kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler();
            }
        }
    }
}
