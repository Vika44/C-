using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            // An array represents a set of data of the same type.

            int[] nums = new int[6]; //Here, at the beginning, we declared an array nums
                                     //that will store data of type int. Then, using the new
                                     //operation, we allocated memory for 6 array elements:
                                     //new int [6]. The number 6 is also called the length of the
                                     //array. With this definition, all elements have a default
                                     //value that is provided for their type. For int, the default is 0.

            int[] nums2 = new int[6] { 1, 2, 3, 4, 5, 6 };

            int[] nums3 = new int[] { 1, 2, 3, 4, 5, 6 };
            // All of the above methods will be equivalent.
            int[] nums4 = new[] { 1, 2, 3, 4, 5, 6 };

            int[] nums5 = { 1, 2, 3, 4, 5, 6 };

            string[] members = { "Ann", "Mary", "Jack", "Mark" }; //  type string

            // Indexes and Retrieving Array Elements

            // Indexes are used to refer to the elements of an array. The index represents the number
            // of the element in the array, with the numbering starting at zero, so the index of the
            // first element will be 0, the index of the fourth element will be 3.
            int[] numbers = { 1, 2, 3, 5, 6 };

            // get an array element
            Console.WriteLine(numbers[4]);  // 6

            // getting an array element into a variable
            var n = numbers[2];     // 3
            Console.WriteLine(n);  // 3

            int[] people = { 1, 2, 3, 5, 6 };

            // change the second element of the array
            people[2] = 8;

            Console.WriteLine(people[2]);  //8 

            // Length property and array length
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numbers.Length);  // 10

            int[] numb = { 1, 2, 3, 4, 5, 6, 7 };

            Console.WriteLine(numb[numb.Length - 1]);  // 7 - last element from the end
            Console.WriteLine(numb[numb.Length - 2]);  // 6 - the penultimate element from the end
            Console.WriteLine(numb[numb.Length - 3]);  // 5 - third element from the end

            // Iterating over arrays
            int[] nuts = { 1, 2, 3, 4, 5, 6, };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            int[] nuds = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * 2;
                Console.WriteLine(numbers[i]);
            }

            //Arrays are characterized by such concepts as rank or number of dimensions.
            //Above, we considered arrays that have one dimension (that is, their rank is 1) - such arrays
            //can be represented as a row (row or column) of an element. But arrays can also be multidimensional.
            //Such arrays have a number of dimensions (that is, rank) greater than 1.
            int[] nujs1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            int[,] nujs2 = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 } };
        }
    }
}
