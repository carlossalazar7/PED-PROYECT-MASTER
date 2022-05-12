using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevere_master
{
     class CVertice
    {
        public int dintancianodo; //guarda la distancia que hay entre el nodo inicio en el algoritmo de Dijkstra 
        public Boolean Visitado; //variable que sirve para marcar como visto el nodo en un recorrido
        public CVertice Padre; //bodo que sirve en los recorridos como el antecesor
        public Boolean pesoasignado;//variable que sirve, se usa en el algoritmo de Dijkstra

        public Sites Valor;//valor que almacena (representa el nodo)
        public List<Routes> ListaAdyacencia; //lista de adyacencia del nodo
        Dictionary<string, short> _banderas;
        Dictionary<string, short> _banderas_predeterminado;

        public CVertice(Sites Valor)
        {
            this.Valor = Valor;
            this.ListaAdyacencia = new List<Routes>();
            this._banderas = new Dictionary<string, short>();
            this._banderas_predeterminado = new Dictionary<string, short>();
            this.Visitado = false;
        }
        public CVertice() : this(new Sites()) { } //contructor por defecto


    }
}
