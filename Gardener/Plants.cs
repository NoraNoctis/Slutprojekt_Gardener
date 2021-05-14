using System;

namespace Gardener
{
    public class Plants
    {
        protected string plantType;
        protected string plantName;

        private bool alive;

        bool watered; //blokerar grow
        protected int waterCount; // ökar efter grow, gämnförs med needWater
        protected int needWater; //hur ofta (tid) plantan behöver vattnas, 
        private int dryCount; // up if watered false, dead after 5 (tid)

        protected  bool fullgrown; 
        protected int growthstage;
        protected int maxGrowth; 

        protected int typeWorth;
        protected int quality;

        public Plants()
        {
            watered = false;
            waterCount = 0;
            dryCount = 0;
            growthstage = 0;
            fullgrown = false;
            alive = true;
            
        }
        public int PrizeWorth()
        {
            int t = 10 * typeWorth;
            int q = 2 * quality;
            int finalPrize = 1 + t + q;
            return finalPrize;

        }
        Public void DisplayInfo ()
        {
            
        }


    }
    
    // check water
    // water
    // check growth
    // check alive
    // grow
    // display info
}
