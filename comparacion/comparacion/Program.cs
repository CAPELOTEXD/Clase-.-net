using System;

namespace comparacion
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre1;
            string nombre2;

            int edad1;
            int edad2;

            Console.WriteLine("comparador de edades");
            Console.WriteLine("A continuacion realizaremos la comparacion de 2 edades y miraremos quien es mayor");
            Console.WriteLine("digite el nombre de la primera persona");

            nombre1 = Console.ReadLine();

            Console.WriteLine("ahora digite la edad");

            edad1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("muy bien, ahora digita el nombre de la siguiente persona");

            nombre2 = Console.ReadLine();

            Console.WriteLine("ahora tu edad");

            edad2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ahora veremos el resultado de quien es mayor");

            if (edad1 > edad2)
            {
                Console.WriteLine("el mayor es {0} con {2} años y el menor es {1} con {3} años",nombre1,nombre2,edad1,edad2);
            }
            if (edad1 < edad2)
            {
                Console.WriteLine("el mayor es {1} con {3} años y el menor es {0} con {2} años", nombre1, nombre2, edad1, edad2);
            }
            if (edad1 == edad2)
            {
                Console.WriteLine("vaya, los dos tienen la misma edad");
                Console.WriteLine("{0} tiene los mismos años que {1} y los dos tienen... {2} años!", nombre1, nombre2, edad1);

            }

            Console.ReadLine();
        }
    }
}
