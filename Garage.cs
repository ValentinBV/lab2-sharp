namespace Labs2
{
    abstract class Garage
    {
        protected int currentCarsCount = 0;
        protected int maxCarCount = 0;
        protected Car[] carsList;

        public bool CheckFreeBoxes()
        {
            if (currentCarsCount < maxCarCount)
            {
                return true;
            }
            return false;
        }

        public virtual int ParkCar(Car car)
        {
            if (car.ParkToGarage() == 1)
            {
                currentCarsCount++;
                return currentCarsCount;
            }
            return 0;
        }
        public virtual int RemoveCar(Car car)
        {
            if (car.OutFromGarage() == 1)
            {
                currentCarsCount--;
                return currentCarsCount;
            }
            return 0;
        }
        public Car this[int index]
        {
            get
            {
                return carsList[index];
            }
            set
            {
                carsList[index] = value;
            }
        }
    }
}
