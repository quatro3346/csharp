using System;

namespace Rectangle
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника:");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину прямоугольника:");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());

            double rectangleArea = rectangleLength * rectangleWidth;
            Console.WriteLine("Площадь прямоугольника = " + rectangleArea);
            double rectanglePerimeter = (rectangleLength + rectangleWidth) * 2;
            Console.WriteLine("Периметр прямоугольника = " + rectanglePerimeter);
            Console.WriteLine("Длина = {0:f}, Ширина = {1:f}, Площадь = {2:f}, Периметр = {3:f}", rectangleLength, rectangleWidth, rectangleArea, rectanglePerimeter);
        }
    }
}
