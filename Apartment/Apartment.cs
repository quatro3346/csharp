using System;

namespace Apartment
{
    class Apartment
    {
        static void Main(string[] args)
        {
            int numberFloors;
            int numberEntrances;
            int totalNumberApartments;
            int totalNumberApartmentsEntrance;
            int entrance;
            int floor;
            int apartment;
            const int apartmentsFloor = 4;
            int position;
            int positionApartment;

            Console.WriteLine("Введите количество этажей:");
            numberFloors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов:");
            numberEntrances = Convert.ToInt32(Console.ReadLine());

            totalNumberApartments = numberEntrances * numberFloors * apartmentsFloor;
            totalNumberApartmentsEntrance = numberFloors * apartmentsFloor;

            Console.WriteLine("Введите номер квартиры:");
            apartment = Convert.ToInt32(Console.ReadLine());
            if (apartment > totalNumberApartments)
                Console.WriteLine("Квартиры с таким номером нет в доме");

            if (apartment % totalNumberApartmentsEntrance == 0)
                entrance = apartment / totalNumberApartmentsEntrance;
            else
                entrance = apartment / totalNumberApartmentsEntrance + 1;
            Console.WriteLine("Подъезд: " + entrance);

            floor = numberFloors - ((totalNumberApartmentsEntrance * entrance - apartment) / apartmentsFloor);
            Console.WriteLine("Этаж: " + floor);

            position = (entrance - 1) * totalNumberApartmentsEntrance + ((floor - 1) * apartmentsFloor) + 1;

            positionApartment = apartment - position + 1;
            if (positionApartment == 1)
                Console.WriteLine("Ближняя слева");
            else if (positionApartment == 2)
                Console.WriteLine("Дальняя слева");
            else if (positionApartment == 3)
                Console.WriteLine("Дальняя справа");
            else
                Console.WriteLine("Ближняя справа");
        }
    }
}
