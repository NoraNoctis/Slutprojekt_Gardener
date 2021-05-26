using System;

namespace Gardener
{
    public class Carrot:Vegetable
    {
        static Random GenC = new Random();
        public Carrot()
        {
            plantName = "Carrot";
            int q = GenC.Next(1,4);

            quality = q;
            


        }
    }
}
