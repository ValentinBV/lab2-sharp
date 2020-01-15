using System;
using System.Collections.Generic;
using System.Text;

namespace Labs2
{
    class TestGarage
    {
        
        public static void test()
        {
            Console.WriteLine("\nТест создания авто\n");
            PassengerCar passCar = new PassengerCar(CarsType.Hatchback, 1300);
            passCar.ParkToGarage();
            passCar.OutFromGarage();
            Console.WriteLine("\nТест создания гаража\n");
            SmallGarage garage = new SmallGarage(4);
            Console.WriteLine(garage.ParkCar(passCar));
            Console.WriteLine(garage.ParkCar(passCar));
            Console.WriteLine(garage.RemoveCar(passCar));
            Console.WriteLine(garage.RemoveCar(passCar));
            garage[0] = passCar;
            garage[0].ParkToGarage();
        }
    }
}
