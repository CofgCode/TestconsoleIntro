using System;

namespace SentenciaWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            while (i < 10)
            {

                Console.WriteLine("Iteracion de I: " + i);
                i++;
            }
            Console.WriteLine("Hello World!");

            int j = 0;
            while (j < 100)
            {
                if (j > 20) break; 
                
                    
                Console.WriteLine("Iteracion de j: " + j);
                           j++;
            }


            string[] friends2 = new string[7]
            {
                "Pancho","Paco","Ana","Ruben","Karla","Luis",null
            };

            int index = 0;
            while (index < friends2.Length) 
            { 
                
                Console.WriteLine(" Este es " + friends2[index]); 
                index++; 
            }

            bool run = false;
            do
            {
                Console.WriteLine("Entro una vez y sale");
                showmefunctioncall();
            }    
            while (run);

        }

        static void showmefunctioncall()
        {
            Console.WriteLine("probando DO WHILE con una sola entrada");
                }
    }
}
