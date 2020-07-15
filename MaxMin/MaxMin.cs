using System;

namespace MaxMin
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Наибольшее число: " + number1);
                Console.WriteLine("Наименьшее число: " + number2);
            }
            else if(number1 == number2)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine("Наибольшее число: " + number2);
                Console.WriteLine("Наименьшее число: " + number1);
            }
        }
    }
}
