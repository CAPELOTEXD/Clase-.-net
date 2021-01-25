using System;

namespace nodos
{
    class Program
    {
        static void Main()
        {
            var list = new ListaNodo();

            list.Listavacia();
            list.addNodo(1);
            list.addNodo(3);
            list.addNodo(2);
            list.addNodo(4);
            //list.Listavacia();
            //list.Listar();
            //list.eliminar();
            //Console.WriteLine();
            //list.Listar();
            //Console.WriteLine();
            //list.delet();
            //list.eliminaar_pos(1);
            list.Listar();
            //list.buscar(2);
            list.editar(3,6);
            Console.WriteLine("total es {0}", list.total());
            list.Listar();

            Console.ReadKey();

        }

      
    }
}
