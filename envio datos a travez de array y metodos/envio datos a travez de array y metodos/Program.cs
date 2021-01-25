using System;

namespace envio_datos_a_travez_de_array_y_metodos
{
    
    class Program
    {           

      
        static void Main()
        {
            object[] parametros = {"Tavo",27,1023929376};
            new Program().metodo(parametros);
            Console.ReadLine();
            
            
        }

        private void metodo(object[] parametros)
        {
            var id = parametros[2];
            String nombre = Convert.ToString(parametros[0]);
            var edad = parametros[1];

        }
    }
}
