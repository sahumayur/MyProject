using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Assignments
{
    internal class Video2
    {
        static void Main(string[] args)
        {
            for(int i=121;i<=229;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    internal class Loop1
    {
        static void Main(string[] args)
        {
            int i = 521;
            while(i>=229)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                i--;
            }
        }
    }

    internal class BreakUse
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=15;i++)
            {
                if(i==10)
                { 
                    Console.WriteLine(i); 
                }
            }
        }
    }

    internal class GcdLcm
    {
        static void Main(string[] args)
        {
            int a, b, Num1, Num2, temp, LCM, GCD;
            Console.WriteLine("Calculate LCM and GCD\nEnter the two numbers to Calculate..");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Calculating....");
            System.Threading.Thread.Sleep(2000);
            Num1 = a;
            Num2 = b;
            while (Num2 != 0)
            {
                temp = Num2;
                Num2 = Num1 % Num2;
                Num1 = temp;
            }
            GCD = Num1;
            LCM = (a * b) / GCD;
            Console.WriteLine("LCM for {0} and {1} is {2}", a, b, LCM);
            Console.WriteLine("GCD for {0} and {1} is {2}", a, b, GCD);
            Console.ReadKey();
        }
    }

    internal class Alphabate1
    {
        static void Main(string[] args)
        {
            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                Console.WriteLine(ch);
            }
        }
    }

    internal class EvenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }

    internal class OddSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }

    internal class NumberOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while(n > 0)
            {
                n = n / 10;
                count++;
            }
            Console.WriteLine("Number of digit is: " + count);
        }
    }

    internal class ProductOfDigit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
           // int count = 0;
            int prod = 1;
            
            while (n > 0)
            {
                int digit = n % 10;
                prod*=digit;
                n = n / 10;
              //  count++;
            }
            Console.WriteLine("Product is: " + prod);
        }
    }

    internal class Friquency //pending
    {
        static void Main(string[] args)
        {

        }
    }

    internal class PrimeNumbr //pending 
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter number:");
            //int n=int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 400; i >= 300; i--)
            {
                bool isprime = true;
                for (int j=2;j<=400;j++)
                {
                    
                    if (i % 2 != 0)
                    {
                        // count++;
                        isprime = false;
                        break;
                    }
                }
            

                if (isprime==true)
                {
                    Console.WriteLine(i);
                }
                //else
                //{
                //    Console.WriteLine("Not Prime Number..");
                //}
            }
        }
    }

    internal class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n=int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(n*i);
            }
        }
    }

    internal class Square
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(i+" Square: "+(i*i));
            }
        }
    }

    internal class Power
    {
        static void Main(string[] args)
        {
            int basenumber, exponent, power;

            
            Console.Write("Enter base number: ");
            basenumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter exponent: ");
            exponent = Convert.ToInt32(Console.ReadLine());

            power = 1;

            for (int i = 1; i <= exponent; i++)
            {
                power = power * basenumber;
            }


            Console.Write("Power : " + power);
        }
    }

    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());

            int factorial = 1;
            Console.WriteLine("Number\t" + "Factorial");
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                
                Console.WriteLine(i + "\t" + factorial);
            }
        }
    }

    internal class Krishnamurti 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int sum = 0;

            while (n > 0)
            {
                int digit = n % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact = fact * i;
                    
                }
                sum=sum + fact; 
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Krishnamurti number.");
            }
            else
            {
                Console.WriteLine("Not KrishnaMurty number.");
            }
        }
    }

    internal class Pallindrome
    {
        static void Main(string[] args)
        {

            

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


    class Automorphic
    {


        public static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());

            
            int sq = n * n;

            
            while (n > 0)
            {
                
                if (n % 10 != sq % 10)
                {
                    Console.WriteLine("not automorphic..");
                }

                // Reduce N and square
                n /= 10;
                sq /= 10;
            }

            Console.WriteLine("Automorphic..");
        }
    }


    internal class Harshed_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, digit = 0;
            int temp = n;
            while (n > 0)
            {
                digit = n % 10;
                sum += digit;
                n = n / 10;
            }
            if (temp % sum == 0)
            {
                Console.WriteLine("Harshed Number");
            }
            else
            {
                Console.WriteLine("Not Harshed Number");
            }
        }
    }
}
