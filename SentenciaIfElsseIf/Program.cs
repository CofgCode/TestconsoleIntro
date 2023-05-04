using System;

namespace SentenciaIfElsseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool areyouhungry = true;
            bool youhavemoney = true;

            if (areyouhungry && youhavemoney && IsOpenRestaurant("Lonches Pepe",9))
            {
                Console.WriteLine("Hello World, you can eat!");
            }
            else
            { 
                Console.WriteLine("no comes");
            
            }


        }

        static bool IsOpenRestaurant(string name, int hour = 0)
        {

            if (name == "Lonches Pepe" && hour > 8 && hour < 23)
            {

                return true;
            }
            else if (name == "Restaurant 24 hours")
            {
                return true;
            }
            else
            { return false;
            
            }




        }
    }
}
