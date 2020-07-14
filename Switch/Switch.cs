using System;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
            const int sum = 1;
            const int sub = 2;
            const int multi = 3;
            const int division = 4;

            Console.WriteLine("Введите два числа:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите код команды от 1 до 4");
            int userCommand = Convert.ToInt32(Console.ReadLine());
            switch (userCommand)
            {
                case sum:
                    Console.WriteLine("Сумма = " + (firstNumber + secondNumber));
                    break;
                case sub:
                    Console.WriteLine("Вычетание = " + (firstNumber - secondNumber));
                    break;
                case multi:
                    Console.WriteLine("Умнножение = " + (firstNumber * secondNumber));
                    break;
                case division:
                    Console.WriteLine("Деление = " + (firstNumber / secondNumber));
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    break;
            }
        }
    }
}
