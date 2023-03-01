using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.OOPS
{
    internal class Product1
    {
        string product_name;
        int product_price;
        int product_quantity;


        public void Getdata(string name , int price,int quantity)
        {
            product_name= name;
            product_price= price;
            product_quantity= quantity;
        }

        public void Putdata()
        {
            Console.WriteLine("Product Name is: "+product_name);
            Console.WriteLine("Product price is: "+product_price);
            Console.WriteLine("Product quantity is: " + product_quantity);
        }

        static void Main(string[] args)
        {
            Product1 prod=new Product1();
            Console.WriteLine("Enter product name: ");
            prod.product_name = Console.ReadLine();
            Console.WriteLine("Enter product price: ");
            prod.product_price=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter product quantity: ");
            prod.product_quantity=int.Parse(Console.ReadLine());
            prod.Getdata(prod.product_name,prod.product_price,prod.product_quantity);
            prod.Putdata();
        }
    }

    internal class Factor1
    {
        int num;
        public void GetDigit(int digit)
        {
            num=digit;
            
        }
        public void PutDigit()
        {
            for (int i = 1; i <= num; i++)
            {
                if(num%i==00)
                {
                    Console.Write("\t"+i);
                }

            }

            Console.WriteLine( );
        }
        static void Main(string[] args)
        {
            Factor1 factor1= new Factor1();
            Console.WriteLine("Enter the number: ");
            factor1.num = int.Parse(Console.ReadLine());

            factor1.GetDigit(factor1.num);
            factor1.PutDigit();
        }
    }

    internal class Student
    {
        private const double V = 1.0;
        int id;
        string name;
        int m1,m2,m3;
        int total = 0;
        float per = 1;

        public void GetDetail(int s_id, string s_name, int s_m1, int s_m2, int s_m3)
        {
            id=s_id;
            name = s_name;
            m1 = s_m1;
            m2 = s_m2;
            m3 = s_m3;
        }

        public void Operation()
        {
            total=m1+m2+m3;
            per=total/3;
        }

        public void DisplayData()
        {
            Console.WriteLine("Name of student is: " + name) ;
            Console.WriteLine("Id of student is: " + id);
            Console.WriteLine("Percentage: " + per);
        }

        static void Main(string[] args)
        {
            Student stud = new Student();

            Console.WriteLine("Enter the Name of student: ");
            stud.name=Console.ReadLine();
            Console.WriteLine("Enter the id of student: ");
            stud.id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of M1: ");
            stud.m1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of M2");
            stud.m2= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the marks of M3: ");
            stud.m3= int.Parse(Console.ReadLine());

            stud.GetDetail(stud.id,stud.name,stud.m1,stud.m2,stud.m3);
            stud.Operation();
            stud.DisplayData();
        }

    }
}
