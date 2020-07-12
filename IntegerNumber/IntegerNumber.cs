using System;

namespace IntegerNumber
{
    class IntegerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                if (number > 5)
                    Console.WriteLine("Данное число > 5");
                else
                    Console.WriteLine("Данное число - положительное");
            }
            else if (number == 0)
            {
                Console.WriteLine("Данное число = 0");
            }
            else
            {
                Console.WriteLine("Данное число - отрицательное");
            }
        }
    }
}
