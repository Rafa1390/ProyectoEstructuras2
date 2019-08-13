using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.LogicaGrafo
{
    public class ListaVertice
    {
        public Vertice Cabeza { get; set; }

        public ListaVertice()
        {
            Cabeza = null;
        }

        /// <summary>
        /// Ingresa un nuevo vertice a la lista de vertices.
        /// </summary>
        /// <param name="nVertice"></param>
        /// <returns></returns>
        public bool Insertar(Vertice nVertice)
        {
            var insertado = false;

            if(nVertice != null)
            {
                insertado = true;

                if (!EsVacio())
                {
                    nVertice.Siguiente = Cabeza;
                }

                Cabeza = nVertice;
            }

            return insertado;
        }

        /// <summary>
        /// Responsable de buscar un vertice en especifico.
        /// </summary>
        /// <param name="nNombre"></param>
        /// <returns></returns>
        public Vertice Buscar(string nNombre)
        {
            var aux = Cabeza;
            Vertice encontrado = null;

            while(aux != null)
            {
                if (aux.Nombre.Equals(nNombre))
                {
                    encontrado = aux;
                    break;
                }

                aux = aux.Siguiente;
            }

            return encontrado;
        }

        /// <summary>
        /// Indica si la lista esta vacia.
        /// </summary>
        /// <returns></returns>
        public bool EsVacio()
        {
            var esVacio = false;

            if(Cabeza == null)
            {
                esVacio = true;
            }

            return esVacio;
        }
    }
}
