using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassApp
{
    class Program
    {
        class Array_Generic<T>
        {
            private T[] Array;
            private int Length
            {
                get { return Array.Length; }
            }

            public Array_Generic()
            {
                Array = new T[10];
            }

            public T GetElement(int index)
            {
                return Array[index];
            }
        }

        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();


        }
    }
}
