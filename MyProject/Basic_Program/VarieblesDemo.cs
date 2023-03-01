using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Basic_Program
{
    internal class VarieblesDemo
    {
        static void Main(string[] args)
        {
            byte mybyte = 56;
            sbyte mybyte1 = -67;

            Console.WriteLine("First byte value: "+mybyte);
            Console.WriteLine("Second byte value: "+mybyte1 + "\n");

            short num1 = 678;
            short num2 = -567;

            Console.WriteLine("First short value: " + num1);
            Console.WriteLine("Second short value: " + num2 + "\n");

            int myint1 = 50000;
            int myint2 = -890000;

            Console.WriteLine("First int value: " + myint1);
            Console.WriteLine("Second int value: " + myint2 + "\n");

            long myl1 = 987768899099;
            long myl2 = -12345698702;

            Console.WriteLine("First long value: " + myl1);
            Console.WriteLine("Second long value: " + myl2 + "\n");

            double per = 78.56;
            float per2 = 67.44f;

            Console.WriteLine("Double value: " + per);
            Console.WriteLine("Float value: " + per2 + "\n");
            
            char ch1 = 't';
            char ch2 = '2';
            char ch3 = '#';

            Console.WriteLine("Alphabate charecter: " + ch1);
            Console.WriteLine("Numeric charecter: " + ch2);
            Console.WriteLine("Special Symbol: " + ch3 + "\n");

            bool ischeack = true;
            bool ischeack2 = false;

            Console.WriteLine("First Boolean char: " + ischeack);
            Console.WriteLine("Second Boolean char: " + ischeack2 + "\n");

            String myname = "Mayur";
            Console.WriteLine("First String: " + myname);

        }


    }
}
