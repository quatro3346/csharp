using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            int year;

            Console.WriteLine("Введите год:");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                Console.WriteLine(year + " - високосный год");
            }
            else
            {
                Console.WriteLine(year + " - невисокосный год");
            }
        }
    }
}
