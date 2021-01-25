using System;
using System.Collections.Generic;
using System.Text;

namespace nodos
{
    public class ListaNodo
    {
        public Nodo primero;
        public int size;
        public ListaNodo()
        {
            primero = null;
            size = 0;
        
        }

        public void addNodo(int dato)
        {
            Nodo nuevo = new Nodo(dato);
            Nodo valor1, valor2;
            if (primero == null)
            {
                primero = nuevo;
                nuevo.siguiente = null;
            }
            else
            {
                valor1 = primero;
                while (valor1 != null)
                {
                    valor2 = valor1.siguiente;

                    if (nuevo.dato <= valor1.dato)
                    {
                        nuevo.siguiente = primero;
                        primero = nuevo;
                        break;
                    }
                    else
                    {
                        if (nuevo.dato > valor1.dato && valor2 == null)
                        {
                            valor1.siguiente = nuevo;
                            nuevo.siguiente = null;
                            break;
                        }
                        else
                        {
                            if (valor1.dato < nuevo.dato && valor2.dato >= nuevo.dato)
                            {
                                valor1.siguiente = nuevo;
                                nuevo.siguiente = valor2;
                                break;
                            }
                            else
                            {
                                valor1 = valor1.siguiente;

                            }
                        }
                    }
                }
            }

            size++;
        }

        public void Listavacia()
        {
            if (primero == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine("La lista tiene datos");
            }
        }

        public void Listar()
        {
            Nodo actual = primero;
            while (actual != null)
            {
                Console.WriteLine("nodo[{0}] => [{0}]",actual.dato);
                actual = actual.siguiente;
            }
        }

        public void eliminar()
        {
            primero = primero.siguiente;

        }

        public void delet()
        {
            Nodo anterior = primero;
            Nodo actual = primero;
            while (actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            anterior.siguiente = null;
        }

        public void eliminaar_pos(int p)
        {
            Nodo anterior = primero;
            Nodo actual = primero;

            int dar = 0;

            if (p > 0)
            {
                while (dar != p && actual.siguiente != null)
                {
                    anterior = actual;
                    actual = actual.siguiente;

                    dar++;
                }

                anterior.siguiente = actual.siguiente;
            }
        }

        public Nodo  buscar(int n)
        {
            Nodo p = primero;

            if (p == null)
            {
                Console.WriteLine("La lista no tiene datos");
            }
            else
            {
                while (p.siguiente != null || p.siguiente == null)
                {
                    if (p.dato == n)
                    {
                        return p;
                    }
                    else
                    {
                        if (p.siguiente == null)
                        {
                            return null;
                        }
                    }
                    p = p.siguiente;
                }
            }

            return null;
        }

        public void editar(int a, int b)
        {
            Nodo pos = buscar(a);
            
            if (pos != null || pos == null)
            {
                pos.dato = b;
            }
        }

        public int total()
        {
            return size;
        }
    }

   
}
