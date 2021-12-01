using System;

namespace Conditional_expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional expressions
            // Comparison operations

            // ==  Compares two operands for equality. If they are equal,
            // then the operation returns true, if they are not equal, then false is returned:
            int a = 110;
            int b = 60;
            bool c = a == b; // false

            // != Compares two operands and returns true if the operands
            // are not equal, and false if they are equal.
            int chair = 8;
            int chair1 = 8;
            bool chair3 = chair != chair1;    // false
            bool chair4 = chair != 10;     // true

            // < Less than operation. Returns true if the first operand
            // is less than the second, and false if the first operand is greater than the second:
            int boy = 20;
            int girl = 8;
            bool h = a < b; // false

            // > Operation "greater than". Compares two operands and returns true if the
            // first operand is greater than the second, otherwise returns false:
            int boys = 20;
            int girls = 8;
            bool j = a > b;     // true
            bool k = a > 35;    // false

            // <= Less than or equal to operation. Compares two operands and returns true if
            // the first operand is less than or equal to the second. Returns false otherwise.
            int greenball = 20;
            int redball = 8;
            bool p = a <= redball; // false
            bool d = a <= 35;     // true

            // > = Greater than or equal to operation. Compares two operands and returns true
            // if the first operand is greater than equal to the second, otherwise it returns false:
            int blueball = 20;
            int pinkball = 8;
            bool l = a >= pinkball; // true
            bool t = a >= 35;     // false

            // | and || Logical addition or logical OR. Returns true if at least one of the operands returns true.
            bool x1 = (14 > 15) | (13 < 15); // 14 > 15 - false, 13 < 15 - true, so it returns true
            bool x2 = (14 > 15) | (13 > 15); // 14 > 15 - false, 13 > 15 - false, so it returns false

            //& and && Logical multiplication or logical AND operation. Returns true if both operands are simultaneously true.
            bool x3 = (14 > 15) & (13 < 15); // 14 > 15 - false, 13 < 15 - true, so it returns false
            bool x4 = (14 < 15) & (13 < 15); // 14 < 15 - true, 13 < 15 - true, so it returns true

            // ! Operation of logical negation. It is performed on one operand and returns true if the operand is false.
            // If the operand is true, then the operation returns false:
            bool o = true;
            bool w = !o; // false
            bool w1 = o; // true

            //^ Operation exclusive OR. Returns true if either
            //the first or the second operand (but not both) are true, otherwise it returns false
            bool x5 = (16 > 17) ^ (14 < 17); // 16 > 17 - false, 14 < 17 - true,   so it returns true
            bool x6 = (40 > 17) ^ (14 / 7 < 3); // 40 > 17 - true, 14/7 < 3 - true,  so it returns false
        }
    }
}
