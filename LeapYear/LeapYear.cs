using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 != 0 || year % 100 == 0 && year % 400 != 0)
            {
                Console.WriteLine(year + " - невисокосный год");
            }
            else
            {
                Console.WriteLine(year + " - високосный год");
            }
        }
    }
}
