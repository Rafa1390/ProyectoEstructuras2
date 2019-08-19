using System.Collections.Generic;
using System.Text;

namespace Logica.LogicaGrafo
{
    public class ListaArco
    {
        public Arco Cabeza { get; set; }

        public ListaArco()
        {
            Cabeza = null;
        }

        public bool Insertar(Arco nArco)
        {
            var insertado = false;

            if (nArco != null)
            {
                insertado = true;

                if (!EsVacio())
                {
                    nArco.Siguiente = Cabeza;
                }

                Cabeza = nArco;

            }

            return insertado;
        }

        public Arco Buscar(Vertice destino)
        {
            var aux = Cabeza;
            Arco encontrado = null;

            while (aux != null)
            {
                if (aux.VerticeDestino.Nombre.Equals(destino.Nombre))
                {
                    encontrado = aux;
                    break;
                }

                aux = aux.Siguiente;
            }

            return encontrado;
        }

        private bool EsVacio()
        {
            var esVacio = false;

            if (Cabeza == null)
            {
                esVacio = true;
            }

            return esVacio;
        }

        public string ToPrint()
        {
            var print = new StringBuilder();
            var aux = Cabeza;
            print.Append("Puntos adyacentes:\n");

            while (aux != null)
            {
                print.Append("\nDestino: " + aux.VerticeDestino.Nombre);
                print.Append("\nDistancia: " + aux.Kilometros + "\n");
                aux = aux.Siguiente;
            }

            return print.ToString();
        }

        public List<Arco> ToList()
        {
            var lista = new List<Arco>();
            var aux = Cabeza;

            while (aux != null)
            {
                lista.Add(aux);
                aux = aux.Siguiente;
            }

            return lista;
        }
    }
}
