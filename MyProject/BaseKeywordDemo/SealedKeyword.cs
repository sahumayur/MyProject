
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseKeywordDemo
{
    internal  class SealedKeyword
    {
        const int a = 5;

        readonly int b;
        public SealedKeyword() 
        {
            b = 10;
            Console.WriteLine("b: "+b);
        }
        public virtual void Print()
        {
            Console.WriteLine("In 1st class");

            Console.WriteLine("a: " + a);
            
        }
       
    }
    internal class NonSealed:SealedKeyword
    {
        public sealed override void Print() //now we can not over ride this method in next class
        {
            base.Print();
            Console.WriteLine("In 2nd class");

        }
    }

    public class Main1
    {
        static void Main(string[] args)
        {
            NonSealed nonSealed= new NonSealed();
            nonSealed.Print();
        }
    }
}
