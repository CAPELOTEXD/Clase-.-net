using System;

namespace calculadora_con_swicth
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion, repetir = 0;
            var con = new calculadora();
           
            do
            {
                Console.WriteLine("Elija la operacion que desea realizar");
                Console.WriteLine("[1] Suma");
                Console.WriteLine("[2] Resta");
                Console.WriteLine("[3] Multiplicacion");
                Console.WriteLine("[4] division");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        con.suma();
                        break;

                    case 2:
                        con.resta();
                        break;
                    case 3:
                        con.Multiplicar();
                        break;
                    case 4:
                        con.dividir();
                        break;

                    default:
                        Console.WriteLine("opcion invalida ");
                        break;
                    
                }
                Console.WriteLine("si desea volver oprima 1 o cualquier tecla para salir");
                repetir = Convert.ToInt32(Console.ReadLine());
            } while (repetir == 1);
        }
    }
    class calculadora
    {

        private int numero1;
        private int numero2;
        public void suma()
        {
            Console.WriteLine("introduca el primer digito a sumar");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdusca el segundo numero a sumar");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"el resultado es: {numero1 + numero2}");

        }

        public void resta()
        {
            Console.WriteLine("introduca el primer digito a restar");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdusca el segundo numero a restar");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"el resultado es: {numero1 - numero2}");

        }

        public void Multiplicar()
        {
            Console.WriteLine("introduca el primer digito a Multiplicar");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdusca el segundo numero a Multiplicar");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"el resultado es: {numero1 * numero2}");

        }

        public void dividir()
        {
            Console.WriteLine("introduca el primer digito a dividir");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introdusca el segundo numero a dividir");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"el resultado es: {numero1 / numero2}");

            
        }


    }
}
