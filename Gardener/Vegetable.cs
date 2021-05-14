using System;

namespace Gardener
{
    public class Vegetable:Plants
    {
        public Vegetable()
        {
            plantType = "Vegetable";
            maxGrowth = 25;
            typeWorth = 4; 
            needWater = 5;
        }
    }
}
