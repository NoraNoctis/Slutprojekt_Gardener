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

        private string statusAlive = "Yes";
        private string statusWater = "Watered";
        private string statusGrowth;
       // protected string trivia; - i konstruktor för specifik växt

        public Plants()
        {
            watered = true;
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
        protected void Grow () 
        {
            if (watered ==true)
            {
                growthstage ++;

                if (growthstage>= maxGrowth)
                {
                    growthstage = maxGrowth;
                    fullgrown = true;
                    statusGrowth = "Fullgrown and ready to harvest";

                }
            }
            statusGrowth = growthstage + "/" + maxGrowth;

        }
        protected void Drink()
        {
            waterCount ++;
        }
        public void WaterPlant ()
        {
            watered = true;
            waterCount = 0;
            dryCount = 0;

        }
        protected void CheckWater()
        {
            if (waterCount>needWater)
            {
                watered = false;
                dryCount ++;
                statusWater = "Needs to be watered";
            }
        }
        protected bool CheckAlive()
        {
            if (dryCount> 5)
            {
                alive = false;
                statusAlive = "No";
            }
            return alive;
        }
        public void Timepass() // kör alla metoder som ska ske när tid går
        {
            CheckWater();
            Grow();
            Drink();
            CheckAlive();

        }

        public void DisplayInfo()
        {
            Console.WriteLine("Plant: "+ plantName);
            Console.WriteLine("Type: "+ plantType);
            Console.WriteLine("Growth: " + statusGrowth);
            Console.WriteLine("Care: "+statusWater);
            Console.WriteLine("Alive: "+statusAlive);
            int v = PrizeWorth();
            Console.WriteLine("Estimated Value: "+ v);
            //Console.WriteLine("Other info: "+trivia); 
        }





    }
    
    
}
