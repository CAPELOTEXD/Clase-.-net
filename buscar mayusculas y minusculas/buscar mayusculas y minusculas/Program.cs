using System;

namespace buscar_mayusculas_y_minusculas
{
    class Program
    {
        private String cadena;
        private String verMayuscula = "";
        private String verminuscula = "";
        private int n;
        private string[] minusculas;
        private string[] Mayusculas;
        private string[] temMy;
        private string[] temmn;


        public Program(string cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            minusculas = new string[n];
            temMy = new string[n];
            temmn = new string[n];

        }

        private String mayusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //IsUpper indica que un caracter unicode esta categorizado como una letra mayuscula
                if (Char.IsUpper(cadena[i]))
                {
                    temMy[i] = Convert.ToString(cadena[i]);
                }
            }

            // genera el ciclo para que rrecorra el array y seleecione las mayusculas

            for (int i = 0; i < temMy.Length; i++)
            {
                if (temMy[i] != null)
                {
                    Mayusculas[i] = temMy[i];
                    verMayuscula = $"{verMayuscula},{Mayusculas[i]}";
                }
            }

            return verMayuscula;
        }

        private String Minusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //Islower indica que un caracter unicode esta categorizado como una letra minuscula
                if (Char.IsLower(cadena[i]))
                {
                    temmn[i] = Convert.ToString(cadena[i]);
                }
            }
            for (int i = 0; i < temmn.Length; i++)
            {
                minusculas[i] = temmn[i];
                verminuscula = $"{verminuscula}.{minusculas[i]}";
            }

            return verminuscula;
        }

        static void Main()
        {
            Console.WriteLine("Escribe la palabra para ver las mayusculas y minusculas");
            var info = Console.ReadLine();
            var dato = new Program(info);
            Console.WriteLine("LasLetras Mayusculas son: " + dato.mayusculas()
                + "\n\n" + "Las letras minusculas son : " + dato.Minusculas());
            Console.ReadLine();
        }
    }
}
