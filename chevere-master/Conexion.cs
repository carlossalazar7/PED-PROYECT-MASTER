using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevere_master
{
    internal class Conexion
    {
        public string servidor, db, cadena;
        public void conec()
        {
            servidor = "localhost";
            db = "proyecto_ped_master";
            cadena = "server=" + servidor + ";database=" + db + "; integrated security = True";
        }

    }
}
