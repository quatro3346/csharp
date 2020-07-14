using System;

namespace PrintSum
{
    class PrintSum
    {
        static void Main(string[] args)
        {
            const string printCommand = "print";
            const string sumCommand = "sum";

            Console.WriteLine("Введите команду:");
            string userCommand = Console.ReadLine();
            switch (userCommand)
            {
                case printCommand:
                    Console.WriteLine("Введите строку:");
                    string userLine = Console.ReadLine();
                    Console.WriteLine(userLine);
                    break;
                case sumCommand:
                    Console.WriteLine("Введите два вещественных числа:");
                    double firstNumber = Convert.ToDouble(Console.ReadLine());
                    double secondNumber = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Сумма чисел = " + (firstNumber + secondNumber));
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}