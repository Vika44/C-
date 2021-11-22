using System;

namespace Variable_and_constant
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ann"; // define a variable and initialize it
            Console.WriteLine(name);
            name = "Lin"; // change the value of the variable
            Console.WriteLine(name);


            const int age = 20; // define a constant
            // age = 21; // ! Error - the value of a constant cannot be changed

        }
    }
}
