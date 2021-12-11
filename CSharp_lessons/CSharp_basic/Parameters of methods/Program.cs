using System;

namespace Parameters_of_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Parameters allow you to transfer some input to the method.
            // Parameters are determined by heated in brackets after the name of the method as:
            
            // Type string
            void PrintMessage(string name)
            {
                Console.WriteLine(name);
            }

            PrintMessage("Nika");  
            PrintMessage("Mary"); // arguments
            PrintMessage("Ann");

            // Type int 
            void Sum(int a, int b)
            {
                int result = a * b;
                Console.WriteLine($"{a} * {b} = {result}");
            }

            Sum(4, 5);
            // Parameters can be used in a reduced version of the method:
            void Sum1(int a1, int b1) => Console.WriteLine($"{a1} + {b1} = { a1 + b1 }");

            Sum1(40, 45);

            // The value transmitted parameter can represent the values ​​of variables or the
            // result of the complex expressions that return a certain value:
            void Sum2(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");

            int d = 5, j = 15, k = 20;
            Sum2(d, j);
            Sum2(20, k);
            Sum2(25, 25 + j);

            // Optional parameters
            void PrintPerson(string name, int age = 40, string company = "Soft")
            {
                Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            }

            PrintPerson("Ann", 25, "Avis");       // Name: Ann  Age: 25    Company: Avis
            PrintPerson("Ann", 24);               // Name: Ann  Age: 24    Company: Soft
            PrintPerson("Ann");                   // Name: Ann  Age: 40    Company: Soft

            // Named parameters
            void Person(string name, int age = 20, string company = "Soft")
            {
                Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
            }

            Person("Nik", company: "Microsoft", age: 37); 
            Person(age: 41, name: "Ann");
            Person(company: "Google", name: "Ray"); 
            // To transmit values, the names of the name when calling the method indicates the name of
            // the parameter and through the colon of its value: name: "Tom"
        }
    }
}
