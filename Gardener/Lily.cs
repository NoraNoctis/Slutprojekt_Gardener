using System;

namespace Gardener
{
    public class Lily:Flower
    {
        static Random Gen = new Random();
        public Lily()
        {
            plantName = "Lily";
            int q = Gen.Next(3,6);

            quality = q;
            


        }
    }
}
