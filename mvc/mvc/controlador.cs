using System;
using System.Collections.Generic;
using System.Text;

namespace mvc
{
    class controlador
    {
        private string nombre;
        private int age;
        public void  date()
        {
            Console.WriteLine("Bienvenido por favor a continuacion escribe tu Nombre..");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Cuantos anos tienes??");
            age = Convert.ToInt32(Console.ReadLine());

            var model = new modelo();
            model.comparacion(nombre,age);
            

        }


    }
}
