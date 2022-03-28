using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevere_master
{
    internal class Conexion
    {

        private static string cadena = "server=Localhost; database=proyecto_ped_master; Integrated Security=yes";
        private SqlConnection conn = new SqlConnection(cadena);
        public SqlConnection Conn { get => conn; }
        public void Conectar()
        {
            Conn.Open();
        }

        public void Cerrar()
        {
            Conn.Close();
        }

    }
}
