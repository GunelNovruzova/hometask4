using System;

namespace ClassLibrary1
{
    public class Calculator
    {
        public void Sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }
        public void Minus(int a, int b)
        {
            Console.WriteLine(a-b);
        }
        public void Divide(int a, int b)
        {
            if (b!=0)
            {
                Console.WriteLine(a/b);
            }
        }
    }
}
