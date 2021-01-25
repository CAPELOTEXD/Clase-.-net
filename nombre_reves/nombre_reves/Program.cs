using System;


namespace nombre_reves
{
    class Program
    {
       
        private String user;
        private String vernombre = "";
        private int n;
        private String[] reves;        
        private String[] reverso;
        private string[] total ;
        

        public Program(string user)
        {
            this.user = user;
            n = user.Length;
            reves = new string[n];
            reverso = new string[n];
        }

        private String voltear()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsLetter(user[i]))
                {
                    reves[i] = Convert.ToString(user[i]);
                }
            }

          

            for (int i = reves.Length-1; i <= reves.Length; i--)
            {
                if (i == -1)
                {
                    break;
                }

                reverso[i] = reves[i];
                vernombre = $"{vernombre}{ reverso[i]}";
               
            }

            return vernombre;
        
        }



        static void Main()
        {
            Console.WriteLine("Digita tu Nombre..");
            
            var user = Console.ReadLine();
            var casos = new Program(user);

            Console.WriteLine("Su nombre al reves es: " + casos.voltear());
        }

       

        

    }
}
