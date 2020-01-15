using System;

namespace Labs2
{
    class PassengerCar : Car
    {
        public PassengerCar(CarsType type, double weight) : base(type, weight)
        {
            Console.WriteLine("Автомобиль создан");
            Console.WriteLine(type);
            Console.WriteLine(weight);
        }
        public override int ParkToGarage()
        {
            Console.WriteLine("Заехать передом");
            return 1;
        }
        public override int OutFromGarage()
        {
            Console.WriteLine("Выехать передом");
            return 1;
        }
    }
}
