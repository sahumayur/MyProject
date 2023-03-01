using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Conditional
{
    internal class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Odd Even *************");

            int num;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num + " is even number");
            }
            else
            {
                Console.WriteLine(num + " is odd number");
            }
        }
    }
        internal class Task1
        {
            static void Main(string[] args)
            {


                Console.WriteLine("*********** Positive Negative *************");

                int num1;
                Console.WriteLine("Enter number: ");
                num1 = int.Parse(Console.ReadLine());
                if (num1 > 0)
                {
                    Console.WriteLine(num1 + " is positive number");
                }
                else
                {
                    Console.WriteLine(num1 + " is negative number");
                }
            }
        }
        internal class Task2
        {
            static void Main(string[] args)
            {

                Console.WriteLine("*********** Multiple of 3 *************");

                int num2;
                Console.WriteLine("Enter the number: ");
                num2 = int.Parse(Console.ReadLine());
                if (num2 % 3 == 0)
                {
                    Console.WriteLine(num2 + " is multiple of 3");
                }
                else
                {
                    Console.WriteLine(num2 + " is not multiple of 3");
                }
            }
        }
        internal class Task3
        {
            static void Main(string[] args)
            {

                Console.WriteLine("*********** Positive/Negative/Zero *************");

                int num3;
                Console.WriteLine("Enter the number: ");
                num3 = int.Parse(Console.ReadLine());
                if (num3 < 0)
                {
                    Console.WriteLine(num3 + " is negative number");
                }
                else if (num3 > 0)
                {
                    Console.WriteLine(num3 + " is positive number");
                }
                else
                {
                    Console.WriteLine("Entered number is 0");
                }
            }
        }
        internal class Task4
        {
            static void Main(string[] args)
            {

                Console.WriteLine("*********** Divisible by 3 or 9 *************");

                int num4;
                Console.WriteLine("Enter the number: ");
                num4 = int.Parse(Console.ReadLine());
                if (num4 % 3 == 0 && num4 % 9 == 0)
                {
                    Console.WriteLine(num4 + " is divisible by 3 and 9");
                }
                else
                {
                    Console.WriteLine(num4 + " is not divisible by 3 and 9");
                }
            }
        }
        internal class Task5
        {
            static void Main(string[] args)
            {

                Console.WriteLine("*********** Percentage and Passout Year *************");

                int passout;
                float per;

                Console.WriteLine("Enter the percentage and passout year: ");
                per = float.Parse(Console.ReadLine());
                passout = int.Parse(Console.ReadLine());

                if (passout >= 2020)
                {
                    if (per >= 60)
                    {
                        Console.WriteLine("Congratulations, you are eligible for the drive");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, due to low percentage criteria you are not eligible for the drive");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry,You are not eligible for the drive becuase only 2020 onwards passout students are allowed to this drive");
                }
            }
        }
        internal class Task6
        {
            static void Main(string[] args)
            {

                Console.WriteLine("*********** 50 to 100 *************");

                int num5;
                Console.WriteLine("Enter any number: ");
                num5 = int.Parse(Console.ReadLine());
                if (num5 > 50 && num5 < 100)
                {
                    Console.WriteLine(num5 + " is greater than 50 and less than 100");
                }
                else
                {
                    Console.WriteLine(num5 + " is not in range of 50 to 100");
                }
            }
        }
        internal class Task7
        {
            static void Main(string[] args)
            {

                Console.WriteLine("*********** Alphabate or Digit *************");

            char ch;
            Console.WriteLine("Enter charecter: ");
            ch=char.Parse(Console.ReadLine());
            if(ch>='0' && ch<='9')
            {
                Console.WriteLine(ch + " is a digit");
            }
            else
            {
                Console.WriteLine(ch+" is a charecter");
            }
        }
    }
}
