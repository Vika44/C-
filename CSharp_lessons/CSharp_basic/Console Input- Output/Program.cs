using System;

namespace Console_Input__Output
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have already used the built-in Console.WriteLine method to output
            // information to the console. That is, if we want to display some information on the console,
            // then we need to pass it to the Console.WriteLine method:

            string table = "raund";
            int chair = 4;
            Console.WriteLine($" table type: {table} chair: {chair}"); //  Console output

            //Console.Write (), it works exactly the same, except that it does not add a line break,
            //meaning subsequent console output will be output on the same line.

            //In addition to outputting information to the console, we can receive information from the console.
            //The Console.ReadLine() method is intended for this.
            //It allows you to get the entered string.

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); // Console output
            Console.WriteLine($"Hi: {name}");

            // A feature of the Console.ReadLine () method is that it can
            // read information from the console only as a string.

            //Convert.ToInt32()-(Converts to int)
            //Convert.ToDouble()-(Converts to double)
            //Convert.ToDecimal()-(Converts to decimal)

            Console.Write("Favourite color: ");
            string color = Console.ReadLine();

            Console.Write("Favourite size: ");
            int size = Convert.ToInt32(Console.ReadLine());
   
            Console.Write("Brush lenght: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Color: {color}  Size: {size}  Brush: {length}");


        }
    }
}
