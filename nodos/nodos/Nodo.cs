﻿using System;
using System.Collections.Generic;
using System.Text;

namespace nodos
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente;
        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;


        
        }
    }
}
