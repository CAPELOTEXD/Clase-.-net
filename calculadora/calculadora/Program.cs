using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            int operacion;
            int numero1;
            int numero2;
            int total;

            Console.WriteLine("Calculadora");
            Console.WriteLine("seleccione su operacion a realizar");
            Console.WriteLine("(1)suma");
            Console.WriteLine("(2)resta");
            Console.WriteLine("(3)multiplicacion");
            Console.WriteLine("(4)division");

            operacion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite primer valor");

            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite el segundo valor");

            numero2 = Convert.ToInt32(Console.ReadLine());
            
            if (operacion == 1)
            {
                 total = numero1 + numero2;
                 Console.WriteLine("el resultado es: {0}", total);

            }
            if (operacion == 2)
            {
                total = numero1 - numero2;
                Console.WriteLine("el resultado es: {0}", total);
            }
            if (operacion == 3)
            {
                total = numero1 * numero2;
                Console.WriteLine("el resultado es: {0}", total);
            }
            if (operacion == 4)
            {
                total = numero1 / numero2;
                Console.WriteLine("el resultado es: {0}",total);
            }


            

            Console.ReadLine();
            

        }
    }
}
