using System;

namespace Gardener
{
    public class Flower:Plants
    {
       static Random GenF = new Random();
        public Flower()
        {
            plantType = "Flower";
            int mG = GenF.Next(10,21);
            maxGrowth = mG;
            typeWorth = 2; 
            needWater = 3;
        }

    }
}
