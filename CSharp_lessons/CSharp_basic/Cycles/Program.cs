using System;

namespace Cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops are control constructs, allowing, depending on certain conditions,
            //to perform an action many times. There are the following types of loops in C #:

            //  for

            //  A for loop declaration has three parts. The first part of the loop
            //  declaration is some actions that are performed once before the loop is executed. This is usually
            //  where you define the variables to be used in the loop.
            //  The second part is the condition under which the loop will run. As long as the condition is true,
            //  the loop will run. And the third part is some of the actions that are performed after the end of the loop block.
            //  These actions are performed each time a loop block ends.
            //  After the loop is declared, the actions in it are enclosed in curly braces.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            for (int a = 1, b = 1; a < 25; a++, b++)
                Console.WriteLine($"{a * b}");

            //  while
            // the while loop immediately checks the truth of some condition,
            // and if the condition is true, then the loop code is executed:
            int v = 10;
            while (v > 0)
            {
                Console.WriteLine(v);
                v--;
            }

            //  do ... while
            // The do loop first executes the loop code and then checks the condition in the while statement.
            // And as long as this condition is true, the cycle repeats.
            int p = 7;
            do
            {
                Console.WriteLine(p);
                p--;
            }
            while (p > 0);  // cycle repeats x7

            int l = -1;
            do
            {
                Console.WriteLine(l);
                l--;
            }
            while (l > 0); // Although we have variable i less than 0, the loop will still execute once.

            //  foreach
            //The foreach loop is for iterating over a set or collection of items.
            foreach (char n in "Mary")
            {
                Console.WriteLine(n);
            }

            // The continue and break statements
            // Sometimes a situation arises when you need to exit the loop without waiting for it to complete.
            // In this case, we can use the break statement.
            for (int d = 0; d < 25; d++)
            {
                if (d == 14)
                    break;
                Console.WriteLine(d); //when counter d reaches 14, the break statement will be
                                      //triggered and the loop will end.
            }

            // if we want the loop not to end when checking, but just skip the current iteration.
            // To do this, we can use the continue statement:
            for (int f = 0; f < 25; f++)
            {
                if (f == 14)
                    continue;
                Console.WriteLine(f); // In this case, the loop, when it reaches the number 14, which does not satisfy the test condition,
                                      // will simply skip this number and move on to the next iteration:
            }

            // Nested loops
            // Some loops can be nested within others
            for (int r = 1; r < 6; r++)
            {
                for (int t = 1; t < 6; t++)
                {
                    Console.Write($"{r * t} \t");
                }
                Console.WriteLine();
            }

        }
    }
}
