using System;

namespace Gardener
{
    public class Garden: Rooms
    {
        static Random Gen = new Random();
        //string [] pots = {"pot A", "pot B", "pot C", "pot D","pot E"};
        bool emptyPotA = true;
       // bool emptyB = true;
       // bool emptyC = true;
       // bool emptyD = true;
       // bool emptyE = true;

        //string selectedPot;
        //posible actions: select pots (10/ 5?), leave
        // pot selected: check empty (bool)> Yes = plant / No = water, harvest, Remove, display info

        // check if pot is empty
        public void PlantPlant()
        {
           int x =  Gen.Next(5);

           if (x ==0)
           {
               Plants pottedPlant = new Aster();
           }
           if (x ==1)
           {
               Plants pottedPlant = new Basil();
           }
           if (x ==2)
           {
               Plants pottedPlant = new Carrot();
           }
           if (x ==3){Plants pottedPlant = new Lily();}
           if (x ==4){Plants pottedPlant = new Parsly();}
           if (x ==5){Plants pottedPlant = new Tomato();}

           

        }

        public void Water()
        {
            pottedPlant.WaterPlant();
        }

    }
}
