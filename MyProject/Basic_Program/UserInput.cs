using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Schema;

namespace MyProject.Basic_Program
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            int l, b, res;
            Console.WriteLine("Enter the Length and Breadth: ");
            l=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            res = l * b;
            Console.WriteLine("Area of Rectangle: " + res);

            int a, cube1;
            Console.WriteLine("Enter the value for cube: ");
            a= int.Parse(Console.ReadLine());
            cube1 = a * a * a;
            Console.WriteLine("cube of entered number is: "+cube1);

            double r, res1;
            Console.WriteLine("Enter the radus in double: ");
            r= double.Parse(Console.ReadLine());
            res1 = 3.14 * r * r;
            Console.WriteLine("Area of entered radius is: "+r);

            int sub1, sub2, sub3, avg;
            Console.WriteLine("Enter the marks for three subjects");
            sub1= int.Parse(Console.ReadLine());
            sub2= int.Parse(Console.ReadLine());
            sub3= int.Parse(Console.ReadLine());
            avg=(sub1+ sub2 + sub3)/3;
            Console.WriteLine("Average of three subject is: "+avg);

            int Marathi, Hindi, English, Mathematics, Science, tot;
            float per1;
            Console.WriteLine("Enter the marks for five subject");
            Marathi=Convert.ToInt32(Console.ReadLine());
            Hindi=Convert.ToInt32(Console.ReadLine());
            English=Convert.ToInt32(Console.ReadLine());
            Mathematics=Convert.ToInt32(Console.ReadLine());
            Science=Convert.ToInt32(Console.ReadLine());

            tot=Marathi+Hindi+English+Mathematics+Science;
            Console.WriteLine("Tottal of five subject is:" + tot);
            per1 = tot/5;
            Console.WriteLine("Percentage of five subject is "+per1);

           /* int sw1, sw2, sw3;

            Console.WriteLine("Enter two values: ");
            sw1= Convert.ToInt32(Console.ReadLine());
            sw2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swap");
            Console.WriteLine("sw1: "+sw1);
            Console.WriteLine("sw2: "+sw2);

            sw3 = sw1;
            sw1 = sw2;
            sw2 = sw3;

            Console.WriteLine("After swap" );
            Console.WriteLine("sw1" + sw1);
            Console.WriteLine("sw2"+sw2);*/

        }
    }
}
