using MyProject.Assignments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Test
{
    internal class Week1
    {
        static void Main(string[] args)
        {
            //1 to 100 not divisible by 5 & 10
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0 && i % 10 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

    }

    internal class Loop
    {
        static void Main(String[] args)
        {
            int b = 0;
            do
            {
                int a = 2;
                b++;
                Console.WriteLine(a++);
            }
            while (b != 3);
        }
    }

    internal class Loop1
    {
        static void Main(string[] args)
        {
            int i = 1; int k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k =" + k + "i =" + i);

        }
    }

    internal class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int mul = 1;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit;
                mul *= digit;
                num = num / 10;
            }
            if (sum == mul)
            {
                Console.WriteLine("spy number");
            }
            else
            {
                Console.WriteLine("its not spy number");
            }

        }
    }

    internal class Trimorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            int cube = num * num * num;
            int cube1 = cube % 10;
            int last = num % 10;
            if (last == cube1)
            {
                Console.WriteLine("Trimorphic number..");
            }
            else
            {
                Console.WriteLine("Not Trimorphic number..");
            }
        }
    }

    internal class Pattern1 //unsolved
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine("");
            }
        }
    }

    internal class Pattern2 //unsolved
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j >= i; j--)
                {
                    Console.WriteLine("");
                }
            }
        }
    }

    internal class Code
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);

            }
        }
    }

    internal class TwinPrime //unsolved
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int num1=int.Parse(Console.ReadLine());
            int num2=int.Parse(Console.ReadLine());
            int i = 2;
            bool isprime = true;
            for (i = 2; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
        }
    }

    internal class PositiveNegative
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(" Negative number.."+(i*i));
                }
            }
        }

    }

    internal class Fibo
    {
        static void Main(string[] args)
        {
            int a=0, b=1, c=0;
            Console.WriteLine("a: "+a);
            Console.WriteLine("b: "+b);
            Console.WriteLine();
            for (int i = 0; i <= 20; i++)
            {
                c = a + b;
                Console.WriteLine(i+" "+c);
                a = b;
                b = c;
            }
        }
    }

    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num=int.Parse(Console.ReadLine());

            int factorial = 1, sum = 0;
            Console.WriteLine("Number\t" + "Factorial\t" + "sum");
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
                sum += factorial;
                Console.WriteLine(i + "\t" + factorial + "\t\t" + sum);
            }
        }
    }

    internal class Q13
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }

        }
    }
}

