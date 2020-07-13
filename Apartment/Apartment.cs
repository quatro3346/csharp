using System;

namespace Apartment
{
    class Apartment
    {
        static void Main(string[] args)
        {
            int floorsCount;
            int entrancesCount;
            int totalApartments;
            int totalApartmentsEntrance;
            int requiredEntrance;
            int requiredFloor;
            int apartment;
            const int apartmentsOnFloor = 4;
            int firstApartmentOnFloor;
            int apartmentPosition;

            Console.WriteLine("Введите количество этажей:");
            floorsCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов:");
            entrancesCount = Convert.ToInt32(Console.ReadLine());

            totalApartments = entrancesCount * floorsCount * apartmentsOnFloor;
            totalApartmentsEntrance = floorsCount * apartmentsOnFloor;

            Console.WriteLine("Введите номер квартиры:");
            apartment = Convert.ToInt32(Console.ReadLine());
            if (apartment > totalApartments)
            {
                Console.WriteLine("Квартиры с таким номером нет в доме");
                return;
            }

            if (apartment % totalApartmentsEntrance == 0)
            { 
                requiredEntrance = apartment / totalApartmentsEntrance; 
            }
            else
            { 
                requiredEntrance = apartment / totalApartmentsEntrance + 1;
            }
            Console.WriteLine("Подъезд: " + requiredEntrance);

            requiredFloor = floorsCount - ((totalApartmentsEntrance * requiredEntrance - apartment) / apartmentsOnFloor);
            Console.WriteLine("Этаж: " + requiredFloor);

            firstApartmentOnFloor = (requiredEntrance - 1) * totalApartmentsEntrance + ((requiredFloor - 1) * apartmentsOnFloor) + 1;

            apartmentPosition = apartment - firstApartmentOnFloor + 1;
            if (apartmentPosition == 1)
            {
                Console.WriteLine("Ближняя слева");
            }
            else if (apartmentPosition == 2)
            {
                Console.WriteLine("Дальняя слева");
            }
            else if (apartmentPosition == 3)
            {
                Console.WriteLine("Дальняя справа");
            }
            else
            {
                Console.WriteLine("Ближняя справа");
            }
        }
    }
}
