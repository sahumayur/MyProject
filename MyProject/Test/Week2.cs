using MyProject.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test
{
    internal class Week2
    {
        //even odd except divisible by 5 & 10
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0 && i%10==0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    internal class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number: ");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 00)
                {
                    Console.Write("\t" + i);
                }

            }
        }
    }

    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even\tSquare");
            for(int i=0; i<50; i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("\t"+(i*i));
                }
            }
        }
    }

    internal class Fibbo
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 1; i <= 20; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(b);
            }
        }
    }

        internal class Harshed_Number
        {
            static void Main(string[] args) 
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                int sum = 0, digit = 0;
                int temp = n;
                while(n>0)
                {
                    digit = n % 10;
                    sum += digit;
                    n = n / 10;
                }
                if(temp%sum==0)
                {
                    Console.WriteLine("Harshed Number");
                }
                else
                {
                    Console.WriteLine("Not Harshed Number");
                }
            }
        }

    internal class Task6
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("RedBlue");
                }
                else if(i%3==0)
                {
                    Console.WriteLine("Red");
                }
                else if(i%5==0)
                {
                    Console.WriteLine("Blue");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    internal class Order
    {
        private int order_id;
        private string city;
        private string cust_name;
        private string is_delivered;

        public int Order_Id
        {
            set { order_id = value; }
            get { return order_id; }
        }

        public string City
        {
            set { city = value; }   
            get { return city; }
        }

        public string Cust_Name
        {
            set { cust_name = value; }
            get { return cust_name; }
        }

        public string Is_delivered
        {
            set { is_delivered = value; }
            get { return is_delivered; }   
        }

    }
    internal class TestOrder
    {
        static void Main(string[] args)
        {
            Order o= new Order();
            o.Order_Id = 101;
            o.City = "Hingoli";
            o.Cust_Name = "Mayur Sahu";
            o.Is_delivered = "Yes";

            Console.WriteLine(o.Order_Id + "\t" + o.City  + "\t" + o.Cust_Name + "\t" + o.Is_delivered);
            
            
        }
    }

    internal class Krishnamurti
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n=int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;

            while(n>0)
            {
                int digit = n % 10;
                int fact = 1;
                for(int i=1;i<=digit;i++)
                {
                    fact = fact * i;
                }
                sum= sum + fact;
                n = n / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Krishnamurti number.");
            }
            else
            {
                Console.WriteLine("Not KrishnaMurty number.");
            }
        }
    }
}
