using System;
using System.Collections.Generic;

namespace Gardener
{
    public class Player
    {
        //inventory: money (int), seeds(int), grown plants (list: class instanser (add/remove))
       public int money = 0;
       public int seeds = 3;

       List<Plants> inInventory = new List<Plants>();


    }
}
