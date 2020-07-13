using System;

namespace TernaryMaxMin
{
    class TernaryMaxMin
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int max;
            int min;

            Console.WriteLine("Введите 2 целых числа:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            secondNumber = Convert.ToInt32(Console.ReadLine());

            max = (firstNumber > secondNumber) ? firstNumber : secondNumber;
            min = (firstNumber < secondNumber) ? firstNumber : secondNumber;
            Console.WriteLine("Наибольшее число: " + max);
            Console.WriteLine("Наименьшее число: " + min);
        }
    }
}
