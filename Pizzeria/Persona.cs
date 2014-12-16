using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Persona
    {
        public string clienteSatisfecho;
        public string pedido;
        public string clase;


        public Persona(string clientesatisfecho, string pedido, string clase) {
            this.clienteSatisfecho =clientesatisfecho;
            this.pedido = pedido;
            this.clase = clase;

        
        }
    }
}
