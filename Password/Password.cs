using System;

namespace Password
{
    class Password
    {
        static void Main(string[] args)
        {
            string password = "qwerty";
            
            Console.WriteLine("Введите пароль: ");
            string userPassword = Console.ReadLine();

            if (password.Equals(userPassword))
            {
                Console.WriteLine("Пароль верный");
            }
            else if (userPassword.Length > password.Length)
            {
                Console.WriteLine("Пароль неверный, введеная строка слишком длинная");
            }
            else if (userPassword.Length < password.Length)
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
