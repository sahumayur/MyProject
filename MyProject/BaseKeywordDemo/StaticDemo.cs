using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseKeywordDemo
{
    internal class StaticDemo
    {
        static int x; static int y;
        public StaticDemo()
        {
            x++;
            Console.WriteLine(x);
        }

        public static void Calculate(int z)
        {
            y = z;
            Console.WriteLine("X+Y: " + (x + y));
        }

        public void Display()
        {
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
        }
    }

    internal class Demo
    {

        static void Main(string[] args)
        {


            StaticDemo sd = new StaticDemo();
            StaticDemo sd1 = new StaticDemo();
            StaticDemo sd2 = new StaticDemo();

            StaticDemo.Calculate(3);

            sd2.Display();

        }
    }

    internal class Animal
    {
        public int legs;

        public void Run(string name)
        {
            //Console.WriteLine(name);
            Console.WriteLine(name+" is Running..");
        }

        public Animal(string name)
        {
            Console.WriteLine("Constructor Animal Name: "+name);
        }
    }
    class Dog :Animal
    {
        public Dog(string name):base("Cat")
        {
            Console.WriteLine(name+" is sleeping");
        }
        int legs = 4;
       public void ShowLegs()
        {
            base.Run("Tiger");
            Console.WriteLine(base.legs);
            Console.WriteLine("Legs: "+legs);

            //base.Run(Tiger);
        }
    }

    internal class BaseKeyword
    {
        static void Main(String[] args)
        {
            Dog dog = new Dog("Lion");
            dog.ShowLegs();
            //dog.Run("Tiger");
        }
    }

}
