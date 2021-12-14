using System;

namespace Switch_Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            // SWITCH CONSTRUCTION
            // The Switch / Case design estimates some
            // expression and compares its value with a set of values. And when
            // the values ​​match, performs a specific code:
            string name = "Ann";

            switch (name)
            {
                case "Mary":
                    Console.WriteLine("Your Name - Mary");
                    break;
                case "Ani":
                    Console.WriteLine("Your Name - Ani");
                    break;
                case "Ann":
                    Console.WriteLine("Your Name - Ann");
                    break;
            }

            string name1 = "Alex";

            // If the value of the NAME variable does not match any value after CASE
            // statements, then none of the CASE blocks are performed. However,
            // even in this case, we still need to perform any actions, then we
            // can add an optional default unit to the Switch design.
            switch (name1)
            {
                case "Bob":
                    Console.WriteLine("Your Name - Bob");
                    break;
                case "Tom":
                    Console.WriteLine("Your Name - Tom");
                    break;
                case "Sam":
                    Console.WriteLine("Your Name - Sam");
                    break;
                default:
                    Console.WriteLine("Unknown name");
                    break;
            }

            // However, if we want, on the contrary, after executing the
            // current CASE block, another CASE block was performed, then
            // we can use Goto Case operator instead of Break:
            int number = 1;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    goto case 5; // Transition to Case 5
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

            // Return value from SWITCH
            int Operation(int op, int a, int b)
            {
                switch (op)
                {
                    case 1: return a + b;
                    case 2: return a - b;
                    case 3: return a * b;
                    case 4: return a / b;
                    default: return 0;
                }
            }

            int result1 = Operation(1, 25, 5); 
            Console.WriteLine(result1);        

            int result2 = Operation(2, 25, 5); 
            Console.WriteLine(result2);

            int result3 = Operation(3, 25, 5);
            Console.WriteLine(result3);

            int result4 = Operation(4, 25, 5);
            Console.WriteLine(result4);
        }

        // Obtaining a result from Switch
        int DoOperation(int op, int a, int b)
        {
            return op switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                _ => 0  // _ = default
            };
        }
    }
}
