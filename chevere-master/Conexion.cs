using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevere_master
{
    internal class Conexion
    {
        public string servidor, db, cadena, usuario, password, puerto;

        public void conec()
        {
            cadena = "server=Localhost\\SQLEXPRESS; database=proyecto_ped_master; Integrated Security=yes";
    }

    }
}
