namespace ClasesYObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // la clase se comvierte en un molde para generar muchos objetos del mismo tipo
            Console.WriteLine("Hello, World!");
            Sale sale1= new Sale(100,DateTime.Now); 
            sale1.Show();  
            Console.WriteLine(sale1.GetInfo());
            
        }
    }

    class Sale
    {

        int total;
        DateTime date;

        // Se crea un constructor igual a la clase para forzar properties de entrada, es un metodo aqui forzamos los properties

        public Sale(int total, DateTime date) {
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