using System;

namespace triangulo_pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int piso = 0;
            int[] arreglo = new int[1];

            //capturamos datos
            Console.WriteLine("escribe la cantidad de pisos");

            piso = Convert.ToInt16(Console.ReadLine());

            /*declaramos el primer ciclo que va a rrecorrer dependiendo el dato ingresado
             en la cantidad de pisos*/

            for (int i = 1; i <= piso; i++)
            {
                /*creamos u arreglo y colocaremos la variable i del ciclo for
                que sera el tamaño que tendra el arreglo cada ves que el ciclo se ejecute*/

                int[] pascal = new int[i];

                // ciclo for que decrementa la forma del triangulo

                for (int j = piso; j < i; j--)
                {
                    Console.Write(" ");
                }
                // ciclo for que genera la suma de las cifras

                for (int k = 0; k < i; k++)
                {
                    //condicion que evalua la variable del ciclo for

                    if (k == 0 || k == (i - 1))
                    {
                        pascal[k] = 1;
                    }
                    else
                    {
                        /*sumamos los numeros que se encuentran en cada posicion
                         del arreglo para formar el triangulo*/

                        pascal[k] = arreglo[k] + arreglo[k - 1]; 

                    }

                    Console.Write("[" + pascal[k] + "]");
                }

                // iguala los arreglos y realiza un salto de linea
                arreglo = pascal;
                Console.WriteLine(" ");

            }

            /*se encarga de mantener la consola abierta mostrando los datos*/

            Console.ReadLine();
        }
    }
}
