using System;

namespace Recursive_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive functions
            // Separately focus on recursive functions.
            // Recursive function represents such a construction
            // in which the function causes itself.

            // Recursive factorial function
            int Factorial(int n)
            {
                if (n == 1) return 1;

                return n * Factorial(n - 1); // That is, if the input number is 1, then 1 returns
            }

            int factorial5 = Factorial(5);  
            int factorial7 = Factorial(7);  
            int factorial9 = Factorial(9);

            Console.WriteLine($"Factorial 5 ={factorial5}");
            Console.WriteLine($"Factorial 7 ={factorial7}");
            Console.WriteLine($"Factorial 9 ={factorial9}");

            // Recursive Fibonacci function
            int Fibonachi(int n)
            {
                if (n == 0 || n == 1) return n; //If we are looking for a zero or first element
                                                //of the sequence, then the same number is
                                                //returned - 0 or 1. otherwise the result of Fibonachi
                                                //expression (n - 1) + Fibonachi (N - 2) is returned;

                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }

            int fib7 = Fibonachi(7);
            int fib8 = Fibonachi(8);
            int fib9 = Fibonachi(9);

            Console.WriteLine($" Fibonacci 7 = {fib7}");
            Console.WriteLine($" Fibonacci 8 = {fib8}");
            Console.WriteLine($" Fibonacci 9 = {fib9}");

            // Recursions and cycles
            static int Fibonachi1(int n)
            {
                int result = 0;
                int b = 1;
                int abc;

                for (int i = 0; i < n; i++)
                {
                    abc = result;
                    result = b;
                    b += abc;
                }
                return result;
            }
        }
    }
}
