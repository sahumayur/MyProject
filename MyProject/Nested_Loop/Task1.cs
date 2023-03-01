using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested_Loop
{
    internal class Task1
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine(" ");
            }
        }
    }
    internal class Task2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }
        }
    }
    internal class Task3
    {
        static void Main(string[] args)
        {
            for (int i = 4; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(i);
            }

        }
    }
    internal class Task4
    {
        static void Main(String[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Task5
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("0");
                    }

                }
                Console.WriteLine("");
            }
        }
    }

    internal class Task6
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(j == 3)
                    {
                        Console.Write("*");
                    }
                    else if (i == 3)
                    {
                        Console.Write("*");
                    }
                    else
                    { 
                        Console.Write(""); 
                    }
                }
                Console.WriteLine("");
            }
        }
    }

    internal class Task7
    {
        static void Main(string[] args)
        {
            for(char ch = 'A'; ch <= 'D'; ch++)
            {
                for(char ch1 = 'A'; ch1 <= ch; ch1++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine("");
            }
        }
    }



    internal class Task8
    {
        static void Main(string[] args)
        {
            for(char c='D';c>='A';c--)
            {
                for(char d='A';d<=c;d++)
                {
                    Console.Write(d);
                }
                Console.WriteLine("");
            }

        }
    }

    internal class Task9
    {
        static void Main(string[] args)
        {
            for (char c = 'A'; c <= 'D'; c++)
            {
                for (char d = 'D'; d >= c; d--)
                {
                    Console.Write(d);
                }
                Console.WriteLine();
            }
        }
    }

    internal class Prime
    {
        static void Main(string[] args)
        {
            int sum=0;
            for (int i= 1;i<= 10;i++)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % 2 == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Sum: "+(sum+=i));
                }
            }
        }
    }


    internal class Table
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********** Table **********");

            int tab = 1;
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    tab = j * i;
                    Console.WriteLine(tab);
                }
                Console.WriteLine();
            }

        }
    }

    internal class Factorial
    {
        static void Main(string[] args)
        {
            // Factorial between 1 to 5

            int factorial = 1, sum=0;
            Console.WriteLine("Number\t"+"Factorial\t"+"sum");
            for (int i = 1; i <= 5; i++)
            {
                factorial *= i;
                sum += factorial;
                Console.WriteLine(i+"\t"+factorial+"\t\t"+sum);
            }
        }
    }

    public class N_Pattern
    {
        public static void Main()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 1 && column != 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }

    internal class Square1
    {
        static void Main(string[] args)
        {
            for (char ch = 'A'; ch <= 'D'; ch++)
            {
                for (char ch1 = 'A'; ch1 <= 'D'; ch1++)
                {
                    if (ch == 'A' || ch1 == 'A' || ch == 'D' || ch1 == 'D')
                    {
                        Console.Write(ch1);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
