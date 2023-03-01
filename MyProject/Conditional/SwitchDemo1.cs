using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class SwitchDemo1
    {
        static void Main(String[] args)
        {

            Console.WriteLine("---------- Display Day via user input ----------\n\n");

            Console.WriteLine(" 1.Monday\t 2.Tuesday\t 3.Wednesday\t 4.Thursday\t 5.Friday\t 6.Saturday\t 7.Sunday\n");
            Console.WriteLine("Enter any number from 1 to 7: ");
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1: Console.WriteLine("It's Monday");
                    break;
                case 2: Console.WriteLine("It's Tuesday");
                    break;
                case 3: Console.WriteLine("It's Wednesday");
                    break;
                case 4: Console.WriteLine("It's Thursday");
                    break;
                case 5: Console.WriteLine("It's Friday");
                    break;
                case 6: Console.WriteLine("It's Saturday");
                    break;
                case 7: Console.WriteLine("It's Sunday");
                    break;
                default: Console.WriteLine("Enter the correct number");
                    break;
            }
        }
    }
    internal class SwitchDemo2
    {
        static void Main(String[] args)
        {

            Console.WriteLine("----------- Arithmatic Operation ----------\n\n");


            Console.WriteLine(" 1.Addition\t 2.Substraction\t 3.Multiplication\t 4.Division\t 5.Modulous\n");
            Console.WriteLine("Select anyone Operation: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch (c)
            {
                case 1: Console.WriteLine("Addition of two number is: " + (a + b));
                    break;
                case 2: Console.WriteLine("Substraction of two number is: " + (a - b));
                    break;
                case 3: Console.WriteLine("Multiplication of two number is: " + (a * b));
                    break;
                case 4: Console.WriteLine("Division of two number is: " + (a / b));
                    break;
                case 5: Console.WriteLine("Modulous of two number is: " + (a % b));
                    break;
                default: Console.WriteLine("Enter correct operation");
                    break;
            }
        }
    }

    internal class SwitchDemo3
    {
        static void Main(String[] args)
        {

            Console.WriteLine("----------- String in switch case ----------\n\n");

            Console.WriteLine("Enter city name: ");
            string s = Console.ReadLine();

            switch (s)
            {
                case "Pune": Console.WriteLine("Employee working in Pune");
                    break;
                case "Mumbai": Console.WriteLine("Employee working in Mumbai");
                    break;
                case "Nagpur": Console.WriteLine("Employee working in Nagpur");
                    break;
                default: Console.WriteLine("City name does not match");
                    break;
            }
        }
    }
    internal class SwitchDemo4
    {
        static void Main(String[] args)
        {

            Console.WriteLine("----------- Boolean in switch case/Divisible by 5 ----------\n\n");

            Console.WriteLine("Enter the number: ");
            int z = int.Parse(Console.ReadLine());

            switch(z%5==0)
            {
                case true:Console.WriteLine("Entered number is divisible by 5");
                    break;
                case false:Console.WriteLine("Entered number is not divisible by 5");
                    break;
            }
        }
    }
}
