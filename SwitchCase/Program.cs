using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 5;
            switch(op)
            {
                case 0: Console.WriteLine("Hello World!"); break;
                case 1: Console.WriteLine("opcion 2"); break;
                case 2:
                case 3: Console.WriteLine("opcion 2 o 3"); break;
                case < 0:
                case > 100:
                    Console.WriteLine("fuera de rango"); break;
                case > 4 and < 10: Console.WriteLine(" rango entre 4 y 10"); break;

                default: Console.WriteLine("Solo hay 10 opciones validas"); break;


            }

            
            


        }
    }
}
