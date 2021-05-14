using System;

namespace Gardener
{
    public class Basil:Herb
    {
        static Random Gen = new Random();
        public Basil()
        {
            plantName = "Basil";
            int q = Gen.Next(1,3);

            quality = q;
            


        }
    }
}
