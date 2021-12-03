using System;

namespace If_else_Construction_and_Ternary_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional constructs are one of the basic
            // components of many programming languages.

            //The if / else construction checks the truth of a certain condition and,
            //depending on the results of the test, executes a certain code.
            int num1 = 20;
            int num2 = 15;  
            if (num1 > num2)
            {
                Console.WriteLine($"Number {num1} is greater than the Number {num2}");
            }

            if (num1 > num2) Console.WriteLine($"Number {num1} is greater than the Number {num2}");

            // The else block is executed if the condition after the if is false, that is, it is equal
            // to false. If the else block contains only one instruction, then again we can shorten it by removing the curly braces:
            int num3 = 14;
            int num4 = 15;
            if (num3 > num4)
            {
                Console.WriteLine($"Number {num3} is greater than the Number {num4}");
            }
            else
            {
                Console.WriteLine($"Number {num3} is less than the Number {num4}");
            }

            // Но в примере выше при сравнении чисел мы можем насчитать три состояния: первое число больше второго, первое число меньше
            // второго и числа равны. Используя конструкцию else if, мы можем обрабатывать дополнительные условия:
            int num5 = 15;
            int num6 = 15;
            if (num5 > num6)
            {
                Console.WriteLine($"Number {num5} is greater than the Number {num6}");
            }
            else if(num5 < num6)
            {
                Console.WriteLine($"Number {num5} is less than the Number {num6}");
            }
            else
            {
                Console.WriteLine($"Number {num5} is equal to Number {num6}");
            }

            //The ternary operation also allows you to check a certain condition and, depending on its truth,
            //perform some actions. It has the following syntax:

            // [first operand is a condition]? [second operand]: [third operand]
            int a = 18;
            int b = 14;

            int p = a > b ? (a + b) : (a - b);
            Console.WriteLine(p); //32

            int a1 = 18;
            int b1 = 14;

            int p1 = a1 < b1 ? (a1 + b1) : (a1 - b1);
            Console.WriteLine(p1); //4
        }
    }
}
