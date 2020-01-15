using System;
using System.Collections.Generic;
using System.Text;

namespace Labs2
{
    class SmallGarage : Garage
    {
        public SmallGarage()
        {
            carsList = new Car[5];
        }
        public SmallGarage(int maxGarageCarsCount)
        {
            maxCarCount = maxGarageCarsCount;
            carsList = new Car[maxGarageCarsCount];
        }
    }
}
