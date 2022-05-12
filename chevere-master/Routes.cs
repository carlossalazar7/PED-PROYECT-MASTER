using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using chevere_master;

namespace Clases
{
    internal class Routes
    {
        //Variables}
        private int peso;
        public CVertice nDestino; 

        //Propiedades


        public int Peso {
            get => peso;
            set => peso = value;
        }

        public Routes(CVertice destino) : this(destino, 1)
        {
            this.nDestino = destino;
        }

        public Routes(CVertice destino, int peso)
        {
            this.nDestino = destino;
            this.peso = peso;
        }
    }
}
