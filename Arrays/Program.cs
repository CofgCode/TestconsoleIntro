using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // arreglos guardan collecciones
            // es una variable que guarda muchos elementos
            string[] friends = new string[7];
            // se numeran en el cero como en C
            friends[0] = "Hector";
            Console.WriteLine("" + friends[0] );

            // aqui el null indica que la ultima posicion esta vacio
            string[] friends2 = new string[7]
            {
                "Pancho","Paco","Ana","Ruben","Karla","Luis",null
            };

            Console.WriteLine(" Este es" , friends2[5]);
            Console.WriteLine( friends2[5]);

            Console.WriteLine(" Este es vacio", friends2[6]);
            Console.WriteLine( friends2[6]);


        }
    }
}
