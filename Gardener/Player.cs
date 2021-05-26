using System;
using System.Collections.Generic;

namespace Gardener
{
    public class Player
    {
        //fungerar som spelarens inventory
        // inehåller : money (int), seeds(int), grown plants (list: class instanser (add/remove))
        // tar också in input 
        
          // inventory:      
       public int money ;
       public int seeds ;

       List<Plants> inInventory = new List<Plants>();
       public  Player()
       {
           money = 0;
           seeds = 3;

       }



       // update, uppdaterar mängden pengar och frön inventory efter köp, försäljning, plantering 


    }
}
