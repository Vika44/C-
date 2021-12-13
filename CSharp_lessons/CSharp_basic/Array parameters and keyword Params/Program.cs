using System;

namespace Array_parameters_and_keyword_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Array_parameters_and_keyword_Params
            void Sum(params int[] numbers) //When you call the method to place a parameter with the Params modifier,
                                           //we can transfer both separate values ​​and an array of values, or do not
                                           //transmit parameters at all.
            {
                int result = 1;
                foreach ( int n in numbers)
                {
                    result *= n;
                }
                Console.WriteLine(result);
            }

            int[] nums = { 1, 2, 3, 4, 5 };
            Sum(nums);
            Sum(1, 2, 3, 4);
            Sum(1, 2, 3);
            Sum();

            // If we need to pass any other parameters, they must be specified
            // before the parameter with the key word Params:
            void Sum2(int firsthnumber, params int[] numbers)
            {
                int result = firsthnumber;
                foreach(int n in numbers)
                {
                    result *= n;
                }
                Console.WriteLine(result);
            }
            int[] nums1 = { 1, 2, 3, 4, 5 };
            Sum2(4, nums1);
            Sum2(1, 2, 3, 4);
            Sum2(1, 2, 3);
            Sum2(15);

            // Array as a parameter
            void Sum3( int[] numbers, int firsthnumber) // In contrast to the method with parameter Params,
                                                        // other parameters can be located after the array parameter.
            {
                int result = firsthnumber;
                foreach (int n in numbers)
                {
                    result *= n;
                }
                Console.WriteLine(result);
            }
            int[] nums2 = { 1, 2, 3, 4, 5 };
            Sum3(nums2, 4); // Since the SUM method takes an array as a parameter
                            // without a keyword Params, then when it is called,
                            // we must convey an array as the first parameter.


        }
    }
}
