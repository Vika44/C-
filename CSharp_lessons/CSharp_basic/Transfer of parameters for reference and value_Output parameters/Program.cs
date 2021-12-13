using System;

namespace Transfer_of_parameters_for_reference_and_value_Output_parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Transfer parameters by value
            void Increment(int a)
            {
                a++;
                Console.WriteLine($"The number in the Increment method: {a}");
            }

            int num = 10;
            Console.WriteLine($"Number to the Increment method: {num}");
            Increment(num); // When transferring arguments to the parameters by value, the method parameter receives
                            // not the variable itself, and its copy continually works with this copy regardless of the variable itself.
            Console.WriteLine($"The number after the Increment method: {num}");

            // Transfer of parameters for reference and modifier REF
            void Decrement(ref int b)
            {
                b--;
                Console.WriteLine($"Number in the Decrement method: {b}");
            }

            int numb = 10;
            Console.WriteLine($"Number to the Decrement method: {numb}");
            Decrement(ref numb); // When the values ​​are transferred to the parameters by reference, the method receives
                                 // the address of the variable in memory. And, thus, if the method changes the value of the
                                 // parameter transmitted by the link, it also changes the value of the variable that is transmitted to its place ..
            Console.WriteLine($"Number after the Decrement method: {numb}");

            // Output parameters. Modifier Out.
            void Summ(int c, int d, out int result)
            {
                result = c * d;
            }

            int number;
            Summ(4, 11, out number);
            Console.WriteLine(number);

            void GetSquareData(int width, int heihgt, out int scuareArea, out int squarePerimetr)
            {
                scuareArea = width * heihgt;
                squarePerimetr = 4 * width;
            }

            
            GetSquareData(40, 40,  out int area, out int perimetr);
            Console.WriteLine($"Perimetr of Square: {perimetr}");
            Console.WriteLine($"Area of Square: {area}");

            // Input parameters. Modifier In.
            void GetRectangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
            {
                //width = 30; // You can not change, since width - input parameter
                rectArea = width * height;
                rectPerimetr = (width + height) * 2;
            }

            int w = 40;
            int h = 60;
            GetRectangleData(w, h, out var area1, out var perimetr1);

            Console.WriteLine($"Square rectangle: {area1}");       
            Console.WriteLine($"Perimeter of rectangle: {perimetr1}");        }
    }
}
