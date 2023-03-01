using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class WhileDemo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
    internal class MagicNumber
    {
        static void Main(string[] args)
        {
            int magicnumber = 100, count=0;
            while (true)
            {
                count++;
                Console.WriteLine("Entr any number");
                int a = int.Parse(Console.ReadLine());
                if(a==magicnumber)
                {
                    Console.WriteLine("Congratulations, you guess correct number");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again");
                    continue;
                }
            }
            Console.WriteLine("Count taken: "+count);
            
        }
    }

    internal class PrimeDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int a = int.Parse(Console.ReadLine());
            int i = 2;
            bool isprime = true;
            while (i<a)
            {
                if(a%i==0)
                {
                    isprime = false;
                    break;
                }
                i++;
            }
            if (isprime == true)
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not Prime Number");
            }
        }
    }

    internal class SumOfDigit
    {
        static void Main(string[] args)
        {
            int sum = 0, num;
            Console.WriteLine("Entr the number: ");
            num= int.Parse(Console.ReadLine());
            while(num>0)
            {
                int digit = num % 10;
                sum += digit;
                num = num / 10;
            }
            Console.WriteLine("Sum of digit is: " + sum);
        }
    }

    internal class ReverseNumber
    {
        static void Main(string[] args)
        {
            int rev = 0;
            Console.WriteLine("Enter the number: ");
            int num=int.Parse(Console.ReadLine());
            while(num>0)
            {
                int digit=num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
