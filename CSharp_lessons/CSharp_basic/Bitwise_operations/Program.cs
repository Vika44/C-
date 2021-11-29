using System;

namespace Bitwise_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logical operations

            // & (logical multiplication)
            // The multiplication is performed bit by bit, and if both operands have bit values ​​equal to 1,
            // then the operation returns 1, otherwise the number 0 is returned.

            int a1 = 3; //11
            int b1 = 5;//101
            Console.WriteLine(a1 & b1); //001 выведет 1

            int a2 = 2; //010
            int b2 = 5; //101
            Console.WriteLine(a2 & b2); //000 выведет 0

            // | logical addition
            // It looks like logical multiplication, the operation is also performed on binary digits,
            // but now one is returned if at least one number in the given digit has a one. 

            int c1 = 3; //011
            int d1 = 5;//101
            Console.WriteLine(c1 | d1); //111 выведет 7

            int c2 = 2; //010
            int d2 = 5; //101
            Console.WriteLine(c2 | d2); //111 выведет 7

            // ^ logical exclusive OR
            // If we have different values ​​of the current bit for both numbers, then 1 is returned,
            // otherwise 0 is returned.

            int x = 20; //The value to be encrypted is in binary form 10100
            int key = 145; // key - in binary 10010001

            int encrypt = x ^ key; // The result will be the number 10000101 or 133
            Console.WriteLine($"Encrypted number: {encrypt}");

            int decrypt = encrypt ^ key; // The result will be the original number 20
            Console.WriteLine($"Decrypted number: {decrypt}");

            // ~ logical negation or inverse
            // if the value of the digit is 1, then it becomes equal to zero, and vice versa.

            int g = 66;              // 1000010
            Console.WriteLine( ~g ); // 1000011  -67

            // Shift operations

            int a = 44; // в двоичной форме 101100
            int b = 2; // в двоичной форме
            int c = a << b; // Сдвиг числа 101100 влево на 2 разряда, равно 10110000 или 176 в десятичной системе

            Console.WriteLine($"Encrypted number: {c}");    // 64

            int d = a >> b; // Сдвиг числа 101100 вправо на 2 разряда, равно 1011 или 11 в десятичной системе
            Console.WriteLine($"Encrypted number: {d}");     //11
        }
    }
}
