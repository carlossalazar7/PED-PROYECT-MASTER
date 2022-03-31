﻿using System;
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
        private static int id;
        private static string name;
        private static int assessment;
        private static double latitud;
        private static double longitud;
        private static int attribute3;
        private static int attribute4;
        private static int attribute5;


        //Propiedades
        public static int Id
        {
            get { return id; }
            set { id = value; if (id < 0) { throw new Exception("Error, no se ha ingresado el id de la ruta"); } }
        }

        public static string Name
        {
            get { return name; }
            set { name = value; if (name == "") { throw new Exception("Error, no se ha ingresado el nombre de la ruta"); } }
        }

        public static int Assessment
        {
            get { return assessment; }
            set { assessment = value; if (assessment < 0 || assessment > 5) { throw new Exception("Error, la puntuacion no es valida"); } }
        }

        public static double Latidud
        {
            get { return latitud; }
            set { latitud = value; }
        }
        public static double Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        public static int Attribute3
        {
            get { return attribute3; }
            set { attribute3 = value; }
        }
        public static int Attribute4
        {
            get { return attribute4; }
            set { attribute4 = value; }
        }
        public static int Attribute5
        {
            get { return attribute5; }
            set { attribute5 = value; }
        }
    }
}
