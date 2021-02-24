using System;

namespace Chap07App
{
    public class Person
    {
        // Constructor that takes no arguments:
        public Person() : base() // 부모 클래스의 생성자
        {
            Name = "unknown";
        }

        // Constructor that takes one argument:
        public Person(string name)
        {
            // base : 부모클래스 접근자
            Console.WriteLine(base.ToString());
            Name = name;
        }

        // Auto-implemented readonly property:
        public string Name { get; }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString()
        {
            return Name;
        }
    }

    class Cat
    {
        public string Name; // 이름
        public string Color; // 색상

        public Cat() {
            Console.WriteLine("Cat()");
        }
        public Cat(string Name)
        { this.Color = ""; }
        // this 키워드
        public Cat(string Name, string color) : this() // 생성자 재활용
        {
            this.Name = Name;
            this.Color = color;
        }
        public void Meow()
        {
            Console.WriteLine($"{this.Name} : 야옹!");
        }
    }
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cat cat1 = new Cat();
            cat1.Name = "야옹이"; 
            cat1.Color = "하얀색";
            cat1.Meow();

            Cat cat2 = new Cat("개", "blue");
            Console.WriteLine(cat2.Name);

            var person1 = new Person();
            Console.WriteLine(person1.Name);

            // Call the constructor that has one parameter.
            var person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.ToString());
            // Get the string representation of the person2 instance.
            Console.WriteLine(person2 + "\n");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
