using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MyProject.Assignments
{
    internal class Video1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Leap Year **********");

            Console.WriteLine("Enter the Year: ");
            int year=int.Parse(Console.ReadLine());
            int leap;
            if (year % 4 == 0)
            {
                Console.WriteLine("Leap Year..");
            }
            else 
            {
                Console.WriteLine("Not leap year..");
            }
        }
    }

    internal class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num=int.Parse(Console.ReadLine());
            if(num%5==0 && num%11==0) 
            {
                Console.WriteLine("Number is divisible by 5 % 11");
            }
            else
            {
                Console.WriteLine("Number is not divisible by 5 & 11");
            }
        }
    }

    internal class Maximum
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter the numbers");
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());
            int c=int.Parse(Console.ReadLine());
            if(a>b && a>c)
            {
                Console.WriteLine("A is Greater");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine("B is greater");
            }
            else
            {
                Console.WriteLine("C is greater");
            }
        }
    }

    internal class Alphabate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the alphabate: ");
            char ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("Its a Vowel..");
            }
            else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Its a Vowel..");
            }
            else
            {
                Console.WriteLine("Its a Consonent..");
            }
        }
    }

    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to perform that operation..");
            Console.WriteLine("1.Addition\t 2.Substraction\t 3.Multiplication\t 4.Division\t 5.Modulous");
            int op=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter two numbers: ");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            if(op==1)
            {
                Console.WriteLine("Addition: " + (num1 + num2));
            }
            else if(op==2)
            {
                Console.WriteLine("Substraction: "+(num1 - num2));
            }
            else if(op==3) 
            {
                Console.WriteLine("Multiplicaton: "+(num1*num2));
            }
            else if(op==4)
            {
                Console.WriteLine("Division: "+(num1/num2));
            }
            else if(op==5)
            {
                Console.WriteLine("Modulous: "+(num1%num2));
            }
            else
            {
                Console.WriteLine("Enter correct operation..");
            }
        }
    }

    internal class NegativePositiveZero
    {
        static void Main(string[] args)
        {


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

    internal class AlphabateDigit
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter charecter: ");
            ch = char.Parse(Console.ReadLine());
            if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + " is a digit");
            }
            else if(ch>= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + " is a charecter");
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine(ch + " is a charecter");
            }
            else
            {
                Console.WriteLine(ch + " is special symbol");
            }
        }
    }

    internal class EvenOdd
    {
        static void Main(string[] args)
        {
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

    internal class Denomination
    {
        static void Main(string[] args)
        {
            int note1,note2,note3,note4,note5,note6,note7,note8;
            Console.WriteLine("How much Money you want to deposite: ");  
            int money=int.Parse(Console.ReadLine());
            int cash = money;
            while (money >= 2000)
            {
                note1 = money / 2000;
                Console.WriteLine("2000: " + note1);
                break;
            }
            while(money>=500)
            {
                note2 = money / 500;
                Console.WriteLine("500: "+note2);
                break;
            }
            while(money>=200)
            {
                note3= money / 200;
                Console.WriteLine("200: " + note3);
                break;  
            }
            while(money>=100)
            {
                note4 = money / 100;
                Console.WriteLine("100: " + note4);
                break;  
            }
            while(money>=50)
            {
                note5 = money / 50;
                Console.WriteLine("50: " + note5);
                break;  
            }
            while(money>=20)
            {
                note6= money / 20;
                Console.WriteLine("20: "+note6);
                break;  
            }
            while(money>=10)
            {
                note7= money / 10;
                Console.WriteLine("10: "+note7);
                break;
            }
            while(money>=1)
            {
                note8= money / 1;
                Console.WriteLine("1: "+note8);
                break;
            }



        }
    }

    internal class Employee
    {
        static void Main(string[] args)
        {
            float hra = 1, da = 1;
            Console.WriteLine("Enter the basic salary:");
            float basic_salary=float.Parse(Console.ReadLine());
            if(basic_salary<=10000)
            {
                hra = (float)(basic_salary * 0.20);
                da = (float)(basic_salary * 0.80);
                float gross = basic_salary + hra + da;
                Console.WriteLine("Groass Salary: "+(gross));
            }
            else if (basic_salary <= 20000)
            {
                hra = (float)(basic_salary * 0.25);
                da = (float)(basic_salary * 0.90);
                float gross = basic_salary + hra + da;
                Console.WriteLine("Groass Salary: " + (gross));
            }
            else if (basic_salary > 20000)
            {
                hra = (float)(basic_salary * 0.30);
                da = (float)(basic_salary * 0.95);
                float gross = basic_salary + hra + da;
                Console.WriteLine("Groass Salary: " + (gross));
            }
        }
    }

    internal class Sum
    {
        static void Main(string[] args)
        {
            int count = 0, sum = 0;
            Console.WriteLine("Enter the number: ");
            int num=int.Parse(Console.ReadLine());
            while(num>0) 
            {
                int digit=num%10;
                if(count%2!=0)
                {
                    sum += digit;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }

    internal class Check3Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num= int.Parse(Console.ReadLine());
            int last=num%10;
            int first;
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                first = num % 10;
                num = num / 10;
                 count++;
                sum = first + last;

            }
            if (count == 3)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Number is greater or smaller than 3 digit...");
            }
        }
    }

    internal class SwCalculator
    {
        static void Main(String[] args)
        {

           


            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //int c;
            char ch;
            do
            {
                Console.WriteLine(" + Addition\t - Substraction\t * Multiplication\t / Division\t % Modulous\n");
                Console.WriteLine("Select anyone Operation: ");
               int c=int.Parse(Console.ReadLine()) ;   
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

    internal class Sw2and3
    {
        static void Main(String[] args)
        {

            Console.WriteLine("---------- Display Day via user input ----------\n\n");

            Console.WriteLine(" 1.Monday\t 2.Tuesday\t 3.Wednesday\t 4.Thursday\t 5.Friday\t 6.Saturday\t 7.Sunday\n");
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
                    Console.WriteLine("error, day does not exist");
                    break;
            }
        }
    }

    internal class Sw1to5
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

    internal class SwArea
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
}
