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
        private static int id;
        private static string name;
        private static string description;
        private static int assessment;
        private static int latitude;
        private static int longitude;
        private static int climate_id;
        private static int category_id;
        private static int visitado; // Revisar: puede ser bool o int?
        private static int etiqueta;
        private static int tree_root;

        //Propiedades

        public static int Id
        {
            get { return id; }
            set { id = value; if (id < 0) { throw new Exception("Error, no se ha ingresado el id del sitio"); } }
        }

        public static string Name
        {
            get { return name; }
            set { name = value; if (name == "") { throw new Exception("Error, no se ha ingresado el nombre"); } }
        }
        public static string Description
        {
            get { return description; }
            set { description = value; }
        }
        public static int Assessment
        {
            get { return assessment; }
            set { assessment = value; if (assessment < 0 || assessment > 5) { throw new Exception("Error, la puntuacion no es valida"); } }
        }
        public static int Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public static int Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public static int Climate_id
        {
            get { return climate_id; }
            set { climate_id = value; if (climate_id > 0) { throw new Exception("Error, no se ha ingresado el id del clima"); } }
        }
        public static int Category_id
        {
            get { return category_id; }
            set { category_id = value; if (category_id > 0) { throw new Exception("Error, no se ha ingresado el id de la categoria"); } }
        }
        public static int Visitado
        {
            get { return visitado; }
            set { visitado = value; }
        }
        public static int Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }
        public static int Tree_root
        {
            get { return tree_root; }
            set { tree_root = value; }
        }

    }
}
