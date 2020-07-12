using System;

namespace Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Приветствую вас, " + name + "!");
        }
    }
}
