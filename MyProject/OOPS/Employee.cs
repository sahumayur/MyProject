using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject.OOPS
{
    internal class Employee
    {
        int id;
        string name;
        int salary;
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.WriteLine("Enter the Id, Name, Salary of an employee");
            e.id = int.Parse(Console.ReadLine());
            e.name = Console.ReadLine();
            e.salary = int.Parse(Console.ReadLine());

            Console.WriteLine("id of an Employee: "+e.id);
            Console.WriteLine("Name of an Employee: "+e.name);
            Console.WriteLine("Salary of an Employee: "+e.salary);
        }
    }


    internal class Car
    {
        string car_name;
        int model_no;
        string color;
        int price;
        static void Main(string[] args)
        {
            Car c = new Car();

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the car name:");
                c.car_name = Console.ReadLine();
                Console.WriteLine("Enter the Model number in year:");
                c.model_no = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the car color:");
                c.color = Console.ReadLine();
                Console.WriteLine("Enter price:");
                c.price = int.Parse(Console.ReadLine());
            }

            for(int j=1;j<=3;j++)
            {
                Console.WriteLine(j+" Car details...");
                Console.WriteLine(c.car_name);
                Console.WriteLine(c.model_no);
                Console.WriteLine(c.color);
                Console.WriteLine(c.price);
            }




        }
    }
}
