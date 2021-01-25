using System;
using System.Collections.Generic;
using System.Text;

namespace mvc
{
    class modelo
    {
        private string name;
        private int year;

        public void comparacion(String a, int b)
        {
            name = a;
            year = b;

            Console.WriteLine($"Tu nombre es: {name} y tienes {year} anos.");
           
        }


    }
}
