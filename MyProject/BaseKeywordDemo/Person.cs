using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseKeywordDemo
{
    internal class Person
    {
        

        public Person(string n,string s)
        {
            Console.WriteLine("Enter the name: "+n);
          
            Console.WriteLine("Enter the address: "+s);
            
        }

       
    }

    class Student : Person
    {
        
        public Student(int r,string sn):base("Mayur","Hingoli")
        {
            Console.WriteLine("Roll NO: "+r);
            Console.WriteLine("School Name: " + sn);
        }
    }

    class Employee : Student
    {
        public Employee(int emp_id,string c_name):base(37,"ZPHSK")
        {
            Console.WriteLine("Emp_id: "+emp_id);
            Console.WriteLine("Company name: " + c_name);
        }
    }

   internal class MainClass
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(101, "Think Quotient");
        }

    }




        
   


        internal class Nib
        {
            string materialType;
            int price;
            public Nib(string materialType, int price)
            {
                this.materialType = materialType;
                this.price = price;
            }
            public void showNib()
            {
                Console.WriteLine(materialType + " " + price);
            }
        }
        internal class Pen
        {
            string color;
            string name, Type;
            Nib nib;

            public Pen(string color, string name, string type, Nib nib)
            {
                this.color = color;
                this.name = name;
                Type = type;
                this.nib = nib;
            }
            public void showPen()
            {
                Console.WriteLine(color + " " + name + " " + Type);
                nib.showNib();
            }
        }
        class Bag
        {
            string Brand, color;
            int price;
            Pen pen;

            public Bag(string brand, string color, int price, Pen pen)
            {
                Brand = brand;
                this.color = color;
                this.price = price;
                this.pen = pen;
            }
            public void showBag()
            {
                Console.WriteLine(Brand + " " + color + " " + price);
                pen.showPen();
            }

            static void Main(string[] args)
            {
                Nib n = new Nib("steel", 20);
                Pen p = new Pen("Blue", "Reynold", "Boll Pen", n);
                Bag b = new Bag("Adidas", "Black", 500, p);
                //n.showNib();
                p.showPen();
                b.showBag();
            }
        }

    }

