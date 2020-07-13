using System;

namespace Circle
{
    /// <summary>
    /// Этот класс c названием домашнего задания - Circle
    /// </summary>
    class Circle
    {
        static void Main(string[] args)
        {
            // радиус стадиона указан в метрах
            double stadiumRadius = 15.0;

            double stadiumArea = Math.PI * Math.Pow(stadiumRadius, 2);
            Console.WriteLine("Stadium area = " + stadiumArea);

            double stadiumCircumference = 2 * Math.PI * stadiumRadius;
            Console.WriteLine("Stadium circumference = " + stadiumCircumference);

            double domeBaseArea = 275.0; /* площадь задана по
                                                      окружности купола*/
            double domeRadius = Math.Sqrt(domeBaseArea / Math.PI);
            Console.WriteLine("Dome radius = " + domeRadius);

            //TODO: угол задан в градусах, потом перевести в радианы и переписать код
            double radius = 83.0;
            double angleInDegrees = 138.0;

            double sectorArea = Math.PI * Math.Pow(radius, 2) * (angleInDegrees / 360);
            Console.WriteLine("Sector area = " + sectorArea);
        }
    }
}
