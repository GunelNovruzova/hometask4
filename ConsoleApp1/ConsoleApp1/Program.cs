using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal1 = new Calculator();
            cal1.Sum(5, 6);
            cal1.Multiply(2, 10);
            cal1.Divide(90, 5);
            cal1.Minus(19, 9);
        }
    }
}
