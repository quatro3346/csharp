using System;

namespace String
{
    class String
    {
        static void Main(string[] args)
        {
            string home = "Дом,";
            string sweetHome = "Милый дом";
            Console.WriteLine(home + Environment.NewLine + sweetHome);

            string date = @"""30""августа 2014г.";
            string link = @"C:\Windows\System32\Drivers\etc\hosts";
            Console.WriteLine(date + Environment.NewLine + link);

            Console.WriteLine("Result = " + (29 + 2) * 3);
        }
    }
}
