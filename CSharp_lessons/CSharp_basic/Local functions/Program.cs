using System;

namespace Local_functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Local functions
            // Local functions represent the functions
            // defined within other methods. Local function,
            // as a rule, contains actions that apply only within its method.
            void liken (int[] numbers1, int[] numbers2)
            {
                int numbers1Sum = Sum(numbers1);
                int numbers2Sum = Sum(numbers2);

                if (numbers1Sum > numbers2Sum)
                    Console.WriteLine("The amount of numbers from the array Numbers1 is more");
                else
                    Console.WriteLine("The amount of numbers from the numbers2 array more");

                int Sum(int[] numbers)
                {
                    int result = 0;
                    foreach (int number in numbers)
                        result += number;
                    return result;
                }
            }

            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 5, 6, 7, 8, 9,};

            liken(numbers1, numbers2);
        }

        // Static local functions
        // Local functions can be static. Such functions are determined using the keyword
        // static. Their feature is that they cannot access the environment variables,
        // that is, a method in which the static function is defined.
        int Sum(int[] numbers)
        {
            int result = 0;
            int limit = 0;
            foreach (int number in numbers)
            {
                if (IsPassed(number, limit)) result += number;
            }
            return result;

            static bool IsPassed(int number, int lim)
            {
                //return number > limit; // Error: ISPASSED method does not have access to Limit variable
                return number > lim;
            }
        }
    }
}
