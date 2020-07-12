using System;

namespace exrrr
{
    class exxrr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника:");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника:");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Площадь прямоугольника:" + (rectangleWidth * rectangleLength));

            Console.WriteLine("Периметр прямоугольника:" + (rectangleWidth + rectangleLength) * 2);

            Console.WriteLine("Длина={0},Ширина={1},Площадь={2},Периметр={3}", rectangleLength, rectangleWidth, (rectangleLength * rectangleWidth), (rectangleWidth + rectangleLength) * 2);
        }
    }
}
