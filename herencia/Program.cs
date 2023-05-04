using System.Security.Cryptography.X509Certificates;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Doctor doctor1 = new Doctor("Juan ",40,"Cardiologo");
            // qui estamos usando el metodo que la clase people nos hereda
            Console.WriteLine(doctor1.GetInfo());

            // aqui estamos usando el metodo adicional que agregamos al heredar
            // en la clase Doctor
            Console.WriteLine(doctor1.GetData());

            // usemos la nueva clase para desarrollador
            Dev dev1 = new Dev("Hector",45,"C#");
            Console.WriteLine(dev1.GetInfo());
            Console.WriteLine(dev1.GetData());


        }

        class People 
        {
            // es normal poner con gion bajo el atributo en las clases si estos son privados
            // es una regla y convención en C#
            private string _name;
            private int _age;
            // este constructor define las propiedades de la clase
            // recuerde que el constructor siemrpe se llama igual que la clase
            public People (string name, int age)
            {
                _name = name;
                _age = age;

            }

            public string GetInfo()
            {
                return _name + " " +_age;

            }


        
        }

        //HEREDANDO PROPIEDADES DE PEOPLE
        // c# solo puede heredar de una clase

        class Doctor : People
         {

            private string _speciality;
            // aunque heredo de People, igual debo definir un constructor  para la clase Doctor donde reciba los parametros de la clase principal
            public Doctor(string name, int age, string speciality) : base(name, age) 
            {
               // aqui accedo a las propiedades de la clase original que hemos heredado en este caso el metodo
               // getinfo
               // ojo esto funciona si la clase original es PROTECTED o PUBLIC
               // SI LA CLASE ORIGINAL es Privada no funciona
                //string a=GetInfo();
                _speciality= speciality;

            }

            // extendemos la funcionalidad de la nueva clase con un nuevo metodo para devolver la información que hemos incluido en la clase
            public string GetData()
            { 
                return GetInfo() + " " +_speciality; 
            } 

        }

        class Dev : People
        { 
            // declaro nuevas propiedades pra la nueva clase que ya viene con la herencia de 
            private string _languaje;

            // Defino el constructor de la nueva clase
            public Dev(string name, int age, string languaje) : base (name, age)
            {
                _languaje = languaje;
            }
            // ahora que tengo una nueva propiedad tengo que mostrarla o usarla

            public string GetData()
            {
                return GetInfo() + " " + _languaje;

            }
        
        
        
        }



    }
}