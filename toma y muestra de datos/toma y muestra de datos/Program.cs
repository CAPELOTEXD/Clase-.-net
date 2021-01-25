using System;

namespace toma_y_muestra_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int edad;

            Console.WriteLine("digite su nombre");

            nombre = Console.ReadLine();

            Console.WriteLine("digite su apellido");

            apellido = Console.ReadLine();

            Console.WriteLine("digite su edad");

            edad = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("señor {0} {1} con edad de {2} años. bienvenido ", nombre, apellido, edad);

            Console.ReadLine();
        }
    }
}
