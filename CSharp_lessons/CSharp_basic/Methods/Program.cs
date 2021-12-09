using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //a method is a named block of code that performs some action.
            void SayHello()
            {
                Console.WriteLine("Hello"); //type void, which indicates that it
                                            //actually returns nothing, it just does some action.
            }

            SayHello(); // Hello
                        // method call

            void SayHelloIt()
            {
                Console.WriteLine("Ciao");
            }
            void SayHelloEn()
            {
                Console.WriteLine("Hello");
            }
            void SayHelloFr()
            {
                Console.WriteLine("Salut");
            }
            SayHelloEn();
            SayHelloIt();
            SayHelloFr();

            void SayBye() => Console.WriteLine("Bye"); // Abbreviated notation of methods
            SayBye();


        }
    }
}
