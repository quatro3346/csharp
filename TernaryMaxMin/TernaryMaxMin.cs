using System;

namespace TernaryMaxMin
{
    class TernaryMaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int max = (number1 > number2) ? number1 : number2;
            int min = (number1 < number2) ? number1 : number2;
            Console.WriteLine("Наибольшее число: " + max);
            Console.WriteLine("Наименьшее число: " + min);
        }
    }
}
