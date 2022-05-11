using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clases
{
    internal class Routes
    {
        //Variables
        private  int id;
        private  string name;
        private  int assessment;
        private  double latitud;
        private  double longitud;

        public Sites nsitio;
        public float distancia;




        //Propiedades
        public  int Id
        {
            get { return id; }
            set { id = value; if (id < 0) { throw new Exception("Error, no se ha ingresado el id de la ruta"); } }
        }

        public  string Name
        {
            get { return name; }
            set { name = value; if (name == "") { throw new Exception("Error, no se ha ingresado el nombre de la ruta"); } }
        }

        public  int Assessment
        {
            get { return assessment; }
            set { assessment = value; if (assessment < 0 || assessment > 5) { throw new Exception("Error, la puntuacion no es valida"); } }
        }

        public  double Latidud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        public  double Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        

        public Routes(Sites destino, float peso)
        {
            this.nsitio = destino;
            this.distancia = peso;
        }
    }
}
