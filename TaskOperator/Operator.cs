using System;

namespace Operator
{
    class Operator
    {
        static void Main(string[] args)
        {
            int a = 61;
            int b = 30;

            int additionIntegers = a + b;
            Console.WriteLine("Addition integers = " + additionIntegers);

            int subtractIntegers = a - b;
            Console.WriteLine("Subtract integers = " + subtractIntegers);

            int divisionIntegers = a / b;
            Console.WriteLine("Division integers = " + divisionIntegers);

            int multiplicationIntegers = a * b;
            Console.WriteLine("Multiplication integers = " + multiplicationIntegers);

            int remainderIntegerDivision = a % b;
            Console.WriteLine("Remainder of integer division = " + remainderIntegerDivision);


            double c = 85.0;
            double d = 29.0;

            double additionRealNumbers = c + d;
            Console.WriteLine("Addition real numbers = " + additionRealNumbers);

            double subtractRealNumbers = c - d;
            Console.WriteLine("Subtract real numbers = " + subtractRealNumbers);

            double divisionRealNumbers = c / d;
            Console.WriteLine("Division real numbers = " + divisionRealNumbers);

            double multiplicationRealNumbers = c * d;
            Console.WriteLine("Multiplication real numbers = " + multiplicationRealNumbers);

            double remainderIntegerDivisionRealNumbers = c % d;
            Console.WriteLine("Remainder of integer division real numbers = " + remainderIntegerDivisionRealNumbers);
        }
    }
}