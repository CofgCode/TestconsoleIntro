namespace ObjectProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Sale mysale = new Sale(100, DateTime.Now);
            // acceder este atributo es posible porque se creo abajo un 
            Console.WriteLine(mysale.Total);  
            mysale.Total = -4545154;

            Console.WriteLine(mysale.Total);
            Console.WriteLine(mysale.Date);
            
            // note que al estar en modo lectura no permite hacer cambios de datos, solo existe el accesors en modo GET
            //mysale.Date= DateTime.Now;


        }


        class Sale
        {
            // estos atributos no se pueden acceder directamente al instanciar un objeto
            // private int total;    esta forma tambien seria valida, y el accesors nos permitira  accederlo porque el permanece publico.
            private int total;
            private DateTime date;

            //para poder saber un valor de estos atributos o cambiarlos, se debe definir un ACCESORS
            public int Total
            {   get 
                { return total; 
                    // aqui aplicamos un formato especial al retornar un valor
                    //return total.ToString("#.00");
                }
                set 
                {   if (value < 0) {  value=0; }
                    total = value;
                 }
            }
            public string Date
            {   get {  return date.ToLongDateString(); }
             }
            // Se crea un constructor igual a la clase para forzar properties de entrada, es un metodo aqui forzamos los properties

            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;

            }

            public string GetInfo()
            {
                return total + "" + date.ToLongDateString();
            }


            public void Show()
            {

                // no es una buena practica hacer esto, lo ideal es hacer alguna operación y retornar al programa principal
                // y el programa principal recibe el resultado y decide si imprime o guarda o hace otra actividad
                Console.WriteLine("Hola soy una venta");

            }

        }


    }
}