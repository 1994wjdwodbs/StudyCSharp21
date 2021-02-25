using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceApp
{

    interface IRunnable // 자동차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            // throw new NotImplementedException();
            Console.WriteLine("날아!");
        }

        public void Run()
        {
            // throw new NotImplementedException();
            Console.WriteLine("달려!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar d = new DroneCar();
            if (d is IRunnable)
                Console.WriteLine("d is IRunnable");
            if (d is IFlyable)
                Console.WriteLine("d is IFlyable");

            d.Run();
            d.Fly();

            Console.WriteLine("자동차(Interface)");
            IRunnable IR = new DroneCar();
            IR.Run();
            // IR.Fly(); is error

            Console.WriteLine("비행기(Interface)");
            IFlyable IF = new DroneCar();
            IF.Fly();
            // IF.Run(); is error

        }
    }
}
