using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class SwitchTask
    {
        static void Main(string[] args)
        {
            int l, b, s, h, b1;
            float r;
            int num;

            Console.WriteLine("---------- 1 to 5 number in word ----------\n\n");

            Console.WriteLine("Enter a number between 1 to 5: ");
            int k = int.Parse(Console.ReadLine());
            switch (k)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Enter correct number");
                    break;
            }
        }
    }
    internal class SwitchTask1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------- Consonent/Vowel ----------\n\n");
            Console.WriteLine("Enter any alphabate: ");
            char ch1 = Convert.ToChar(Console.ReadLine());
            switch (ch1)
            {
                case 'a':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Its a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Its a Vowel");
                    break;
                default:
                    Console.WriteLine("its a Consonent");
                    break;
            }
        }
    }
    internal class SwitchTask2
    {
        static void Main(string[] args)
        {
            int l, b, s, h, b1;
            float r;
            Console.WriteLine("********** Area **********\n\n");
            Console.WriteLine("1.Area of Circle \n 2.Area of Reactangle \n 3.Area of Square \n 4.Area of Traingle");
            Console.WriteLine("Enter the number to perform that operation: ");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Enter the radius: ");
                    r = float.Parse(Console.ReadLine());
                    Console.WriteLine("Area of circle: " + (3.14 * r * r));
                    break;
                case 2:
                    Console.WriteLine("Enter the value of l and b: ");
                    l = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of Reactangle: " + (l * b));
                    break;
                case 3:
                    Console.WriteLine("Enter the value of side: ");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of Square: " + (s * s));
                    break;
                case 4:
                    Console.WriteLine("Enter the values of h and b");
                    h = int.Parse(Console.ReadLine());
                    b1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of Traingle is: " + ((h * b1) / 2));
                    break;
            }
        }
    }
    internal class SwitchTask3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** odd/even ***********\n\n");
            int a;
            Console.WriteLine("Enter the number: ");
            a=int.Parse(Console.ReadLine());
            switch(a%2==0)
            {
                case true: Console.WriteLine(a + " is even number");
                    break;
                    case false: Console.WriteLine(a + " is odd number");
                    break;
            }
        }
    }
}
