using System;

namespace ForCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] friends = new string[10] 
            { "Pancho", "paco", "lucia", "poncho", "aleja", "bebe", "mas",null,null, null  
            };

            bool run = true;
            for ( int i=0; i<friends.Length && run; i++ )
            {
                Console.WriteLine(friends[i] );

            }



        }
    }
}
