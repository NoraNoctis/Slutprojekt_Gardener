using System;

namespace Gardener
{
    public class Tomato:Vegetables
    {
        static Random Gen = new Random();
        public Tomato()
        {
            plantName = "Tomato";
            int q = Gen.Next(1,5);

            quality = q;
            


        }
    }
}
