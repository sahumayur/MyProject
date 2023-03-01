using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Nested_Loop
{
    internal class PatternDemo1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("*");
                }
            }

        }
    }

    internal class PatternDemo2
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

    internal class PatternDemo3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=4;j>=i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

    internal class PatternDemo4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the row: ");
            int r=int.Parse(Console.ReadLine());
            for(int i=1;i<=r;i++)
            {
                for(int j=1;j<=r;j++)
                {
                    if(i==1||j==1||i==r||j==r)
                    {
                        Console.Write("*");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }

    internal class Pattern2
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

    internal class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");


            }
        }
    }
    internal class Square
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Row: ");
            int row=int.Parse(Console.ReadLine());
            for (int i = 1; i <= row;i++)
            {
                for(int j=1;j<=row;j++)
                {
                    if (i == 1 || j == 1 || i == row || j == row)
                    {
                        Console.Write("*");
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

    
