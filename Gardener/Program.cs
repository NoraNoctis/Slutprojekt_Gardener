using System;
using System.Collections.Generic;

namespace Gardener
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true; 

            while (play == true)
            {
                int room = Choise(new string[] {"Garden","Marketplase"});

                // dictionary actions?

                if (room == 0) // garden 
                { 
                    //posible actions: select pots (10), leave
                    // pot selected: check empty (bool)> +plant /- check growth, check water/water, harvest, display info
                    // leave > room ==3
                 
                 

                }
                else if (room == 1) // shop
                { 
                    // posible actions: buy, sell 
                    //inventory: money (int), seeds(int), grown plants (list: class instanser (add/remove))
                    // leave > room ==3
                


                }
                else if (room == 3)
                {

                }
                else 
                {
                    Console.WriteLine("sorry, code not working");
                }

                


            }


        

        }
        static int Choise(string[] options)
        {

            Console.WriteLine("Select where you want to go");
            Console.WriteLine("Your choises are:");
            int i = 0;
            int number = 1;
            int choise = -1;
            int R = options.Length;


            while (i < R)
            {
                Console.WriteLine(number + ") " + options[i]);
                i++;
                number++;

            }

            while (choise <= -1 || choise > R)
            {
                bool test = int.TryParse(Console.ReadLine(), out choise);
                if (test == false)
                {
                    Console.WriteLine("that is not an optional selection");

                }
                else if (choise <= -1 || choise > R)
                {
                    Console.WriteLine("that is not an optional selection");

                }

            }
            choise--;
            return choise;

        }
    }
}
