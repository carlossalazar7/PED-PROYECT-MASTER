using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Clases
{
    //This class will be our nodes for the Routs Graphs
    internal class Sites
    {
        //Atributos
        private int id;
        private string name;
        private string description;
        private int assessment;
        private decimal latitude; //Este era float
        private decimal longitude; // Este era float
        private int climate_id;
        private int category_id;
        private int visitado;
        private int etiqueta;
        private String picture;


        // {[()]}
        public List<Routes> ListaAdyacencia; //Lista de adyacencia de cada sitio turistico.




        //Propiedades


        public int Id
        {
            get { return id; }
            set { id = value; if (id < 0) { throw new Exception("Error, no se ha ingresado el id del sitio"); } }
        }

        public string Name
        {
            get { return name; }
            set { name = value; if (name == "") { throw new Exception("Error, no se ha ingresado el nombre"); } }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Assessment
        {
            get { return assessment; }
            set { assessment = value; if (assessment < 0 || assessment > 5) { throw new Exception("Error, la puntuacion no es valida"); } }
        }
        public decimal Latitude  //Este era float
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public decimal Longitude //Este era float
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public int Climate_id
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


        public string Picture
        {
            get => picture;
            set => picture = value;
        }


        //Methods
        public Sites(string nombre, string _description, decimal _latitude, decimal _longitude) //latitude y longitud eran float
        {



            this.name = nombre;
            this.ListaAdyacencia = new List<Routes>();
            this.description = _description;
            this.latitude = _latitude;
            this.longitude = _longitude;



        }
        public Sites() : this("", "", (decimal)0.0, (decimal)0.0) { } //Los dos decimal eran float


    }
}