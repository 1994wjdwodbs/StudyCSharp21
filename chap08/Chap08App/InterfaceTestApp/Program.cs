using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    /*class Ridable // 탈 것
    {
        public virtual void Ride()
        {
            Console.WriteLine("탈것!");
        }
    }*/
    interface ICar
    {
        void Run();
        void Ride();
    }

    interface IPlane
    {
        void Fly();
        void Ride();
    }

    class Car : ICar // : Ridable
    {
        public void Run()
        {
            Console.WriteLine("Run!");
        }

        public void Ride()
        {
            // base.Ride();
            this.Run();
        }
    }

    class Plane : IPlane // : Ridable
    {
        public void Fly()
        {
            Console.WriteLine("Fly!");
        }

        public  void Ride()
        {
            // base.Ride();
            this.Fly();
        }
    }

    /*class : Car, Plane // 다중 상속 불가
    {
    }*/

    class DroneCar : ICar, IPlane
    {
        public void Run()
        {
            Console.WriteLine("드론카 달리다!");
            // throw new NotImplementedException();
        }
        public void Fly()
        {
            Console.WriteLine("드론카 날다!");
            // throw new NotImplementedException();
        }
        public void Ride()
        {
            Run();
            Fly();
            // throw new NotImplementedException();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            DroneCar dreamCar = new DroneCar();
            dreamCar.Ride();

        }
    }
}
