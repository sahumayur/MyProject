using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Loops
{
    internal class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** odd number between 35 to 50 **********");

            for (int i = 35; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
    internal class Task1
    {
        static void Main(string[] args)
        {




            Console.WriteLine("********** Sum of 1 to 10 **********");

            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of 1 to 10: " + sum);

            Console.WriteLine("********** Count odd number between 20 to 50 **********");

            int count = 0;
            for (int j = 20; j <= 50; j++)
            {

                if (j % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
    internal class Task2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********** number between 320 to 225 **********");

            for (int i = 320; i >= 225; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Task3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********** Table **********");

            int tab=1;
            Console.WriteLine("Enter the number: ");
            int x = int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                tab = x*i;
                Console.WriteLine(tab);
            }
            

        }
    }
}
