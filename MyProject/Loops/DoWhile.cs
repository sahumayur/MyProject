using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class DoWhile
    {

        static void Main(String[] args)
        {

            Console.WriteLine("---------- Display Day via user input ----------\n\n");


                Console.WriteLine(" 1.Monday\t 2.Tuesday\t 3.Wednesday\t 4.Thursday\t 5.Friday\t 6.Saturday\t 7.Sunday\n");

            char ch;
            do
            {
                Console.WriteLine("Enter any number from 1 to 7: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("It's Monday");
                        break;
                    case 2:
                        Console.WriteLine("It's Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("It's Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("It's Thursday");
                        break;
                    case 5:
                        Console.WriteLine("It's Friday");
                        break;
                    case 6:
                        Console.WriteLine("It's Saturday");
                        break;
                    case 7:
                        Console.WriteLine("It's Sunday");
                        break;
                    default:
                        Console.WriteLine("Enter the correct number");
                        break;
                }
                Console.WriteLine("Do you want to coninue: ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch=='y' || ch=='Y');
        }
    }
    internal class DoWhile2
    {
        static void Main(String[] args)
        {

            Console.WriteLine("----------- Arithmatic Operation ----------\n\n");



            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            char ch;
            do
            {

                Console.WriteLine(" 1.Addition\t 2.Substraction\t 3.Multiplication\t 4.Division\t 5.Modulous\n");
                Console.WriteLine("Select anyone Operation: ");
                int c = int.Parse(Console.ReadLine());

                switch (c)
            {
                case 1:
                    Console.WriteLine("Addition of two number is: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Substraction of two number is: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of two number is: " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division of two number is: " + (a / b));
                    break;
                case 5:
                    Console.WriteLine("Modulous of two number is: " + (a % b));
                    break;
                default:
                    Console.WriteLine("Enter correct operation");
                    break;
            }
                Console.WriteLine("Do you want to coninue: ");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');

        }
    }

}
