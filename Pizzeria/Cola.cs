using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Cola
    {
        int tamaño;
        int frente;
        int ultimo;
        public String[] COLA;

        public Cola(int tamaño)
        {
            this.tamaño = tamaño;
            frente = ultimo = -1;
            COLA = new String[tamaño];
        }


        public bool estaLlena()
        {
            if (ultimo >= tamaño - 1)
            {
                return true;
            }
            else return false;
        }

        public bool estaVacia()
        {
            if (frente == -1)
            {
                return true;

            }
            else return false;
        }

        public bool encolar(String dato)
        {
            if (!estaLlena())
            {
                COLA[++ultimo] = dato;
                if (ultimo == 0)
                    frente = 0;
                return true;
            }
            return false;
        }

        public String desencolar()
        {
            String dato = "";
            if (!estaVacia())
            {
                dato = COLA[frente];
                COLA[frente] = "";
                if (frente == ultimo)
                {
                    frente = ultimo = -1;
                }
                else frente++;
            }
            return dato;
        }
    
    }
}
