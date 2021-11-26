using System;

namespace Arithmetic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 5;
            int c = a + b; //25 + operations
            int d = a - b; //15 - operations
            int f = a * b; //100 * operations
            int e = a / b; //4 / operations
            Console.WriteLine($"c: {c} d: {d} f: {f} e: {e}");

            // % 
            double k = 10;
            double l = k % 4; // 2 The operation of obtaining the remainder of an integer division of two numbers:
            Console.WriteLine(l);

            // ++
            int number1 = 10;
            int number2 = ++number1; // number2 = 11; number1 = 11 Increment operation prefix

            int number3 = 10;
            int number4 = number3++; // number4 = 10 number3 = 11 Increment operation postfix

            // --
            int class1 = 60;
            int class2 = --class1; // class2 = 59; class1 = 59 Decrement operation prefix

            int class3  = 60;
            int class4  = class3--; // class4 = 60; class3 = 59  Decrement operation postfix
        }
    }
}
