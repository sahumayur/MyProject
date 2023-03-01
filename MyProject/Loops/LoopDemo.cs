using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class LoopDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Count number of digit *************\n");

            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }

            Console.WriteLine(count);
        }
    }

    internal class LoopDemo1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********** Average of digit from number *************\n");
            Console.WriteLine("Entr the number: ");
            int num1 = int.Parse(Console.ReadLine());
            int tot = 0;
            int count1 = 0;
            while (num1 > 0)
            {
                int digit = num1 % 10;
                tot = tot + digit;
                num1 = num1 / 10;
                count1++;
            }
            Console.WriteLine("Total: " + tot);
            Console.WriteLine("Average: " + (tot / count1));
        }
    }

    internal class Pallindrome
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********** Pallindrome number *************\n");

            Console.WriteLine("Enter the number: ");
            int num2 = int.Parse(Console.ReadLine());
            int cpy = num2;
            int rev = 0;
            while (num2 > 0)
            {
                int digit = num2 % 10;
                rev = rev * 10 + digit;
                num2 = num2 / 10;
            }
            Console.WriteLine(rev);
            if (rev == cpy)
            {
                Console.WriteLine("Pallindrome number");
            }
            else
            {
                Console.WriteLine("Not Pallindrome number");
            }
        }
    }


    internal class LoopDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Armstrong number *************\n");

            Console.WriteLine("Enter number: ");
            int num3 = int.Parse(Console.ReadLine());
            int cpy1 = num3;
            int sum = 0;
            while (num3 > 0)
            {
                int digit = num3 % 10;
                sum = sum + (digit * digit * digit);
                num3 = num3 / 10;
            }
            if (sum == cpy1)
            {
                Console.WriteLine("Armstrong number");
            }
            else
            {
                Console.WriteLine("Not armstrong number");
            }
        }
    }
}

