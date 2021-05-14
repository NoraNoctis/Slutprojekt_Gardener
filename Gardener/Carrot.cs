using System;

namespace Gardener
{
    public class Carrot:Vegetables
    {
        static Random Gen = new Random();
        public Carrot()
        {
            plantName = "Carrot";
            int q = Gen.Next(1,4);

            quality = q;
            


        }
    }
}
