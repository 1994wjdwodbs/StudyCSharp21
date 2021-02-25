using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap09App
{
    class MyClass
    {
        private int iValue; 
        // 0 ~ 120 값만 입력받는 멤버변수
        private double dZeta;
        private float fPng;
        private string strVal;
        private int inCode;

        // 프로퍼티
        public int IValue
        {
            get 
            {
                return this.iValue;
            }
            set 
            {
                // 여기서 말하는 value는 setXXX(int value)를 말함
                if (value < 0)
                    this.iValue = 0;
                else if (value > 120)
                    this.iValue = 120;
                else
                    this.iValue = value;
            }
        }

        public MyClass(int iValue)
        {
            IValue = iValue;
        }

        public void PrintValue()
        {
            Console.WriteLine($"값은 {this.iValue}");
        }
    }

    class Base_ 
    { 
        public void Out()
        {
            Console.WriteLine("B()");
        }
    }

    class Derived_ : Base_
    {
        public new void Out()
        {
            Console.WriteLine("D()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(1200);
            myClass.PrintValue();

            myClass.IValue = 108;
            myClass.PrintValue();
            Console.WriteLine($"현재 온도는 {myClass.IValue}°C 입니다.");

            Base_ B = new Derived_();
            B.Out();

            // Derived_ D = (Derived_) new Base_();
            // D.Out();

        }
    }
}
