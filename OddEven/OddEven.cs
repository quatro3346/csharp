using System;
using System.Xml.Schema;

namespace OddEven
{
    class OddEven
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите целое число:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Данное число - четное");
            }
            else
            {
                Console.WriteLine("Данное число - нечетное");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Данное число кратно 5");
            }
            else
            {
                Console.WriteLine("Данное число не кратно 5");
            }
        }
    }
}