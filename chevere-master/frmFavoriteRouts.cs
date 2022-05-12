using Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chevere_master
{
    public partial class frmFavoriteRouts : frmChildMenu_GUI
    {
        private TouristRouts grafo; //instanciamos la clase CGrafo
        private CVertice nuevoNodo;//instanciamos la clase CVertice
        private CVertice NodoOrigen;//instanciamos la clase CVertice
        private CVertice NodoDestino; //instanciamos la clase CVertice
        private int var_control = 0; //la utilizaremoa para determinar el estado de  la pizarra:
                                     //0 -> sin accion, 1-> dibujando arco, 2->Nuevo vértice
                                     //variables para el control de ventanas modales
                                     //private recorrido ventanaRecorrido //ventana para seleccionar el nodo inicial del recorrido


        List<CVertice> nodosRuta;
        List<CVertice> nodosOrdenados;
        bool buscarRuta = false, nuevoVertice = false, nuevoArco = false;
        bool profundidad = false, anchura = false, nodoEncontrado = false;
        Queue cola = new Queue();
        private Sites destino = new Sites(), origen = new Sites();
        private int distancia = 0;


        public frmFavoriteRouts()
        {
            InitializeComponent();
        }

        private void frmFavoriteRouts_Load(object sender, EventArgs e)
        {
            grafo = new TouristRouts();
            int peso = 1;
            Sites sitio1 = new Sites();
            sitio1.Name = "Ahuachapan";

            Sites sitio2 = new Sites();
            sitio2.Name = "Santa Ana";


            NodoOrigen = new CVertice();
            NodoOrigen.Valor = sitio1;

            NodoDestino = new CVertice();
            NodoDestino.Valor = sitio2;

            if (grafo.AgregarArco(NodoOrigen, NodoDestino, peso))
            {
                MessageBox.Show("Cantidad de rutas: " + grafo.nodos.Count().ToString());
            }

        }
    }
}
