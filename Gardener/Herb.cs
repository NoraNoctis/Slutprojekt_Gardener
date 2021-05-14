using System;

namespace Gardener
{
    public class Herb:Plants
    {
         public Herb()
        {
            plantType = "Herb";
            maxGrowth = 15;
            typeWorth = 1; 
            needWater = 5;
        }
    }
}
