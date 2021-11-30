using System;

namespace Assignment_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 44; // = assigns the value of the right operand to the left operand:

            // + =: assignment after addition. Assigns the left operand to the sum of the left and right operands:
            // A + = B is the same as A = A + B
            int a = 2;
            a += 10;
            Console.WriteLine(a); // 12

            // - =: assignment after subtraction. Assigns to the left operand the difference between the left and right operands:
            // A - = B is equivalent to A = A - B
            int b = 40;
            b -= 30;
            Console.WriteLine(b); // 10

            // * =: assignment after multiplication. Assigns the left operand to the product of the left and right operands:
            // A * = B is equivalent to A = A * B
            int c = 5;
            c *= 4;
            Console.WriteLine(c); // 20

            // / =: assignment after division. Assigns the quotient of the left and right operands to the left operand:
            // A / = B is equivalent to A = A / B
            int d = 60;
            d /= 6;
            Console.WriteLine(d); // 10

            // % =: assignment after modulo division. Assigns the left operand the remainder of the integer division of the left operand by the right:
            // A% = B is equivalent to A = A% B
            int f = 10;
            f %= 4;
            Console.WriteLine(f); // 2

            // & =: assignment after bitwise conjunction. Assigns the left operand the result of the bitwise conjunction of
            // its bit representation with the bit representation of the right operand: A & = B is equivalent to A = A & B

            // | =: assignment after bitwise disjunction. Assigns the left operand the result of a bitwise disjunction of its bit
            // representation with the bit representation of the right operand: A | = B is equivalent to A = A | B

            // ^ =: assignment after exclusive OR operation.Assigns the left operand the exclusive OR result of
            // its bit representation with the bit representation of the right operand: A ^ = B is equivalent to A = A ^ B

            // << =: assignment after shifting the digits to the left. Assigns the left operand the result of shifting its bit representation
            // to the left by a specified number of bits, equal to the value of the right operand: A << = B is equivalent to A = A << B
            int h = 7;
            h <<= 4;
            Console.WriteLine(h); // 112

            // >> =: assignment after shifting the bits to the right. Assigns the left operand the result of shifting its bit representation
            // to the right by a specified number of bits, equal to the value of the right operand: A >> = B is equivalent to A = A >> B
            int r = 10;
            r >>= 2;
            Console.WriteLine(r); // 2
        }
    }
}
