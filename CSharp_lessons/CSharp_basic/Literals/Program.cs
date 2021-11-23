using System;

namespace Literals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Literals represent immutable values ​​(sometimes called constants);
            // Literals can be passed to variables as values;

            // Literals can be logical-true and false

            // integer
            Console.WriteLine(-11);
            Console.WriteLine(5);      //decimal form
            Console.WriteLine(505);

            Console.WriteLine(0b11);        // 3
            Console.WriteLine(0b1011);      // 11  binary form
            Console.WriteLine(0b100001);    // 33 

            Console.WriteLine(0x0A);    // 10
            Console.WriteLine(0xFF);    // 255  hexadecimal form
            Console.WriteLine(0xA1);    // 161

            // real
            Console.WriteLine(5.14);
            Console.WriteLine(200.221);
            Console.WriteLine(-0.20);

            // character
            Console.WriteLine('4');
            Console.WriteLine('k');
            Console.WriteLine('j');

            // String literals
            Console.WriteLine("hello");
            Console.WriteLine("love");
            Console.WriteLine("name");

            // escape specific characters in C# string
            // '\n' - line feed
            // '\t' - tab
            // '\'  - slash

            // null - no values
        }
    }
}
