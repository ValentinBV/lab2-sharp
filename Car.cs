namespace Labs2
{
    abstract class Car
    
    {
        public string number { get; set; }
        public CarsType carsType;
        public double fullWeight { get; set; }

        public Car(CarsType type, double weight)
        {
            carsType = type;
            fullWeight = weight;
        }
        public abstract int ParkToGarage();

        public virtual int OutFromGarage()
        {
            return 1;
        }
    }
}
