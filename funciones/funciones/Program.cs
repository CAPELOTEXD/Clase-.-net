using System;

namespace funciones
{
    class Program
    {
        int total;
        int numero1;
        int numero2;


        static void Main()
        {
            var datos = new Program();
            
            int seleccion;
            
            Console.WriteLine("seleccione operacion a realizar");
            Console.WriteLine("(1) SUMA.");
            Console.WriteLine("(2) Resta.");
            Console.WriteLine("(3) Multiplicar.");
            Console.WriteLine("(4) Dividir.");
            seleccion = Convert.ToInt32(Console.ReadLine());
            

            if (seleccion == 1)
            {
                datos.Suma();
                
                
            }

            if (seleccion == 2)
            {
                datos.Resta();
            }

            if (seleccion == 3)
            {
                datos.Multiplicacion();
            }

            if (seleccion == 4)
            {
                datos.Division();
            }


            Console.WriteLine("el resultado es: {0}",datos.total);

        }

        private int Suma()
        {
            Console.WriteLine("digite el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            return total = numero1 + numero2;
        }

        private int Resta()
        {
            Console.WriteLine("digite el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            return total = numero1 - numero2;
        }

        private int Multiplicacion()
        {
            Console.WriteLine("digite el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            return total = numero1 * numero2;
        }

        private int Division()
        {
            Console.WriteLine("digite el primer numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite segundo numero");
            numero2 = Convert.ToInt32(Console.ReadLine());

            return total = numero1 / numero2;
        }






    }
}
