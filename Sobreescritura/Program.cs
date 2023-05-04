using System.Globalization;

namespace Sobreescritura
{
    internal class Program
    {
        static void Main(string[] args)
        {
                        
            Console.WriteLine("Hello, World!");

            B b = new B();
            // esta linea falla porque se invoca un metodo protegido en la clase principal no en la clase heredada
            //            Console.WriteLine("Clase inicial !"+  b.Hi());
            Console.WriteLine("Clase inicial !" + b.Hi());

            Sale sale = new Sale(10);
            sale.add(2);
            sale.add(8);
            Console.WriteLine("Clase suma arreglo:" + sale.GetTotal());

            SaleWithTax saleWithTax = new SaleWithTax(10, 1.16m);
            saleWithTax.add(2);
            saleWithTax.add(8);

            Console.WriteLine("Clase suma arreglo con tax:" + saleWithTax.GetTotal());



        }
    }


    public class Sale
    {
        // guion bajo es un elemento privado o un atributo  privado
        private decimal[] _amounts;
        private int _n;
        private int _end;   // conocer el final de los arreglos


        public Sale(int n) {
            // creo un arreglo basado en el numero de elementos que deseo
            _amounts = new decimal[n];
            _n = n;
            _end = 0; // inicializo esta variable
        
        }

        public void add(decimal amount)
        {
            if (_end < _n)
            {
                _amounts[_end] = amount;
                _end++;

            }
         }

        public virtual decimal GetTotal()
        {
            // recorrido del arreglo
            decimal result = 0;
            int i = 0;
            while (i<_amounts.Length)
            {
                result += _amounts[i];
                i++;


            }
            return result;
        }

    }

    public class SaleWithTax:Sale
    {

        private decimal _tax;
        // como hereda de una clase que recibe un entero en su constructor, toca obligado en la herencia de esta clase 
        // tener un entero, asi entonces defino el constructor de esta clase con el int y la base
        public SaleWithTax(int n, decimal tax) : base(n)
        {

            _tax = tax;
        }
        // la m del 1.16m es para el decimal
        public override decimal GetTotal()
        {

            //return base.GetTotal() * 1.16m;
            return base.GetTotal() * _tax;

        }




    }

    public class A
    {
        // esta clase protected solo puede ser accedida y ejecutada en los hijos
        //protected string Hi()
        
        // Escrito de esta manera no  puedo sobre escribirlo
        //public  string Hi()  

        // agrego la directiva virtual para poder sobreescribirlo en la clase heredada
        public virtual string Hi()
        {
            return "Hola Soy A";

        }

    }

    public class B: A
    {

        // USO ESTO PARA PODERLO LLAMAR EN EL HIJO
        //public void Test()
        //{
        //    Hi();

        //}

        public override string Hi()
        {
            return base.Hi() + " y Hola SOy B";
        }
    }

}