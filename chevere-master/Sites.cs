using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clases
{
    internal class Sites
    {
        //Variables
        private  int id;
        private  string name;
        private  string description;
        private  int assessment;
        private  int latitude;
        private  int longitude;
        private  int climate_id;
        private  int category_id;
        private  int visitado; // Revisar: puede ser bool o int?
        private  int etiqueta;
        private  int tree_root;

        //Propiedades

        public  int Id
        {
            get { return id; }
            set { id = value; if (id < 0) { throw new Exception("Error, no se ha ingresado el id del sitio"); } }
        }

        public  string Name
        {
            get { return name; }
            set { name = value; if (name == "") { throw new Exception("Error, no se ha ingresado el nombre"); } }
        }
        public  string Description
        {
            get { return description; }
            set { description = value; }
        }
        public  int Assessment
        {
            get { return assessment; }
            set { assessment = value; if (assessment < 0 || assessment > 5) { throw new Exception("Error, la puntuacion no es valida"); } }
        }
        public  int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public  int Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public  int Climate_id
        {
            get { return climate_id; }
            set { climate_id = value; if (climate_id > 0) { throw new Exception("Error, no se ha ingresado el id del clima"); } }
        }
        public int Category_id
        {
            get { return category_id; }
            set { category_id = value; if (category_id > 0) { throw new Exception("Error, no se ha ingresado el id de la categoria"); } }
        }
        public int Visitado
        {
            get { return visitado; }
            set { visitado = value; }
        }
        public int Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }
        public int Tree_root
        {
            get { return tree_root; }
            set { tree_root = value; }
        }

    }
}
