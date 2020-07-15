using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string password = "qwerty";
            
            Console.WriteLine("Введите пароль: ");
            string introducedPassword = Console.ReadLine();

            if (password.Equals(introducedPassword))
            {
                Console.WriteLine("Пароль верный");
            }
            else if (introducedPassword.Length > password.Length)
            {
                Console.WriteLine("Пароль неверный, введеная строка слишком длинная");
            }
            else if (introducedPassword.Length < password.Length)
            {
                Console.WriteLine("Пароль неверный, введеная строка слишком короткая");
            }
            else
            {
                Console.WriteLine("Пароль неверный");
            }
        }
    }
}