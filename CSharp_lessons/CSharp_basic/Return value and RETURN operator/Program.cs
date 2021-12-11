using System;

namespace Return_value_and_RETURN_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Methods can also return some meaning. To do this, the Return statement
            // is applied, after which the return value is:
            string GetMessage()
            {
                return "Hello";
            }

            string Getsm()
            {
                return "bye";
            }
            string word = Getsm(); // // Get the result of the method into the variable message
            Console.WriteLine(word);

            // Transfer as a value of the parameter of another method:
            string GetMessagee()
            {
                return "Family";
            }
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            PrintMessage(GetMessagee());
            PrintMessage("Father");

            // After the RETURN statement, you can also specify complex
            // expressions or calls for other methods that return a certain result.
            int Sum(int a, int b)
            {
                return a + b;
            }

            int result = Sum(14, 15);   
            Console.WriteLine(result);  
            Console.WriteLine(Sum(5, 6));

            // The Return statement not only returns a value,
            // but also produces a way out of the method.
            void PrintPerson(string name, int age)
            {
                if (age > 120 || age < 1)
                {
                    Console.WriteLine("Invalid age");
                    return;
                }
                Console.WriteLine($"Name: {name}  Age: {age}");
            }

            PrintPerson("Mary", 25);         
            PrintPerson("Angel", 166);    
        }
    }
}
