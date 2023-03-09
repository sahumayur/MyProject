using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.AbstractInteface
{
    //Task1
    internal abstract class Car
    {
        
        public abstract void Run();
    } 
    
    internal abstract class Suv:Car
    {
       
        public abstract void Maintainance();
    }

    internal class Vahicle:Suv
    {
       

        public override void Maintainance()
        {
            // throw new NotImplementedException();

            Console.WriteLine("In the SUV ");
        }

        public override void Run()
        {
            //throw new NotImplementedException();
            Console.WriteLine("In the Car");
        }
    }

    internal class Main1
    {
        static void Main(string[] args)
        {
            Vahicle v = new Vahicle();
            v.Run();
            v.Maintainance();
        }
    }

    //Task2
    internal abstract class Addition
    {
        public int a;
    }
    internal interface INumable
    {
        static int b;
    }
    internal class Result : Addition, INumable
    {
        public void Display(int res)
        {
            Console.WriteLine("Addition: "+res);
        }
    }

    internal class Operation
    {
        static void Main(string[] args)
        {
            Result res = new Result();
            Console.WriteLine("Enter the value of A ");
            res.a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of B: ");
            INumable.b=int.Parse(Console.ReadLine());
            int c=res.a+INumable.b;
            res.Display(c);
        }
    }

    //Task3

    internal interface ILaptopable
    {
        public static string brand;
        public static int size;
        public void DisplayInfo();
    }

    internal interface IConfigurationable : ILaptopable
    {
        public static int ram;
        public static int ssd;
        public static string os;
        public void ShowInfo();

    }

    internal class Merge:IConfigurationable
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Name of Brand: "+ILaptopable.brand);
            Console.WriteLine("Screen size: " + ILaptopable.size);
        }

        public void ShowInfo()
        {
            Console.WriteLine("Size of RAM is: "+IConfigurationable.ram);
            Console.WriteLine("Size of SSD is: "+IConfigurationable.ssd);
            Console.WriteLine("Operating System is: " + IConfigurationable.os);
        }
    }

    internal class Operate
    {
        static void Main(string[] args)
        {
            Merge m = new Merge();

            Console.WriteLine("Enter the laptop brand name:");
            ILaptopable.brand = Console.ReadLine();
            Console.WriteLine("Enter the size in between 12'' to 16'': ");
            ILaptopable.size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Ram: ");
            IConfigurationable.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ssd: ");
            IConfigurationable.ssd= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the os: ");
            IConfigurationable.os = Console.ReadLine();

            m.DisplayInfo();
            m.ShowInfo();
        }
    }
}
