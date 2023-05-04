using System;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            
            Show();
            sum(1,2);
            sum(7, 8);
            int result = Mul(4,8);

            Console.WriteLine(result);
        }

        static int Mul(int num1, int num2)
        {

            return num1 * num2;
        }

        static void sum(int num1, int num2)

        {
            int num3 = num1 + num2;
            System.Console.WriteLine(num3);
            
            }

        static void Show()
        {
            Console.WriteLine("print text from function");

                
         }

    }
}
