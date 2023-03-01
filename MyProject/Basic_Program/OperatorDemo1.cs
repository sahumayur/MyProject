using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic_Program
{
    internal class OperatorDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************ Unary Operator **************");
            
            int a=2; int b = 2; int x;
            x = a++ - ++b;
            System.Console.WriteLine("x=" + x + " a=" + a + " b=" + b + "\n");

            x = --a - --b - a;
            System.Console.WriteLine("x=" + x + " a=" + a + " b=" + b + "\n");

            x = a++ - --b + --a;
            System.Console.WriteLine("x=" + x + " a=" + a + " b=" + b+"\n");

            x = ++b - ++a + a;
            System.Console.WriteLine("x=" + x + " a=" + a + " b=" + b+"\n");

            x = --a - b-- - b;
            System.Console.WriteLine("x=" + x + " a=" + a + " b=" + b+"\n");

            Console.WriteLine("************ Arithmatic Opertor **************");

            int x1, y1, z1;
            x1 = 51 % 9 - (3 + 4 / 2);
            Console.WriteLine("Value of x1 is: "+x1+"\n");

            y1 = 8 * 2 / 4 * 2 + 4;
            Console.WriteLine("Value of y1 is: " + y1+"\n");

            z1 = 6 + 3 * 4 / 2 * 2;
            Console.WriteLine("Value of z1 is: " + z1 + "\n");

            Console.WriteLine("************ Relational/Conditional Opertor **************");

            int a1 = 25, b1 = 30, c1=15;
            Console.WriteLine(a1 > b1);
            Console.WriteLine(a1 > c1);

            Console.WriteLine("************ Logical Opertor **************");

            Console.WriteLine((a1>b1) && (a1>c1));
            Console.WriteLine((a1>b1) || (a1>c1));
            Console.WriteLine(" ");

            Console.WriteLine("************ Assignment  Opertor **************");

            int g=5;
            g += 5;
            Console.WriteLine("g+5: "+g);

            g -= 2;
            Console.WriteLine("g-2: "+g);

            g *= 12;
            Console.WriteLine("g*12: " + g);

            g /= 2;
            Console.WriteLine("g/2: " + g);

            g %= 3;
            Console.WriteLine("g%3: " + g);
        }
    }
}
