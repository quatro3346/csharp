using System;

namespace MaxMin
{
    class MaxMin
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Введите два целых числа:");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("Наибольшее число: " + firstNumber);
                Console.WriteLine("Наименьшее число: " + secondNumber);
            }
            else if(firstNumber == secondNumber)
            {
                Console.WriteLine("Числа равны");
            }
            else
            {
                Console.WriteLine("Наибольшее число: " + secondNumber);
                Console.WriteLine("Наименьшее число: " + firstNumber);
            }
        }
    }
}
