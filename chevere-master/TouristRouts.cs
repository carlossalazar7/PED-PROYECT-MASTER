using chevere_master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class TouristRouts
    {
        public List<CVertice> nodos; //Lists de sitios del grafo rutas turisticas

        //Constructor

        public TouristRouts()
        {
            nodos = new List<CVertice>();

        }

        /// Operaciones basicas del grafo Rutas Turisticas ///
        

        //Construye un sitio a partir de sus parametros bases y lo agrega a la lista de sitios.
<<<<<<< HEAD
        public Sites AgregarSitio(string nombre, string descrip, decimal latitud, decimal longitud) //lat y long eran float
=======
        public CVertice AgregarSitio(Sites valor)
>>>>>>> c010fad7fe34f4008083652b671c5eae65f2f663
        {
            CVertice nodo = new CVertice(valor);
            nodos.Add(nodo);
            return nodo;

        }

        //Agrega un sitio a la lista de nodos del grafo.
        public void AgregarVertice(CVertice nuevoNodo)
        {
            nodos.Add(nuevoNodo);
        }

        //Busca un sitio en la lista de sitios del grafo.
        public CVertice BuscarVertice(Sites valor)
        {
            return nodos.Find(v => v.Valor == valor);
        }

        //Crear un Camino a partir de los valores de sitio de origen y sitio de destino
        public bool AgregarArco(Sites origen, Sites nDestino, int peso)
        {
            CVertice vOrigen, vnDestino;
            //si alguno de los nodos no existe, se activa una excepcion
            if ((vOrigen = nodos.Find(v => v.Valor == origen)) == null)
                throw new Exception("El nodo " + origen + "No existe dentro del grafo");

            if ((vnDestino = nodos.Find(v => v.Valor == nDestino)) == null)
                throw new Exception("El nodo " + origen + "No existe dentro del grafo");

            return AgregarArco(vOrigen, vnDestino, peso);
        }

        public bool AgregarArco(CVertice origen, CVertice nDestino, int peso)
        {
            if (origen.ListaAdyacencia.Find(v => v.nDestino == nDestino) == null)
            {
                if (nDestino.ListaAdyacencia.Find(v => v.nDestino == origen) != null)
                {
                    return false;
                }
                origen.ListaAdyacencia.Add(new Routes(nDestino, peso));
                return true;
            }
            return false;
        }

        public int posicionNodo(Sites Nodo)
        {
            for (int i = 0; i < nodos.Count; i++)
            {
                if (String.Compare(nodos[i].Valor.Name, Nodo.Name) == 0)
                    return i;
            }
            return -1;
        }


        //funciones que desmarca como visitado todos los nodos del grafo;
        public void Desmarcar()
        {
            foreach (CVertice n in nodos)
            {
                n.Visitado = false;
                n.Padre = null;
                n.dintancianodo = int.MaxValue;
                n.pesoasignado = false;
            }
        }

    }
}
